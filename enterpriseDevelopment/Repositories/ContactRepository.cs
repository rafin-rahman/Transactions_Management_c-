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
        private Logger Logger = LogManager.GetCurrentClassLogger();
        public string databaseConn;
        SqlConnection connection;
        public ContactRepository()
        {
            databaseConn = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            connection = new SqlConnection(databaseConn);
        }

        public List<Contact> GetContacts(int id)
        {
            List<Contact> u = new List<Contact>();

            string selectQuery = "SELECT * FROM ContactsTbl WHERE [userIdFk] = @userID";
            try
            {
                SqlCommand sqlCommand = new SqlCommand(selectQuery, connection);
                sqlCommand.Parameters.Add("@userID", SqlDbType.Int).Value = id;
                connection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    u.Add(new Contact
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
            return u;
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
                if (x > 0) return true;
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
        {
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
