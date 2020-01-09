namespace Presentation
{
    partial class Transactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transactions));
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
            this.reportTransactionsHeaderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportTransactionsHeader = new Presentation.Reports.DataSet.ReportTransactionsHeader();
            this.reportTransactionsDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportTransactionsDetail = new Presentation.Reports.DataSet.ReportTransactionsDetail();
            this.PanelTab = new System.Windows.Forms.Panel();
            this.lblTab = new System.Windows.Forms.Label();
            this.PBExit = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DataGridPerson = new System.Windows.Forms.DataGridView();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.lblOperation = new System.Windows.Forms.Label();
            this.ComboBoxOperation = new System.Windows.Forms.ComboBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAhorro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.TabTransfer = new System.Windows.Forms.TabControl();
            this.TabSummary = new System.Windows.Forms.TabPage();
            this.DataGridTransaction = new System.Windows.Forms.DataGridView();
            this.TabReport = new System.Windows.Forms.TabPage();
            this.ReportViewerTransactions = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.reportTransactionsHeaderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportTransactionsHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportTransactionsDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportTransactionsDetail)).BeginInit();
            this.PanelTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBExit)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPerson)).BeginInit();
            this.GroupBox.SuspendLayout();
            this.TabTransfer.SuspendLayout();
            this.TabSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridTransaction)).BeginInit();
            this.TabReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportTransactionsHeaderBindingSource
            // 
            this.reportTransactionsHeaderBindingSource.DataSource = this.reportTransactionsHeader;
            this.reportTransactionsHeaderBindingSource.Position = 0;
            // 
            // reportTransactionsHeader
            // 
            this.reportTransactionsHeader.DataSetName = "ReportTransactionsHeader";
            this.reportTransactionsHeader.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportTransactionsDetailBindingSource
            // 
            this.reportTransactionsDetailBindingSource.DataSource = this.reportTransactionsDetail;
            this.reportTransactionsDetailBindingSource.Position = 0;
            // 
            // reportTransactionsDetail
            // 
            this.reportTransactionsDetail.DataSetName = "ReportTransactionsDetail";
            this.reportTransactionsDetail.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PanelTab
            // 
            this.PanelTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(39)))), ((int)(((byte)(84)))));
            this.PanelTab.Controls.Add(this.lblTab);
            this.PanelTab.Controls.Add(this.PBExit);
            this.PanelTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTab.Location = new System.Drawing.Point(0, 0);
            this.PanelTab.Name = "PanelTab";
            this.PanelTab.Size = new System.Drawing.Size(1242, 28);
            this.PanelTab.TabIndex = 0;
            // 
            // lblTab
            // 
            this.lblTab.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTab.ForeColor = System.Drawing.Color.White;
            this.lblTab.Location = new System.Drawing.Point(25, 3);
            this.lblTab.Name = "lblTab";
            this.lblTab.Size = new System.Drawing.Size(164, 23);
            this.lblTab.TabIndex = 9;
            this.lblTab.Text = "Transacciones";
            this.lblTab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PBExit
            // 
            this.PBExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(39)))), ((int)(((byte)(84)))));
            this.PBExit.Image = ((System.Drawing.Image)(resources.GetObject("PBExit.Image")));
            this.PBExit.Location = new System.Drawing.Point(3, 3);
            this.PBExit.Name = "PBExit";
            this.PBExit.Size = new System.Drawing.Size(16, 16);
            this.PBExit.TabIndex = 3;
            this.PBExit.TabStop = false;
            this.PBExit.Click += new System.EventHandler(this.PBExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.panel1.Controls.Add(this.DataGridPerson);
            this.panel1.Controls.Add(this.btnTransfer);
            this.panel1.Controls.Add(this.GroupBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1242, 313);
            this.panel1.TabIndex = 1;
            // 
            // DataGridPerson
            // 
            this.DataGridPerson.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.DataGridPerson.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridPerson.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridPerson.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridPerson.EnableHeadersVisualStyles = false;
            this.DataGridPerson.GridColor = System.Drawing.Color.WhiteSmoke;
            this.DataGridPerson.Location = new System.Drawing.Point(144, 105);
            this.DataGridPerson.Name = "DataGridPerson";
            this.DataGridPerson.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridPerson.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.DataGridPerson.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridPerson.Size = new System.Drawing.Size(809, 140);
            this.DataGridPerson.TabIndex = 42;
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(39)))), ((int)(((byte)(84)))));
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransfer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnTransfer.Location = new System.Drawing.Point(12, 261);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(1218, 39);
            this.btnTransfer.TabIndex = 4;
            this.btnTransfer.Text = "Transferir";
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.lblOperation);
            this.GroupBox.Controls.Add(this.ComboBoxOperation);
            this.GroupBox.Controls.Add(this.txtDocumento);
            this.GroupBox.Controls.Add(this.label1);
            this.GroupBox.Controls.Add(this.txtAhorro);
            this.GroupBox.Controls.Add(this.label6);
            this.GroupBox.Controls.Add(this.label3);
            this.GroupBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.GroupBox.Location = new System.Drawing.Point(12, 15);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(1218, 84);
            this.GroupBox.TabIndex = 23;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "Operación";
            // 
            // lblOperation
            // 
            this.lblOperation.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperation.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblOperation.Location = new System.Drawing.Point(607, 19);
            this.lblOperation.Name = "lblOperation";
            this.lblOperation.Size = new System.Drawing.Size(144, 29);
            this.lblOperation.TabIndex = 35;
            this.lblOperation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ComboBoxOperation
            // 
            this.ComboBoxOperation.FormattingEnabled = true;
            this.ComboBoxOperation.Items.AddRange(new object[] {
            "",
            "1",
            "4"});
            this.ComboBoxOperation.Location = new System.Drawing.Point(525, 23);
            this.ComboBoxOperation.Name = "ComboBoxOperation";
            this.ComboBoxOperation.Size = new System.Drawing.Size(59, 25);
            this.ComboBoxOperation.TabIndex = 2;
            this.ComboBoxOperation.SelectedIndexChanged += new System.EventHandler(this.ComboBoxOperation_SelectedIndexChanged);
            // 
            // txtDocumento
            // 
            this.txtDocumento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.Location = new System.Drawing.Point(132, 21);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(236, 27);
            this.txtDocumento.TabIndex = 1;
            this.txtDocumento.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDocumento_KeyUp);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 29);
            this.label1.TabIndex = 32;
            this.label1.Text = "Documento:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAhorro
            // 
            this.txtAhorro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAhorro.Location = new System.Drawing.Point(947, 23);
            this.txtAhorro.Name = "txtAhorro";
            this.txtAhorro.Size = new System.Drawing.Size(236, 27);
            this.txtAhorro.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(796, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 29);
            this.label6.TabIndex = 27;
            this.label6.Text = "Monto a Transferir:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(407, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 29);
            this.label3.TabIndex = 23;
            this.label3.Text = "Operacion:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitle.Location = new System.Drawing.Point(12, 366);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1218, 48);
            this.lblTitle.TabIndex = 27;
            this.lblTitle.Text = "RESUMEN DE LA TRANSFERENCIA";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(39)))), ((int)(((byte)(84)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnClear.Location = new System.Drawing.Point(905, 436);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(325, 39);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(39)))), ((int)(((byte)(84)))));
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnReport.Location = new System.Drawing.Point(905, 491);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(325, 39);
            this.btnReport.TabIndex = 44;
            this.btnReport.Text = "Generar Reporte";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // TabTransfer
            // 
            this.TabTransfer.Controls.Add(this.TabSummary);
            this.TabTransfer.Controls.Add(this.TabReport);
            this.TabTransfer.Location = new System.Drawing.Point(12, 436);
            this.TabTransfer.Name = "TabTransfer";
            this.TabTransfer.SelectedIndex = 0;
            this.TabTransfer.Size = new System.Drawing.Size(875, 427);
            this.TabTransfer.TabIndex = 45;
            // 
            // TabSummary
            // 
            this.TabSummary.Controls.Add(this.DataGridTransaction);
            this.TabSummary.Location = new System.Drawing.Point(4, 26);
            this.TabSummary.Name = "TabSummary";
            this.TabSummary.Padding = new System.Windows.Forms.Padding(3);
            this.TabSummary.Size = new System.Drawing.Size(867, 397);
            this.TabSummary.TabIndex = 0;
            this.TabSummary.Text = "Resumen";
            this.TabSummary.UseVisualStyleBackColor = true;
            // 
            // DataGridTransaction
            // 
            this.DataGridTransaction.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.DataGridTransaction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridTransaction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridTransaction.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridTransaction.EnableHeadersVisualStyles = false;
            this.DataGridTransaction.GridColor = System.Drawing.Color.WhiteSmoke;
            this.DataGridTransaction.Location = new System.Drawing.Point(3, 3);
            this.DataGridTransaction.Name = "DataGridTransaction";
            this.DataGridTransaction.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridTransaction.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.DataGridTransaction.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.DataGridTransaction.Size = new System.Drawing.Size(861, 391);
            this.DataGridTransaction.TabIndex = 44;
            // 
            // TabReport
            // 
            this.TabReport.Controls.Add(this.ReportViewerTransactions);
            this.TabReport.Location = new System.Drawing.Point(4, 26);
            this.TabReport.Name = "TabReport";
            this.TabReport.Padding = new System.Windows.Forms.Padding(3);
            this.TabReport.Size = new System.Drawing.Size(867, 397);
            this.TabReport.TabIndex = 1;
            this.TabReport.Text = "Reporte";
            this.TabReport.UseVisualStyleBackColor = true;
            // 
            // ReportViewerTransactions
            // 
            this.ReportViewerTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ReportTransactionsHeader";
            reportDataSource1.Value = this.reportTransactionsHeaderBindingSource;
            reportDataSource2.Name = "ReportTransactionsDetail";
            reportDataSource2.Value = this.reportTransactionsDetailBindingSource;
            this.ReportViewerTransactions.LocalReport.DataSources.Add(reportDataSource1);
            this.ReportViewerTransactions.LocalReport.DataSources.Add(reportDataSource2);
            this.ReportViewerTransactions.LocalReport.ReportEmbeddedResource = "Presentation.Reports.ReportTransactions.rdlc";
            this.ReportViewerTransactions.Location = new System.Drawing.Point(3, 3);
            this.ReportViewerTransactions.Name = "ReportViewerTransactions";
            this.ReportViewerTransactions.ServerReport.BearerToken = null;
            this.ReportViewerTransactions.Size = new System.Drawing.Size(861, 391);
            this.ReportViewerTransactions.TabIndex = 0;
            // 
            // Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1242, 875);
            this.Controls.Add(this.TabTransfer);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelTab);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Transactions";
            this.Text = "Transactions";
            this.Load += new System.EventHandler(this.Transactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportTransactionsHeaderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportTransactionsHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportTransactionsDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportTransactionsDetail)).EndInit();
            this.PanelTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBExit)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPerson)).EndInit();
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            this.TabTransfer.ResumeLayout(false);
            this.TabSummary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridTransaction)).EndInit();
            this.TabReport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTab;
        private System.Windows.Forms.PictureBox PBExit;
        private System.Windows.Forms.Label lblTab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAhorro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComboBoxOperation;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.DataGridView DataGridPerson;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblOperation;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.TabControl TabTransfer;
        private System.Windows.Forms.TabPage TabSummary;
        private System.Windows.Forms.DataGridView DataGridTransaction;
        private System.Windows.Forms.TabPage TabReport;
        private Microsoft.Reporting.WinForms.ReportViewer ReportViewerTransactions;
        private System.Windows.Forms.BindingSource reportTransactionsHeaderBindingSource;
        private Reports.DataSet.ReportTransactionsHeader reportTransactionsHeader;
        private System.Windows.Forms.BindingSource reportTransactionsDetailBindingSource;
        private Reports.DataSet.ReportTransactionsDetail reportTransactionsDetail;
    }
}