
namespace Banking_System
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.maintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCustomerDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCustomerDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCustomerDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseCustomerDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sEPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newAccountDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editAccountDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAccountDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseAccountDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sEPToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withDrawalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fundTransferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.balanceEnquiryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miniStatementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customStatementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maintenanceToolStripMenuItem,
            this.transactionToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(514, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // maintenanceToolStripMenuItem
            // 
            this.maintenanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCustomerDetailsToolStripMenuItem,
            this.editCustomerDetailsToolStripMenuItem,
            this.deleteCustomerDetailsToolStripMenuItem,
            this.browseCustomerDetailsToolStripMenuItem,
            this.sEPToolStripMenuItem,
            this.newAccountDetailsToolStripMenuItem,
            this.editAccountDetailsToolStripMenuItem,
            this.deleteAccountDetailsToolStripMenuItem,
            this.browseAccountDetailsToolStripMenuItem,
            this.sEPToolStripMenuItem1,
            this.changePasswordToolStripMenuItem});
            this.maintenanceToolStripMenuItem.Name = "maintenanceToolStripMenuItem";
            this.maintenanceToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.maintenanceToolStripMenuItem.Text = "Maintenance";
            this.maintenanceToolStripMenuItem.Click += new System.EventHandler(this.maintenanceToolStripMenuItem_Click);
            // 
            // newCustomerDetailsToolStripMenuItem
            // 
            this.newCustomerDetailsToolStripMenuItem.Name = "newCustomerDetailsToolStripMenuItem";
            this.newCustomerDetailsToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.newCustomerDetailsToolStripMenuItem.Text = "New customer Details";
            this.newCustomerDetailsToolStripMenuItem.Click += new System.EventHandler(this.newCustomerDetailsToolStripMenuItem_Click);
            // 
            // editCustomerDetailsToolStripMenuItem
            // 
            this.editCustomerDetailsToolStripMenuItem.Name = "editCustomerDetailsToolStripMenuItem";
            this.editCustomerDetailsToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.editCustomerDetailsToolStripMenuItem.Text = "Edit Customer Details";
            this.editCustomerDetailsToolStripMenuItem.Click += new System.EventHandler(this.editCustomerDetailsToolStripMenuItem_Click);
            // 
            // deleteCustomerDetailsToolStripMenuItem
            // 
            this.deleteCustomerDetailsToolStripMenuItem.Name = "deleteCustomerDetailsToolStripMenuItem";
            this.deleteCustomerDetailsToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.deleteCustomerDetailsToolStripMenuItem.Text = "Delete Customer Details";
            this.deleteCustomerDetailsToolStripMenuItem.Click += new System.EventHandler(this.deleteCustomerDetailsToolStripMenuItem_Click);
            // 
            // browseCustomerDetailsToolStripMenuItem
            // 
            this.browseCustomerDetailsToolStripMenuItem.Name = "browseCustomerDetailsToolStripMenuItem";
            this.browseCustomerDetailsToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.browseCustomerDetailsToolStripMenuItem.Text = "Browse Customer Details";
            // 
            // sEPToolStripMenuItem
            // 
            this.sEPToolStripMenuItem.Name = "sEPToolStripMenuItem";
            this.sEPToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.sEPToolStripMenuItem.Text = "---------------SEP---------------";
            this.sEPToolStripMenuItem.Click += new System.EventHandler(this.sEPToolStripMenuItem_Click);
            // 
            // newAccountDetailsToolStripMenuItem
            // 
            this.newAccountDetailsToolStripMenuItem.Name = "newAccountDetailsToolStripMenuItem";
            this.newAccountDetailsToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.newAccountDetailsToolStripMenuItem.Text = "New Account Details";
            this.newAccountDetailsToolStripMenuItem.Click += new System.EventHandler(this.newAccountDetailsToolStripMenuItem_Click);
            // 
            // editAccountDetailsToolStripMenuItem
            // 
            this.editAccountDetailsToolStripMenuItem.Name = "editAccountDetailsToolStripMenuItem";
            this.editAccountDetailsToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.editAccountDetailsToolStripMenuItem.Text = "Edit Account Details";
            // 
            // deleteAccountDetailsToolStripMenuItem
            // 
            this.deleteAccountDetailsToolStripMenuItem.Name = "deleteAccountDetailsToolStripMenuItem";
            this.deleteAccountDetailsToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.deleteAccountDetailsToolStripMenuItem.Text = "Delete Account Details";
            // 
            // browseAccountDetailsToolStripMenuItem
            // 
            this.browseAccountDetailsToolStripMenuItem.Name = "browseAccountDetailsToolStripMenuItem";
            this.browseAccountDetailsToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.browseAccountDetailsToolStripMenuItem.Text = "Browse Account Details";
            // 
            // sEPToolStripMenuItem1
            // 
            this.sEPToolStripMenuItem1.Name = "sEPToolStripMenuItem1";
            this.sEPToolStripMenuItem1.Size = new System.Drawing.Size(243, 22);
            this.sEPToolStripMenuItem1.Text = "-------------SEP----------------";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.depositToolStripMenuItem,
            this.withDrawalToolStripMenuItem,
            this.fundTransferToolStripMenuItem});
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.transactionToolStripMenuItem.Text = "Transaction";
            // 
            // depositToolStripMenuItem
            // 
            this.depositToolStripMenuItem.Name = "depositToolStripMenuItem";
            this.depositToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.depositToolStripMenuItem.Text = "Deposit";
            // 
            // withDrawalToolStripMenuItem
            // 
            this.withDrawalToolStripMenuItem.Name = "withDrawalToolStripMenuItem";
            this.withDrawalToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.withDrawalToolStripMenuItem.Text = "WithDrawal";
            // 
            // fundTransferToolStripMenuItem
            // 
            this.fundTransferToolStripMenuItem.Name = "fundTransferToolStripMenuItem";
            this.fundTransferToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.fundTransferToolStripMenuItem.Text = "Fund Transfer";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.balanceEnquiryToolStripMenuItem,
            this.miniStatementToolStripMenuItem,
            this.customStatementToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // balanceEnquiryToolStripMenuItem
            // 
            this.balanceEnquiryToolStripMenuItem.Name = "balanceEnquiryToolStripMenuItem";
            this.balanceEnquiryToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.balanceEnquiryToolStripMenuItem.Text = "Balance Enquiry";
            // 
            // miniStatementToolStripMenuItem
            // 
            this.miniStatementToolStripMenuItem.Name = "miniStatementToolStripMenuItem";
            this.miniStatementToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.miniStatementToolStripMenuItem.Text = "Mini Statement";
            // 
            // customStatementToolStripMenuItem
            // 
            this.customStatementToolStripMenuItem.Name = "customStatementToolStripMenuItem";
            this.customStatementToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.customStatementToolStripMenuItem.Text = "Custom Statement";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(509, 263);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 292);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "DEI BANK";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem maintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCustomerDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCustomerDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCustomerDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browseCustomerDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sEPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newAccountDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editAccountDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAccountDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browseAccountDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sEPToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depositToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withDrawalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fundTransferToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem balanceEnquiryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miniStatementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customStatementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}