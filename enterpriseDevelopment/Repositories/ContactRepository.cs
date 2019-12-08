using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace enterpriseDevelopment
{
    class ContactRepository
    {
        public string databaseConn;
        SqlConnection connection;
        public ContactRepository()
        {
            databaseConn = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            connection = new SqlConnection(databaseConn);
        }


        public List<Contact> GetContacts(int id)
        {

            // object u
            List<Contact> u = new List<Contact>();

            string selectQuery = "SELECT * FROM ContactsTbl WHERE [userIdFk] = @userID";
            try
            {
                SqlCommand sqlCommand = new SqlCommand(selectQuery, connection);
                // userName parameter of his method
                sqlCommand.Parameters.Add("@userID", SqlDbType.Int).Value = id;


                connection.Open();
                // Ask to retrieve all the  row
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();



                while (sqlDataReader.Read())
                {
                    u.Add(new Contact
                    {
                        ContactId = (int)sqlDataReader["ContactId"],
                        userIdFk = (int)sqlDataReader["userIdFk"],
                        ContactName = sqlDataReader["Contactname"].ToString()
                    });


                }
                connection.Close();


            }
            catch (Exception ex)
            {

            }

            // u is the object created at the beginning of the this method 
            return u;
        }

        public bool DeleteContact(Contact contact)
        {
            

            string selectQuery = "DELETE FROM ContactsTbl WHERE [userIdFk] = @userID AND [ContactId] = @contactID";
            try
            {
                SqlCommand sqlCommand = new SqlCommand(selectQuery, connection);
                // userName parameter of his method
                sqlCommand.Parameters.Add("@userID", SqlDbType.Int).Value = contact.userIdFk;
                sqlCommand.Parameters.Add("@contactID", SqlDbType.Int).Value = contact.ContactId;

                connection.Open();
                var x = sqlCommand.ExecuteNonQuery();
                connection.Close();
                if (x > 0 )
                {
                    return true;
                }else
                {
                    return false;
                }
                


            }
            catch (Exception ex)
            {
                return false;
            }

           
        }

        public int AddContact(Contact contact)
        {


            string selectQuery = "INSERT INTO ContactsTbl  ([userIdFk], [Contactname]) OUTPUT INSERTED.ContactId VALUES (@userID, @name)";
            try
            {
                SqlCommand sqlCommand = new SqlCommand(selectQuery, connection);
                // userName parameter of his method
                sqlCommand.Parameters.Add("@userID", SqlDbType.Int).Value = contact.userIdFk;
                sqlCommand.Parameters.Add("@name", SqlDbType.NVarChar).Value = contact.ContactName;

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
                return 0;
            }


        }

        public bool EditContact(Contact contact)
        {


            string selectQuery = "UPDATE ContactsTbl SET [Contactname] = @name WHERE [ContactId] = @id AND [userIdFk] = @userID";
            try
            {
                SqlCommand sqlCommand = new SqlCommand(selectQuery, connection);
                // userName parameter of his method
                sqlCommand.Parameters.Add("@userID", SqlDbType.Int).Value = contact.userIdFk;
                sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = contact.ContactId;
                sqlCommand.Parameters.Add("@name", SqlDbType.NVarChar).Value = contact.ContactName;

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
                return false;
            }


        }
    }

}
