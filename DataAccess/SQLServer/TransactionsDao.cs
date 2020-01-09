using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.SQLServer
{
    public class TransactionsDao:ConnectionToSql
    {
        DataTable tablePerson = new DataTable();
        public DataTable ShowPersons(string Document)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    //command.CommandText = "SELECT Document,m.AccountNumber,Name,LastName,CurrentSaving FROM Members m WHERE Document LIKE ('%@DOCUMENT%')";
                    command.CommandText = "SELECT Document,m.AccountNumber,Name,LastName,LimSaving,CurrentSaving FROM Members m WHERE Document LIKE ('%'+@DOCUMENT+'%') AND m.AccountNumber <> ''";
                    command.Parameters.AddWithValue("@DOCUMENT", Document);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    tablePerson.Load(reader);
                    return tablePerson;
                }
            }
        }

        public void InsertTransaction(string Document, int OperationId, decimal Amount)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SP_TRANSACTIONS";
                    command.Parameters.AddWithValue("@DOCUMENTO", Document);
                    command.Parameters.AddWithValue("@OPERATION_ID", OperationId);
                    command.Parameters.AddWithValue("@AMOUNT_TRANS", Amount);
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }

        DataTable tableSummary = new DataTable();
        public DataTable ShowSummaryTran(string Document)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT Document,m.AccountNumber,Name,LastName,Amount,AmountTransaction,TransactionDate FROM Members m INNER JOIN Account a ON a.MemberId = m.IdMember LEFT JOIN Transactions t ON t.IdAccount = a.AccountId WHERE Document = @DOCUMENT";
                    command.Parameters.AddWithValue("@DOCUMENT", Document);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    tableSummary.Load(reader);
                    return tableSummary;
                }
            }
        }

        public DataTable ReportTransaction(string Document)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SP_TRANSACTION_SUMMARY_HEADER";
                    command.Parameters.AddWithValue("@DOCUMENT", Document);
                    command.CommandType = CommandType.StoredProcedure;
                    var reader = command.ExecuteReader();
                    var table = new DataTable();
                    table.Load(reader);
                    reader.Dispose();
                    return table;
                }
            }
        }

        public DataTable ReportTransactionDetail(string Document)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SP_TRANSACTION_SUMMARY_DETAIL";
                    command.Parameters.AddWithValue("@DOCUMENT", Document);
                    command.CommandType = CommandType.StoredProcedure;
                    var reader = command.ExecuteReader();
                    var table = new DataTable();
                    table.Load(reader);
                    reader.Dispose();
                    return table;
                }
            }
        }
    }
}
