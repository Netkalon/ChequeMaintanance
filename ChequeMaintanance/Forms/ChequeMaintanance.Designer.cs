using ChequeMaintanance.Forms;

namespace ChequeMaintanance.Forms
{
    partial class FrmChequeMaintanance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChequeMaintanance));
            this.MenuDetails = new System.Windows.Forms.MenuStrip();
            this.AddCheque = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewCheques = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuDetails
            // 
            this.MenuDetails.BackColor = System.Drawing.Color.Navy;
            this.MenuDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MenuDetails.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuDetails.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.MenuDetails.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuDetails.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddCheque,
            this.ViewCheques,
            this.exitToolStripMenuItem});
            this.MenuDetails.Location = new System.Drawing.Point(0, 0);
            this.MenuDetails.Name = "MenuDetails";
            this.MenuDetails.Size = new System.Drawing.Size(1478, 28);
            this.MenuDetails.TabIndex = 1;
            this.MenuDetails.Text = "menuStrip1";
            // 
            // AddCheque
            // 
            this.AddCheque.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCheque.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddCheque.Name = "AddCheque";
            this.AddCheque.Size = new System.Drawing.Size(115, 24);
            this.AddCheque.Text = "Add Cheque\'s";
            this.AddCheque.Click += new System.EventHandler(this.AddChequeToolStripMenuItemClick);
            // 
            // ViewCheques
            // 
            this.ViewCheques.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewCheques.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ViewCheques.Name = "ViewCheques";
            this.ViewCheques.Size = new System.Drawing.Size(120, 24);
            this.ViewCheques.Text = "View Cheque\'s";
            this.ViewCheques.Click += new System.EventHandler(this.ViewChequesToolStripMenuItemClick);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // FrmChequeMaintanance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1478, 649);
            this.Controls.Add(this.MenuDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuDetails;
            this.Name = "FrmChequeMaintanance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cheque Details Maintanance App";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmChequeMaintananceLoad);
            this.MenuDetails.ResumeLayout(false);
            this.MenuDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuDetails;
        private System.Windows.Forms.ToolStripMenuItem AddCheque;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewCheques;
    }
}

