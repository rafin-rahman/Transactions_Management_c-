using enterpriseDevelopment.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using NLog;

namespace enterpriseDevelopment.Repositories
{
    class EventRecurringRepository
    {
        private Logger Logger = LogManager.GetCurrentClassLogger();
        public string databaseConn;
        SqlConnection connection;

        public EventRecurringRepository()
        {
            databaseConn = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            connection = new SqlConnection(databaseConn);
        }

        public List<EventRecurring> GetEvents(int id)
        {
            List<EventRecurring> recurringEvents = new List<EventRecurring>();
            string query =
                "SELECT EventsRepeatTbl.*, ContactsTbl.ContactName AS ContactName " +
                "FROM EventsRepeatTbl " +
                "LEFT JOIN ContactsTbl ON ContactsTbl.ContactId = EventsRepeatTbl.contactIdFk " +
                "WHERE EventsRepeatTbl.userIdFk = @userID";
            try
            {
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.Parameters.Add("@UserID", SqlDbType.Int).Value = id;
                connection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    EventRecurring temp = new EventRecurring
                    {
                        Id = (int)sqlDataReader["EventId"],
                        Title = sqlDataReader["EventTitle"].ToString(),
                        Status = sqlDataReader["EventStatus"].ToString(),
                        Location = sqlDataReader["Location"].ToString(),
                        Message = sqlDataReader["EventMessage"].ToString(),
                        Period = sqlDataReader["EventPeriod"].ToString(),
                        Date = (DateTime)sqlDataReader["dateTime"],
                        UserFK = (int)sqlDataReader["userIdFk"]
                    };

                    if (sqlDataReader["contactIdFk"] == DBNull.Value)
                        temp.ContactFk = 0;
                    else
                        temp.ContactFk = (int)sqlDataReader["contactIdFk"];

                    if (sqlDataReader["ContactName"] == DBNull.Value)
                        temp.ContactName = "";
                    else
                        temp.ContactName = sqlDataReader["ContactName"].ToString();
                    // Min value to make a recurring event endless, the timer will never reach the min value
                    if (sqlDataReader["EventPeriodEndDate"] == DBNull.Value)
                        temp.EndDate = DateTime.MinValue;
                    else
                        temp.EndDate = (DateTime)sqlDataReader["EventPeriodEndDate"];

                    recurringEvents.Add(temp);
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return recurringEvents;
        }

        public bool AddEvent(EventRecurring recurringEvent)
        {
            string query = "INSERT INTO EventsRepeatTbl ([EventTitle],[EventStatus],[Location],[EventMessage],[EventPeriod],[dateTime],[EventPeriodEndDate],[userIdFk],[contactIdFk])" +
                "VALUES" +
                "(@title, @status, @location, @message, @period, @dateTime, @endDate, @userID, @contactID)";
            try
            {
                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.Add("@title", SqlDbType.NVarChar).Value = recurringEvent.Title;
                cmd.Parameters.Add("@status", SqlDbType.NChar).Value = recurringEvent.Status;
                cmd.Parameters.Add("@location", SqlDbType.VarChar).Value = recurringEvent.Location;
                cmd.Parameters.Add("@message", SqlDbType.VarChar).Value = recurringEvent.Message;
                cmd.Parameters.Add("@period", SqlDbType.VarChar).Value = recurringEvent.Period;
                cmd.Parameters.Add("@dateTime", SqlDbType.DateTime).Value = recurringEvent.Date;
                cmd.Parameters.Add("@userID", SqlDbType.Int).Value = recurringEvent.UserFK;


                SqlParameter sqlParameter = new SqlParameter("@contactID", SqlDbType.Int);
                if (recurringEvent.ContactFk == 0)
                    sqlParameter.Value = DBNull.Value;
                else
                    sqlParameter.Value = recurringEvent.ContactFk;
                cmd.Parameters.Add(sqlParameter);

                SqlParameter sqlParameter2 = new SqlParameter("@endDate", SqlDbType.DateTime);
                if (recurringEvent.EndDate == DateTime.MinValue)
                    sqlParameter2.Value = DBNull.Value;
                else
                    sqlParameter2.Value = recurringEvent.EndDate;

                cmd.Parameters.Add(sqlParameter2);

                connection.Open();
                var x = cmd.ExecuteNonQuery();
                if (x > 0)
                    return true;
                else
                    return false;

            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public bool editEvent(EventRecurring eventRepeat)
        {
            string query = "UPDATE EventsRepeatTbl SET [EventTitle] = @title, [EventStatus] = @status, [Location] = @location, [EventMessage] = @message, [EventPeriod] = @period, [dateTime] = @dateTime, [EventPeriodEndDate] = @endDate, [userIdFk] = @userID, [contactIdFk] = @contactID ";

            try
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.Add("@title", SqlDbType.NVarChar).Value = eventRepeat.Title;
                cmd.Parameters.Add("@status", SqlDbType.NChar).Value = eventRepeat.Status;
                cmd.Parameters.Add("@period", SqlDbType.NVarChar).Value = eventRepeat.Period;
                cmd.Parameters.Add("@location", SqlDbType.NVarChar).Value = eventRepeat.Location;
                cmd.Parameters.Add("@message", SqlDbType.NVarChar).Value = eventRepeat.Message;
                cmd.Parameters.Add("@dateTime", SqlDbType.DateTime).Value = eventRepeat.Date;
                cmd.Parameters.Add("@userID", SqlDbType.Int).Value = eventRepeat.UserFK;

                SqlParameter sqlParameter = new SqlParameter("@contactID", SqlDbType.Int);
                if (eventRepeat.ContactFk == 0)
                    sqlParameter.Value = DBNull.Value;
                else
                    sqlParameter.Value = eventRepeat.ContactFk;

                cmd.Parameters.Add(sqlParameter);

                SqlParameter sqlParameter2 = new SqlParameter("@endDate", SqlDbType.DateTime);
                if (eventRepeat.EndDate == DateTime.MinValue)
                    sqlParameter2.Value = DBNull.Value;
                else
                    sqlParameter2.Value = eventRepeat.EndDate;

                cmd.Parameters.Add(sqlParameter2);

                connection.Open();
                var x = cmd.ExecuteNonQuery();
                if (x > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public bool deleteEvent(EventRecurring eventRepeat)
        {
            string selectQuery = "DELETE FROM EventsRepeatTbl WHERE [EventId] = @id AND [userIdFk] = @userId";
            try
            {
                SqlCommand sqlCommand = new SqlCommand(selectQuery, connection);
                sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = eventRepeat.Id;
                sqlCommand.Parameters.Add("@userId", SqlDbType.Int).Value = eventRepeat.UserFK;

                connection.Open();
                var x = sqlCommand.ExecuteNonQuery();
                if (x > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
