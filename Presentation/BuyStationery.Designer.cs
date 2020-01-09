namespace Presentation
{
    partial class BuyStationery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyStationery));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportBuyStationeryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportBuyStationery = new Presentation.Reports.DataSet.ReportBuyStationery();
            this.PanelTab = new System.Windows.Forms.Panel();
            this.lblTab = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegBinnacle = new System.Windows.Forms.Button();
            this.DatePickerInitial = new System.Windows.Forms.DateTimePicker();
            this.DatePickerFinal = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.DataGridStationeryVault = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabBinnacle = new System.Windows.Forms.TabPage();
            this.DataGridVault = new System.Windows.Forms.DataGridView();
            this.TabReport = new System.Windows.Forms.TabPage();
            this.ReportViewerStationery = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.reportBuyStationeryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportBuyStationery)).BeginInit();
            this.PanelTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridStationeryVault)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.TabBinnacle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridVault)).BeginInit();
            this.TabReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportBuyStationeryBindingSource
            // 
            this.reportBuyStationeryBindingSource.DataSource = this.reportBuyStationery;
            this.reportBuyStationeryBindingSource.Position = 0;
            // 
            // reportBuyStationery
            // 
            this.reportBuyStationery.DataSetName = "ReportBuyStationery";
            this.reportBuyStationery.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PanelTab
            // 
            this.PanelTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(39)))), ((int)(((byte)(84)))));
            this.PanelTab.Controls.Add(this.lblTab);
            this.PanelTab.Controls.Add(this.btnClose);
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
            this.lblTab.Size = new System.Drawing.Size(208, 23);
            this.lblTab.TabIndex = 7;
            this.lblTab.Text = "Compra de Papeleria";
            this.lblTab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(3, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(16, 16);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(29, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1169, 117);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bitacora";
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Location = new System.Drawing.Point(95, 28);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(397, 74);
            this.txtDescription.TabIndex = 36;
            this.txtDescription.Text = "";
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
            this.txtAmount.Location = new System.Drawing.Point(706, 30);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(260, 27);
            this.txtAmount.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(597, 28);
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
            this.btnRegBinnacle.Location = new System.Drawing.Point(41, 255);
            this.btnRegBinnacle.Name = "btnRegBinnacle";
            this.btnRegBinnacle.Size = new System.Drawing.Size(1109, 39);
            this.btnRegBinnacle.TabIndex = 43;
            this.btnRegBinnacle.Text = "Registrar";
            this.btnRegBinnacle.UseVisualStyleBackColor = false;
            this.btnRegBinnacle.Click += new System.EventHandler(this.btnRegBinnacle_Click);
            // 
            // DatePickerInitial
            // 
            this.DatePickerInitial.Location = new System.Drawing.Point(216, 326);
            this.DatePickerInitial.Name = "DatePickerInitial";
            this.DatePickerInitial.Size = new System.Drawing.Size(270, 22);
            this.DatePickerInitial.TabIndex = 44;
            // 
            // DatePickerFinal
            // 
            this.DatePickerFinal.Location = new System.Drawing.Point(756, 327);
            this.DatePickerFinal.Name = "DatePickerFinal";
            this.DatePickerFinal.Size = new System.Drawing.Size(270, 22);
            this.DatePickerFinal.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(121, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 29);
            this.label3.TabIndex = 48;
            this.label3.Text = "Desde";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(686, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 29);
            this.label5.TabIndex = 49;
            this.label5.Text = "Hasta";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(39)))), ((int)(((byte)(84)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSearch.Location = new System.Drawing.Point(462, 397);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(288, 39);
            this.btnSearch.TabIndex = 50;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(39)))), ((int)(((byte)(84)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnClear.Location = new System.Drawing.Point(29, 824);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(1169, 39);
            this.btnClear.TabIndex = 51;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // DataGridStationeryVault
            // 
            this.DataGridStationeryVault.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.DataGridStationeryVault.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridStationeryVault.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridStationeryVault.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridStationeryVault.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridStationeryVault.EnableHeadersVisualStyles = false;
            this.DataGridStationeryVault.GridColor = System.Drawing.Color.WhiteSmoke;
            this.DataGridStationeryVault.Location = new System.Drawing.Point(485, 45);
            this.DataGridStationeryVault.Name = "DataGridStationeryVault";
            this.DataGridStationeryVault.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridStationeryVault.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.DataGridStationeryVault.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridStationeryVault.Size = new System.Drawing.Size(228, 69);
            this.DataGridStationeryVault.TabIndex = 52;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabBinnacle);
            this.tabControl1.Controls.Add(this.TabReport);
            this.tabControl1.Location = new System.Drawing.Point(33, 450);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1165, 368);
            this.tabControl1.TabIndex = 53;
            // 
            // TabBinnacle
            // 
            this.TabBinnacle.Controls.Add(this.DataGridVault);
            this.TabBinnacle.Location = new System.Drawing.Point(4, 26);
            this.TabBinnacle.Name = "TabBinnacle";
            this.TabBinnacle.Padding = new System.Windows.Forms.Padding(3);
            this.TabBinnacle.Size = new System.Drawing.Size(1157, 338);
            this.TabBinnacle.TabIndex = 0;
            this.TabBinnacle.Text = "Bitacora";
            this.TabBinnacle.UseVisualStyleBackColor = true;
            // 
            // DataGridVault
            // 
            this.DataGridVault.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.DataGridVault.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridVault.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridVault.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridVault.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridVault.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridVault.EnableHeadersVisualStyles = false;
            this.DataGridVault.GridColor = System.Drawing.Color.WhiteSmoke;
            this.DataGridVault.Location = new System.Drawing.Point(3, 3);
            this.DataGridVault.Name = "DataGridVault";
            this.DataGridVault.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridVault.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.DataGridVault.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.DataGridVault.Size = new System.Drawing.Size(1151, 332);
            this.DataGridVault.TabIndex = 42;
            // 
            // TabReport
            // 
            this.TabReport.Controls.Add(this.ReportViewerStationery);
            this.TabReport.Location = new System.Drawing.Point(4, 26);
            this.TabReport.Name = "TabReport";
            this.TabReport.Padding = new System.Windows.Forms.Padding(3);
            this.TabReport.Size = new System.Drawing.Size(1157, 338);
            this.TabReport.TabIndex = 1;
            this.TabReport.Text = "Reporte";
            this.TabReport.UseVisualStyleBackColor = true;
            // 
            // ReportViewerStationery
            // 
            this.ReportViewerStationery.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ReportBuyStationery";
            reportDataSource1.Value = this.reportBuyStationeryBindingSource;
            this.ReportViewerStationery.LocalReport.DataSources.Add(reportDataSource1);
            this.ReportViewerStationery.LocalReport.ReportEmbeddedResource = "Presentation.Reports.ReportBuyStationery.rdlc";
            this.ReportViewerStationery.Location = new System.Drawing.Point(3, 3);
            this.ReportViewerStationery.Name = "ReportViewerStationery";
            this.ReportViewerStationery.ServerReport.BearerToken = null;
            this.ReportViewerStationery.Size = new System.Drawing.Size(1151, 332);
            this.ReportViewerStationery.TabIndex = 0;
            // 
            // BuyStationery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1242, 875);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.DataGridStationeryVault);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DatePickerFinal);
            this.Controls.Add(this.DatePickerInitial);
            this.Controls.Add(this.btnRegBinnacle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PanelTab);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BuyStationery";
            this.Text = "BuyStationery";
            this.Load += new System.EventHandler(this.BuyStationery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportBuyStationeryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportBuyStationery)).EndInit();
            this.PanelTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridStationeryVault)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.TabBinnacle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridVault)).EndInit();
            this.TabReport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTab;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label lblTab;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegBinnacle;
        private System.Windows.Forms.DateTimePicker DatePickerInitial;
        private System.Windows.Forms.DateTimePicker DatePickerFinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView DataGridStationeryVault;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabBinnacle;
        private System.Windows.Forms.DataGridView DataGridVault;
        private System.Windows.Forms.TabPage TabReport;
        private Microsoft.Reporting.WinForms.ReportViewer ReportViewerStationery;
        private System.Windows.Forms.BindingSource reportBuyStationeryBindingSource;
        private Reports.DataSet.ReportBuyStationery reportBuyStationery;
    }
}