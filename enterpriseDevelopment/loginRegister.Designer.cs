namespace enterpriseDevelopment
{
    partial class LoginRegister
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
            this.loginBtn = new System.Windows.Forms.Button();
            this.registerBtn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.usernameLogTxt = new System.Windows.Forms.TextBox();
            this.passwordLogTxt = new System.Windows.Forms.TextBox();
            this.fullNameRegTxt = new System.Windows.Forms.TextBox();
            this.usernameRegTxt = new System.Windows.Forms.TextBox();
            this.passwordRegTxt = new System.Windows.Forms.TextBox();
            this.usernameLogLbl = new System.Windows.Forms.Label();
            this.passwordLogLbl = new System.Windows.Forms.Label();
            this.firstnameRegLbl = new System.Windows.Forms.Label();
            this.usernameRegLbl = new System.Windows.Forms.Label();
            this.passwordRegLbl = new System.Windows.Forms.Label();
            this.password2RegLbl = new System.Windows.Forms.Label();
            this.password2RegTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(301, 220);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(325, 139);
            this.loginBtn.TabIndex = 0;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(1156, 220);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(365, 139);
            this.registerBtn.TabIndex = 1;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // usernameLogTxt
            // 
            this.usernameLogTxt.Location = new System.Drawing.Point(347, 429);
            this.usernameLogTxt.Name = "usernameLogTxt";
            this.usernameLogTxt.Size = new System.Drawing.Size(241, 31);
            this.usernameLogTxt.TabIndex = 2;
            // 
            // passwordLogTxt
            // 
            this.passwordLogTxt.Location = new System.Drawing.Point(347, 511);
            this.passwordLogTxt.Name = "passwordLogTxt";
            this.passwordLogTxt.Size = new System.Drawing.Size(241, 31);
            this.passwordLogTxt.TabIndex = 3;
            this.passwordLogTxt.UseSystemPasswordChar = true;
            // 
            // fullNameRegTxt
            // 
            this.fullNameRegTxt.AcceptsReturn = true;
            this.fullNameRegTxt.Location = new System.Drawing.Point(1218, 429);
            this.fullNameRegTxt.Name = "fullNameRegTxt";
            this.fullNameRegTxt.Size = new System.Drawing.Size(241, 31);
            this.fullNameRegTxt.TabIndex = 4;
            // 
            // usernameRegTxt
            // 
            this.usernameRegTxt.Location = new System.Drawing.Point(1218, 511);
            this.usernameRegTxt.Name = "usernameRegTxt";
            this.usernameRegTxt.Size = new System.Drawing.Size(241, 31);
            this.usernameRegTxt.TabIndex = 5;
            // 
            // passwordRegTxt
            // 
            this.passwordRegTxt.Location = new System.Drawing.Point(1218, 599);
            this.passwordRegTxt.Name = "passwordRegTxt";
            this.passwordRegTxt.Size = new System.Drawing.Size(241, 31);
            this.passwordRegTxt.TabIndex = 6;
            this.passwordRegTxt.UseSystemPasswordChar = true;
            // 
            // usernameLogLbl
            // 
            this.usernameLogLbl.AutoSize = true;
            this.usernameLogLbl.Location = new System.Drawing.Point(409, 386);
            this.usernameLogLbl.Name = "usernameLogLbl";
            this.usernameLogLbl.Size = new System.Drawing.Size(110, 25);
            this.usernameLogLbl.TabIndex = 7;
            this.usernameLogLbl.Text = "Username";
            // 
            // passwordLogLbl
            // 
            this.passwordLogLbl.AutoSize = true;
            this.passwordLogLbl.Location = new System.Drawing.Point(409, 476);
            this.passwordLogLbl.Name = "passwordLogLbl";
            this.passwordLogLbl.Size = new System.Drawing.Size(106, 25);
            this.passwordLogLbl.TabIndex = 8;
            this.passwordLogLbl.Text = "Password";
            // 
            // firstnameRegLbl
            // 
            this.firstnameRegLbl.AutoSize = true;
            this.firstnameRegLbl.Location = new System.Drawing.Point(1284, 386);
            this.firstnameRegLbl.Name = "firstnameRegLbl";
            this.firstnameRegLbl.Size = new System.Drawing.Size(113, 25);
            this.firstnameRegLbl.TabIndex = 9;
            this.firstnameRegLbl.Text = "First name";
            // 
            // usernameRegLbl
            // 
            this.usernameRegLbl.AutoSize = true;
            this.usernameRegLbl.Location = new System.Drawing.Point(1284, 476);
            this.usernameRegLbl.Name = "usernameRegLbl";
            this.usernameRegLbl.Size = new System.Drawing.Size(110, 25);
            this.usernameRegLbl.TabIndex = 10;
            this.usernameRegLbl.Text = "Username";
            // 
            // passwordRegLbl
            // 
            this.passwordRegLbl.AutoSize = true;
            this.passwordRegLbl.Location = new System.Drawing.Point(1284, 562);
            this.passwordRegLbl.Name = "passwordRegLbl";
            this.passwordRegLbl.Size = new System.Drawing.Size(106, 25);
            this.passwordRegLbl.TabIndex = 11;
            this.passwordRegLbl.Text = "Password";
            // 
            // password2RegLbl
            // 
            this.password2RegLbl.AutoSize = true;
            this.password2RegLbl.Location = new System.Drawing.Point(1213, 656);
            this.password2RegLbl.Name = "password2RegLbl";
            this.password2RegLbl.Size = new System.Drawing.Size(265, 25);
            this.password2RegLbl.TabIndex = 13;
            this.password2RegLbl.Text = "Type your password again";
            // 
            // password2RegTxt
            // 
            this.password2RegTxt.Location = new System.Drawing.Point(1218, 693);
            this.password2RegTxt.Name = "password2RegTxt";
            this.password2RegTxt.Size = new System.Drawing.Size(241, 31);
            this.password2RegTxt.TabIndex = 12;
            this.password2RegTxt.UseSystemPasswordChar = true;
            // 
            // LoginRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1819, 899);
            this.Controls.Add(this.password2RegLbl);
            this.Controls.Add(this.password2RegTxt);
            this.Controls.Add(this.passwordRegLbl);
            this.Controls.Add(this.usernameRegLbl);
            this.Controls.Add(this.firstnameRegLbl);
            this.Controls.Add(this.passwordLogLbl);
            this.Controls.Add(this.usernameLogLbl);
            this.Controls.Add(this.passwordRegTxt);
            this.Controls.Add(this.usernameRegTxt);
            this.Controls.Add(this.fullNameRegTxt);
            this.Controls.Add(this.passwordLogTxt);
            this.Controls.Add(this.usernameLogTxt);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.loginBtn);
            this.Name = "LoginRegister";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.loginRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button registerBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox usernameLogTxt;
        private System.Windows.Forms.TextBox passwordLogTxt;
        private System.Windows.Forms.TextBox fullNameRegTxt;
        private System.Windows.Forms.TextBox usernameRegTxt;
        private System.Windows.Forms.TextBox passwordRegTxt;
        private System.Windows.Forms.Label usernameLogLbl;
        private System.Windows.Forms.Label passwordLogLbl;
        private System.Windows.Forms.Label firstnameRegLbl;
        private System.Windows.Forms.Label usernameRegLbl;
        private System.Windows.Forms.Label passwordRegLbl;
        private System.Windows.Forms.Label password2RegLbl;
        private System.Windows.Forms.TextBox password2RegTxt;
    }
}