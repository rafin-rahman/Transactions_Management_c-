using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using NLog;

namespace enterpriseDevelopment
{
    class ContactRepository
    {
        // Loggger to save errors in a txt file
        private Logger Logger = LogManager.GetCurrentClassLogger();

        public string databaseConnection;
        SqlConnection connection;

        // Connection to db
        public ContactRepository()
        {
            // get the string URL from app.config
            databaseConnection = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            // connectiong to db
            connection = new SqlConnection(databaseConnection);
        }

        public List<Contact> GetContacts(int id)
        {
            List<Contact> contacts = new List<Contact>();

            string selectQuery = "SELECT * FROM ContactsTbl WHERE [userIdFk] = @userID";
            try
            {
                SqlCommand sqlCommand = new SqlCommand(selectQuery, connection);
                sqlCommand.Parameters.Add("@userID", SqlDbType.Int).Value = id;
                connection.Open();
                // Execute query "selectQuery"
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                // storing contacts from db to the list u
                while (sqlDataReader.Read())
                {
                    contacts.Add(new Contact
                    {
                        Id = (int)sqlDataReader["ContactId"],
                        UserFk = (int)sqlDataReader["userIdFk"],
                        Name = sqlDataReader["Contactname"].ToString()
                    });
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
            return contacts;
        }

        public bool DeleteContact(Contact contact)
        {
            string selectQuery = "DELETE FROM ContactsTbl WHERE [userIdFk] = @userID AND [ContactId] = @contactID";
            try
            {
                connection.Open();

                SqlCommand sqlCommand = new SqlCommand(selectQuery, connection);
                sqlCommand.Parameters.Add("@userID", SqlDbType.Int).Value = contact.UserFk;
                sqlCommand.Parameters.Add("@contactID", SqlDbType.Int).Value = contact.Id;

                var x = sqlCommand.ExecuteNonQuery();
                connection.Close();
                // if it executes the query it will be 1 else 0
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

        public int AddContact(Contact contact)
        {   // "OUTPUT INSERTED.ContactId" returns the newly added contactId
            string selectQuery = "INSERT INTO ContactsTbl  ([userIdFk], [Contactname]) OUTPUT INSERTED.ContactId VALUES (@userID, @name)";
            try
            {
                SqlCommand sqlCommand = new SqlCommand(selectQuery, connection);
                sqlCommand.Parameters.Add("@userID", SqlDbType.Int).Value = contact.UserFk;
                sqlCommand.Parameters.Add("@name", SqlDbType.NVarChar).Value = contact.Name;

                connection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                int y = 0;
                while (sqlDataReader.Read())
                {
                    y = (int)sqlDataReader["ContactId"];
                }
                connection.Close();
                // y = added contactId
                return y;
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
                return 0;
            }
            finally
            {
                connection.Close();
            }
        }

        public bool EditContact(Contact contact)
        {
            string selectQuery = "UPDATE ContactsTbl SET [Contactname] = @name WHERE [ContactId] = @id AND [userIdFk] = @userID";
            try
            {
                SqlCommand sqlCommand = new SqlCommand(selectQuery, connection);

                sqlCommand.Parameters.Add("@userID", SqlDbType.Int).Value = contact.UserFk;
                sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = contact.Id;
                sqlCommand.Parameters.Add("@name", SqlDbType.NVarChar).Value = contact.Name;

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
    }
}
