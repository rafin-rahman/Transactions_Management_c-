using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using enterpriseDevelopment.Models;
using NLog;

namespace enterpriseDevelopment.Repositories
{



    class EventRepository
    {
        public string databaseConn;
        SqlConnection connection;
        private Logger Logger = LogManager.GetCurrentClassLogger();

        public EventRepository()
        {
            databaseConn = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            connection = new SqlConnection(databaseConn);
        }

        public List<Event> GetEvents(int id)
        {
            connection = new SqlConnection(databaseConn);
            List<Event> events = new List<Event>();
            // It joins contact with event if a contact is assigned for an event
            string selectQuery = "SELECT EventsTbl.*, ContactsTbl.ContactName AS ContactName FROM EventsTbl LEFT JOIN ContactsTbl ON ContactsTbl.ContactId = EventsTbl.contactIdFk WHERE EventsTbl.userIdFk = @userID";
            try
            {
                SqlCommand sqlCommand = new SqlCommand(selectQuery, connection);
                sqlCommand.Parameters.Add("@userID", SqlDbType.Int).Value = id;
                
                connection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Event tempEvent = new Event
                    {
                        Id = (int)sqlDataReader["EventId"],
                        Title = sqlDataReader["EventTitle"].ToString(),
                        Status = sqlDataReader["EventStatus"].ToString(),
                        Location = sqlDataReader["Location"].ToString(),
                        Message = sqlDataReader["EventMessage"].ToString(),
                        Date = (DateTime)sqlDataReader["dateTime"],
                        UserFK = (int)sqlDataReader["userIdFk"]
                    };

                    if (sqlDataReader["contactIdFk"] == DBNull.Value)
                        tempEvent.ContactFk = 0;
                    else
                        tempEvent.ContactFk = (int)sqlDataReader["contactIdFk"];

                    if (sqlDataReader["ContactName"] == DBNull.Value)
                        tempEvent.ContactName = "";
                    else
                        tempEvent.ContactName = sqlDataReader["ContactName"].ToString();

                    events.Add(tempEvent);
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
            return events;
        }

        
        public bool AddEvent(Event eventObj)
        {
            connection = new SqlConnection(databaseConn);
            string addQuery = "INSERT INTO EventsTbl ([EventTitle],[EventStatus],[Location],[EventMessage],[dateTime],[userIdFk],[contactIdFk]) VALUES (@title, @status, @location, @message, @datetime, @userFk, @contactFk)";
            try
            {
                SqlCommand sqlCommand = new SqlCommand(addQuery, connection);
                sqlCommand.Parameters.Add("@title", SqlDbType.VarChar).Value = eventObj.Title;
                sqlCommand.Parameters.Add("@status", SqlDbType.VarChar).Value = eventObj.Status;
                sqlCommand.Parameters.Add("@location", SqlDbType.VarChar).Value = eventObj.Location;
                sqlCommand.Parameters.Add("@message", SqlDbType.VarChar).Value = eventObj.Message;
                sqlCommand.Parameters.Add("@datetime", SqlDbType.DateTime).Value = eventObj.Date;
                sqlCommand.Parameters.Add("@userFk", SqlDbType.Int).Value = eventObj.UserFK;

                // to avoid storing contact Id as 0
                SqlParameter sqlParameter = new SqlParameter("@contactFk", SqlDbType.Int);
                if (eventObj.ContactFk == 0)
                    // saves contactId in the db as NULL instead of 0
                    sqlParameter.Value = DBNull.Value;
                else
                    sqlParameter.Value = eventObj.ContactFk;
                sqlCommand.Parameters.Add(sqlParameter);

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

        public bool EditEvent(Event editEvent)
        {
            connection = new SqlConnection(databaseConn);
            string editQuery = "UPDATE EventsTbl SET [EventTitle] = @title, [EventStatus] = @status, [Location] = @location, [EventMessage] = @message, [dateTime] = @dateTime, [contactIdFk] = @contactFk WHERE [EventId] = @id AND [userIdFk] = @userID";
            try
            {
                SqlCommand sqlCommand = new SqlCommand(editQuery, connection);
                sqlCommand.Parameters.Add("@title", SqlDbType.NVarChar).Value = editEvent.Title;
                sqlCommand.Parameters.Add("@status", SqlDbType.NVarChar).Value = editEvent.Status;
                sqlCommand.Parameters.Add("@location", SqlDbType.NVarChar).Value = editEvent.Location;
                sqlCommand.Parameters.Add("@message", SqlDbType.NVarChar).Value = editEvent.Message;
                sqlCommand.Parameters.Add("@dateTime", SqlDbType.DateTime).Value = editEvent.Date;
                sqlCommand.Parameters.Add("@userID", SqlDbType.Int).Value = editEvent.UserFK;
                sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = editEvent.Id;


                // to avoid storing contact Id as 0
                SqlParameter sqlParameter = new SqlParameter("@contactFk", SqlDbType.Int);
                if (editEvent.ContactFk == 0)
                    // saves contactId in the db as NULL instead of 0
                    sqlParameter.Value = DBNull.Value;
                else
                    sqlParameter.Value = editEvent.ContactFk;

                sqlCommand.Parameters.Add(sqlParameter);

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

        public bool DeleteEvent(Event eventObj)
        {
            connection = new SqlConnection(databaseConn);
            string query = "DELETE FROM EventsTbl WHERE [EventId] = @eventID and [userIdFk] = @userID";
            try
            {
                SqlCommand sqlcommand = new SqlCommand(query, connection);
                sqlcommand.Parameters.Add("@eventID", SqlDbType.Int).Value = eventObj.Id;
                sqlcommand.Parameters.Add("@userId", SqlDbType.Int).Value = eventObj.UserFK;
                connection.Open();
                var x = sqlcommand.ExecuteNonQuery();

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
