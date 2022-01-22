
namespace Banking_System
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.UserId = new System.Windows.Forms.Label();
            this.Pwd = new System.Windows.Forms.Label();
            this.UseridText = new System.Windows.Forms.TextBox();
            this.PwdText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.imgbtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserId
            // 
            this.UserId.AutoSize = true;
            this.UserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserId.Location = new System.Drawing.Point(38, 53);
            this.UserId.Name = "UserId";
            this.UserId.Size = new System.Drawing.Size(78, 24);
            this.UserId.TabIndex = 0;
            this.UserId.Text = "User ID";
            this.UserId.Click += new System.EventHandler(this.UserId_Click);
            // 
            // Pwd
            // 
            this.Pwd.AutoSize = true;
            this.Pwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pwd.Location = new System.Drawing.Point(38, 107);
            this.Pwd.Name = "Pwd";
            this.Pwd.Size = new System.Drawing.Size(100, 24);
            this.Pwd.TabIndex = 1;
            this.Pwd.Text = "Password";
            this.Pwd.Click += new System.EventHandler(this.label1_Click);
            // 
            // UseridText
            // 
            this.UseridText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UseridText.Location = new System.Drawing.Point(195, 52);
            this.UseridText.MaxLength = 20;
            this.UseridText.Name = "UseridText";
            this.UseridText.Size = new System.Drawing.Size(216, 29);
            this.UseridText.TabIndex = 2;
            this.UseridText.TextChanged += new System.EventHandler(this.UseridText_TextChanged);
            // 
            // PwdText
            // 
            this.PwdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PwdText.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.PwdText.Location = new System.Drawing.Point(195, 107);
            this.PwdText.MaxLength = 20;
            this.PwdText.Name = "PwdText";
            this.PwdText.Size = new System.Drawing.Size(216, 29);
            this.PwdText.TabIndex = 3;
            this.PwdText.UseSystemPasswordChar = true;
            this.PwdText.TextChanged += new System.EventHandler(this.PwdText_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(92, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imgbtn
            // 
            this.imgbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.imgbtn.Image = ((System.Drawing.Image)(resources.GetObject("imgbtn.Image")));
            this.imgbtn.Location = new System.Drawing.Point(368, 107);
            this.imgbtn.Name = "imgbtn";
            this.imgbtn.Size = new System.Drawing.Size(43, 29);
            this.imgbtn.TabIndex = 5;
            this.imgbtn.UseVisualStyleBackColor = true;
            this.imgbtn.Click += new System.EventHandler(this.imgbtn_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(280, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 41);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 273);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.imgbtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PwdText);
            this.Controls.Add(this.UseridText);
            this.Controls.Add(this.Pwd);
            this.Controls.Add(this.UserId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Login Page";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserId;
        private System.Windows.Forms.Label Pwd;
        private System.Windows.Forms.TextBox UseridText;
        private System.Windows.Forms.TextBox PwdText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button imgbtn;
        private System.Windows.Forms.Button button2;
    }
}

