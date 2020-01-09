namespace Presentation.Reports
{
    partial class ReportProfits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportProfits));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.PanelTab = new System.Windows.Forms.Panel();
            this.PBExit = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.DatePickerFinal = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DatePickerInitial = new System.Windows.Forms.DateTimePicker();
            this.ReportViewerProfits = new Microsoft.Reporting.WinForms.ReportViewer();
            this.profits = new Presentation.Reports.DataSet.Profits();
            this.profitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PanelTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBExit)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profitsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTab
            // 
            this.PanelTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(39)))), ((int)(((byte)(84)))));
            this.PanelTab.Controls.Add(this.PBExit);
            this.PanelTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTab.Location = new System.Drawing.Point(0, 0);
            this.PanelTab.Name = "PanelTab";
            this.PanelTab.Size = new System.Drawing.Size(1002, 28);
            this.PanelTab.TabIndex = 0;
            // 
            // PBExit
            // 
            this.PBExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(39)))), ((int)(((byte)(84)))));
            this.PBExit.Image = ((System.Drawing.Image)(resources.GetObject("PBExit.Image")));
            this.PBExit.Location = new System.Drawing.Point(3, 3);
            this.PBExit.Name = "PBExit";
            this.PBExit.Size = new System.Drawing.Size(16, 16);
            this.PBExit.TabIndex = 6;
            this.PBExit.TabStop = false;
            this.PBExit.Click += new System.EventHandler(this.PBExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.panel1.Controls.Add(this.btnGenerate);
            this.panel1.Controls.Add(this.DatePickerFinal);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.DatePickerInitial);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 122);
            this.panel1.TabIndex = 1;
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
            this.btnGenerate.TabIndex = 40;
            this.btnGenerate.Text = "Generar";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // DatePickerFinal
            // 
            this.DatePickerFinal.Location = new System.Drawing.Point(659, 20);
            this.DatePickerFinal.Name = "DatePickerFinal";
            this.DatePickerFinal.Size = new System.Drawing.Size(262, 22);
            this.DatePickerFinal.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(537, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 27);
            this.label1.TabIndex = 37;
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
            this.label2.TabIndex = 36;
            this.label2.Text = "Fecha Inicio:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DatePickerInitial
            // 
            this.DatePickerInitial.Location = new System.Drawing.Point(190, 20);
            this.DatePickerInitial.Name = "DatePickerInitial";
            this.DatePickerInitial.Size = new System.Drawing.Size(262, 22);
            this.DatePickerInitial.TabIndex = 0;
            // 
            // ReportViewerProfits
            // 
            reportDataSource1.Name = "Profits";
            reportDataSource1.Value = this.profitsBindingSource;
            this.ReportViewerProfits.LocalReport.DataSources.Add(reportDataSource1);
            this.ReportViewerProfits.LocalReport.ReportEmbeddedResource = "Presentation.Reports.ReportProfits.rdlc";
            this.ReportViewerProfits.Location = new System.Drawing.Point(161, 156);
            this.ReportViewerProfits.Name = "ReportViewerProfits";
            this.ReportViewerProfits.ServerReport.BearerToken = null;
            this.ReportViewerProfits.Size = new System.Drawing.Size(685, 806);
            this.ReportViewerProfits.TabIndex = 2;
            // 
            // profits
            // 
            this.profits.DataSetName = "Profits";
            this.profits.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // profitsBindingSource
            // 
            this.profitsBindingSource.DataSource = this.profits;
            this.profitsBindingSource.Position = 0;
            // 
            // ReportProfits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 974);
            this.Controls.Add(this.ReportViewerProfits);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelTab);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ReportProfits";
            this.Text = "ReportProfits";
            this.Load += new System.EventHandler(this.ReportProfits_Load);
            this.PanelTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBExit)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profitsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTab;
        private System.Windows.Forms.PictureBox PBExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker DatePickerInitial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DatePickerFinal;
        private System.Windows.Forms.Button btnGenerate;
        private Microsoft.Reporting.WinForms.ReportViewer ReportViewerProfits;
        private System.Windows.Forms.BindingSource profitsBindingSource;
        private DataSet.Profits profits;
    }
}