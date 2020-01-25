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
            List<Event> u = new List<Event>();
            string selectQuery = "SELECT EventsTbl.*, ContactsTbl.ContactName AS ContactName FROM EventsTbl LEFT JOIN ContactsTbl ON ContactsTbl.ContactId = EventsTbl.contactIdFk WHERE EventsTbl.userIdFk = @userID";
            try
            {
                SqlCommand sqlCommand = new SqlCommand(selectQuery, connection);
                sqlCommand.Parameters.Add("@userID", SqlDbType.Int).Value = id;

                connection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Event temp = new Event
                    {
                        id = (int)sqlDataReader["EventId"],
                        title = sqlDataReader["EventTitle"].ToString(),
                        status = sqlDataReader["EventStatus"].ToString(),
                        location = sqlDataReader["Location"].ToString(),
                        message = sqlDataReader["EventMessage"].ToString(),
                        date = (DateTime)sqlDataReader["dateTime"],
                        userFK = (int)sqlDataReader["userIdFk"]
                    };

                    if (sqlDataReader["contactIdFk"] == DBNull.Value)
                    
                        temp.contactFk = 0;
                    
                    else
                    
                        temp.contactFk = (int)sqlDataReader["contactIdFk"];
                    

                    if (sqlDataReader["ContactName"] == DBNull.Value)
                    
                        temp.contactName = "";
                    
                    else
                    
                        temp.contactName = sqlDataReader["ContactName"].ToString();
                    

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

        // Store events into DB
        public bool AddEvent(Event eventObj)
        {

            string addQuery = "INSERT INTO EventsTbl ([EventTitle],[EventStatus],[Location],[EventMessage],[dateTime],[userIdFk],[contactIdFk]) VALUES (@title, @status, @location, @message, @datetime, @userFk, @contactFk)";
            try
            {
                SqlCommand sqlCommand = new SqlCommand(addQuery, connection);
                sqlCommand.Parameters.Add("@title", SqlDbType.VarChar).Value = eventObj.title;
                sqlCommand.Parameters.Add("@status", SqlDbType.VarChar).Value = eventObj.status;
                sqlCommand.Parameters.Add("@location", SqlDbType.VarChar).Value = eventObj.location;
                sqlCommand.Parameters.Add("@message", SqlDbType.VarChar).Value = eventObj.message;
                sqlCommand.Parameters.Add("@datetime", SqlDbType.DateTime).Value = eventObj.date;
                sqlCommand.Parameters.Add("@userFk", SqlDbType.Int).Value = eventObj.userFK;


                // to avoid storing contact id as 0
                SqlParameter sqlParameter = new SqlParameter("@contactFk", SqlDbType.Int);
                if (eventObj.contactFk == 0) sqlParameter.Value = DBNull.Value;
                else sqlParameter.Value = eventObj.contactFk;
                sqlCommand.Parameters.Add(sqlParameter);

                connection.Open();
                var x = sqlCommand.ExecuteNonQuery();
                connection.Close();
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


        public bool EditEvent(Event eventObj)
        {
            string editQuery = "UPDATE EventsTbl SET [EventTitle] = @title, [EventStatus] = @status, [Location] = @location, [EventMessage] = @message, [dateTime] = @dateTime, [contactIdFk] = @contactFk WHERE [EventId] = @id AND [userIdFk] = @userID";
            try
            {
                SqlCommand sqlCommand = new SqlCommand(editQuery, connection);

                sqlCommand.Parameters.Add("@title", SqlDbType.NVarChar).Value = eventObj.title;
                sqlCommand.Parameters.Add("@status", SqlDbType.NVarChar).Value = eventObj.status;
                sqlCommand.Parameters.Add("@location", SqlDbType.NVarChar).Value = eventObj.location;
                sqlCommand.Parameters.Add("@message", SqlDbType.NVarChar).Value = eventObj.message;
                sqlCommand.Parameters.Add("@dateTime", SqlDbType.DateTime).Value = eventObj.date;
                sqlCommand.Parameters.Add("@userID", SqlDbType.Int).Value = eventObj.userFK;
                sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = eventObj.id;


                // to avoid storing contact id as 0
                SqlParameter sqlParameter = new SqlParameter("@contactFk", SqlDbType.Int);
                if (eventObj.contactFk == 0) sqlParameter.Value = DBNull.Value;
                else sqlParameter.Value = eventObj.contactFk;
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
            string query = "DELETE FROM EventsTbl WHERE [EventId] = @eventID and [userIdFk] = @userID";
            try
            {

                SqlCommand sqlcommand = new SqlCommand(query, connection);
                sqlcommand.Parameters.Add("@eventID", SqlDbType.Int).Value = eventObj.id;
                sqlcommand.Parameters.Add("@userId", SqlDbType.Int).Value = eventObj.userFK;
                connection.Open();
                var x = sqlcommand.ExecuteNonQuery();
                
                if (x > 0)
                
                    return true;
                
                else
                
                    return false;
                
            }
            catch (Exception)
            {
               
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
    }


}
