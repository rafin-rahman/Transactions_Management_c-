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
        public string databaseConn;
        SqlConnection connection;
        public UserRepository()
        {
            databaseConn = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            connection = new SqlConnection(databaseConn);
        }

        public bool AddUserAccount(UserAccount userAccount)
        {
            string addQuery = "INSERT INTO UserAccountsTbl( [Username], [UserPwd], [UserFName] ) " + "VALUES " + "(@UserName,@UserPwd, @UserFName) ;";

            try
            {
                SqlCommand sqlCommand = new SqlCommand(addQuery, connection);
                sqlCommand.Parameters.Add("@UserName", SqlDbType.Text).Value = userAccount.Username;
                sqlCommand.Parameters.Add("@UserPwd", SqlDbType.Text).Value = userAccount.Password;
                sqlCommand.Parameters.Add("@UserFName", SqlDbType.Text).Value = userAccount.FullName;

                connection.Open();
                var i = sqlCommand.ExecuteNonQuery();

                if (i > 0)
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

        public UserAccount GetUserByUsername(string userName)
        {
            UserAccount userAccount = new UserAccount();

            string selectQuery = "SELECT * FROM UserAccountsTbl WHERE [Username] = @Username";
            databaseConn = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            try
            {
                SqlCommand sqlCommand = new SqlCommand(selectQuery, connection);
                sqlCommand.Parameters.Add("@Username", SqlDbType.NVarChar).Value = userName;
                
                connection.Open();
                // get only one user
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.SingleRow);
                while (sqlDataReader.Read())
                {
                    userAccount.Id = (int)sqlDataReader["UserId"];
                    userAccount.FullName = sqlDataReader["UserFName"].ToString();
                    userAccount.Username = sqlDataReader["Username"].ToString();
                    userAccount.Password = sqlDataReader["UserPwd"].ToString();
                    userAccount.LogDate = (DateTime)sqlDataReader["LogDate"];
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
            return userAccount;
        }

        public bool EditLogDate(UserAccount user)
        {
            string selectQuery = "UPDATE UserAccountsTbl SET [LogDate] = @accessDate WHERE [userId] = @id";
            try
            {
                SqlCommand sqlCommand = new SqlCommand(selectQuery, connection);
                sqlCommand.Parameters.Add("@accessDate", SqlDbType.DateTime).Value = user.LogDate;
                sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = user.Id;

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
    }
}
