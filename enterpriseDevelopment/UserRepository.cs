using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enterpriseDevelopment
{
    class UserRepository
    {
        public string dbConn;
        SqlConnection connection;
        public UserRepository()
        {
            // connection string such as names, password ecc
            dbConn = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            // database connection
            connection = new SqlConnection(dbConn);
        }

        // User = instance of UserAccount class
        public bool AddUserAccount(UserAccount userObj)
        {

            string addUserQuery = "INSERT INTO UserAccounts( [Username], [UserPwd], [UserFName] ) " + "VALUES " + "(@UserName,@UserPwd, @UserFName) ;";

            try
            {
                SqlCommand sqlCommand = new SqlCommand(addUserQuery, connection);
                // SqlDbType => converts string from c# to varchar for Sql || userObj.[[table column name]]
                // This line will take user input and store it to @UserName and convert into Sql varchar and send it to Username column in UserAccounts
                sqlCommand.Parameters.Add("@UserName", SqlDbType.Text).Value = userObj.Username;
                sqlCommand.Parameters.Add("@UserPwd", SqlDbType.Text).Value = userObj.UserPwd;
                sqlCommand.Parameters.Add("@UserFName", SqlDbType.Text).Value = userObj.UserFName;

                connection.Open();
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

        //public bool updateUserAccount(UserAccount userObj)
        //{

        //    string updateUserQuery = "UPDATE ";
        

        //    return false;
        //}
    }
}
