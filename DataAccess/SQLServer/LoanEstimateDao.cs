using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess.SQLServer
{
    public class LoanEstimateDao:ConnectionToSql
    {
        DataTable tableRequest = new DataTable();
        public DataTable MostrarSolicitud()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT LoanId,Document,le.Name,le.LastName,RequestedAmount,InterestRate,ApplicationDate FROM LoanRequest le INNER JOIN Members m ON m.IdMember = le.MemberId WHERE le.Status = 1";
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    tableRequest.Load(reader);
                    return tableRequest;
                }
            }
        }

        public void InsertEstimate(string Document,int NumDues,DateTime Date,int InterestRate,decimal AmountRequest)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SP_LOAN_ESTIMATE";
                    command.Parameters.AddWithValue("@DOCUMENTO", Document);
                    command.Parameters.AddWithValue("@NUM_CUOTAS", NumDues);
                    command.Parameters.AddWithValue("@FECHA_INICIO", Date);
                    command.Parameters.AddWithValue("@TASA", InterestRate);
                    command.Parameters.AddWithValue("@CANT_SOLICITADA", AmountRequest);
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }

        public void InsertDues(string Document,decimal AmountRequest,int InterestRate,DateTime Date)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SP_GENERATE_DUES";
                    command.Parameters.AddWithValue("@DOCUMENTO", Document);
                    command.Parameters.AddWithValue("@CANTIDAD_SOL", AmountRequest);
                    command.Parameters.AddWithValue("@TASA", InterestRate);
                    command.Parameters.AddWithValue("@FECHA", Date);
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }

        DataTable tableDues = new DataTable();
        public DataTable MostrarCuotas(string Document)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT DueDate,LoanAmount,d.InterestRate,DueNumber,DueValue FROM Dues d INNER JOIN LoanRequest lr ON lr.LoanId = d.LoanId INNER JOIN Members m ON m.IdMember = lr.MemberId WHERE m.Document = @DOCUMENTO AND d.Status = 1";
                    command.Parameters.AddWithValue("@DOCUMENTO", Document);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    tableDues.Load(reader);
                    return tableDues;
                }
            }
        }
    }
}