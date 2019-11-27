using System;
using System.Collections.Generic;
using System.Configuration;
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
            dbConn = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            connection = new SqlConnection(dbConn);
        }


        public bool addUserAccount(UserAccount UserId)
        {
            Query = "INSERT INTO UserAccounts([UserId], [UserId]) VALUES(@UserId);";

            return false;
        }
    }
}
