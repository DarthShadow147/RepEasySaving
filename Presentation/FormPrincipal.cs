using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Common.Cache;

namespace Presentation
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            CustomizeDesing();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            LoadUserData();
        }
        private void LoadUserData()
        {
            lblName.Text = UserLoginCache.FirstName + ", " + UserLoginCache.LastName;
            lblPosition.Text = UserLoginCache.Position;
            lblEmail.Text = UserLoginCache.Email;
        }

        #region Funcionalidades del formulario
        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION 
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.PanelContenedor.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea cerrar la aplicacion?", "Advertencia",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
                //this.Close();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaximize.Visible = true;
            btnRestart.Visible = false;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximize.Visible = false;
            btnRestart.Visible = true;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void CustomizeDesing()
        {
            PanelSubRegistro.Visible = false;
            PanelSubPrestamos.Visible = false;
            PanelSubTransacciones.Visible = false;
            PanelSubConsultas.Visible = false;
            PanelSubReportes.Visible = false;
            PanelSubOtrasTrans.Visible = false;
        }

        private void hideSubMenu()
        {
            if (PanelSubRegistro.Visible == true)
                PanelSubRegistro.Visible = false;
            if (PanelSubPrestamos.Visible == true)
                PanelSubPrestamos.Visible = false;
            if (PanelSubTransacciones.Visible == true)
                PanelSubTransacciones.Visible = false;
            if (PanelSubConsultas.Visible == true)
                PanelSubConsultas.Visible = false;
            if (PanelSubReportes.Visible == true)
                PanelSubReportes.Visible = false;
            if (PanelSubOtrasTrans.Visible == true)
                PanelSubOtrasTrans.Visible = false;
        }

        private void ShowMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        #endregion

        //Metodo para abrir formularios dentro de un panel
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = PanelFormularios.Controls.OfType<MiForm>().FirstOrDefault();
            //Si el formulario no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                PanelFormularios.Controls.Add(formulario);
                PanelFormularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            //Si el formulario existe 
            else
            {
                formulario.BringToFront();
            }
        }
        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["Members"] == null)
                btnMembers.BackColor = Color.FromArgb(70, 67, 75);
            if (Application.OpenForms["LoanRequest"] == null)
                btnLoanRequest.BackColor = Color.FromArgb(70, 67, 75);
            if (Application.OpenForms["LoanEstimate"] == null)
                btnDesembolso.BackColor = Color.FromArgb(70, 67, 75);
            if (Application.OpenForms["ShowDues"] == null)
                btnDues.BackColor = Color.FromArgb(70, 67, 75);
            if (Application.OpenForms["Payments"] == null)
                btnPayment.BackColor = Color.FromArgb(70, 67, 75);
            if (Application.OpenForms["CreateAccount"] == null)
                btnCreateAccount.BackColor = Color.FromArgb(70, 67, 75);
            if (Application.OpenForms["Transactions"] == null)
                btnTransactions.BackColor = Color.FromArgb(70, 67, 75);
            if (Application.OpenForms["LoanQuery"] == null)
                btnConsularPrestamos.BackColor = Color.FromArgb(70, 67, 75);
            if (Application.OpenForms["Reports.LoanSaving"] == null)
                btnConsAhorro.BackColor = Color.FromArgb(70, 67, 75);
            if (Application.OpenForms["About"] == null)
                btnAbout.BackColor = Color.FromArgb(70, 67, 75);
            if (Application.OpenForms["Events"] == null)
                btnEvents.BackColor = Color.FromArgb(70, 67, 75);
            if (Application.OpenForms["Stationery"] == null)
                btnPapeleria.BackColor = Color.FromArgb(70, 67, 75);
            if (Application.OpenForms["Statistics"] == null)
                btnEstadisticas.BackColor = Color.FromArgb(70, 67, 75);
            if (Application.OpenForms["Settlement"] == null)
                btnVault.BackColor = Color.FromArgb(70, 67, 75);
            if (Application.OpenForms["BuyStationery"] == null)
                btnCompraPapeleria.BackColor = Color.FromArgb(70, 67, 75);
            //Esto para todos los botones
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Clock.Text = DateTime.Now.ToLongTimeString();
            Date.Text = DateTime.Now.ToShortDateString();
            Day.Text = DateTime.Now.ToString("dddd");
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Members>();
            btnMembers.BackColor = Color.FromArgb(86, 81, 81);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
        }

        private void lkMyProfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirFormulario<Profilefrm>();
        }

        private void btnLoanRequest_Click(object sender, EventArgs e)
        {
            AbrirFormulario<LoanRequest>();
            btnLoanRequest.BackColor = Color.FromArgb(86, 81, 81);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
        }

        private void BtnSubRegistro_Click(object sender, EventArgs e)
        {
            ShowMenu(PanelSubRegistro);
        }

        private void btnSubPrestamos_Click(object sender, EventArgs e)
        {
            ShowMenu(PanelSubPrestamos);
        }

        private void btnSubTransacciones_Click(object sender, EventArgs e)
        {
            ShowMenu(PanelSubTransacciones);
        }

        private void btnSubConsultas_Click(object sender, EventArgs e)
        {
            ShowMenu(PanelSubConsultas);
        }

        private void btnSubReportes_Click(object sender, EventArgs e)
        {
            ShowMenu(PanelSubReportes);
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea cerrar la sesión actual?", "Advertencia",MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
            btnLogOut.BackColor = Color.FromArgb(86, 81, 81);
        }

        private void btnDesembolso_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario<LoanEstimate>();
            btnDesembolso.BackColor = Color.FromArgb(86, 81, 81);
        }

        private void btnDues_Click(object sender, EventArgs e)
        {
            AbrirFormulario<ShowDues>();
            btnDues.BackColor = Color.FromArgb(86, 81, 81);
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Payments>();
            btnPayment.BackColor = Color.FromArgb(86, 81, 81);
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            AbrirFormulario<CreateAccount>();
            btnCreateAccount.BackColor = Color.FromArgb(86, 81, 81);
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Transactions>();
            btnTransactions.BackColor = Color.FromArgb(86, 81, 81);
        }

        private void btnConsularPrestamos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<LoanQuery>();
            btnConsularPrestamos.BackColor = Color.FromArgb(86, 81, 81);
        }

        private void btnConsAhorro_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Reports.LoanSaving>();
            btnConsAhorro.BackColor = Color.FromArgb(86, 81, 81);
        }

        private void btnAbout_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario<About>();
            btnAbout.BackColor = Color.FromArgb(86, 81, 81);
        }

        private void btnSubOtrasTrans_Click(object sender, EventArgs e)
        {
            ShowMenu(PanelSubOtrasTrans);
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Events>();
            btnEvents.BackColor = Color.FromArgb(86, 81, 81);
        }

        private void btnPapeleria_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Stationery>();
            btnPapeleria.BackColor = Color.FromArgb(86, 81, 81);
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Statistics>();
            btnEstadisticas.BackColor = Color.FromArgb(86, 81, 81);
        }

        private void btnVault_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Settlement>();
            btnVault.BackColor = Color.FromArgb(86, 81, 81);
        }

        private void btnCompraPapeleria_Click(object sender, EventArgs e)
        {
            AbrirFormulario<BuyStationery>();
            btnCompraPapeleria.BackColor = Color.FromArgb(86, 81, 81);
        }
    }
}
