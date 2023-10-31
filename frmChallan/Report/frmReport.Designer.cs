namespace frmChallan.Report
{
    partial class frmReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.CannibalizedDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rdlcReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.CannibalizedDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CannibalizedDetailsBindingSource
            // 
            this.CannibalizedDetailsBindingSource.DataSource = typeof(BussinessLibrary.SupportLibrary.CannibalizedDetails);
            // 
            // rdlcReportViewer
            // 
            this.rdlcReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Cannibalized";
            reportDataSource1.Value = this.CannibalizedDetailsBindingSource;
            this.rdlcReportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.rdlcReportViewer.LocalReport.ReportEmbeddedResource = "frmChallan.Report.rptCannibalized.rdlc";
            this.rdlcReportViewer.Location = new System.Drawing.Point(0, 0);
            this.rdlcReportViewer.Name = "rdlcReportViewer";
            this.rdlcReportViewer.Size = new System.Drawing.Size(704, 434);
            this.rdlcReportViewer.TabIndex = 0;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 434);
            this.Controls.Add(this.rdlcReportViewer);
            this.Name = "frmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CannibalizedDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rdlcReportViewer;
        private System.Windows.Forms.BindingSource CannibalizedDetailsBindingSource;
    }
}