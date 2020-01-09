using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using DataAccess.SQLServer;
using Common.Cache;

namespace Domain
{
    public class UserModel
    {
        UserDao userDao = new UserDao();

        //Atributes
        private int idUser;
        private string loginName;
        private string password;
        private string firstname;
        private string lastname;
        private string position;
        private string email;

        public UserModel(int idUser, string loginName, string password, string firstname, string lastname, string position, string email)
        {
            this.idUser = idUser;
            this.loginName = loginName;
            this.password = password;
            this.firstname = firstname;
            this.lastname = lastname;
            this.position = position;
            this.email = email;
        }

        public UserModel()
        {

        }

        public string editUserProfile()
        {
            userDao.editProfile(idUser, loginName, password, firstname, lastname, email);
            LoginUser(loginName, password);
            return "Tu perfil se ha actualizado correctamente";
        }

        public bool LoginUser(string user, string password)
        {
            return userDao.Login(user, password);
        }
        public string recoverPassword(string userRequesting)
        {
            return userDao.recoverPassword(userRequesting);
        }

        public void AnyMethod()
        {
            if (UserLoginCache.Position == Positions.Administrador)
            {
                //Codes
            }
            if (UserLoginCache.Position == Positions.Usuario)
            {
                //Codes
            }
        }
    }
}
