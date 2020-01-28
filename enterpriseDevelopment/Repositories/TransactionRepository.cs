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
            connection = new SqlConnection(databaseConn);
            List<Transaction> u = new List<Transaction>();

            string selectQuery = "SELECT TransactionsTbl.*, ContactsTbl.ContactName AS ContactName FROM TransactionsTbl LEFT JOIN ContactsTbl ON ContactsTbl.ContactId = TransactionsTbl.contactIdFk WHERE TransactionsTbl.userIdFk = @userID";
            try
            {
                SqlCommand sqlCommand = new SqlCommand(selectQuery, connection);
                sqlCommand.Parameters.Add("@userID", SqlDbType.Int).Value = id;
                

                connection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Transaction temp = new Transaction
                    {
                        Id = (int)sqlDataReader["TransactionId"],
                        Category = sqlDataReader["TransactionCategory"].ToString(),
                        Amount = (decimal)sqlDataReader["TransactionAmount"],
                        DateTime = (DateTime)sqlDataReader["dateTime"],
                        Description = sqlDataReader["TransactionMessage"].ToString(),
                        IncomeExpense = (bool)sqlDataReader["IncomeExpense"],
                        UserFk = (int)sqlDataReader["userIdFk"]
                    };

                    if (temp.IncomeExpense == true)
                        temp.TransactionType = "Income";
                    else
                        temp.TransactionType = "Expense";

                    if (sqlDataReader["contactIdFk"] == DBNull.Value)
                        temp.ContactFk = 0;
                    else
                        temp.ContactFk = (int)sqlDataReader["contactIdFk"];

                    if (sqlDataReader["ContactName"] == DBNull.Value)
                        temp.ContactName = "";
                    else
                        temp.ContactName = sqlDataReader["ContactName"].ToString();

                    u.Add(temp);
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

        public List<Transaction> GetTransactions(DateTime date, int id)
        {
            connection = new SqlConnection(databaseConn);
            List<Transaction> u = new List<Transaction>();

            string selectQuery = "SELECT * FROM TransactionsTbl WHERE userIdFk = @userID AND CONVERT(Date, dateTime,1) BETWEEN @StartDate AND @EndDate";
            try
            {
                SqlCommand sqlCommand = new SqlCommand(selectQuery, connection);
                sqlCommand.Parameters.Add("@userID", SqlDbType.Int).Value = id;
                sqlCommand.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = date.AddDays(-30).ToShortDateString();
                sqlCommand.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = date.ToShortDateString();
                
                connection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Transaction temp = new Transaction
                    {
                        Id = (int)sqlDataReader["TransactionId"],
                        Category = sqlDataReader["TransactionCategory"].ToString(),
                        Amount = (decimal)sqlDataReader["TransactionAmount"],
                        DateTime = (DateTime)sqlDataReader["dateTime"],
                        Description = sqlDataReader["TransactionMessage"].ToString(),
                        IncomeExpense = (bool)sqlDataReader["IncomeExpense"],
                        UserFk = (int)sqlDataReader["userIdFk"]
                    };

                    if (temp.IncomeExpense == true)
                        temp.TransactionType = "Income";
                    else
                        temp.TransactionType = "Expense";

                    if (sqlDataReader["contactIdFk"] == DBNull.Value)
                        temp.ContactFk = 0;
                    else
                        temp.ContactFk = (int)sqlDataReader["contactIdFk"];
                    u.Add(temp);
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


        public bool DeleteTransaction(Transaction transaction)
        {
            connection = new SqlConnection(databaseConn);
            int x = 0;
            string selectQuery = "DELETE FROM TransactionsTbl WHERE [TransactionId] = @transactionID AND [userIdFk] = @userId";
            try
            {
                SqlCommand sqlCommand = new SqlCommand(selectQuery, connection);
                sqlCommand.Parameters.Add("@transactionID", SqlDbType.Int).Value = transaction.Id;
                sqlCommand.Parameters.Add("@userId", SqlDbType.Int).Value = transaction.UserFk;

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
                return true;
            else
                return false;
        }

        public bool AddTransction(Transaction transaction)
        {
            connection = new SqlConnection(databaseConn);
            string selectQuery = "INSERT INTO TransactionsTbl  ([TransactionCategory], [TransactionAmount], [userIdFk], [contactIdFk], [dateTime], [TransactionMessage], [IncomeExpense]) VALUES (@TransactionCategory, @TransactionAmount, @userIdFk, @contactIdFk, @dateTime, @TransactionMessage, @IncomeExpense)";
            try
            {
                SqlCommand sqlCommand = new SqlCommand(selectQuery, connection);
                sqlCommand.Parameters.Add("@TransactionCategory", SqlDbType.VarChar).Value = transaction.Category;
                sqlCommand.Parameters.Add("@TransactionAmount", SqlDbType.Money).Value = transaction.Amount;
                sqlCommand.Parameters.Add("@userIdFk", SqlDbType.Int).Value = transaction.UserFk;
                sqlCommand.Parameters.Add("@dateTime", SqlDbType.DateTime).Value = transaction.DateTime;
                sqlCommand.Parameters.Add("@TransactionMessage", SqlDbType.VarChar).Value = transaction.Description;
                sqlCommand.Parameters.Add("@IncomeExpense", SqlDbType.Bit).Value = transaction.IncomeExpense;

                SqlParameter sqlParameter = new SqlParameter("@contactIdFk", SqlDbType.Int);
                if (transaction.ContactFk == 0) sqlParameter.Value = DBNull.Value;
                else sqlParameter.Value = transaction.ContactFk;
                sqlCommand.Parameters.Add(sqlParameter);

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

        public bool EditTransaction(Transaction transaction)
        {
            connection = new SqlConnection(databaseConn);
            string selectQuery = "UPDATE TransactionsTbl SET [TransactionCategory] = @transactionCategory, [TransactionAmount] = @transactionAmount, [dateTime] = @dateTime, [TransactionMessage] = @transactionMessage, [IncomeExpense] = @incomeExpense, [contactIdFk] = @contactIdFk WHERE [TransactionId] = @id AND [userIdFk] = @userID";
            try
            {
                SqlCommand sqlCommand = new SqlCommand(selectQuery, connection);

                sqlCommand.Parameters.Add("@transactionCategory", SqlDbType.NVarChar).Value = transaction.Category;
                sqlCommand.Parameters.Add("@transactionAmount", SqlDbType.Money).Value = transaction.Amount;
                sqlCommand.Parameters.Add("@dateTime", SqlDbType.DateTime).Value = transaction.DateTime;
                sqlCommand.Parameters.Add("@transactionMessage", SqlDbType.NVarChar).Value = transaction.Description;
                sqlCommand.Parameters.Add("@incomeExpense", SqlDbType.Bit).Value = transaction.IncomeExpense;
                sqlCommand.Parameters.Add("@userID", SqlDbType.Int).Value = transaction.UserFk;
                sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = transaction.Id;

                SqlParameter sqlParameter = new SqlParameter("@contactIdFk", SqlDbType.Int);
                if (transaction.ContactFk == 0) sqlParameter.Value = DBNull.Value;
                else sqlParameter.Value = transaction.ContactFk;
                sqlCommand.Parameters.Add(sqlParameter);

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
