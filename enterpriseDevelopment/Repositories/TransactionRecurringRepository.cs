using enterpriseDevelopment.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enterpriseDevelopment.Repositories
{
    class TransactionRecurringRepository
    {

        public string databaseConn;
        SqlConnection connection;

        public TransactionRecurringRepository()
        {

            databaseConn = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            connection = new SqlConnection(databaseConn);
        }

        public List<TransactionRepeat> GetTransactions(int id)
        {

            // object u
            List<TransactionRepeat> u = new List<TransactionRepeat>();

            string selectQuery = "SELECT TransactionsRepeatTbl.*, ContactsTbl.ContactName AS ContactName FROM TransactionsRepeatTbl LEFT JOIN ContactsTbl ON ContactsTbl.ContactId = TransactionsRepeatTbl.contactIdFk WHERE TransactionsRepeatTbl.userIdFk = @userID";
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
                    TransactionRepeat temp = new TransactionRepeat
                    {
                        transactionId = (int)sqlDataReader["TransactionId"],
                        transactionCategory = sqlDataReader["TransactionCategory"].ToString(),
                        transactionAmount = (decimal)sqlDataReader["TransactionAmount"],
                        dateTime = (DateTime)sqlDataReader["dateTime"],
                        transactionMessage = sqlDataReader["TransactionMessage"].ToString(),
                        incomeExpense = (bool)sqlDataReader["IncomeExpense"],
                        userIdFk = (int)sqlDataReader["userIdFk"],
                        subscriptionPeriod = sqlDataReader["subscriptionPeriod"].ToString()
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

                    if (sqlDataReader["subscriptionEndTime"] == DBNull.Value)
                    {
                        temp.subscriptionEndTime = DateTime.MinValue;
                    }
                    else
                    {
                        temp.subscriptionEndTime = (DateTime)sqlDataReader["subscriptionEndTime"];
                    }



                    u.Add(temp);



                }
                connection.Close();
            }
            catch (Exception ex)
            {

            }

            // u is the object created at the beginning of the this method 
            return u;
        }

        public bool AddTransction(TransactionRepeat transactionRepeat)
        {


            string selectQuery = "INSERT INTO TransactionsRepeatTbl  ([TransactionCategory], [TransactionAmount], [userIdFk], [contactIdFk], [dateTime], [TransactionMessage], [IncomeExpense], [subscriptionPeriod], [subscriptionEndTime]) VALUES (@TransactionCategory, @TransactionAmount, @userIdFk, @contactIdFk, @dateTime, @TransactionMessage, @IncomeExpense, @subscriptionPeriod, @subscriptionEndTime)";
            try
            {
                SqlCommand sqlCommand = new SqlCommand(selectQuery, connection);


                sqlCommand.Parameters.Add("@TransactionCategory", SqlDbType.VarChar).Value = transactionRepeat.transactionCategory;
                sqlCommand.Parameters.Add("@TransactionAmount", SqlDbType.Money).Value = transactionRepeat.transactionAmount;
                sqlCommand.Parameters.Add("@userIdFk", SqlDbType.Int).Value = transactionRepeat.userIdFk;
                sqlCommand.Parameters.Add("@dateTime", SqlDbType.DateTime).Value = transactionRepeat.dateTime;
                sqlCommand.Parameters.Add("@TransactionMessage", SqlDbType.VarChar).Value = transactionRepeat.transactionMessage;
                sqlCommand.Parameters.Add("@IncomeExpense", SqlDbType.Bit).Value = transactionRepeat.incomeExpense;
                sqlCommand.Parameters.Add("@subscriptionPeriod", SqlDbType.VarChar).Value = transactionRepeat.subscriptionPeriod;
               
                // to avoid storing contact id as 0
                SqlParameter sqlParameter = new SqlParameter("@contactIdFk", SqlDbType.Int);
                if (transactionRepeat.contactIdFk == 0) sqlParameter.Value = DBNull.Value;
                else sqlParameter.Value = transactionRepeat.contactIdFk;
                sqlCommand.Parameters.Add(sqlParameter);

                SqlParameter sqlParameter2 = new SqlParameter("@subscriptionEndTime", SqlDbType.DateTime);
                if (transactionRepeat.subscriptionEndTime == DateTime.MinValue) sqlParameter2.Value = DBNull.Value;
                else sqlParameter2.Value = transactionRepeat.subscriptionEndTime;
                sqlCommand.Parameters.Add(sqlParameter2);

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
                return false;
            }
        }

        public bool EditTransaction(TransactionRepeat transactionRepeat)
        {


            string selectQuery = "UPDATE TransactionsRepeatTbl SET [TransactionCategory] = @transactionCategory, [TransactionAmount] = @transactionAmount, [dateTime] = @dateTime, [TransactionMessage] = @transactionMessage, [IncomeExpense] = @incomeExpense, [subscriptionPeriod] = @subscriptionPeriod, [subscriptionEndTime] = @subscriptionEndTime WHERE [TransactionId] = @id AND [userIdFk] = @userID";
            try
            {
                SqlCommand sqlCommand = new SqlCommand(selectQuery, connection);


                sqlCommand.Parameters.Add("@transactionCategory", SqlDbType.NVarChar).Value = transactionRepeat.transactionCategory;
                sqlCommand.Parameters.Add("@transactionAmount", SqlDbType.Money).Value = transactionRepeat.transactionAmount;
                sqlCommand.Parameters.Add("@dateTime", SqlDbType.DateTime).Value = transactionRepeat.dateTime;
                sqlCommand.Parameters.Add("@subscriptionPeriod", SqlDbType.DateTime).Value = transactionRepeat.subscriptionPeriod;
                sqlCommand.Parameters.Add("@subscriptionEndTime", SqlDbType.DateTime).Value = transactionRepeat.subscriptionEndTime;
                sqlCommand.Parameters.Add("@transactionMessage", SqlDbType.NVarChar).Value = transactionRepeat.transactionMessage;
                sqlCommand.Parameters.Add("@incomeExpense", SqlDbType.Bit).Value = transactionRepeat.incomeExpense;
                sqlCommand.Parameters.Add("@userID", SqlDbType.Int).Value = transactionRepeat.userIdFk;
                sqlCommand.Parameters.Add("@id", SqlDbType.Int).Value = transactionRepeat.transactionId;

                SqlParameter sqlParameter2 = new SqlParameter("@subscriptionEndTime", SqlDbType.DateTime);
                if (transactionRepeat.subscriptionEndTime == DateTime.MinValue) sqlParameter2.Value = DBNull.Value;
                else sqlParameter2.Value = transactionRepeat.subscriptionEndTime;
                sqlCommand.Parameters.Add(sqlParameter2);

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
                return false;
            }


        }

        public bool DeleteTransaction(TransactionRepeat transactionRepeat)
        {


            string selectQuery = "DELETE FROM TransactionsRepeatTbl WHERE [TransactionId] = @transactionID AND [userIdFk] = @userId";
            try
            {
                SqlCommand sqlCommand = new SqlCommand(selectQuery, connection);
                // userName parameter of his method
                sqlCommand.Parameters.Add("@transactionID", SqlDbType.Int).Value = transactionRepeat.transactionId;
                sqlCommand.Parameters.Add("@userId", SqlDbType.Int).Value = transactionRepeat.userIdFk;

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
                return false;
            }


        }
    }
}
