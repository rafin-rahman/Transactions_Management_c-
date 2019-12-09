using enterpriseDevelopment.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;

namespace enterpriseDevelopment.Repositories
{
    class EventRecurringRepository
    {
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
                        id = (int)sqlDataReader["EventId"],
                        title = sqlDataReader["EventTitle"].ToString(),
                        status = sqlDataReader["EventStatus"].ToString(),
                        location = sqlDataReader["Location"].ToString(),
                        message = sqlDataReader["EventMessage"].ToString(),
                        period = sqlDataReader["EventPeriod"].ToString(),
                        date = (DateTime)sqlDataReader["dateTime"],
                        userFK = (int)sqlDataReader["userIdFk"]
                    };

                    if (sqlDataReader["contactIdFk"] == DBNull.Value)
                    {
                        temp.contactFk = 0;
                    }
                    else
                    {
                        temp.contactFk = (int)sqlDataReader["contactIdFk"];
                    }

                    if (sqlDataReader["ContactName"] == DBNull.Value)
                    {
                        temp.contactName = "";
                    }
                    else
                    {
                        temp.contactName = sqlDataReader["ContactName"].ToString();
                    }

                    if (sqlDataReader["EventPeriodEndDate"] == DBNull.Value)
                    {
                        temp.endDate = DateTime.MinValue;
                    }
                    else
                    {
                        temp.endDate = (DateTime)sqlDataReader["EventPeriodEndDate"];
                    }

                    u.Add(temp);

                }
                connection.Close();
            }
            catch (Exception)
            {

                connection.Close();
            }
            return u;


        }

        public bool AddEvent(EventRepeat eventRepeat)
        {
            string query = "INSERT INTO EventsTbl ([EventTitle],[EventStatus],[Location],[EventMessage],[EventPeriod],[dateTime],[EventPeriodEndDate],[userIdFk],[contactIdFk])" +
                "VALUES" +
                "(@title, @status, @location, @message, @period, @dateTime, @endDate, @userID, @contactID)";
            try
            {
                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.Add("@title", SqlDbType.VarChar).Value = eventRepeat.title;
                cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = eventRepeat.status;
                cmd.Parameters.Add("@location", SqlDbType.VarChar).Value = eventRepeat.location;
                cmd.Parameters.Add("@message", SqlDbType.VarChar).Value = eventRepeat.message;
                cmd.Parameters.Add("@period", SqlDbType.VarChar).Value = eventRepeat.period;
                cmd.Parameters.Add("@dateTime", SqlDbType.VarChar).Value = eventRepeat.date;
                // cmd.Parameters.Add("@endDate", SqlDbType.VarChar).Value = eventRepeat.endDate;
                cmd.Parameters.Add("@userID", SqlDbType.Int).Value = eventRepeat.status;
                // cmd.Parameters.Add("@contactID", SqlDbType.Int).Value = eventRepeat.status;


                // CONTACT ID
                SqlParameter sqlParameter = new SqlParameter("@contactID", SqlDbType.Int);
                if (eventRepeat.contactFk == 0)
                {
                    sqlParameter.Value = DBNull.Value;
                }
                else
                {
                    sqlParameter.Value = eventRepeat.contactFk;
                }
                cmd.Parameters.Add(sqlParameter);
                // End date time 
                SqlParameter sql2 = new SqlParameter("@endDate", SqlDbType.DateTime);
                if (eventRepeat.endDate == DateTime.MinValue)
                {
                    sql2.Value = DBNull.Value;
                }
                else
                {
                    sql2.Value = eventRepeat.endDate;
                }
                cmd.Parameters.Add(sql2);

                connection.Open();
                var x = cmd.ExecuteNonQuery();
                connection.Close();
                if (x > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                connection.Close();
                return false;
            }



        }

        public bool editEvent(EventRepeat eventRepeat)
        {

            string query = "UPDATE EventsRepeatTbl SET [EventTitle] = @title, [EventStatus] = @status, [Location] = @location, [EventMessage] = @message, [EventPeriod] = @period, [dateTime] = @dateTime, [EventPeriodEndDate] = @endDate, [userIdFk] = @userID, [contactIdFk] = @contactID ";

            try
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.Add("@title", SqlDbType.NVarChar).Value = eventRepeat.title;
                cmd.Parameters.Add("@status", SqlDbType.NVarChar).Value = eventRepeat.status;
                cmd.Parameters.Add("@location", SqlDbType.NVarChar).Value = eventRepeat.location;
                cmd.Parameters.Add("@message", SqlDbType.NVarChar).Value = eventRepeat.message;
                cmd.Parameters.Add("@dateTime", SqlDbType.DateTime).Value = eventRepeat.date;
                cmd.Parameters.Add("@userID", SqlDbType.Int).Value = eventRepeat.userFK;


                SqlParameter sqlParameter = new SqlParameter("@contactID", SqlDbType.Int);
                if (eventRepeat.contactFk == 0) sqlParameter.Value = DBNull.Value;
                else sqlParameter.Value = eventRepeat.contactFk;
                cmd.Parameters.Add(sqlParameter);

                SqlParameter sqlParameter2 = new SqlParameter("@endDate", SqlDbType.DateTime);
                if (eventRepeat.endDate == DateTime.MinValue) sqlParameter2.Value = DBNull.Value;
                else sqlParameter2.Value = eventRepeat.endDate;
                cmd.Parameters.Add(sqlParameter2);

                connection.Open();
                var x = cmd.ExecuteNonQuery();
                connection.Close();
                if (x > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                connection.Close();
                throw;
            }
            
        }

        public bool deleteEvent(EventRepeat eventRepeat)
        {

            string selectQuery = "DELETE FROM EventsRepeatTbl WHERE [EventId] = @id AND [userIdFk] = @userId";
            try
            {
                SqlCommand sqlCommand = new SqlCommand(selectQuery, connection);
              
                sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = eventRepeat.id;
                sqlCommand.Parameters.Add("@userId", SqlDbType.Int).Value = eventRepeat.userFK;

                connection.Open();
                var x = sqlCommand.ExecuteNonQuery();
                connection.Close();
                if (x > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }



            }
            catch (Exception ex)
            {
                connection.Close();
                return false;
            }

        }
    }
}
