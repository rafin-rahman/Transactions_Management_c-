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

        public bool AddContact(ContactClass ContactObj)
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
                } else
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

    }

}
