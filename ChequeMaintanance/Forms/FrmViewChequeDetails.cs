using System;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace ChequeMaintanance.Forms
{
    public partial class FrmViewChequeDetails : Form
    {
        public FrmViewChequeDetails()
        {
            InitializeComponent();
        }

        private void FrmViewChequeDetailsLoad(object sender, EventArgs e)
        {
            ReportPageSettings rptPageSettings = RptChequeDetails.LocalReport.GetDefaultPageSettings();
            if (RptChequeDetails.ParentForm.Width > rptPageSettings.PaperSize.Width)
            {
                int vPad = (RptChequeDetails.ParentForm.Width - rptPageSettings.PaperSize.Width) / 2;
                RptChequeDetails.Padding = new Padding(vPad - 20, 1, vPad - 20, 1);
            }
            this.proc_ReportTableAdapter.Fill(this.chequeMaintananceDBdsReport.Proc_Report);
            RptChequeDetails.RefreshReport();
        }

        public void RefreshReport()
        {
            ReportPageSettings rptPageSettings = RptChequeDetails.LocalReport.GetDefaultPageSettings();
            if (RptChequeDetails.ParentForm.Width > rptPageSettings.PaperSize.Width)
            {
                int vPad = (RptChequeDetails.ParentForm.Width - rptPageSettings.PaperSize.Width) / 2;
                RptChequeDetails.Padding = new Padding(vPad - 20, 1, vPad - 20, 1);
            }
            RptChequeDetails.ZoomMode = ZoomMode.FullPage;
            this.proc_ReportTableAdapter.Fill(this.chequeMaintananceDBdsReport.Proc_Report);
            RptChequeDetails.RefreshReport();
        }

        private void RptChequeDetailsReportRefresh(object sender, System.ComponentModel.CancelEventArgs e)
        {
            RefreshReport();
        }
    }
}