namespace Presentation
{
    partial class Settlement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settlement));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.vaultTotalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vaultTotal = new Presentation.Reports.DataSet.VaultTotal();
            this.profitsTotalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.profitsTotal = new Presentation.Reports.DataSet.ProfitsTotal();
            this.settlementSummaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PanelTab = new System.Windows.Forms.Panel();
            this.lblTab = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.TabStationery = new System.Windows.Forms.TabControl();
            this.TabDetail = new System.Windows.Forms.TabPage();
            this.DataGridSettlement = new System.Windows.Forms.DataGridView();
            this.TabReport = new System.Windows.Forms.TabPage();
            this.ReportViewerSettlement = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnSettlement = new System.Windows.Forms.Button();
            this.DataGridMembers = new System.Windows.Forms.DataGridView();
            this.btnReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vaultTotalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaultTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profitsTotalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profitsTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settlementSummaryBindingSource)).BeginInit();
            this.PanelTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.TabStationery.SuspendLayout();
            this.TabDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSettlement)).BeginInit();
            this.TabReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // vaultTotalBindingSource
            // 
            this.vaultTotalBindingSource.DataSource = this.vaultTotal;
            this.vaultTotalBindingSource.Position = 0;
            // 
            // vaultTotal
            // 
            this.vaultTotal.DataSetName = "VaultTotal";
            this.vaultTotal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // profitsTotalBindingSource
            // 
            this.profitsTotalBindingSource.DataSource = this.profitsTotal;
            this.profitsTotalBindingSource.Position = 0;
            // 
            // profitsTotal
            // 
            this.profitsTotal.DataSetName = "ProfitsTotal";
            this.profitsTotal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.lblTab.Size = new System.Drawing.Size(164, 23);
            this.lblTab.TabIndex = 8;
            this.lblTab.Text = "Liquidación";
            this.lblTab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(3, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(16, 16);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 3;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // TabStationery
            // 
            this.TabStationery.Controls.Add(this.TabDetail);
            this.TabStationery.Controls.Add(this.TabReport);
            this.TabStationery.Location = new System.Drawing.Point(3, 380);
            this.TabStationery.Name = "TabStationery";
            this.TabStationery.SelectedIndex = 0;
            this.TabStationery.Size = new System.Drawing.Size(1227, 504);
            this.TabStationery.TabIndex = 0;
            // 
            // TabDetail
            // 
            this.TabDetail.Controls.Add(this.DataGridSettlement);
            this.TabDetail.Location = new System.Drawing.Point(4, 26);
            this.TabDetail.Name = "TabDetail";
            this.TabDetail.Padding = new System.Windows.Forms.Padding(3);
            this.TabDetail.Size = new System.Drawing.Size(1219, 474);
            this.TabDetail.TabIndex = 0;
            this.TabDetail.Text = "Detalle Liquidación";
            this.TabDetail.UseVisualStyleBackColor = true;
            // 
            // DataGridSettlement
            // 
            this.DataGridSettlement.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.DataGridSettlement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridSettlement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridSettlement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridSettlement.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridSettlement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridSettlement.EnableHeadersVisualStyles = false;
            this.DataGridSettlement.GridColor = System.Drawing.Color.WhiteSmoke;
            this.DataGridSettlement.Location = new System.Drawing.Point(3, 3);
            this.DataGridSettlement.Name = "DataGridSettlement";
            this.DataGridSettlement.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridSettlement.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.DataGridSettlement.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridSettlement.Size = new System.Drawing.Size(1213, 468);
            this.DataGridSettlement.TabIndex = 45;
            // 
            // TabReport
            // 
            this.TabReport.Controls.Add(this.ReportViewerSettlement);
            this.TabReport.Location = new System.Drawing.Point(4, 26);
            this.TabReport.Name = "TabReport";
            this.TabReport.Padding = new System.Windows.Forms.Padding(3);
            this.TabReport.Size = new System.Drawing.Size(1219, 474);
            this.TabReport.TabIndex = 1;
            this.TabReport.Text = "Reporte";
            this.TabReport.UseVisualStyleBackColor = true;
            // 
            // ReportViewerSettlement
            // 
            this.ReportViewerSettlement.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "VaultTotal";
            reportDataSource1.Value = this.vaultTotalBindingSource;
            reportDataSource2.Name = "ProfitsTotal";
            reportDataSource2.Value = this.profitsTotalBindingSource;
            reportDataSource3.Name = "SettlementSummary";
            reportDataSource3.Value = this.settlementSummaryBindingSource;
            this.ReportViewerSettlement.LocalReport.DataSources.Add(reportDataSource1);
            this.ReportViewerSettlement.LocalReport.DataSources.Add(reportDataSource2);
            this.ReportViewerSettlement.LocalReport.DataSources.Add(reportDataSource3);
            this.ReportViewerSettlement.LocalReport.ReportEmbeddedResource = "Presentation.Reports.ReportSettlementVault.rdlc";
            this.ReportViewerSettlement.Location = new System.Drawing.Point(3, 3);
            this.ReportViewerSettlement.Name = "ReportViewerSettlement";
            this.ReportViewerSettlement.ServerReport.BearerToken = null;
            this.ReportViewerSettlement.Size = new System.Drawing.Size(1213, 468);
            this.ReportViewerSettlement.TabIndex = 0;
            // 
            // btnSettlement
            // 
            this.btnSettlement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(39)))), ((int)(((byte)(84)))));
            this.btnSettlement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettlement.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettlement.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSettlement.Location = new System.Drawing.Point(29, 284);
            this.btnSettlement.Name = "btnSettlement";
            this.btnSettlement.Size = new System.Drawing.Size(1176, 39);
            this.btnSettlement.TabIndex = 42;
            this.btnSettlement.Text = "Liquidar";
            this.btnSettlement.UseVisualStyleBackColor = false;
            this.btnSettlement.Click += new System.EventHandler(this.btnSettlement_Click);
            // 
            // DataGridMembers
            // 
            this.DataGridMembers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.DataGridMembers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridMembers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridMembers.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridMembers.EnableHeadersVisualStyles = false;
            this.DataGridMembers.GridColor = System.Drawing.Color.WhiteSmoke;
            this.DataGridMembers.Location = new System.Drawing.Point(29, 48);
            this.DataGridMembers.Name = "DataGridMembers";
            this.DataGridMembers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridMembers.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.DataGridMembers.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.DataGridMembers.Size = new System.Drawing.Size(1176, 230);
            this.DataGridMembers.TabIndex = 45;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(39)))), ((int)(((byte)(84)))));
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnReport.Location = new System.Drawing.Point(29, 329);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(1176, 39);
            this.btnReport.TabIndex = 46;
            this.btnReport.Text = "Generar Reporte";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // Settlement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1242, 875);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.TabStationery);
            this.Controls.Add(this.DataGridMembers);
            this.Controls.Add(this.btnSettlement);
            this.Controls.Add(this.PanelTab);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Settlement";
            this.Text = "Settlement";
            this.Load += new System.EventHandler(this.Settlement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vaultTotalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaultTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profitsTotalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profitsTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settlementSummaryBindingSource)).EndInit();
            this.PanelTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.TabStationery.ResumeLayout(false);
            this.TabDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSettlement)).EndInit();
            this.TabReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMembers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTab;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label lblTab;
        private System.Windows.Forms.TabControl TabStationery;
        private System.Windows.Forms.TabPage TabDetail;
        private System.Windows.Forms.TabPage TabReport;
        private System.Windows.Forms.Button btnSettlement;
        private System.Windows.Forms.DataGridView DataGridSettlement;
        private System.Windows.Forms.DataGridView DataGridMembers;
        private System.Windows.Forms.Button btnReport;
        private Microsoft.Reporting.WinForms.ReportViewer ReportViewerSettlement;
        private System.Windows.Forms.BindingSource vaultTotalBindingSource;
        private Reports.DataSet.VaultTotal vaultTotal;
        private System.Windows.Forms.BindingSource profitsTotalBindingSource;
        private Reports.DataSet.ProfitsTotal profitsTotal;
        private System.Windows.Forms.BindingSource settlementSummaryBindingSource;
        private Reports.DataSet.SettlementSummary settlementSummary;
    }
}