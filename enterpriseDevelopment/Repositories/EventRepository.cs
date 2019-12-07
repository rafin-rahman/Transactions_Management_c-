using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using enterpriseDevelopment.Models;

namespace enterpriseDevelopment.Repositories
{



    class EventRepository
    {
        public string databaseConn;
        SqlConnection connection;

        public EventRepository()
        {

            databaseConn = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            connection = new SqlConnection(databaseConn);
        }

        // Store events into DB
        public bool AddEvent(Event eventObj)
        {

            string addQuery = "INSERT INTO EventsTbl ([EventTitle],[EventStatus],[Location],[EventMessage],[dateTime],[userIdFk],[contactIdFk]) VALUES (@title, @status, @location, @messsage, @datetime, @userFk, @contactFk)"
            try
            {
                SqlCommand sqlCommand = new SqlCommand(addQuery, connection);
                sqlCommand.Parameters.Add("@title", SqlDbType.VarChar).Value = eventObj.title;
                sqlCommand.Parameters.Add("@status", SqlDbType.VarChar).Value = eventObj.status;
                sqlCommand.Parameters.Add("@location", SqlDbType.VarChar).Value = eventObj.location;
                sqlCommand.Parameters.Add("@message", SqlDbType.VarChar).Value = eventObj.message;
                sqlCommand.Parameters.Add("@datetime", SqlDbType.DateTime).Value = eventObj.date;
                sqlCommand.Parameters.Add("@userFk", SqlDbType.Int).Value = eventObj.userFK;
                sqlCommand.Parameters.Add("@contactFk", SqlDbType.Int).Value = eventObj.contactFk;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

    }


}
