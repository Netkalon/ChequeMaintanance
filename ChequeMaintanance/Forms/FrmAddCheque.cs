using System.Drawing;
using ChequeMaintanance.Helpers;
using ChequeMaintanance.Models;
using log4net;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace ChequeMaintanance.Forms
{
    public partial class FrmAddCheque : Form
    {
        private readonly ILog log = LogManager.GetLogger(typeof(FrmAddCheque));
        DBHelper objHelper = new DBHelper();

        public FrmAddCheque()
        {
            InitializeComponent();
        }

        private void FrmAddChequeLoad(object sender, EventArgs e)
        {
            var objAddCheque = new VmAddCheque();
            objAddCheque.Mode = "GETALL";
            LoadDatas(objAddCheque);
        }

        private void BtnSaveClick(object sender, EventArgs e)
        {
            var objAddCheque = new VmAddCheque();
            if (TxtChequeNumber.Text == "" || string.IsNullOrEmpty(TxtChequeNumber.Text))
            {
                LblMessageFaliure.Text = "Please Enter Cheque Number";
                TxtChequeNumber.Focus();
                return;
            }
            if (TxtGivenTo.Text == "" || string.IsNullOrEmpty(TxtGivenTo.Text))
            {
                LblMessageFaliure.Text = "Please Enter the Name of the Person whom you gave this Cheque";
                TxtGivenTo.Focus();
                return;
            }
            if (TxtGivenDate.Text == "" || string.IsNullOrEmpty(TxtGivenDate.Text))
            {
                LblMessageFaliure.Text = "Please Select Cheque Issued date";
                TxtGivenDate.Focus();
                return;
            }
            if (TxtValidUpto.Text == "" || string.IsNullOrEmpty(TxtValidUpto.Text))
            {
                LblMessageFaliure.Text = "Please Select Cheque Expiry date";
                TxtValidUpto.Focus();
                return;
            }
            if (TxtAmount.Text == "" || string.IsNullOrEmpty(TxtAmount.Text))
            {
                LblMessageFaliure.Text = "Please Fill the Cheque Amount";
                TxtAmount.Focus();
                return;
            }
            objAddCheque.Mode = "INSERT";
            objAddCheque.ChequeNumber = TxtChequeNumber.Text;
            objAddCheque.GivenTo = TxtGivenTo.Text;
            objAddCheque.GivenDate = TxtGivenDate.Text;
            objAddCheque.ValidUpto = TxtValidUpto.Text;
            objAddCheque.Amount = Convert.ToDecimal(TxtAmount.Text);
            objAddCheque.Notes = RtfNotes.Text;
            SaveDatas(objAddCheque);
        }

        private void BtnClearClick(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void LoadDatas(VmAddCheque objAddCheque)
        {
            try
            {
                var dsResult = new DataSet();
                var lstDatas = new List<VmAddCheque>();
                SqlParameter[] sqlParam = new SqlParameter[5];
                sqlParam[0] = new SqlParameter("@Mode", objAddCheque.Mode);
                sqlParam[1] = new SqlParameter("@ChequeNumber", objAddCheque.ChequeNumber);
                sqlParam[2] = new SqlParameter("@GivenTo", objAddCheque.GivenTo);
                sqlParam[3] = new SqlParameter("@GivenDate", objAddCheque.GivenDate);
                sqlParam[4] = new SqlParameter("@ValidUpto", objAddCheque.ValidUpto);
                dsResult = objHelper.GetDatasetFromProcedure("dbo.Proc_ChequeDetails", sqlParam);
                if (dsResult != null && dsResult.Tables.Count > 0)
                {
                    if (dsResult.Tables[0].Rows.Count > 0)
                    {
                        lstDatas = dsResult.Tables[0].ToList<VmAddCheque>().ToList();
                        BindGrid(lstDatas);
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error("[FrmAddCheque][LoadDatas][ExceptionMessage = " + ex.Message + "][ExceptionStackTrace = " + ex.StackTrace + "]");
            }
        }

        private void SaveDatas(VmAddCheque objAddCheque)
        {
            try
            {
                var dsResult = new DataSet();
                var msgs = new VmCommonModel();
                var lstDatas = new List<VmAddCheque>();
                SqlParameter[] sqlParam = new SqlParameter[9];
                sqlParam[0] = new SqlParameter("@Mode", objAddCheque.Mode);
                sqlParam[1] = new SqlParameter("@ChequeDetailsId", objAddCheque.ChequeDetailsId);
                sqlParam[2] = new SqlParameter("@ChequeNumber", objAddCheque.ChequeNumber);
                sqlParam[3] = new SqlParameter("@GivenTo", objAddCheque.GivenTo);
                sqlParam[4] = new SqlParameter("@GivenDate", objAddCheque.GivenDate);
                sqlParam[5] = new SqlParameter("@ValidUpto", objAddCheque.ValidUpto);
                sqlParam[6] = new SqlParameter("@Amount", objAddCheque.Amount);
                sqlParam[7] = new SqlParameter("@Notes", objAddCheque.Notes);
                sqlParam[8] = new SqlParameter("@UserId", GlobalAccess.GlobalUserId);
                dsResult = objHelper.GetDatasetFromProcedure("dbo.Proc_ChequeDetails", sqlParam);
                if (dsResult != null && dsResult.Tables.Count > 0)
                {
                    if (dsResult.Tables[0].Rows.Count > 0)
                    {
                        msgs = dsResult.Tables[0].ToList<VmCommonModel>().ToList().FirstOrDefault();
                    }
                    if (msgs.IsSuccess == true)
                    {
                        LblMessageFaliure.Visible = false;
                        MessageBox.Show(this.MdiParent, msgs.OutputMessage, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dsResult.Tables[1].Rows.Count > 0)
                        {
                            lstDatas = dsResult.Tables[1].ToList<VmAddCheque>().ToList();
                            BindGrid(lstDatas);
                        }
                        ClearInputs();
                    }
                    else
                    {
                        LblMessageFaliure.Visible = true;
                        LblMessageFaliure.Text = msgs.OutputMessage;
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error("[FrmAddCheque][SaveDatas][ExceptionMessage = " + ex.Message + "][ExceptionStackTrace = " + ex.StackTrace + "]");
            }
        }

        private void BindGrid(object obj)
        {
            if (GrdChequeDetails.RowCount == 0)
            {
                GrdChequeDetails.AllowUserToAddRows = false;
                GrdChequeDetails.Columns.Clear();
                GrdChequeDetails.ColumnCount = 6;
                GrdChequeDetails.Columns[0].Name = "Cheque Number";
                GrdChequeDetails.Columns[0].DataPropertyName = "ChequeNumber";
                GrdChequeDetails.Columns[0].Width = 175;
                GrdChequeDetails.Columns[1].Name = "Given To";
                GrdChequeDetails.Columns[1].DataPropertyName = "GivenTo";
                GrdChequeDetails.Columns[1].Width = 175;
                GrdChequeDetails.Columns[2].Name = "Given Date";
                GrdChequeDetails.Columns[2].DataPropertyName = "GivenDate";
                GrdChequeDetails.Columns[2].Width = 125;
                GrdChequeDetails.Columns[3].Name = "Valid Upto";
                GrdChequeDetails.Columns[3].DataPropertyName = "ValidUpto";
                GrdChequeDetails.Columns[3].Width = 125;
                GrdChequeDetails.Columns[4].Name = "Amount";
                GrdChequeDetails.Columns[4].DataPropertyName = "Amount";
                GrdChequeDetails.Columns[4].Width = 150;
                GrdChequeDetails.Columns[5].Name = "Notes";
                GrdChequeDetails.Columns[5].DataPropertyName = "Notes";
                GrdChequeDetails.Columns[5].Width = 250;
                GrdChequeDetails.AutoGenerateColumns = false;
                GrdChequeDetails.ReadOnly = true;
                GrdChequeDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                GrdChequeDetails.RowHeadersVisible = false;
                GrdChequeDetails.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkGray;
                GrdChequeDetails.ScrollBars = ScrollBars.Both;
            }
            GrdChequeDetails.DataSource = obj;
        }

        private void ClearInputs()
        {
            TxtChequeNumber.Text = "";
            TxtGivenTo.Text = "";
            TxtGivenDate.Text = "";
            TxtValidUpto.Text = "";
            TxtAmount.Text = "";
            RtfNotes.Text = "";
            LblMessageFaliure.Text = "";
        }

        private void TxtAmountKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}