using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess.SQLServer
{
    public class LoanRequestDao:ConnectionToSql
    {
        DataTable table = new DataTable();
        public DataTable MostrarMiembrosLoan()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT IdMember,Document,Name,LastName,LimLoan,CurrentDeb FROM Members";
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    table.Load(reader);
                    return table;
                }
            }
        }

        DataTable tableRequest = new DataTable();
        public DataTable MostrarSolicitud()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT LoanId,MemberId,Name,LastName,RequestedAmount,InterestRate,ApplicationDate,Observations FROM LoanRequest WHERE Status = 1";
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    tableRequest.Load(reader);
                    return tableRequest;
                }
            }
        }

        DataTable tableVault = new DataTable();
        public DataTable MostrarFondos()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT SUM(Amount) AS AvailableAmount FROM Vault WHERE OperationId <> 3";
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    tableVault.Load(reader);
                    return tableVault;
                }
            }
        }

        public void InsertRequest(string Document, string name, string lastname,double requestamount,int interestrate,string observations)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SP_LOAN_REQUEST";
                    command.Parameters.AddWithValue("@DOCUMENTO", Document);
                    command.Parameters.AddWithValue("@NOMBRES", name);
                    command.Parameters.AddWithValue("@APELLIDOS", lastname);
                    command.Parameters.AddWithValue("@CANT_SOLICITADA", requestamount);
                    command.Parameters.AddWithValue("@TASA", interestrate);
                    command.Parameters.AddWithValue("@OBSERVACIONES", observations);
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }

        public void DeleteRequest(int LoanId)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "DELETE FROM LoanRequest WHERE LoanId = @LoanId";
                    command.Parameters.AddWithValue("@LoanId", LoanId);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }
    }
}
