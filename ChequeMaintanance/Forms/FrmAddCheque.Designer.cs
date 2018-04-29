namespace ChequeMaintanance.Forms
{
    partial class FrmAddCheque
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
            this.PnlChequeDetails = new System.Windows.Forms.Panel();
            this.LblMessageFaliure = new System.Windows.Forms.Label();
            this.BtnClear = new System.Windows.Forms.Button();
            this.TxtValidUpto = new System.Windows.Forms.DateTimePicker();
            this.TxtGivenDate = new System.Windows.Forms.DateTimePicker();
            this.TxtAmount = new System.Windows.Forms.TextBox();
            this.LblAmount = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.RtfNotes = new System.Windows.Forms.RichTextBox();
            this.LblNotes = new System.Windows.Forms.Label();
            this.TxtGivenTo = new System.Windows.Forms.TextBox();
            this.TxtChequeNumber = new System.Windows.Forms.TextBox();
            this.LblValidUpto = new System.Windows.Forms.Label();
            this.LblGivenDate = new System.Windows.Forms.Label();
            this.LblGivenTo = new System.Windows.Forms.Label();
            this.LblChequeNumber = new System.Windows.Forms.Label();
            this.PnlGrid = new System.Windows.Forms.Panel();
            this.GrdChequeDetails = new System.Windows.Forms.DataGridView();
            this.PnlChequeDetails.SuspendLayout();
            this.PnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdChequeDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlChequeDetails
            // 
            this.PnlChequeDetails.BackColor = System.Drawing.Color.Navy;
            this.PnlChequeDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlChequeDetails.Controls.Add(this.LblMessageFaliure);
            this.PnlChequeDetails.Controls.Add(this.BtnClear);
            this.PnlChequeDetails.Controls.Add(this.TxtValidUpto);
            this.PnlChequeDetails.Controls.Add(this.TxtGivenDate);
            this.PnlChequeDetails.Controls.Add(this.TxtAmount);
            this.PnlChequeDetails.Controls.Add(this.LblAmount);
            this.PnlChequeDetails.Controls.Add(this.BtnSave);
            this.PnlChequeDetails.Controls.Add(this.RtfNotes);
            this.PnlChequeDetails.Controls.Add(this.LblNotes);
            this.PnlChequeDetails.Controls.Add(this.TxtGivenTo);
            this.PnlChequeDetails.Controls.Add(this.TxtChequeNumber);
            this.PnlChequeDetails.Controls.Add(this.LblValidUpto);
            this.PnlChequeDetails.Controls.Add(this.LblGivenDate);
            this.PnlChequeDetails.Controls.Add(this.LblGivenTo);
            this.PnlChequeDetails.Controls.Add(this.LblChequeNumber);
            this.PnlChequeDetails.Location = new System.Drawing.Point(13, 13);
            this.PnlChequeDetails.Name = "PnlChequeDetails";
            this.PnlChequeDetails.Size = new System.Drawing.Size(1457, 348);
            this.PnlChequeDetails.TabIndex = 0;
            // 
            // LblMessageFaliure
            // 
            this.LblMessageFaliure.ForeColor = System.Drawing.Color.Red;
            this.LblMessageFaliure.Location = new System.Drawing.Point(13, 13);
            this.LblMessageFaliure.Name = "LblMessageFaliure";
            this.LblMessageFaliure.Size = new System.Drawing.Size(1421, 23);
            this.LblMessageFaliure.TabIndex = 14;
            this.LblMessageFaliure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(601, 277);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(150, 35);
            this.BtnClear.TabIndex = 14;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClearClick);
            // 
            // TxtValidUpto
            // 
            this.TxtValidUpto.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.TxtValidUpto.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TxtValidUpto.Location = new System.Drawing.Point(321, 227);
            this.TxtValidUpto.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.TxtValidUpto.Name = "TxtValidUpto";
            this.TxtValidUpto.Size = new System.Drawing.Size(430, 22);
            this.TxtValidUpto.TabIndex = 7;
            // 
            // TxtGivenDate
            // 
            this.TxtGivenDate.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.TxtGivenDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TxtGivenDate.Location = new System.Drawing.Point(321, 177);
            this.TxtGivenDate.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.TxtGivenDate.Name = "TxtGivenDate";
            this.TxtGivenDate.Size = new System.Drawing.Size(430, 22);
            this.TxtGivenDate.TabIndex = 6;
            // 
            // TxtAmount
            // 
            this.TxtAmount.Location = new System.Drawing.Point(960, 70);
            this.TxtAmount.MaxLength = 23;
            this.TxtAmount.Name = "TxtAmount";
            this.TxtAmount.Size = new System.Drawing.Size(430, 22);
            this.TxtAmount.TabIndex = 9;
            this.TxtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAmountKeyPress);
            // 
            // LblAmount
            // 
            this.LblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAmount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblAmount.Location = new System.Drawing.Point(760, 69);
            this.LblAmount.Name = "LblAmount";
            this.LblAmount.Size = new System.Drawing.Size(172, 23);
            this.LblAmount.TabIndex = 15;
            this.LblAmount.Text = "Amount";
            this.LblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(321, 277);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(150, 35);
            this.BtnSave.TabIndex = 11;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSaveClick);
            // 
            // RtfNotes
            // 
            this.RtfNotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RtfNotes.Location = new System.Drawing.Point(960, 122);
            this.RtfNotes.Name = "RtfNotes";
            this.RtfNotes.Size = new System.Drawing.Size(430, 130);
            this.RtfNotes.TabIndex = 10;
            this.RtfNotes.Text = "";
            // 
            // LblNotes
            // 
            this.LblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNotes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblNotes.Location = new System.Drawing.Point(757, 122);
            this.LblNotes.Name = "LblNotes";
            this.LblNotes.Size = new System.Drawing.Size(175, 130);
            this.LblNotes.TabIndex = 8;
            this.LblNotes.Text = "Notes";
            this.LblNotes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtGivenTo
            // 
            this.TxtGivenTo.Location = new System.Drawing.Point(321, 122);
            this.TxtGivenTo.MaxLength = 50;
            this.TxtGivenTo.Name = "TxtGivenTo";
            this.TxtGivenTo.Size = new System.Drawing.Size(430, 22);
            this.TxtGivenTo.TabIndex = 5;
            // 
            // TxtChequeNumber
            // 
            this.TxtChequeNumber.Location = new System.Drawing.Point(321, 68);
            this.TxtChequeNumber.MaxLength = 50;
            this.TxtChequeNumber.Name = "TxtChequeNumber";
            this.TxtChequeNumber.Size = new System.Drawing.Size(430, 22);
            this.TxtChequeNumber.TabIndex = 4;
            // 
            // LblValidUpto
            // 
            this.LblValidUpto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValidUpto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblValidUpto.Location = new System.Drawing.Point(40, 229);
            this.LblValidUpto.Name = "LblValidUpto";
            this.LblValidUpto.Size = new System.Drawing.Size(145, 23);
            this.LblValidUpto.TabIndex = 3;
            this.LblValidUpto.Text = "Cheque Valid Upto";
            this.LblValidUpto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblGivenDate
            // 
            this.LblGivenDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGivenDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblGivenDate.Location = new System.Drawing.Point(40, 179);
            this.LblGivenDate.Name = "LblGivenDate";
            this.LblGivenDate.Size = new System.Drawing.Size(145, 23);
            this.LblGivenDate.TabIndex = 2;
            this.LblGivenDate.Text = "Cheque Given Date";
            this.LblGivenDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblGivenTo
            // 
            this.LblGivenTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGivenTo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblGivenTo.Location = new System.Drawing.Point(40, 122);
            this.LblGivenTo.Name = "LblGivenTo";
            this.LblGivenTo.Size = new System.Drawing.Size(145, 23);
            this.LblGivenTo.TabIndex = 1;
            this.LblGivenTo.Text = "Cheque Given To";
            this.LblGivenTo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblChequeNumber
            // 
            this.LblChequeNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblChequeNumber.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblChequeNumber.Location = new System.Drawing.Point(40, 68);
            this.LblChequeNumber.Name = "LblChequeNumber";
            this.LblChequeNumber.Size = new System.Drawing.Size(145, 23);
            this.LblChequeNumber.TabIndex = 0;
            this.LblChequeNumber.Text = "Cheque Number";
            this.LblChequeNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PnlGrid
            // 
            this.PnlGrid.BackColor = System.Drawing.Color.Navy;
            this.PnlGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlGrid.Controls.Add(this.GrdChequeDetails);
            this.PnlGrid.Location = new System.Drawing.Point(13, 375);
            this.PnlGrid.Name = "PnlGrid";
            this.PnlGrid.Size = new System.Drawing.Size(1457, 348);
            this.PnlGrid.TabIndex = 1;
            // 
            // GrdChequeDetails
            // 
            this.GrdChequeDetails.AllowUserToAddRows = false;
            this.GrdChequeDetails.AllowUserToOrderColumns = true;
            this.GrdChequeDetails.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.GrdChequeDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GrdChequeDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdChequeDetails.GridColor = System.Drawing.Color.SeaShell;
            this.GrdChequeDetails.Location = new System.Drawing.Point(17, 15);
            this.GrdChequeDetails.Name = "GrdChequeDetails";
            this.GrdChequeDetails.RowHeadersVisible = false;
            this.GrdChequeDetails.RowTemplate.Height = 24;
            this.GrdChequeDetails.Size = new System.Drawing.Size(1424, 318);
            this.GrdChequeDetails.TabIndex = 0;
            // 
            // FrmAddCheque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1482, 735);
            this.Controls.Add(this.PnlGrid);
            this.Controls.Add(this.PnlChequeDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmAddCheque";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Cheque Details";
            this.Load += new System.EventHandler(this.FrmAddChequeLoad);
            this.PnlChequeDetails.ResumeLayout(false);
            this.PnlChequeDetails.PerformLayout();
            this.PnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdChequeDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlChequeDetails;
        private System.Windows.Forms.Label LblValidUpto;
        private System.Windows.Forms.Label LblGivenDate;
        private System.Windows.Forms.Label LblGivenTo;
        private System.Windows.Forms.Label LblChequeNumber;
        private System.Windows.Forms.TextBox TxtGivenTo;
        private System.Windows.Forms.TextBox TxtChequeNumber;
        private System.Windows.Forms.RichTextBox RtfNotes;
        private System.Windows.Forms.Label LblNotes;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label LblMessageFaliure;
        private System.Windows.Forms.TextBox TxtAmount;
        private System.Windows.Forms.Label LblAmount;
        private System.Windows.Forms.DateTimePicker TxtGivenDate;
        private System.Windows.Forms.DateTimePicker TxtValidUpto;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Panel PnlGrid;
        private System.Windows.Forms.DataGridView GrdChequeDetails;
    }
}