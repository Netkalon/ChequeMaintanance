using System;
using System.Windows.Forms;

namespace ChequeMaintanance.Forms
{
    public partial class FrmChequeMaintanance : Form
    {
        public FrmChequeMaintanance()
        {
            InitializeComponent();
        }

        private void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmChequeMaintananceLoad(object sender, EventArgs e)
        {
            //FrmLogin frmLogin = new FrmLogin();
            //frmLogin.MdiParent = this;
            //MenuDetails.Enabled = false;
            //MenuDetails.Visible = false;
            //frmLogin.Show();
        }

        private void AddChequeToolStripMenuItemClick(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is FrmAddCheque)
                {
                    frm.Focus();
                    frm.Refresh();
                    return;
                }
            }
            FrmAddCheque frmAddCheque = new FrmAddCheque();
            frmAddCheque.MdiParent = this;
            frmAddCheque.Show();
        }

        private void ViewChequesToolStripMenuItemClick(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is FrmViewChequeDetails)
                {
                    frm.Focus();
                    frm.Refresh();
                    return;
                }
            }
            FrmViewChequeDetails frmViewChequeDetails = new FrmViewChequeDetails();
            frmViewChequeDetails.MdiParent = this;
            frmViewChequeDetails.Show();
        }
    }
}