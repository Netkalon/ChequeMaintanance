using ChequeMaintanance.Helpers;
using ChequeMaintanance.Models;
using log4net;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace ChequeMaintanance.Forms
{
    public partial class FrmLogin : Form
    {
        private readonly ILog log = LogManager.GetLogger(typeof(FrmLogin));
        DBHelper objHelper = new DBHelper();

        public FrmLogin()
        {
            InitializeComponent();
        }
        
        private void FrmLoginLoad(object sender, EventArgs e)
        {
            this.AcceptButton = BtnLogin;
        }

        private void BtnCloseClick(object sender, EventArgs e)
        {
            this.MdiParent.Close();
        }

        private void BtnLoginClick(object sender, EventArgs e)
        {
            if (TxtUserName.Text == "" || string.IsNullOrEmpty(TxtUserName.Text))
            {
                LblMessage.Text = "Please Enter User Name";
                TxtUserName.Focus();
                return;
            }
            if (TxtPassword.Text == "" || string.IsNullOrEmpty(TxtPassword.Text))
            {
                LblMessage.Text = "Please Enter Password";
                TxtPassword.Focus();
                return;
            }
            try
            {
                var dsResult = new DataSet();
                var vmResult = new VmUserDetails();
                SqlParameter[] sqlParam = new SqlParameter[3];
                sqlParam[0] = new SqlParameter("@Mode", "VALIDATEUSER");
                sqlParam[1] = new SqlParameter("@UserName", TxtUserName.Text);
                sqlParam[2] = new SqlParameter("@Password", TxtPassword.Text);
                dsResult = objHelper.GetDatasetFromProcedure("dbo.Proc_ValidateUser", sqlParam);
                if (dsResult != null && dsResult.Tables.Count > 0)
                {
                    if (dsResult.Tables[0].Rows.Count > 0)
                    {
                        vmResult = dsResult.Tables[0].ToList<VmUserDetails>().ToList().FirstOrDefault();
                    }
                }
                if (vmResult.IsAuthenticated)
                {
                    FrmChequeMaintanance frmMain = new FrmChequeMaintanance();
                    frmMain.Show();
                    //Form frm = this.MdiParent;
                    //MenuStrip ms = (MenuStrip)frm.Controls["MenuDetails"];
                   // ms.Enabled = true;
                   // ms.Visible = true;
                    GlobalAccess.GlobalUserId = vmResult.UserId;
                    GlobalAccess.GlobalUserFullName = vmResult.UserFullName;
                    frmMain.Text = "Welcome " + vmResult.UserFullName;
                    this.Hide();
                }
                else
                {
                    LblMessage.Text = vmResult.ErrorMessage;
                    return;
                }
            }
            catch (Exception ex)
            {
                log.Error("[FrmLogin][BtnLoginClick][ExceptionMessage = " + ex.Message + "][ExceptionStackTrace = " + ex.StackTrace + "]");
            }
        }
    }
}