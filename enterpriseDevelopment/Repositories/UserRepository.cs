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
                sqlCommand.Parameters.Add("@UserPwd", SqlDbType.Text).Value = userObj.Password;
                sqlCommand.Parameters.Add("@UserFName", SqlDbType.Text).Value = userObj.FullName;

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
            UserAccount u = new UserAccount();

            string selectQuery = "SELECT * FROM UserAccountsTbl WHERE [Username] = @Username";
            dbConn = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            try
            {
                SqlCommand sqlCommand = new SqlCommand(selectQuery, connection);
                sqlCommand.Parameters.Add("@Username", SqlDbType.NVarChar).Value = userName;
                
                connection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.SingleRow);
                while (sqlDataReader.Read())
                {
                    u.Id = (int)sqlDataReader["UserId"];
                    u.FullName = sqlDataReader["UserFName"].ToString();
                    u.Username = sqlDataReader["Username"].ToString();
                    u.Password = sqlDataReader["UserPwd"].ToString();
                    u.LogDate = (DateTime)sqlDataReader["LogDate"];
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
