namespace Presentation
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.PanelFormularios = new System.Windows.Forms.Panel();
            this.Day = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.Clock = new System.Windows.Forms.Label();
            this.ProductName = new System.Windows.Forms.Label();
            this.PanelButtons = new System.Windows.Forms.Panel();
            this.LogOut = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.PanelSubReportes = new System.Windows.Forms.Panel();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.btnSubReportes = new System.Windows.Forms.Button();
            this.PanelSubConsultas = new System.Windows.Forms.Panel();
            this.btnConsAhorro = new System.Windows.Forms.Button();
            this.btnConsularPrestamos = new System.Windows.Forms.Button();
            this.btnSubConsultas = new System.Windows.Forms.Button();
            this.PanelSubOtrasTrans = new System.Windows.Forms.Panel();
            this.btnCompraPapeleria = new System.Windows.Forms.Button();
            this.btnPapeleria = new System.Windows.Forms.Button();
            this.btnEvents = new System.Windows.Forms.Button();
            this.btnSubOtrasTrans = new System.Windows.Forms.Button();
            this.PanelSubTransacciones = new System.Windows.Forms.Panel();
            this.btnVault = new System.Windows.Forms.Button();
            this.btnTransactions = new System.Windows.Forms.Button();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.btnSubTransacciones = new System.Windows.Forms.Button();
            this.PanelSubPrestamos = new System.Windows.Forms.Panel();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnDues = new System.Windows.Forms.Button();
            this.btnDesembolso = new System.Windows.Forms.Button();
            this.btnLoanRequest = new System.Windows.Forms.Button();
            this.btnSubPrestamos = new System.Windows.Forms.Button();
            this.PanelSubRegistro = new System.Windows.Forms.Panel();
            this.btnMembers = new System.Windows.Forms.Button();
            this.BtnSubRegistro = new System.Windows.Forms.Button();
            this.PanelPerfil = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lkMyProfile = new System.Windows.Forms.LinkLabel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTab = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnRestart = new System.Windows.Forms.PictureBox();
            this.btnMaximize = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PanelContenedor.SuspendLayout();
            this.PanelFormularios.SuspendLayout();
            this.PanelButtons.SuspendLayout();
            this.PanelSubReportes.SuspendLayout();
            this.PanelSubConsultas.SuspendLayout();
            this.PanelSubOtrasTrans.SuspendLayout();
            this.PanelSubTransacciones.SuspendLayout();
            this.PanelSubPrestamos.SuspendLayout();
            this.PanelSubRegistro.SuspendLayout();
            this.PanelPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PanelContenedor.Controls.Add(this.PanelFormularios);
            this.PanelContenedor.Controls.Add(this.PanelButtons);
            this.PanelContenedor.Controls.Add(this.panel1);
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(0, 0);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(1498, 1080);
            this.PanelContenedor.TabIndex = 0;
            // 
            // PanelFormularios
            // 
            this.PanelFormularios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.PanelFormularios.Controls.Add(this.Day);
            this.PanelFormularios.Controls.Add(this.Date);
            this.PanelFormularios.Controls.Add(this.Clock);
            this.PanelFormularios.Controls.Add(this.ProductName);
            this.PanelFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFormularios.Location = new System.Drawing.Point(250, 40);
            this.PanelFormularios.Name = "PanelFormularios";
            this.PanelFormularios.Size = new System.Drawing.Size(1248, 1040);
            this.PanelFormularios.TabIndex = 2;
            // 
            // Day
            // 
            this.Day.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Day.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(39)))), ((int)(((byte)(84)))));
            this.Day.Location = new System.Drawing.Point(1009, 941);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(183, 54);
            this.Day.TabIndex = 4;
            this.Day.Text = "Day";
            this.Day.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Date
            // 
            this.Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Date.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(39)))), ((int)(((byte)(84)))));
            this.Date.Location = new System.Drawing.Point(770, 941);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(184, 54);
            this.Date.TabIndex = 3;
            this.Date.Text = "Date";
            this.Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Clock
            // 
            this.Clock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Clock.Font = new System.Drawing.Font("Century Gothic", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(39)))), ((int)(((byte)(84)))));
            this.Clock.Location = new System.Drawing.Point(759, 787);
            this.Clock.Name = "Clock";
            this.Clock.Size = new System.Drawing.Size(410, 154);
            this.Clock.TabIndex = 2;
            this.Clock.Text = "00:00:00";
            this.Clock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProductName
            // 
            this.ProductName.Font = new System.Drawing.Font("Century Gothic", 57.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(39)))), ((int)(((byte)(84)))));
            this.ProductName.Location = new System.Drawing.Point(0, 0);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(1237, 148);
            this.ProductName.TabIndex = 1;
            this.ProductName.Text = "EASY SAVING";
            this.ProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelButtons
            // 
            this.PanelButtons.AutoScroll = true;
            this.PanelButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.PanelButtons.Controls.Add(this.LogOut);
            this.PanelButtons.Controls.Add(this.btnAbout);
            this.PanelButtons.Controls.Add(this.PanelSubReportes);
            this.PanelButtons.Controls.Add(this.btnSubReportes);
            this.PanelButtons.Controls.Add(this.PanelSubConsultas);
            this.PanelButtons.Controls.Add(this.btnSubConsultas);
            this.PanelButtons.Controls.Add(this.PanelSubOtrasTrans);
            this.PanelButtons.Controls.Add(this.btnSubOtrasTrans);
            this.PanelButtons.Controls.Add(this.PanelSubTransacciones);
            this.PanelButtons.Controls.Add(this.btnSubTransacciones);
            this.PanelButtons.Controls.Add(this.PanelSubPrestamos);
            this.PanelButtons.Controls.Add(this.btnSubPrestamos);
            this.PanelButtons.Controls.Add(this.PanelSubRegistro);
            this.PanelButtons.Controls.Add(this.BtnSubRegistro);
            this.PanelButtons.Controls.Add(this.PanelPerfil);
            this.PanelButtons.Controls.Add(this.btnLogOut);
            this.PanelButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelButtons.Location = new System.Drawing.Point(0, 40);
            this.PanelButtons.Name = "PanelButtons";
            this.PanelButtons.Size = new System.Drawing.Size(250, 1040);
            this.PanelButtons.TabIndex = 1;
            // 
            // LogOut
            // 
            this.LogOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogOut.FlatAppearance.BorderSize = 0;
            this.LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOut.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut.ForeColor = System.Drawing.Color.Gainsboro;
            this.LogOut.Image = ((System.Drawing.Image)(resources.GetObject("LogOut.Image")));
            this.LogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LogOut.Location = new System.Drawing.Point(0, 985);
            this.LogOut.Name = "LogOut";
            this.LogOut.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.LogOut.Size = new System.Drawing.Size(250, 45);
            this.LogOut.TabIndex = 19;
            this.LogOut.Text = "Cerrar Sesion";
            this.LogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbout.Location = new System.Drawing.Point(0, 940);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAbout.Size = new System.Drawing.Size(250, 45);
            this.btnAbout.TabIndex = 18;
            this.btnAbout.Text = "Acerca de";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click_1);
            // 
            // PanelSubReportes
            // 
            this.PanelSubReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.PanelSubReportes.Controls.Add(this.btnEstadisticas);
            this.PanelSubReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSubReportes.Location = new System.Drawing.Point(0, 900);
            this.PanelSubReportes.Name = "PanelSubReportes";
            this.PanelSubReportes.Size = new System.Drawing.Size(250, 40);
            this.PanelSubReportes.TabIndex = 22;
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEstadisticas.FlatAppearance.BorderSize = 0;
            this.btnEstadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadisticas.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstadisticas.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEstadisticas.Image = ((System.Drawing.Image)(resources.GetObject("btnEstadisticas.Image")));
            this.btnEstadisticas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEstadisticas.Location = new System.Drawing.Point(0, 0);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnEstadisticas.Size = new System.Drawing.Size(250, 40);
            this.btnEstadisticas.TabIndex = 17;
            this.btnEstadisticas.Text = "Estadisticas";
            this.btnEstadisticas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstadisticas.UseVisualStyleBackColor = true;
            this.btnEstadisticas.Click += new System.EventHandler(this.btnEstadisticas_Click);
            // 
            // btnSubReportes
            // 
            this.btnSubReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubReportes.FlatAppearance.BorderSize = 0;
            this.btnSubReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubReportes.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubReportes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSubReportes.Location = new System.Drawing.Point(0, 855);
            this.btnSubReportes.Name = "btnSubReportes";
            this.btnSubReportes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSubReportes.Size = new System.Drawing.Size(250, 45);
            this.btnSubReportes.TabIndex = 16;
            this.btnSubReportes.Text = "Reportes";
            this.btnSubReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubReportes.UseVisualStyleBackColor = true;
            this.btnSubReportes.Click += new System.EventHandler(this.btnSubReportes_Click);
            // 
            // PanelSubConsultas
            // 
            this.PanelSubConsultas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.PanelSubConsultas.Controls.Add(this.btnConsAhorro);
            this.PanelSubConsultas.Controls.Add(this.btnConsularPrestamos);
            this.PanelSubConsultas.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSubConsultas.Location = new System.Drawing.Point(0, 775);
            this.PanelSubConsultas.Name = "PanelSubConsultas";
            this.PanelSubConsultas.Size = new System.Drawing.Size(250, 80);
            this.PanelSubConsultas.TabIndex = 20;
            // 
            // btnConsAhorro
            // 
            this.btnConsAhorro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsAhorro.FlatAppearance.BorderSize = 0;
            this.btnConsAhorro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsAhorro.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsAhorro.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnConsAhorro.Image = ((System.Drawing.Image)(resources.GetObject("btnConsAhorro.Image")));
            this.btnConsAhorro.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsAhorro.Location = new System.Drawing.Point(0, 40);
            this.btnConsAhorro.Name = "btnConsAhorro";
            this.btnConsAhorro.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnConsAhorro.Size = new System.Drawing.Size(250, 40);
            this.btnConsAhorro.TabIndex = 15;
            this.btnConsAhorro.Text = "Ahorros";
            this.btnConsAhorro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsAhorro.UseVisualStyleBackColor = true;
            this.btnConsAhorro.Click += new System.EventHandler(this.btnConsAhorro_Click);
            // 
            // btnConsularPrestamos
            // 
            this.btnConsularPrestamos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsularPrestamos.FlatAppearance.BorderSize = 0;
            this.btnConsularPrestamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsularPrestamos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsularPrestamos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnConsularPrestamos.Image = ((System.Drawing.Image)(resources.GetObject("btnConsularPrestamos.Image")));
            this.btnConsularPrestamos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsularPrestamos.Location = new System.Drawing.Point(0, 0);
            this.btnConsularPrestamos.Name = "btnConsularPrestamos";
            this.btnConsularPrestamos.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnConsularPrestamos.Size = new System.Drawing.Size(250, 40);
            this.btnConsularPrestamos.TabIndex = 14;
            this.btnConsularPrestamos.Text = "Prestamos";
            this.btnConsularPrestamos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsularPrestamos.UseVisualStyleBackColor = true;
            this.btnConsularPrestamos.Click += new System.EventHandler(this.btnConsularPrestamos_Click);
            // 
            // btnSubConsultas
            // 
            this.btnSubConsultas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubConsultas.FlatAppearance.BorderSize = 0;
            this.btnSubConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubConsultas.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubConsultas.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSubConsultas.Location = new System.Drawing.Point(0, 730);
            this.btnSubConsultas.Name = "btnSubConsultas";
            this.btnSubConsultas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSubConsultas.Size = new System.Drawing.Size(250, 45);
            this.btnSubConsultas.TabIndex = 13;
            this.btnSubConsultas.Text = "Consultas";
            this.btnSubConsultas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubConsultas.UseVisualStyleBackColor = true;
            this.btnSubConsultas.Click += new System.EventHandler(this.btnSubConsultas_Click);
            // 
            // PanelSubOtrasTrans
            // 
            this.PanelSubOtrasTrans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.PanelSubOtrasTrans.Controls.Add(this.btnCompraPapeleria);
            this.PanelSubOtrasTrans.Controls.Add(this.btnPapeleria);
            this.PanelSubOtrasTrans.Controls.Add(this.btnEvents);
            this.PanelSubOtrasTrans.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSubOtrasTrans.Location = new System.Drawing.Point(0, 610);
            this.PanelSubOtrasTrans.Name = "PanelSubOtrasTrans";
            this.PanelSubOtrasTrans.Size = new System.Drawing.Size(250, 120);
            this.PanelSubOtrasTrans.TabIndex = 24;
            // 
            // btnCompraPapeleria
            // 
            this.btnCompraPapeleria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCompraPapeleria.FlatAppearance.BorderSize = 0;
            this.btnCompraPapeleria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompraPapeleria.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompraPapeleria.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCompraPapeleria.Image = ((System.Drawing.Image)(resources.GetObject("btnCompraPapeleria.Image")));
            this.btnCompraPapeleria.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCompraPapeleria.Location = new System.Drawing.Point(0, 80);
            this.btnCompraPapeleria.Name = "btnCompraPapeleria";
            this.btnCompraPapeleria.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCompraPapeleria.Size = new System.Drawing.Size(250, 40);
            this.btnCompraPapeleria.TabIndex = 25;
            this.btnCompraPapeleria.Text = "Compra de Papeleria";
            this.btnCompraPapeleria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompraPapeleria.UseVisualStyleBackColor = true;
            this.btnCompraPapeleria.Click += new System.EventHandler(this.btnCompraPapeleria_Click);
            // 
            // btnPapeleria
            // 
            this.btnPapeleria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPapeleria.FlatAppearance.BorderSize = 0;
            this.btnPapeleria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPapeleria.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPapeleria.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPapeleria.Image = ((System.Drawing.Image)(resources.GetObject("btnPapeleria.Image")));
            this.btnPapeleria.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPapeleria.Location = new System.Drawing.Point(0, 40);
            this.btnPapeleria.Name = "btnPapeleria";
            this.btnPapeleria.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnPapeleria.Size = new System.Drawing.Size(250, 40);
            this.btnPapeleria.TabIndex = 1;
            this.btnPapeleria.Text = "Papeleria";
            this.btnPapeleria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPapeleria.UseVisualStyleBackColor = true;
            this.btnPapeleria.Click += new System.EventHandler(this.btnPapeleria_Click);
            // 
            // btnEvents
            // 
            this.btnEvents.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEvents.FlatAppearance.BorderSize = 0;
            this.btnEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvents.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvents.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEvents.Image = ((System.Drawing.Image)(resources.GetObject("btnEvents.Image")));
            this.btnEvents.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEvents.Location = new System.Drawing.Point(0, 0);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnEvents.Size = new System.Drawing.Size(250, 40);
            this.btnEvents.TabIndex = 0;
            this.btnEvents.Text = "Eventos";
            this.btnEvents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEvents.UseVisualStyleBackColor = true;
            this.btnEvents.Click += new System.EventHandler(this.btnEvents_Click);
            // 
            // btnSubOtrasTrans
            // 
            this.btnSubOtrasTrans.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubOtrasTrans.FlatAppearance.BorderSize = 0;
            this.btnSubOtrasTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubOtrasTrans.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubOtrasTrans.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSubOtrasTrans.Location = new System.Drawing.Point(0, 565);
            this.btnSubOtrasTrans.Name = "btnSubOtrasTrans";
            this.btnSubOtrasTrans.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSubOtrasTrans.Size = new System.Drawing.Size(250, 45);
            this.btnSubOtrasTrans.TabIndex = 23;
            this.btnSubOtrasTrans.Text = "Otras Transacciones";
            this.btnSubOtrasTrans.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubOtrasTrans.UseVisualStyleBackColor = true;
            this.btnSubOtrasTrans.Click += new System.EventHandler(this.btnSubOtrasTrans_Click);
            // 
            // PanelSubTransacciones
            // 
            this.PanelSubTransacciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.PanelSubTransacciones.Controls.Add(this.btnVault);
            this.PanelSubTransacciones.Controls.Add(this.btnTransactions);
            this.PanelSubTransacciones.Controls.Add(this.btnCreateAccount);
            this.PanelSubTransacciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSubTransacciones.Location = new System.Drawing.Point(0, 445);
            this.PanelSubTransacciones.Name = "PanelSubTransacciones";
            this.PanelSubTransacciones.Size = new System.Drawing.Size(250, 120);
            this.PanelSubTransacciones.TabIndex = 18;
            // 
            // btnVault
            // 
            this.btnVault.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVault.FlatAppearance.BorderSize = 0;
            this.btnVault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVault.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVault.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnVault.Image = ((System.Drawing.Image)(resources.GetObject("btnVault.Image")));
            this.btnVault.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVault.Location = new System.Drawing.Point(0, 80);
            this.btnVault.Name = "btnVault";
            this.btnVault.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnVault.Size = new System.Drawing.Size(250, 40);
            this.btnVault.TabIndex = 12;
            this.btnVault.Text = "Liquidacion";
            this.btnVault.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVault.UseVisualStyleBackColor = true;
            this.btnVault.Click += new System.EventHandler(this.btnVault_Click);
            // 
            // btnTransactions
            // 
            this.btnTransactions.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransactions.FlatAppearance.BorderSize = 0;
            this.btnTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactions.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransactions.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTransactions.Image = ((System.Drawing.Image)(resources.GetObject("btnTransactions.Image")));
            this.btnTransactions.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTransactions.Location = new System.Drawing.Point(0, 40);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnTransactions.Size = new System.Drawing.Size(250, 40);
            this.btnTransactions.TabIndex = 11;
            this.btnTransactions.Text = "Abonos";
            this.btnTransactions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransactions.UseVisualStyleBackColor = true;
            this.btnTransactions.Click += new System.EventHandler(this.btnTransactions_Click);
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreateAccount.FlatAppearance.BorderSize = 0;
            this.btnCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAccount.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAccount.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCreateAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateAccount.Image")));
            this.btnCreateAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreateAccount.Location = new System.Drawing.Point(0, 0);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCreateAccount.Size = new System.Drawing.Size(250, 40);
            this.btnCreateAccount.TabIndex = 10;
            this.btnCreateAccount.Text = "Crear Cuenta";
            this.btnCreateAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // btnSubTransacciones
            // 
            this.btnSubTransacciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubTransacciones.FlatAppearance.BorderSize = 0;
            this.btnSubTransacciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubTransacciones.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubTransacciones.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSubTransacciones.Location = new System.Drawing.Point(0, 400);
            this.btnSubTransacciones.Name = "btnSubTransacciones";
            this.btnSubTransacciones.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSubTransacciones.Size = new System.Drawing.Size(250, 45);
            this.btnSubTransacciones.TabIndex = 9;
            this.btnSubTransacciones.Text = "Transacciones";
            this.btnSubTransacciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubTransacciones.UseVisualStyleBackColor = true;
            this.btnSubTransacciones.Click += new System.EventHandler(this.btnSubTransacciones_Click);
            // 
            // PanelSubPrestamos
            // 
            this.PanelSubPrestamos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.PanelSubPrestamos.Controls.Add(this.btnPayment);
            this.PanelSubPrestamos.Controls.Add(this.btnDues);
            this.PanelSubPrestamos.Controls.Add(this.btnDesembolso);
            this.PanelSubPrestamos.Controls.Add(this.btnLoanRequest);
            this.PanelSubPrestamos.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSubPrestamos.Location = new System.Drawing.Point(0, 240);
            this.PanelSubPrestamos.Name = "PanelSubPrestamos";
            this.PanelSubPrestamos.Size = new System.Drawing.Size(250, 160);
            this.PanelSubPrestamos.TabIndex = 16;
            // 
            // btnPayment
            // 
            this.btnPayment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPayment.FlatAppearance.BorderSize = 0;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPayment.Image = ((System.Drawing.Image)(resources.GetObject("btnPayment.Image")));
            this.btnPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPayment.Location = new System.Drawing.Point(0, 120);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnPayment.Size = new System.Drawing.Size(250, 40);
            this.btnPayment.TabIndex = 8;
            this.btnPayment.Text = "Pago Prestamos";
            this.btnPayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnDues
            // 
            this.btnDues.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDues.FlatAppearance.BorderSize = 0;
            this.btnDues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDues.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDues.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDues.Image = ((System.Drawing.Image)(resources.GetObject("btnDues.Image")));
            this.btnDues.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDues.Location = new System.Drawing.Point(0, 80);
            this.btnDues.Name = "btnDues";
            this.btnDues.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnDues.Size = new System.Drawing.Size(250, 40);
            this.btnDues.TabIndex = 7;
            this.btnDues.Text = "Consulta Coutas";
            this.btnDues.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDues.UseVisualStyleBackColor = true;
            this.btnDues.Click += new System.EventHandler(this.btnDues_Click);
            // 
            // btnDesembolso
            // 
            this.btnDesembolso.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDesembolso.FlatAppearance.BorderSize = 0;
            this.btnDesembolso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesembolso.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesembolso.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDesembolso.Image = ((System.Drawing.Image)(resources.GetObject("btnDesembolso.Image")));
            this.btnDesembolso.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDesembolso.Location = new System.Drawing.Point(0, 40);
            this.btnDesembolso.Name = "btnDesembolso";
            this.btnDesembolso.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnDesembolso.Size = new System.Drawing.Size(250, 40);
            this.btnDesembolso.TabIndex = 6;
            this.btnDesembolso.Text = "Desembolso";
            this.btnDesembolso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDesembolso.UseVisualStyleBackColor = true;
            this.btnDesembolso.Click += new System.EventHandler(this.btnDesembolso_Click_1);
            // 
            // btnLoanRequest
            // 
            this.btnLoanRequest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLoanRequest.FlatAppearance.BorderSize = 0;
            this.btnLoanRequest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnLoanRequest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnLoanRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoanRequest.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoanRequest.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLoanRequest.Image = ((System.Drawing.Image)(resources.GetObject("btnLoanRequest.Image")));
            this.btnLoanRequest.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoanRequest.Location = new System.Drawing.Point(0, 0);
            this.btnLoanRequest.Name = "btnLoanRequest";
            this.btnLoanRequest.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnLoanRequest.Size = new System.Drawing.Size(250, 40);
            this.btnLoanRequest.TabIndex = 5;
            this.btnLoanRequest.Text = "Solicitud prestamos";
            this.btnLoanRequest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoanRequest.UseVisualStyleBackColor = true;
            this.btnLoanRequest.Click += new System.EventHandler(this.btnLoanRequest_Click);
            // 
            // btnSubPrestamos
            // 
            this.btnSubPrestamos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubPrestamos.FlatAppearance.BorderSize = 0;
            this.btnSubPrestamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubPrestamos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubPrestamos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSubPrestamos.Location = new System.Drawing.Point(0, 195);
            this.btnSubPrestamos.Name = "btnSubPrestamos";
            this.btnSubPrestamos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSubPrestamos.Size = new System.Drawing.Size(250, 45);
            this.btnSubPrestamos.TabIndex = 4;
            this.btnSubPrestamos.Text = "Prestamos";
            this.btnSubPrestamos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubPrestamos.UseVisualStyleBackColor = true;
            this.btnSubPrestamos.Click += new System.EventHandler(this.btnSubPrestamos_Click);
            // 
            // PanelSubRegistro
            // 
            this.PanelSubRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.PanelSubRegistro.Controls.Add(this.btnMembers);
            this.PanelSubRegistro.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSubRegistro.Location = new System.Drawing.Point(0, 155);
            this.PanelSubRegistro.Name = "PanelSubRegistro";
            this.PanelSubRegistro.Size = new System.Drawing.Size(250, 40);
            this.PanelSubRegistro.TabIndex = 14;
            // 
            // btnMembers
            // 
            this.btnMembers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMembers.FlatAppearance.BorderSize = 0;
            this.btnMembers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnMembers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMembers.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMembers.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMembers.Image = ((System.Drawing.Image)(resources.GetObject("btnMembers.Image")));
            this.btnMembers.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMembers.Location = new System.Drawing.Point(0, 0);
            this.btnMembers.Name = "btnMembers";
            this.btnMembers.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnMembers.Size = new System.Drawing.Size(250, 40);
            this.btnMembers.TabIndex = 3;
            this.btnMembers.Text = "Miembros";
            this.btnMembers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMembers.UseVisualStyleBackColor = true;
            this.btnMembers.Click += new System.EventHandler(this.btnMembers_Click);
            // 
            // BtnSubRegistro
            // 
            this.BtnSubRegistro.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSubRegistro.FlatAppearance.BorderSize = 0;
            this.BtnSubRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSubRegistro.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubRegistro.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnSubRegistro.Location = new System.Drawing.Point(0, 110);
            this.BtnSubRegistro.Name = "BtnSubRegistro";
            this.BtnSubRegistro.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnSubRegistro.Size = new System.Drawing.Size(250, 45);
            this.BtnSubRegistro.TabIndex = 2;
            this.BtnSubRegistro.Text = "Registro";
            this.BtnSubRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSubRegistro.UseVisualStyleBackColor = true;
            this.BtnSubRegistro.Click += new System.EventHandler(this.BtnSubRegistro_Click);
            // 
            // PanelPerfil
            // 
            this.PanelPerfil.Controls.Add(this.pictureBox2);
            this.PanelPerfil.Controls.Add(this.lblName);
            this.PanelPerfil.Controls.Add(this.lblPosition);
            this.PanelPerfil.Controls.Add(this.lkMyProfile);
            this.PanelPerfil.Controls.Add(this.lblEmail);
            this.PanelPerfil.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelPerfil.Location = new System.Drawing.Point(0, 0);
            this.PanelPerfil.Name = "PanelPerfil";
            this.PanelPerfil.Size = new System.Drawing.Size(250, 110);
            this.PanelPerfil.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblName.Location = new System.Drawing.Point(87, 31);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(119, 23);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Name";
            // 
            // lblPosition
            // 
            this.lblPosition.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblPosition.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPosition.Location = new System.Drawing.Point(88, 6);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(118, 23);
            this.lblPosition.TabIndex = 8;
            this.lblPosition.Text = "Position";
            // 
            // lkMyProfile
            // 
            this.lkMyProfile.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(53)))), ((int)(((byte)(79)))));
            this.lkMyProfile.AutoSize = true;
            this.lkMyProfile.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkMyProfile.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lkMyProfile.Location = new System.Drawing.Point(12, 81);
            this.lkMyProfile.Name = "lkMyProfile";
            this.lkMyProfile.Size = new System.Drawing.Size(56, 17);
            this.lkMyProfile.TabIndex = 1;
            this.lkMyProfile.TabStop = true;
            this.lkMyProfile.Text = "Mi Perfil";
            this.lkMyProfile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkMyProfile_LinkClicked);
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEmail.Location = new System.Drawing.Point(88, 56);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(156, 23);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogOut.Location = new System.Drawing.Point(0, 1076);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnLogOut.Size = new System.Drawing.Size(250, 40);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "Cerrar Sesión";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(39)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.lblTab);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnRestart);
            this.panel1.Controls.Add(this.btnMaximize);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1498, 40);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // lblTab
            // 
            this.lblTab.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTab.ForeColor = System.Drawing.Color.White;
            this.lblTab.Location = new System.Drawing.Point(9, 9);
            this.lblTab.Name = "lblTab";
            this.lblTab.Size = new System.Drawing.Size(140, 23);
            this.lblTab.TabIndex = 4;
            this.lblTab.Text = "Menú Principal";
            this.lblTab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(1426, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(16, 16);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestart.Image = ((System.Drawing.Image)(resources.GetObject("btnRestart.Image")));
            this.btnRestart.Location = new System.Drawing.Point(1448, 12);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(16, 16);
            this.btnRestart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestart.TabIndex = 2;
            this.btnRestart.TabStop = false;
            this.btnRestart.Visible = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximize.Image")));
            this.btnMaximize.Location = new System.Drawing.Point(1448, 12);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(16, 16);
            this.btnMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximize.TabIndex = 1;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1470, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(16, 16);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1498, 1080);
            this.Controls.Add(this.PanelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(650, 400);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrincipal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.PanelContenedor.ResumeLayout(false);
            this.PanelFormularios.ResumeLayout(false);
            this.PanelButtons.ResumeLayout(false);
            this.PanelSubReportes.ResumeLayout(false);
            this.PanelSubConsultas.ResumeLayout(false);
            this.PanelSubOtrasTrans.ResumeLayout(false);
            this.PanelSubTransacciones.ResumeLayout(false);
            this.PanelSubPrestamos.ResumeLayout(false);
            this.PanelSubRegistro.ResumeLayout(false);
            this.PanelPerfil.ResumeLayout(false);
            this.PanelPerfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelButtons;
        private System.Windows.Forms.Panel PanelFormularios;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.PictureBox btnRestart;
        private System.Windows.Forms.PictureBox btnMaximize;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label ProductName;
        private System.Windows.Forms.Label Clock;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Day;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnLoanRequest;
        private System.Windows.Forms.Button btnMembers;
        private System.Windows.Forms.Label lblTab;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.LinkLabel lkMyProfile;
        private System.Windows.Forms.Panel PanelPerfil;
        private System.Windows.Forms.Button BtnSubRegistro;
        private System.Windows.Forms.Panel PanelSubRegistro;
        private System.Windows.Forms.Button btnSubPrestamos;
        private System.Windows.Forms.Panel PanelSubPrestamos;
        private System.Windows.Forms.Button btnDesembolso;
        private System.Windows.Forms.Button btnDues;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnSubTransacciones;
        private System.Windows.Forms.Panel PanelSubTransacciones;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Button btnTransactions;
        private System.Windows.Forms.Button btnVault;
        private System.Windows.Forms.Button btnSubConsultas;
        private System.Windows.Forms.Panel PanelSubConsultas;
        private System.Windows.Forms.Button btnConsAhorro;
        private System.Windows.Forms.Button btnConsularPrestamos;
        private System.Windows.Forms.Button btnSubReportes;
        private System.Windows.Forms.Panel PanelSubReportes;
        private System.Windows.Forms.Button btnEstadisticas;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.Panel PanelSubOtrasTrans;
        private System.Windows.Forms.Button btnPapeleria;
        private System.Windows.Forms.Button btnEvents;
        private System.Windows.Forms.Button btnSubOtrasTrans;
        private System.Windows.Forms.Button btnCompraPapeleria;
    }
}