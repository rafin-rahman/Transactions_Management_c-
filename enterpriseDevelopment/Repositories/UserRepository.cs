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

            string addUserQuery = "INSERT INTO UserAccountsTbl( [Username], [UserPwd], [UserFName] ) " + "VALUES " + "(@UserName,@UserPwd, @UserFName) ;";

            try
            {
                SqlCommand sqlCommand = new SqlCommand(addUserQuery, connection);
                // SqlDbType => converts string from c# to varchar for Sql || userObj.[[table column name]]
                // This line will take user input and store it to @UserName and convert into Sql varchar and send it to Username column in UserAccountsTbl
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
                connection.Close();
                return false;
            }

        }


        public UserAccount GetUserByUsername(string userName)
        {

            // object u
            UserAccount u = new UserAccount();
            // UserAccountsTbl is the table name
            string selectQuery = "SELECT * FROM UserAccountsTbl WHERE [Username] = @Username";
            dbConn = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            try
            {
                SqlCommand sqlCommand = new SqlCommand(selectQuery, connection);
                // userName parameter of his method
                sqlCommand.Parameters.Add("@Username", SqlDbType.NVarChar).Value = userName;


                connection.Open();
                // Ask to retrieve only ONE row
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.SingleRow);

                
                
                while(sqlDataReader.Read())
                {
                    u.UserId = (int)sqlDataReader["UserId"];
                    u.UserFName = sqlDataReader["UserFName"].ToString();
                    u.Username = sqlDataReader["Username"].ToString();
                    u.UserPwd = sqlDataReader["UserPwd"].ToString();
                    u.LogDate = (DateTime)sqlDataReader["LogDate"];

                }
                connection.Close();

                
            }
            catch (Exception ex)
            {
                connection.Close();
            }

            // u is the object created at the beginning of the this method 
            return u;
        }

        public bool EditLogDate(UserAccount user)
        {


            string selectQuery = "UPDATE UserAccountsTbl SET [LogDate] = @accessDate WHERE [userId] = @id";
            try
            {
                SqlCommand sqlCommand = new SqlCommand(selectQuery, connection);
                // userName parameter of his method
                sqlCommand.Parameters.Add("@accessDate", SqlDbType.DateTime).Value = user.LogDate;
                sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = user.UserId;
                

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
