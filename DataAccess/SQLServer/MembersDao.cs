using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess.SQLServer
{
    public class MembersDao:ConnectionToSql
    {
        DataTable table = new DataTable();    
        public DataTable Mostrar()
        {
            //TRANSACT SQL
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT IdMember,Document,Name,LastName,Phone,LimSaving,LimLoan,CurrentDeb, CASE WHEN Member = 1 THEN 'Miembro' WHEN Member = 0 THEN 'Externo' END as Member FROM Members";
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    table.Load(reader);
                    return table;
                }
            }
        }
        public void Insert(string Document, string name, string lastname, string phone, double limsaving, double limloan, bool member)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    //command.CommandText = "INSERT INTO Members(Document,Name,LastName,Phone,LimSaving) VALUES ('" + Document + "','" + name + "','" + lastname + "','" + phone + "'," + limsaving + ")";
                    //command.CommandType = CommandType.Text;
                    command.CommandText = "SP_INSERT_MEMBER";
                    command.Parameters.AddWithValue("@DOCUMENTO", Document);
                    command.Parameters.AddWithValue("@NOMBRES", name);
                    command.Parameters.AddWithValue("@APELLIDOS", lastname);
                    command.Parameters.AddWithValue("@TELEFONO", phone);
                    command.Parameters.AddWithValue("@AHORRO", limsaving);
                    command.Parameters.AddWithValue("@LIM_PRESTAMOS", limloan);
                    command.Parameters.AddWithValue("@MIEMBRO", member);
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }
        public void Edit(string Document, string name, string lastname, string phone, double limsaving, double limloan, bool member)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE Members SET Document = @document, Name = @name, LastName = @lastname, Phone = @phone, LimSaving = @limsaving, LimLoan = @LimLoan, member = @member WHERE  Document = @document";
                    command.Parameters.AddWithValue("@document", Document);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@lastname", lastname);
                    command.Parameters.AddWithValue("@phone", phone);
                    command.Parameters.AddWithValue("@limsaving", limsaving);
                    command.Parameters.AddWithValue("@LimLoan", limloan);
                    command.Parameters.AddWithValue("@member", member);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }
        public void Delete(int memberid)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "DELETE FROM Members WHERE IdMember = @memberid";
                    command.Parameters.AddWithValue("@memberid", memberid);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    command.Parameters.Clear();
                }
            }
        }
    }
}
