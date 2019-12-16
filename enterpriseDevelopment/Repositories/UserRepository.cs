using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog; 

namespace enterpriseDevelopment
{
    class UserRepository
    {
        private Logger Logger = LogManager.GetCurrentClassLogger();
        public string dbConn;
        SqlConnection connection;
        public UserRepository()
        {
           
            dbConn = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;

            connection = new SqlConnection(dbConn);
        }

        
        public bool AddUserAccount(UserAccount userObj)
        {

            string addUserQuery = "INSERT INTO UserAccountsTbl( [Username], [UserPwd], [UserFName] ) " + "VALUES " + "(@UserName,@UserPwd, @UserFName) ;";

            try
            {
                SqlCommand sqlCommand = new SqlCommand(addUserQuery, connection);
                
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

                Logger.Error(ex.Message);
                connection.Close();
                return false;
            }

        }


        public UserAccount GetUserByUsername(string userName)
        {

           
            UserAccount u = new UserAccount();
           
            string selectQuery = "SELECT * FROM UserAccountsTbl WHERE [Username] = @Username";
            dbConn = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            try
            {
                SqlCommand sqlCommand = new SqlCommand(selectQuery, connection);
               
                sqlCommand.Parameters.Add("@Username", SqlDbType.NVarChar).Value = userName;


                connection.Open();
               
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

                Logger.Error(ex.Message);
                connection.Close();
            }

            
            return u;
        }

        public bool EditLogDate(UserAccount user)
        {


            string selectQuery = "UPDATE UserAccountsTbl SET [LogDate] = @accessDate WHERE [userId] = @id";
            try
            {
                SqlCommand sqlCommand = new SqlCommand(selectQuery, connection);
                
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
                Logger.Error(ex.Message);
                connection.Close();
                return false;
            }


        }

    }
}
