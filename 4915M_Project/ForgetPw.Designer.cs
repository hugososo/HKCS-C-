namespace _4915M_Project
{
    partial class ForgetPw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgetPw));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lbSignUp = new System.Windows.Forms.Label();
            this.lbSignIn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(428, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1);
            this.panel1.TabIndex = 1;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.BackColor = System.Drawing.Color.Transparent;
            this.lbEmail.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbEmail.Location = new System.Drawing.Point(366, 155);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(46, 18);
            this.lbEmail.TabIndex = 3;
            this.lbEmail.Text = "Email:";
            // 
            // tbEmail
            // 
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEmail.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(428, 151);
            this.tbEmail.MaxLength = 40;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(200, 19);
            this.tbEmail.TabIndex = 5;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Orange;
            this.btnSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(468, 225);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(112, 37);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lbSignUp
            // 
            this.lbSignUp.AutoSize = true;
            this.lbSignUp.BackColor = System.Drawing.Color.Transparent;
            this.lbSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbSignUp.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSignUp.ForeColor = System.Drawing.Color.White;
            this.lbSignUp.Location = new System.Drawing.Point(53, 215);
            this.lbSignUp.Name = "lbSignUp";
            this.lbSignUp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbSignUp.Size = new System.Drawing.Size(209, 18);
            this.lbSignUp.TabIndex = 8;
            this.lbSignUp.Text = "Don\'t Have an Account? Sign up! ";
            this.lbSignUp.Click += new System.EventHandler(this.lbSignUp_Click);
            // 
            // lbSignIn
            // 
            this.lbSignIn.AutoSize = true;
            this.lbSignIn.BackColor = System.Drawing.Color.Transparent;
            this.lbSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbSignIn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSignIn.ForeColor = System.Drawing.Color.White;
            this.lbSignIn.Location = new System.Drawing.Point(53, 256);
            this.lbSignIn.Name = "lbSignIn";
            this.lbSignIn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbSignIn.Size = new System.Drawing.Size(216, 18);
            this.lbSignIn.TabIndex = 9;
            this.lbSignIn.Text = "Already have an Account? Sign In!";
            this.lbSignIn.Click += new System.EventHandler(this.lbSignIn_Click);
            // 
            // ForgetPw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_4915M_Project.Properties.Resources.ForgetPw;
            this.ClientSize = new System.Drawing.Size(691, 389);
            this.Controls.Add(this.lbSignIn);
            this.Controls.Add(this.lbSignUp);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(707, 427);
            this.MinimumSize = new System.Drawing.Size(707, 427);
            this.Name = "ForgetPw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HKCS Limited";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lbSignUp;
        private System.Windows.Forms.Label lbSignIn;
    }
}

