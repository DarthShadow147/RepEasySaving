using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace Presentation
{
    public partial class UserRecoveryPassword : Form
    {
        public UserRecoveryPassword()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {

        }

        private void btnSendMail_Click_1(object sender, EventArgs e)
        {
            var user = new UserModel();
            var result = user.recoverPassword(txtUserNameEmail.Text);
            lblInfoMessage.Text = result;
            lblInfoMessage.Visible = true;
        }
    }
}
