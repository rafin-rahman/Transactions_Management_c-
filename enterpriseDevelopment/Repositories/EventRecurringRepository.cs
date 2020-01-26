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

        public List<EventRepeat> GetEvents(int id)
        {
            List<EventRepeat> u = new List<EventRepeat>();
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
                    EventRepeat temp = new EventRepeat
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

                    if (sqlDataReader["contactIdFk"] == DBNull.Value) temp.ContactFk = 0; else temp.ContactFk = (int)sqlDataReader["contactIdFk"];

                    if (sqlDataReader["ContactName"] == DBNull.Value) temp.ContactName = ""; else temp.ContactName = sqlDataReader["ContactName"].ToString();

                    if (sqlDataReader["EventPeriodEndDate"] == DBNull.Value) temp.EndDate = DateTime.MinValue; else temp.EndDate = (DateTime)sqlDataReader["EventPeriodEndDate"];

                    u.Add(temp);
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
            return u;
        }

        public bool AddEvent(EventRepeat eventRepeat)
        {
            string query = "INSERT INTO EventsRepeatTbl ([EventTitle],[EventStatus],[Location],[EventMessage],[EventPeriod],[dateTime],[EventPeriodEndDate],[userIdFk],[contactIdFk])" +
                "VALUES" +
                "(@title, @status, @location, @message, @period, @dateTime, @endDate, @userID, @contactID)";
            try
            {
                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.Add("@title", SqlDbType.NVarChar).Value = eventRepeat.Title;
                cmd.Parameters.Add("@status", SqlDbType.NChar).Value = eventRepeat.Status;
                cmd.Parameters.Add("@location", SqlDbType.VarChar).Value = eventRepeat.Location;
                cmd.Parameters.Add("@message", SqlDbType.VarChar).Value = eventRepeat.Message;
                cmd.Parameters.Add("@period", SqlDbType.VarChar).Value = eventRepeat.Period;
                cmd.Parameters.Add("@dateTime", SqlDbType.DateTime).Value = eventRepeat.Date;
                cmd.Parameters.Add("@userID", SqlDbType.Int).Value = eventRepeat.UserFK;

                // CONTACT ID
                SqlParameter sqlParameter = new SqlParameter("@contactID", SqlDbType.Int);
                if (eventRepeat.ContactFk == 0) sqlParameter.Value = DBNull.Value; else sqlParameter.Value = eventRepeat.ContactFk;
                cmd.Parameters.Add(sqlParameter);
                // End date time 
                SqlParameter sql2 = new SqlParameter("@endDate", SqlDbType.DateTime);
                if (eventRepeat.EndDate == DateTime.MinValue)
                    sql2.Value = DBNull.Value;
                else
                    sql2.Value = eventRepeat.EndDate;

                cmd.Parameters.Add(sql2);

                connection.Open();
                var x = cmd.ExecuteNonQuery();
                if (x > 0) return true; else return false;

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

        public bool editEvent(EventRepeat eventRepeat)
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
                if (eventRepeat.ContactFk == 0) sqlParameter.Value = DBNull.Value;
                else sqlParameter.Value = eventRepeat.ContactFk;
                cmd.Parameters.Add(sqlParameter);

                SqlParameter sqlParameter2 = new SqlParameter("@endDate", SqlDbType.DateTime);
                if (eventRepeat.EndDate == DateTime.MinValue) sqlParameter2.Value = DBNull.Value;
                else sqlParameter2.Value = eventRepeat.EndDate;
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

        public bool deleteEvent(EventRepeat eventRepeat)
        {
            string selectQuery = "DELETE FROM EventsRepeatTbl WHERE [EventId] = @id AND [userIdFk] = @userId";
            try
            {
                SqlCommand sqlCommand = new SqlCommand(selectQuery, connection);
                sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = eventRepeat.Id;
                sqlCommand.Parameters.Add("@userId", SqlDbType.Int).Value = eventRepeat.UserFK;

                connection.Open();
                var x = sqlCommand.ExecuteNonQuery();
                if (x > 0) return true; else return false;
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
                connection.Close();
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
