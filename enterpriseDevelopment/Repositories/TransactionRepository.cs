using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using enterpriseDevelopment.Models;
using NLog;

namespace enterpriseDevelopment.Repositories
{
    class TransactionRepository
    {
        private Logger Logger = LogManager.GetCurrentClassLogger();

        public string databaseConn;
        SqlConnection connection;

        public TransactionRepository()
        {
            databaseConn = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            connection = new SqlConnection(databaseConn);
        }

        public List<Transaction> GetTransactions(int id)
        {

            // object u
            List<Transaction> u = new List<Transaction>();

            string selectQuery = "SELECT TransactionsTbl.*, ContactsTbl.ContactName AS ContactName FROM TransactionsTbl LEFT JOIN ContactsTbl ON ContactsTbl.ContactId = TransactionsTbl.contactIdFk WHERE TransactionsTbl.userIdFk = @userID";
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
                    Transaction temp = new Transaction
                    {
                        transactionId = (int)sqlDataReader["TransactionId"],
                        transactionCategory = sqlDataReader["TransactionCategory"].ToString(),
                        transactionAmount = (decimal)sqlDataReader["TransactionAmount"],
                        dateTime = (DateTime)sqlDataReader["dateTime"],
                        transactionMessage = sqlDataReader["TransactionMessage"].ToString(),
                        incomeExpense = (bool)sqlDataReader["IncomeExpense"],
                        userIdFk = (int)sqlDataReader["userIdFk"]
                    };

                    if (temp.incomeExpense == true)
                    {
                        temp.typeValue = "Income";
                    }
                    else
                    {
                        temp.typeValue = "Expense";
                    }


                    if (sqlDataReader["contactIdFk"] == DBNull.Value)
                    {
                        temp.contactIdFk = 0;
                    }
                    else
                    {
                        temp.contactIdFk = (int)sqlDataReader["contactIdFk"];
                    }

                    if (sqlDataReader["ContactName"] == DBNull.Value)
                    {
                        temp.contactName = "";
                    }
                    else
                    {
                        temp.contactName = sqlDataReader["ContactName"].ToString();
                    }
                    u.Add(temp);



                }
                connection.Close();
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
                connection.Close();

            }

            // u is the object created at the beginning of the this method 
            return u;
        }

        public List<Transaction> GetTransactions(DateTime date ,int id)
        {

            // object u
            List<Transaction> u = new List<Transaction>();

            string selectQuery = "SELECT * FROM TransactionsTbl WHERE userIdFk = @userID AND CONVERT(Date, dateTime,1) BETWEEN @StartDate AND @EndDate";
            try
            {
                SqlCommand sqlCommand = new SqlCommand(selectQuery, connection);
                // userName parameter of his method
                sqlCommand.Parameters.Add("@userID", SqlDbType.Int).Value = id;
                sqlCommand.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = date.AddDays(-30).ToShortDateString();
                sqlCommand.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = date.ToShortDateString();

                connection.Open();
                // Ask to retrieve all the  row
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();



                while (sqlDataReader.Read())
                {
                    Transaction temp = new Transaction
                    {
                        transactionId = (int)sqlDataReader["TransactionId"],
                        transactionCategory = sqlDataReader["TransactionCategory"].ToString(),
                        transactionAmount = (decimal)sqlDataReader["TransactionAmount"],
                        dateTime = (DateTime)sqlDataReader["dateTime"],
                        transactionMessage = sqlDataReader["TransactionMessage"].ToString(),
                        incomeExpense = (bool)sqlDataReader["IncomeExpense"],
                        userIdFk = (int)sqlDataReader["userIdFk"]
                    };

                    if (temp.incomeExpense == true)
                    {
                        temp.typeValue = "Income";
                    }
                    else
                    {
                        temp.typeValue = "Expense";
                    }


                    if (sqlDataReader["contactIdFk"] == DBNull.Value)
                    {
                        temp.contactIdFk = 0;
                    }
                    else
                    {
                        temp.contactIdFk = (int)sqlDataReader["contactIdFk"];
                    }
                   
                    u.Add(temp);



                }
                connection.Close();
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
                connection.Close();

            }

            // u is the object created at the beginning of the this method 
            return u;
        }


        public bool DeleteTransaction(Transaction transaction)
        {
            int x = 0;
            string selectQuery = "DELETE FROM TransactionsTbl WHERE [TransactionId] = @transactionID AND [userIdFk] = @userId";
            try
            {
                SqlCommand sqlCommand = new SqlCommand(selectQuery, connection);
                // userName parameter of his method
                sqlCommand.Parameters.Add("@transactionID", SqlDbType.Int).Value = transaction.transactionId;
                sqlCommand.Parameters.Add("@userId", SqlDbType.Int).Value = transaction.userIdFk;

                connection.Open();
                x = sqlCommand.ExecuteNonQuery();



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
            if (x > 0)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        public bool AddTransction(Transaction transaction)
        {


            string selectQuery = "INSERT INTO TransactionsTbl  ([TransactionCategory], [TransactionAmount], [userIdFk], [contactIdFk], [dateTime], [TransactionMessage], [IncomeExpense]) VALUES (@TransactionCategory, @TransactionAmount, @userIdFk, @contactIdFk, @dateTime, @TransactionMessage, @IncomeExpense)";
            try
            {
                SqlCommand sqlCommand = new SqlCommand(selectQuery, connection);


                sqlCommand.Parameters.Add("@TransactionCategory", SqlDbType.VarChar).Value = transaction.transactionCategory;
                sqlCommand.Parameters.Add("@TransactionAmount", SqlDbType.Money).Value = transaction.transactionAmount;
                sqlCommand.Parameters.Add("@userIdFk", SqlDbType.Int).Value = transaction.userIdFk;
                sqlCommand.Parameters.Add("@dateTime", SqlDbType.DateTime).Value = transaction.dateTime;
                sqlCommand.Parameters.Add("@TransactionMessage", SqlDbType.VarChar).Value = transaction.transactionMessage;
                sqlCommand.Parameters.Add("@IncomeExpense", SqlDbType.Bit).Value = transaction.incomeExpense;
                // to avoid storing contact id as 0
                SqlParameter sqlParameter = new SqlParameter("@contactIdFk", SqlDbType.Int);
                if (transaction.contactIdFk == 0) sqlParameter.Value = DBNull.Value;
                else sqlParameter.Value = transaction.contactIdFk;
                sqlCommand.Parameters.Add(sqlParameter);

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

        public bool EditTransaction(Transaction transaction)
        {


            string selectQuery = "UPDATE TransactionsTbl SET [TransactionCategory] = @transactionCategory, [TransactionAmount] = @transactionAmount, [dateTime] = @dateTime, [TransactionMessage] = @transactionMessage, [IncomeExpense] = @incomeExpense, [contactIdFk] = @contactIdFk WHERE [TransactionId] = @id AND [userIdFk] = @userID";
            try
            {
                SqlCommand sqlCommand = new SqlCommand(selectQuery, connection);


                sqlCommand.Parameters.Add("@transactionCategory", SqlDbType.NVarChar).Value = transaction.transactionCategory;
                sqlCommand.Parameters.Add("@transactionAmount", SqlDbType.Money).Value = transaction.transactionAmount;
                sqlCommand.Parameters.Add("@dateTime", SqlDbType.DateTime).Value = transaction.dateTime;
                sqlCommand.Parameters.Add("@transactionMessage", SqlDbType.NVarChar).Value = transaction.transactionMessage;
                sqlCommand.Parameters.Add("@incomeExpense", SqlDbType.Bit).Value = transaction.incomeExpense;
                sqlCommand.Parameters.Add("@userID", SqlDbType.Int).Value = transaction.userIdFk;
                sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = transaction.transactionId;

                // to avoid storing contact id as 0
                SqlParameter sqlParameter = new SqlParameter("@contactIdFk", SqlDbType.Int);
                if (transaction.contactIdFk == 0) sqlParameter.Value = DBNull.Value;
                else sqlParameter.Value = transaction.contactIdFk;
                sqlCommand.Parameters.Add(sqlParameter);

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
