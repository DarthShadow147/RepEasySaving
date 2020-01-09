using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Cache;
using Domain;

namespace Presentation
{
    public partial class Profilefrm : Form
    {
        public Profilefrm()
        {
            InitializeComponent();
        }
        private void btnClose_Load(object sender, EventArgs e)
        {
            LoaduserDate();
            initializePassEditControls();
        }

        private void LoaduserDate()
        {
            //View
            lblInfoUser.Text = UserLoginCache.LoginName;
            lblInfoName.Text = UserLoginCache.FirstName;
            lblInfoLastName.Text = UserLoginCache.LastName;
            lblEmail.Text = UserLoginCache.Email;

            //EditPanel
            txtUserName.Text = UserLoginCache.LoginName;
            txtNames.Text = UserLoginCache.FirstName;
            txtApellidos.Text = UserLoginCache.LastName;
            txtEmail.Text = UserLoginCache.Email;
            txtContraseña.Text = UserLoginCache.Password;
            txtConfirmPass.Text = UserLoginCache.Password;
            txtCurrentPass.Text = "";
            txtCurrentPass.UseSystemPasswordChar = true;
        }
        private void initializePassEditControls()
        {
            lkEditar.Text = "Editar";
            txtContraseña.Enabled = false;
            txtContraseña.UseSystemPasswordChar = true;
            txtConfirmPass.Enabled = false;
            txtConfirmPass.UseSystemPasswordChar = true;
        }
        private void reset()
        {
            LoaduserDate();
            initializePassEditControls();
        }

        private void lkEditar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lkEditar.Text == "Editar")
            {
                txtContraseña.Text = "Cancelar";
                txtContraseña.Enabled = true;
                txtContraseña.Text = "";
                txtConfirmPass.Enabled = true;
                txtConfirmPass.Text = "";
            }
            else if (lkEditar.Text == "Cancelar")
            {
                initializePassEditControls();
                txtContraseña.Text = UserLoginCache.Password;
                txtConfirmPass.Text = UserLoginCache.Password;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text.Length >= 5)
            {
                if (txtContraseña.Text == txtConfirmPass.Text)
                {
                    if (txtCurrentPass.Text == UserLoginCache.Password)
                    {
                        var userModel = new UserModel(idUser: UserLoginCache.IdUser,
                            loginName: txtUserName.Text,
                            password: txtContraseña.Text,
                            firstname: txtNames.Text,
                            lastname: txtApellidos.Text,
                            position: null,
                            email: txtEmail.Text);
                        var result = userModel.editUserProfile();
                        MessageBox.Show(result);
                        reset();
                        PanelEdit.Visible = false;
                    }
                    else
                        MessageBox.Show("Contraseña actual incorrecta, intente nuevamente.");
                }
                else
                    MessageBox.Show("Las contraseñas no coinciden.");
            }
            else
                MessageBox.Show("La contraseña debe tener minimo 5 caracteres.");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            PanelEdit.Visible = false;
            reset();
        }

        private void lkEditProfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PanelEdit.Visible = true;
            LoaduserDate();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
