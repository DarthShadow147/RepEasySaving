namespace Presentation.Reports
{
    partial class LoanSaving
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoanSaving));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.eSLoanSavingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eSLoanSaving = new Presentation.Reports.DataSet.ESLoanSaving();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PBExit = new System.Windows.Forms.PictureBox();
            this.lblTab = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.ReportSaving = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.eSLoanSavingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSLoanSaving)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBExit)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // eSLoanSavingBindingSource
            // 
            this.eSLoanSavingBindingSource.DataSource = this.eSLoanSaving;
            this.eSLoanSavingBindingSource.Position = 0;
            // 
            // eSLoanSaving
            // 
            this.eSLoanSaving.DataSetName = "ESLoanSaving";
            this.eSLoanSaving.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(39)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.PBExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1242, 28);
            this.panel1.TabIndex = 0;
            // 
            // PBExit
            // 
            this.PBExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(39)))), ((int)(((byte)(84)))));
            this.PBExit.Image = ((System.Drawing.Image)(resources.GetObject("PBExit.Image")));
            this.PBExit.Location = new System.Drawing.Point(3, 3);
            this.PBExit.Name = "PBExit";
            this.PBExit.Size = new System.Drawing.Size(16, 16);
            this.PBExit.TabIndex = 5;
            this.PBExit.TabStop = false;
            this.PBExit.Click += new System.EventHandler(this.PBExit_Click);
            // 
            // lblTab
            // 
            this.lblTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(39)))), ((int)(((byte)(84)))));
            this.lblTab.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTab.ForeColor = System.Drawing.Color.White;
            this.lblTab.Location = new System.Drawing.Point(25, 3);
            this.lblTab.Name = "lblTab";
            this.lblTab.Size = new System.Drawing.Size(164, 23);
            this.lblTab.TabIndex = 11;
            this.lblTab.Text = "Consultar Ahorros";
            this.lblTab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.panel2.Controls.Add(this.txtDocumento);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1242, 104);
            this.panel2.TabIndex = 12;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.Location = new System.Drawing.Point(157, 12);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(223, 27);
            this.txtDocumento.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(26, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 27);
            this.label1.TabIndex = 35;
            this.label1.Text = "Documento:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(39)))), ((int)(((byte)(84)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSearch.Location = new System.Drawing.Point(594, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(394, 39);
            this.btnSearch.TabIndex = 36;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ReportSaving
            // 
            reportDataSource2.Name = "ESLoanSaving";
            reportDataSource2.Value = this.eSLoanSavingBindingSource;
            this.ReportSaving.LocalReport.DataSources.Add(reportDataSource2);
            this.ReportSaving.LocalReport.ReportEmbeddedResource = "Presentation.Reports.LoanSaving.rdlc";
            this.ReportSaving.Location = new System.Drawing.Point(325, 138);
            this.ReportSaving.Name = "ReportSaving";
            this.ReportSaving.ServerReport.BearerToken = null;
            this.ReportSaving.Size = new System.Drawing.Size(685, 743);
            this.ReportSaving.TabIndex = 13;
            // 
            // LoanSaving
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1242, 875);
            this.Controls.Add(this.ReportSaving);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblTab);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoanSaving";
            this.Text = "LoanSaving";
            this.Load += new System.EventHandler(this.LoanSaving_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eSLoanSavingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSLoanSaving)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBExit)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PBExit;
        private System.Windows.Forms.Label lblTab;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private Microsoft.Reporting.WinForms.ReportViewer ReportSaving;
        private System.Windows.Forms.BindingSource eSLoanSavingBindingSource;
        private DataSet.ESLoanSaving eSLoanSaving;
    }
}