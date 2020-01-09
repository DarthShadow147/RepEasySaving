namespace Presentation.Reports
{
    partial class ReportContributions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportContributions));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rEPORTCONTRIBUTIONSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rEPORT_CONTRIBUTIONS = new Presentation.Reports.DataSet.REPORT_CONTRIBUTIONS();
            this.sPREPORTCONTRIBUTIONSTOTALBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rEPORT_CONTRIBUTIONS_TOTAL = new Presentation.Reports.DataSet.REPORT_CONTRIBUTIONS_TOTAL();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PBExit = new System.Windows.Forms.PictureBox();
            this.PanelParameters = new System.Windows.Forms.Panel();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.DatetimeFinal = new System.Windows.Forms.DateTimePicker();
            this.DateTimeInitial = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ReportContributionsView = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sP_REPORT_CONTRIBUTIONS_TOTALTableAdapter = new Presentation.Reports.DataSet.REPORT_CONTRIBUTIONS_TOTALTableAdapters.SP_REPORT_CONTRIBUTIONS_TOTALTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rEPORTCONTRIBUTIONSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEPORT_CONTRIBUTIONS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPREPORTCONTRIBUTIONSTOTALBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEPORT_CONTRIBUTIONS_TOTAL)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBExit)).BeginInit();
            this.PanelParameters.SuspendLayout();
            this.SuspendLayout();
            // 
            // rEPORTCONTRIBUTIONSBindingSource
            // 
            this.rEPORTCONTRIBUTIONSBindingSource.DataSource = this.rEPORT_CONTRIBUTIONS;
            this.rEPORTCONTRIBUTIONSBindingSource.Position = 0;
            // 
            // rEPORT_CONTRIBUTIONS
            // 
            this.rEPORT_CONTRIBUTIONS.DataSetName = "REPORT_CONTRIBUTIONS";
            this.rEPORT_CONTRIBUTIONS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sPREPORTCONTRIBUTIONSTOTALBindingSource
            // 
            this.sPREPORTCONTRIBUTIONSTOTALBindingSource.DataMember = "SP_REPORT_CONTRIBUTIONS_TOTAL";
            this.sPREPORTCONTRIBUTIONSTOTALBindingSource.DataSource = this.rEPORT_CONTRIBUTIONS_TOTAL;
            // 
            // rEPORT_CONTRIBUTIONS_TOTAL
            // 
            this.rEPORT_CONTRIBUTIONS_TOTAL.DataSetName = "REPORT_CONTRIBUTIONS_TOTAL";
            this.rEPORT_CONTRIBUTIONS_TOTAL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(39)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.PBExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 28);
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
            // PanelParameters
            // 
            this.PanelParameters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.PanelParameters.Controls.Add(this.btnGenerate);
            this.PanelParameters.Controls.Add(this.DatetimeFinal);
            this.PanelParameters.Controls.Add(this.DateTimeInitial);
            this.PanelParameters.Controls.Add(this.label1);
            this.PanelParameters.Controls.Add(this.label2);
            this.PanelParameters.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelParameters.Location = new System.Drawing.Point(0, 28);
            this.PanelParameters.Name = "PanelParameters";
            this.PanelParameters.Size = new System.Drawing.Size(1002, 122);
            this.PanelParameters.TabIndex = 1;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(39)))), ((int)(((byte)(84)))));
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGenerate.Location = new System.Drawing.Point(370, 63);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(251, 39);
            this.btnGenerate.TabIndex = 39;
            this.btnGenerate.Text = "Generar";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // DatetimeFinal
            // 
            this.DatetimeFinal.Location = new System.Drawing.Point(659, 20);
            this.DatetimeFinal.Name = "DatetimeFinal";
            this.DatetimeFinal.Size = new System.Drawing.Size(264, 22);
            this.DatetimeFinal.TabIndex = 38;
            // 
            // DateTimeInitial
            // 
            this.DateTimeInitial.Location = new System.Drawing.Point(190, 20);
            this.DateTimeInitial.Name = "DateTimeInitial";
            this.DateTimeInitial.Size = new System.Drawing.Size(272, 22);
            this.DateTimeInitial.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(537, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 27);
            this.label1.TabIndex = 36;
            this.label1.Text = "Fecha Final:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(79, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 27);
            this.label2.TabIndex = 35;
            this.label2.Text = "Fecha Inicio:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ReportContributionsView
            // 
            reportDataSource1.Name = "REPORT_CONTRIBUTIONS";
            reportDataSource1.Value = this.rEPORTCONTRIBUTIONSBindingSource;
            reportDataSource2.Name = "REPORT_CONTRIBUTIONS_TOTAL";
            reportDataSource2.Value = this.sPREPORTCONTRIBUTIONSTOTALBindingSource;
            this.ReportContributionsView.LocalReport.DataSources.Add(reportDataSource1);
            this.ReportContributionsView.LocalReport.DataSources.Add(reportDataSource2);
            this.ReportContributionsView.LocalReport.ReportEmbeddedResource = "Presentation.Reports.ReportContributions.rdlc";
            this.ReportContributionsView.Location = new System.Drawing.Point(161, 156);
            this.ReportContributionsView.Name = "ReportContributionsView";
            this.ReportContributionsView.ServerReport.BearerToken = null;
            this.ReportContributionsView.Size = new System.Drawing.Size(685, 806);
            this.ReportContributionsView.TabIndex = 2;
            // 
            // sP_REPORT_CONTRIBUTIONS_TOTALTableAdapter
            // 
            this.sP_REPORT_CONTRIBUTIONS_TOTALTableAdapter.ClearBeforeFill = true;
            // 
            // ReportContributions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 974);
            this.Controls.Add(this.ReportContributionsView);
            this.Controls.Add(this.PanelParameters);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ReportContributions";
            this.Text = "ReportContributions";
            this.Load += new System.EventHandler(this.ReportContributions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rEPORTCONTRIBUTIONSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEPORT_CONTRIBUTIONS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPREPORTCONTRIBUTIONSTOTALBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEPORT_CONTRIBUTIONS_TOTAL)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBExit)).EndInit();
            this.PanelParameters.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PBExit;
        private System.Windows.Forms.Panel PanelParameters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DatetimeFinal;
        private System.Windows.Forms.DateTimePicker DateTimeInitial;
        private System.Windows.Forms.Button btnGenerate;
        private Microsoft.Reporting.WinForms.ReportViewer ReportContributionsView;
        private System.Windows.Forms.BindingSource rEPORTCONTRIBUTIONSBindingSource;
        private DataSet.REPORT_CONTRIBUTIONS rEPORT_CONTRIBUTIONS;
        private System.Windows.Forms.BindingSource sPREPORTCONTRIBUTIONSTOTALBindingSource;
        private DataSet.REPORT_CONTRIBUTIONS_TOTAL rEPORT_CONTRIBUTIONS_TOTAL;
        private DataSet.REPORT_CONTRIBUTIONS_TOTALTableAdapters.SP_REPORT_CONTRIBUTIONS_TOTALTableAdapter sP_REPORT_CONTRIBUTIONS_TOTALTableAdapter;
    }
}