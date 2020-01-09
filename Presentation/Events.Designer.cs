namespace Presentation
{
    partial class Events
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Events));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.settlementEventsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.settlementEvents = new Presentation.Reports.DataSet.SettlementEvents();
            this.summayBinnacleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.summayBinnacle = new Presentation.Reports.DataSet.SummayBinnacle();
            this.totalBinnacleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTab = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtParticipants = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInversion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblEvent = new System.Windows.Forms.Label();
            this.txtIdEvento = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.DataGridEvents = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.CheckSpending = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegBinnacle = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGanancias = new System.Windows.Forms.Button();
            this.TabEvent = new System.Windows.Forms.TabControl();
            this.TabBitacora = new System.Windows.Forms.TabPage();
            this.DataGridBinnacle = new System.Windows.Forms.DataGridView();
            this.TabReport = new System.Windows.Forms.TabPage();
            this.ReportSettlement = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnPruebasReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.settlementEventsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settlementEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.summayBinnacleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.summayBinnacle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalBinnacleBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.GroupBox.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEvents)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.TabEvent.SuspendLayout();
            this.TabBitacora.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridBinnacle)).BeginInit();
            this.TabReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // settlementEventsBindingSource
            // 
            this.settlementEventsBindingSource.DataSource = this.settlementEvents;
            this.settlementEventsBindingSource.Position = 0;
            // 
            // settlementEvents
            // 
            this.settlementEvents.DataSetName = "SettlementEvents";
            this.settlementEvents.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // summayBinnacleBindingSource
            // 
            this.summayBinnacleBindingSource.DataSource = this.summayBinnacle;
            this.summayBinnacleBindingSource.Position = 0;
            // 
            // summayBinnacle
            // 
            this.summayBinnacle.DataSetName = "SummayBinnacle";
            this.summayBinnacle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(39)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.lblTab);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1242, 28);
            this.panel1.TabIndex = 0;
            // 
            // lblTab
            // 
            this.lblTab.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTab.ForeColor = System.Drawing.Color.White;
            this.lblTab.Location = new System.Drawing.Point(25, 3);
            this.lblTab.Name = "lblTab";
            this.lblTab.Size = new System.Drawing.Size(164, 23);
            this.lblTab.TabIndex = 6;
            this.lblTab.Text = "Eventos";
            this.lblTab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(3, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(16, 16);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 1;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.txtName);
            this.GroupBox.Controls.Add(this.label7);
            this.GroupBox.Controls.Add(this.txtParticipants);
            this.GroupBox.Controls.Add(this.label3);
            this.GroupBox.Controls.Add(this.txtInversion);
            this.GroupBox.Controls.Add(this.label4);
            this.GroupBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.GroupBox.Location = new System.Drawing.Point(69, 6);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(1053, 77);
            this.GroupBox.TabIndex = 21;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "Información";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(95, 22);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(182, 27);
            this.txtName.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(9, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 29);
            this.label7.TabIndex = 32;
            this.label7.Text = "Nombre:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtParticipants
            // 
            this.txtParticipants.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParticipants.Location = new System.Drawing.Point(823, 18);
            this.txtParticipants.Name = "txtParticipants";
            this.txtParticipants.Size = new System.Drawing.Size(182, 27);
            this.txtParticipants.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(697, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 29);
            this.label3.TabIndex = 23;
            this.label3.Text = "Participantes:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtInversion
            // 
            this.txtInversion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInversion.Location = new System.Drawing.Point(463, 19);
            this.txtInversion.Name = "txtInversion";
            this.txtInversion.Size = new System.Drawing.Size(182, 27);
            this.txtInversion.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(312, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Inversion:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.panel2.Controls.Add(this.lblEvent);
            this.panel2.Controls.Add(this.txtIdEvento);
            this.panel2.Controls.Add(this.btnSelect);
            this.panel2.Controls.Add(this.DataGridEvents);
            this.panel2.Controls.Add(this.btnInsert);
            this.panel2.Controls.Add(this.GroupBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1242, 292);
            this.panel2.TabIndex = 22;
            // 
            // lblEvent
            // 
            this.lblEvent.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvent.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblEvent.Location = new System.Drawing.Point(971, 218);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(74, 29);
            this.lblEvent.TabIndex = 43;
            this.lblEvent.Text = "Id Evento:";
            this.lblEvent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtIdEvento
            // 
            this.txtIdEvento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdEvento.Location = new System.Drawing.Point(1051, 220);
            this.txtIdEvento.Name = "txtIdEvento";
            this.txtIdEvento.Size = new System.Drawing.Size(71, 27);
            this.txtIdEvento.TabIndex = 42;
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(39)))), ((int)(((byte)(84)))));
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSelect.Location = new System.Drawing.Point(892, 158);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(230, 39);
            this.btnSelect.TabIndex = 41;
            this.btnSelect.Text = "Seleccionar";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // DataGridEvents
            // 
            this.DataGridEvents.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.DataGridEvents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridEvents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridEvents.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridEvents.EnableHeadersVisualStyles = false;
            this.DataGridEvents.GridColor = System.Drawing.Color.WhiteSmoke;
            this.DataGridEvents.Location = new System.Drawing.Point(339, 158);
            this.DataGridEvents.Name = "DataGridEvents";
            this.DataGridEvents.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridEvents.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.DataGridEvents.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridEvents.Size = new System.Drawing.Size(530, 116);
            this.DataGridEvents.TabIndex = 38;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(39)))), ((int)(((byte)(84)))));
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnInsert.Location = new System.Drawing.Point(69, 100);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(1053, 39);
            this.btnInsert.TabIndex = 40;
            this.btnInsert.Text = "Registrar";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.CheckSpending);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(69, 329);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1053, 117);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bitacora";
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Location = new System.Drawing.Point(95, 28);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(362, 74);
            this.txtDescription.TabIndex = 36;
            this.txtDescription.Text = "";
            // 
            // CheckSpending
            // 
            this.CheckSpending.AutoSize = true;
            this.CheckSpending.Location = new System.Drawing.Point(517, 35);
            this.CheckSpending.Name = "CheckSpending";
            this.CheckSpending.Size = new System.Drawing.Size(66, 21);
            this.CheckSpending.TabIndex = 35;
            this.CheckSpending.Text = "Gasto";
            this.CheckSpending.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 29);
            this.label1.TabIndex = 32;
            this.label1.Text = "Descripcion:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(766, 30);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(260, 27);
            this.txtAmount.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(657, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 29);
            this.label2.TabIndex = 23;
            this.label2.Text = "Costo:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRegBinnacle
            // 
            this.btnRegBinnacle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(39)))), ((int)(((byte)(84)))));
            this.btnRegBinnacle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegBinnacle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegBinnacle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRegBinnacle.Location = new System.Drawing.Point(60, 452);
            this.btnRegBinnacle.Name = "btnRegBinnacle";
            this.btnRegBinnacle.Size = new System.Drawing.Size(1053, 39);
            this.btnRegBinnacle.TabIndex = 41;
            this.btnRegBinnacle.Text = "Registrar";
            this.btnRegBinnacle.UseVisualStyleBackColor = false;
            this.btnRegBinnacle.Click += new System.EventHandler(this.btnRegBinnacle_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(39)))), ((int)(((byte)(84)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLimpiar.Location = new System.Drawing.Point(974, 591);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(148, 39);
            this.btnLimpiar.TabIndex = 42;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGanancias
            // 
            this.btnGanancias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(39)))), ((int)(((byte)(84)))));
            this.btnGanancias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGanancias.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGanancias.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGanancias.Location = new System.Drawing.Point(974, 645);
            this.btnGanancias.Name = "btnGanancias";
            this.btnGanancias.Size = new System.Drawing.Size(148, 39);
            this.btnGanancias.TabIndex = 43;
            this.btnGanancias.Text = "Liquidar Ganancias";
            this.btnGanancias.UseVisualStyleBackColor = false;
            this.btnGanancias.Click += new System.EventHandler(this.btnGanancias_Click);
            // 
            // TabEvent
            // 
            this.TabEvent.Controls.Add(this.TabBitacora);
            this.TabEvent.Controls.Add(this.TabReport);
            this.TabEvent.Location = new System.Drawing.Point(69, 497);
            this.TabEvent.Name = "TabEvent";
            this.TabEvent.SelectedIndex = 0;
            this.TabEvent.Size = new System.Drawing.Size(877, 355);
            this.TabEvent.TabIndex = 44;
            // 
            // TabBitacora
            // 
            this.TabBitacora.Controls.Add(this.DataGridBinnacle);
            this.TabBitacora.Location = new System.Drawing.Point(4, 26);
            this.TabBitacora.Name = "TabBitacora";
            this.TabBitacora.Padding = new System.Windows.Forms.Padding(3);
            this.TabBitacora.Size = new System.Drawing.Size(869, 325);
            this.TabBitacora.TabIndex = 0;
            this.TabBitacora.Text = "Bitacora";
            this.TabBitacora.UseVisualStyleBackColor = true;
            // 
            // DataGridBinnacle
            // 
            this.DataGridBinnacle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.DataGridBinnacle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridBinnacle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridBinnacle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridBinnacle.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridBinnacle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridBinnacle.EnableHeadersVisualStyles = false;
            this.DataGridBinnacle.GridColor = System.Drawing.Color.WhiteSmoke;
            this.DataGridBinnacle.Location = new System.Drawing.Point(3, 3);
            this.DataGridBinnacle.Name = "DataGridBinnacle";
            this.DataGridBinnacle.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridBinnacle.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.DataGridBinnacle.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.DataGridBinnacle.Size = new System.Drawing.Size(863, 319);
            this.DataGridBinnacle.TabIndex = 40;
            // 
            // TabReport
            // 
            this.TabReport.Controls.Add(this.ReportSettlement);
            this.TabReport.Location = new System.Drawing.Point(4, 26);
            this.TabReport.Name = "TabReport";
            this.TabReport.Padding = new System.Windows.Forms.Padding(3);
            this.TabReport.Size = new System.Drawing.Size(869, 325);
            this.TabReport.TabIndex = 1;
            this.TabReport.Text = "Liquidación";
            this.TabReport.UseVisualStyleBackColor = true;
            // 
            // ReportSettlement
            // 
            this.ReportSettlement.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "SettlementEvents";
            reportDataSource1.Value = this.settlementEventsBindingSource;
            reportDataSource2.Name = "SummaryBinnacle";
            reportDataSource2.Value = this.summayBinnacleBindingSource;
            reportDataSource3.Name = "TotalBinnacle";
            reportDataSource3.Value = this.totalBinnacleBindingSource;
            this.ReportSettlement.LocalReport.DataSources.Add(reportDataSource1);
            this.ReportSettlement.LocalReport.DataSources.Add(reportDataSource2);
            this.ReportSettlement.LocalReport.DataSources.Add(reportDataSource3);
            this.ReportSettlement.LocalReport.ReportEmbeddedResource = "Presentation.Reports.ReportSettlementEvent.rdlc";
            this.ReportSettlement.Location = new System.Drawing.Point(3, 3);
            this.ReportSettlement.Name = "ReportSettlement";
            this.ReportSettlement.ServerReport.BearerToken = null;
            this.ReportSettlement.Size = new System.Drawing.Size(863, 319);
            this.ReportSettlement.TabIndex = 0;
            // 
            // btnPruebasReport
            // 
            this.btnPruebasReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(39)))), ((int)(((byte)(84)))));
            this.btnPruebasReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPruebasReport.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPruebasReport.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPruebasReport.Location = new System.Drawing.Point(974, 702);
            this.btnPruebasReport.Name = "btnPruebasReport";
            this.btnPruebasReport.Size = new System.Drawing.Size(148, 39);
            this.btnPruebasReport.TabIndex = 45;
            this.btnPruebasReport.Text = "Mostrar Reporte";
            this.btnPruebasReport.UseVisualStyleBackColor = false;
            this.btnPruebasReport.Click += new System.EventHandler(this.btnPruebasReport_Click);
            // 
            // Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1242, 875);
            this.Controls.Add(this.btnPruebasReport);
            this.Controls.Add(this.TabEvent);
            this.Controls.Add(this.btnGanancias);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnRegBinnacle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Events";
            this.Text = "Events";
            this.Load += new System.EventHandler(this.Events_Load);
            ((System.ComponentModel.ISupportInitialize)(this.settlementEventsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settlementEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.summayBinnacleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.summayBinnacle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalBinnacleBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEvents)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.TabEvent.ResumeLayout(false);
            this.TabBitacora.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridBinnacle)).EndInit();
            this.TabReport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label lblTab;
        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtParticipants;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInversion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridView DataGridEvents;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegBinnacle;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.CheckBox CheckSpending;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.TextBox txtIdEvento;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGanancias;
        private System.Windows.Forms.TabControl TabEvent;
        private System.Windows.Forms.TabPage TabBitacora;
        private System.Windows.Forms.DataGridView DataGridBinnacle;
        private System.Windows.Forms.TabPage TabReport;
        private Microsoft.Reporting.WinForms.ReportViewer ReportSettlement;
        private System.Windows.Forms.BindingSource settlementEventsBindingSource;
        private Reports.DataSet.SettlementEvents settlementEvents;
        private System.Windows.Forms.BindingSource summayBinnacleBindingSource;
        private Reports.DataSet.SummayBinnacle summayBinnacle;
        private System.Windows.Forms.Button btnPruebasReport;
        private System.Windows.Forms.BindingSource totalBinnacleBindingSource;
        private Reports.DataSet.TotalBinnacle totalBinnacle;
    }
}