using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.SQLServer
{
    public class StationeryDao:ConnectionToSql
    {
        DataTable tableMembers = new DataTable();
        public DataTable ShowMembers()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT IdMember,Document,Name,LastName,CASE WHEN Member = 1 THEN 'Miembro' WHEN Member = 0 THEN 'Externo' END as Member, AccountId FROM Members m INNER JOIN Account a ON a.MemberId = m.IdMember WHERE Member = 1";
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    tableMembers.Load(reader);
                    return tableMembers;
                }
            }
        }

        public void TransferVault(int MemberId, string Document, int AccountId)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SP_LOAD_STATONERY";
                    command.Parameters.AddWithValue("@IDMEMBER", MemberId);
                    command.Parameters.AddWithValue("@DOCUMENT", Document);
                    command.Parameters.AddWithValue("@ACCOUNTID", AccountId);
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }

        DataTable tableVault = new DataTable();
        public DataTable ShowVault(DateTime InitialDate, DateTime FinalDate)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SP_VAULT_STATONERY";
                    command.Parameters.AddWithValue("@INITIAL_DATE", InitialDate);
                    command.Parameters.AddWithValue("@FINAL_DATE", FinalDate);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();
                    tableVault.Load(reader);
                    return tableVault;
                }
            }
        }
    }
}
