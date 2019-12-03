using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using enterpriseDevelopment.Models;

namespace enterpriseDevelopment.Repositories
{
    class TransactionRepository
    {

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

            string selectQuery = "SELECT * FROM TransactionTbl WHERE [userIdFk] = @userID";
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
                        transactionId = (int)sqlDataReader["TransacionI"],
                        transactionCategory = sqlDataReader["TransactionCategory"].ToString(),
                        transactionAmount = (decimal)sqlDataReader["TransactionAmount"],
                        dateTime = (DateTime)sqlDataReader["dateTime"],
                        transactionMessage = sqlDataReader["TransactionMessage"].ToString(),
                        incomeExpense = (bool)sqlDataReader["IncomeExpense"],
                        userIdFk = (int)sqlDataReader["userIdFk"],
                        contactIdFk = (int)sqlDataReader["contactIdFk"]
                    };

                    if (temp.incomeExpense)
                    {
                        temp.typeValue = "Expense";
                    }
                    else
                    {
                        temp.typeValue = "Income";
                    }



                    //}
                    connection.Close();


                }
            }
            catch (Exception ex)
            {

            }

            // u is the object created at the beginning of the this method 
            return u;
        }

        public bool DeleteTransaction(Transaction transaction)
        {


            string selectQuery = "DELETE FROM TransactionTbl WHERE [TransactionId] = @transactionID AND [userIdFk] = @userId";
            try
            {
                SqlCommand sqlCommand = new SqlCommand(selectQuery, connection);
                // userName parameter of his method
                sqlCommand.Parameters.Add("@transactionID", SqlDbType.Int).Value = transaction.transactionId;
                sqlCommand.Parameters.Add("@userId", SqlDbType.Int).Value = transaction.userIdFk;

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

        public bool AddTransction(Transaction transaction)
        {


            string selectQuery = "INSERT INTO TransactionTbl  ([TransactionId], [TransactionCategory], [TransactionAmount], [userIdFk], [contactIdFk], [dateTime], [TransactionMessage], [IncomeExpense]) VALUES" +
                " (@TransactionId, @TransactionCategory, @TransactionAmount, @userIdFk, @contactIdFk, @dateTime, @TransactionMessage, @IncomeExpense)";
            try
            {
                SqlCommand sqlCommand = new SqlCommand(selectQuery, connection);
                
                sqlCommand.Parameters.Add("@TransactionId", SqlDbType.Int).Value = transaction.transactionId;
                sqlCommand.Parameters.Add("@TransactionCategory", SqlDbType.NVarChar).Value = transaction.transactionCategory;
                sqlCommand.Parameters.Add("@TransactionAmount", SqlDbType.Money).Value = transaction.transactionCategory;
                sqlCommand.Parameters.Add("@userIdFk", SqlDbType.Int).Value = transaction.transactionCategory;
                sqlCommand.Parameters.Add("@contactIdFk", SqlDbType.Int).Value = transaction.transactionCategory;
                sqlCommand.Parameters.Add("@dateTime", SqlDbType.Date).Value = transaction.transactionCategory;
                sqlCommand.Parameters.Add("@TransactionMessage", SqlDbType.NVarChar).Value = transaction.transactionCategory;
                sqlCommand.Parameters.Add("@IncomeExpense", SqlDbType.Bit).Value = transaction.incomeExpense;

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

        public bool EditContact(Transaction transaction)
        {


            string selectQuery = "UPDATE TransactionTbl SET [TransactionCategory] = @transactionCategory, [TransactionAmount] = @transactionAmount, [dateTime] = @dateTime, [TransactionMessage] = @transactionMessage, [IncomeExpense] = @incomeExpense WHERE [TransactionId] = @id AND [userIdFk] = @userID";
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
