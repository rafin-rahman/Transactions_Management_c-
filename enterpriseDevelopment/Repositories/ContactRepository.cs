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

        public bool AddContact(Contact ContactObj)
        {

            string addContact = "INSERT INTO Contacts([Contactname], [userIdFk])" + "VALUES" + "(@contactName, userAccountID);";
            try
            {
                SqlCommand sqlCommand = new SqlCommand(addContact, connection);
                sqlCommand.Parameters.Add("@contactName", SqlDbType.Text).Value = ContactObj.ContactName;
                sqlCommand.Parameters.Add("@userAccountID", SqlDbType.Int).Value = ContactObj.userIdFk;

                connection.Open();
                // Exceute non query when there's nothing to return, in this case is just inserting data into DB.
                // sqlCommand.ExecuteNonQuery() returs number of rows affected
                var i = sqlCommand.ExecuteNonQuery();
                if (i > 0)
                {
                    connection.Close();
                    return true;
                }
                else
                {
                    connection.Close();
                    return false;
                }


            }

            catch (Exception ex)
            {
                return false;
            }

        }

        public List<Contact> GetContacts(int id)
        {

            // object u
            List<Contact> u = new List<Contact>();

            string selectQuery = "SELECT * FROM Contacts WHERE [userIdFk] = @userID";
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
            

            string selectQuery = "DELETE FROM Contacts WHERE [userIdFk] = @userID AND [ContactId] = @contactID";
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
     }

}
