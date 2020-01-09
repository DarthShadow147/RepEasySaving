using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Common.Cache;

namespace DataAccess.SQLServer
{
    public class UserDao:ConnectionToSql
    {

        public void editProfile(int id, string username, string password, string name, string lastname, string email)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE Users SET UserName = @username, Password = @password, FirstName = @name, LastName = @lastname, Email = @email WHERE UserId = @id";
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@lastname", lastname);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@id", id);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
            }
        }


        public bool Login(string user, string password)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Users WHERE UserName = @UserName AND Password = @Password";
                    command.Parameters.AddWithValue("@UserName", user);
                    command.Parameters.AddWithValue("@Password", password);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserLoginCache.IdUser = reader.GetInt32(0);
                            UserLoginCache.LoginName = reader.GetString(1);
                            UserLoginCache.Password = reader.GetString(2);
                            UserLoginCache.FirstName = reader.GetString(3);
                            UserLoginCache.LastName = reader.GetString(4);
                            UserLoginCache.Position = reader.GetString(5);
                            UserLoginCache.Email = reader.GetString(6);
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
        public string recoverPassword(string userRequesting)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Users WHERE UserName = @UserName OR Email = @Email";
                    command.Parameters.AddWithValue("@UserName", userRequesting);
                    command.Parameters.AddWithValue("@Email", userRequesting);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read() == true)
                    {
                        string userName = reader.GetString(3) + ", " + reader.GetString(4);
                        string userMail = reader.GetString(6);
                        string accountPassword = reader.GetString(2);

                        var mailService = new MailServices.SystemSupportMail();
                        mailService.sendMail(
                            subject: "SISTEMA: solicitud de recuperación de contraseña",
                            body: "Hola, " + userName + "\n Recientemente solicitaste recuperar tu contraseña.\n" +
                            "Tu contraseña actual es: " + accountPassword +
                            "Sin embargo, le pedimos que cambie su contraseña inmediatamente una vez que ingrese al sistema.",
                            recipientMail: new List<string> { userMail }
                            );
                        return "Hola, " + userName + "\n Recientemente solicitaste recuperar tu contraseña.\n" +
                               "Por favor revisa tu correo: " + userMail + "\n" +
                               "Sin embargo, le pedimos que cambie su contraseña inmediatamente una vez que ingrese al sistema.";
                    }
                    else
                        return "Lo sentimos, no hay ninguna cuenta registrada con este nombre de usuario o correo electronico";
                }
            }

        }


        public void AnyMethod()
        {
            if (UserLoginCache.Position == Positions.Administrador)
            {

            }
            if (UserLoginCache.Position == Positions.Usuario)
            {

            }
        }
    }
}
