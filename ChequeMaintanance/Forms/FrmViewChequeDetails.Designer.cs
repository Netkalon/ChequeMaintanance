using ChequeMaintanance.AppData;
namespace ChequeMaintanance.Forms
{
    partial class FrmViewChequeDetails
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.procReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chequeMaintananceDBdsReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chequeMaintananceDBdsReport = new ChequeMaintanance.AppData.ChequeMaintananceDBdsReport();
            this.PnlReport = new System.Windows.Forms.Panel();
            this.RptChequeDetails = new Microsoft.Reporting.WinForms.ReportViewer();
            this.proc_ReportTableAdapter = new ChequeMaintanance.AppData.ChequeMaintananceDBdsReportTableAdapters.Proc_ReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.procReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chequeMaintananceDBdsReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chequeMaintananceDBdsReport)).BeginInit();
            this.PnlReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // procReportBindingSource
            // 
            this.procReportBindingSource.DataMember = "Proc_Report";
            this.procReportBindingSource.DataSource = this.chequeMaintananceDBdsReportBindingSource;
            // 
            // chequeMaintananceDBdsReportBindingSource
            // 
            this.chequeMaintananceDBdsReportBindingSource.DataSource = this.chequeMaintananceDBdsReport;
            this.chequeMaintananceDBdsReportBindingSource.Position = 0;
            // 
            // chequeMaintananceDBdsReport
            // 
            this.chequeMaintananceDBdsReport.DataSetName = "ChequeMaintananceDBdsReport";
            this.chequeMaintananceDBdsReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PnlReport
            // 
            this.PnlReport.BackColor = System.Drawing.Color.SeaShell;
            this.PnlReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlReport.Controls.Add(this.RptChequeDetails);
            this.PnlReport.Location = new System.Drawing.Point(13, 12);
            this.PnlReport.Name = "PnlReport";
            this.PnlReport.Size = new System.Drawing.Size(1457, 711);
            this.PnlReport.TabIndex = 1;
            // 
            // RptChequeDetails
            // 
            reportDataSource2.Name = "dsReport";
            reportDataSource2.Value = this.procReportBindingSource;
            this.RptChequeDetails.LocalReport.DataSources.Add(reportDataSource2);
            this.RptChequeDetails.LocalReport.ReportEmbeddedResource = "ChequeMaintanance.Forms.RptChequeDetails.rdlc";
            this.RptChequeDetails.Location = new System.Drawing.Point(3, 3);
            this.RptChequeDetails.Name = "RptChequeDetails";
            this.RptChequeDetails.Size = new System.Drawing.Size(1449, 703);
            this.RptChequeDetails.TabIndex = 0;
            this.RptChequeDetails.ReportRefresh += new System.ComponentModel.CancelEventHandler(this.RptChequeDetailsReportRefresh);
            // 
            // proc_ReportTableAdapter
            // 
            this.proc_ReportTableAdapter.ClearBeforeFill = true;
            // 
            // FrmViewChequeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1482, 735);
            this.Controls.Add(this.PnlReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmViewChequeDetails";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Cheque Details";
            this.Load += new System.EventHandler(this.FrmViewChequeDetailsLoad);
            ((System.ComponentModel.ISupportInitialize)(this.procReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chequeMaintananceDBdsReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chequeMaintananceDBdsReport)).EndInit();
            this.PnlReport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlReport;
        private Microsoft.Reporting.WinForms.ReportViewer RptChequeDetails;
        private System.Windows.Forms.BindingSource chequeMaintananceDBdsReportBindingSource;
        private ChequeMaintananceDBdsReport chequeMaintananceDBdsReport;
        private System.Windows.Forms.BindingSource procReportBindingSource;
        private ChequeMaintanance.AppData.ChequeMaintananceDBdsReportTableAdapters.Proc_ReportTableAdapter proc_ReportTableAdapter;
    }
}