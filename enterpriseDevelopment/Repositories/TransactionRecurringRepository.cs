using enterpriseDevelopment.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace enterpriseDevelopment.Repositories
{
    class TransactionRecurringRepository
    {
        private Logger Logger = LogManager.GetCurrentClassLogger();
        public string databaseConn;
        SqlConnection connection;

        public TransactionRecurringRepository()
        {
            databaseConn = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            connection = new SqlConnection(databaseConn);
        }

        public List<TransactionRepeat> GetTransactions(int id)
        {
            List<TransactionRepeat> u = new List<TransactionRepeat>();

            string selectQuery = "SELECT TransactionsRepeatTbl.*, ContactsTbl.ContactName AS ContactName FROM TransactionsRepeatTbl LEFT JOIN ContactsTbl ON ContactsTbl.ContactId = TransactionsRepeatTbl.contactIdFk WHERE TransactionsRepeatTbl.userIdFk = @userID";
            try
            {
                SqlCommand sqlCommand = new SqlCommand(selectQuery, connection);
                sqlCommand.Parameters.Add("@userID", SqlDbType.Int).Value = id;
                
                connection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    TransactionRepeat temp = new TransactionRepeat
                    {
                        Id = (int)sqlDataReader["TransactionId"],
                        Category = sqlDataReader["TransactionCategory"].ToString(),
                        Amount = (decimal)sqlDataReader["TransactionAmount"],
                        DateTime = (DateTime)sqlDataReader["dateTime"],
                        Description = sqlDataReader["TransactionMessage"].ToString(),
                        IncomeExpense = (bool)sqlDataReader["IncomeExpense"],
                        UserFk = (int)sqlDataReader["userIdFk"],
                        Period = sqlDataReader["subscriptionPeriod"].ToString()
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

                    if (sqlDataReader["subscriptionEndTime"] == DBNull.Value)
                        temp.EndTime = DateTime.MinValue;
                    else
                        temp.EndTime = (DateTime)sqlDataReader["subscriptionEndTime"];

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

        public bool AddTransction(TransactionRepeat transactionRepeat)
        {
            string selectQuery = "INSERT INTO TransactionsRepeatTbl  ([TransactionCategory], [TransactionAmount], [userIdFk], [contactIdFk], [dateTime], [TransactionMessage], [IncomeExpense], [subscriptionPeriod], [subscriptionEndTime]) VALUES (@TransactionCategory, @TransactionAmount, @userIdFk, @contactIdFk, @dateTime, @TransactionMessage, @IncomeExpense, @subscriptionPeriod, @subscriptionEndTime)";
            try
            {
                SqlCommand sqlCommand = new SqlCommand(selectQuery, connection);
                sqlCommand.Parameters.Add("@TransactionCategory", SqlDbType.VarChar).Value = transactionRepeat.Category;
                sqlCommand.Parameters.Add("@TransactionAmount", SqlDbType.Money).Value = transactionRepeat.Amount;
                sqlCommand.Parameters.Add("@userIdFk", SqlDbType.Int).Value = transactionRepeat.UserFk;
                sqlCommand.Parameters.Add("@dateTime", SqlDbType.DateTime).Value = transactionRepeat.DateTime;
                sqlCommand.Parameters.Add("@TransactionMessage", SqlDbType.VarChar).Value = transactionRepeat.Description;
                sqlCommand.Parameters.Add("@IncomeExpense", SqlDbType.Bit).Value = transactionRepeat.IncomeExpense;
                sqlCommand.Parameters.Add("@subscriptionPeriod", SqlDbType.VarChar).Value = transactionRepeat.Period;

                SqlParameter sqlParameter = new SqlParameter("@contactIdFk", SqlDbType.Int);
                if (transactionRepeat.ContactFk == 0) sqlParameter.Value = DBNull.Value;
                else sqlParameter.Value = transactionRepeat.ContactFk;
                sqlCommand.Parameters.Add(sqlParameter);

                SqlParameter sqlParameter2 = new SqlParameter("@subscriptionEndTime", SqlDbType.DateTime);
                if (transactionRepeat.EndTime == DateTime.MinValue) sqlParameter2.Value = DBNull.Value;
                else sqlParameter2.Value = transactionRepeat.EndTime;
                sqlCommand.Parameters.Add(sqlParameter2);

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

        public bool EditTransaction(TransactionRepeat transactionRepeat)
        {
            string selectQuery = "UPDATE TransactionsRepeatTbl SET [TransactionCategory] = @transactionCategory, [TransactionAmount] = @transactionAmount, [dateTime] = @dateTime, [TransactionMessage] = @transactionMessage, [IncomeExpense] = @incomeExpense, [subscriptionPeriod] = @subscriptionPeriod, [subscriptionEndTime] = @subscriptionEndTime, [contactIdFk] = @contactIdFk WHERE [TransactionId] = @id AND [userIdFk] = @userID";
            try
            {
                SqlCommand sqlCommand = new SqlCommand(selectQuery, connection);
                sqlCommand.Parameters.Add("@transactionCategory", SqlDbType.VarChar).Value = transactionRepeat.Category;
                sqlCommand.Parameters.Add("@transactionAmount", SqlDbType.Money).Value = transactionRepeat.Amount;
                sqlCommand.Parameters.Add("@dateTime", SqlDbType.DateTime).Value = transactionRepeat.DateTime;
                sqlCommand.Parameters.Add("@subscriptionPeriod", SqlDbType.VarChar).Value = transactionRepeat.Period;
                sqlCommand.Parameters.Add("@transactionMessage", SqlDbType.VarChar).Value = transactionRepeat.Description;
                sqlCommand.Parameters.Add("@incomeExpense", SqlDbType.Bit).Value = transactionRepeat.IncomeExpense;
                sqlCommand.Parameters.Add("@userID", SqlDbType.Int).Value = transactionRepeat.UserFk;
                sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = transactionRepeat.Id;

                SqlParameter sqlParameter = new SqlParameter("@contactIdFk", SqlDbType.Int);
                if (transactionRepeat.ContactFk == 0) sqlParameter.Value = DBNull.Value;
                else sqlParameter.Value = transactionRepeat.ContactFk;
                sqlCommand.Parameters.Add(sqlParameter);

                SqlParameter sqlParameter2 = new SqlParameter("@subscriptionEndTime", SqlDbType.DateTime);
                if (transactionRepeat.EndTime == DateTime.MinValue) sqlParameter2.Value = DBNull.Value;
                else sqlParameter2.Value = transactionRepeat.EndTime;
                sqlCommand.Parameters.Add(sqlParameter2);

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

        public bool DeleteTransaction(TransactionRepeat transactionRepeat)
        {
            string selectQuery = "DELETE FROM TransactionsRepeatTbl WHERE [TransactionId] = @transactionID AND [userIdFk] = @userId";
            try
            {
                SqlCommand sqlCommand = new SqlCommand(selectQuery, connection);
                sqlCommand.Parameters.Add("@transactionID", SqlDbType.Int).Value = transactionRepeat.Id;
                sqlCommand.Parameters.Add("@userId", SqlDbType.Int).Value = transactionRepeat.UserFk;

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
