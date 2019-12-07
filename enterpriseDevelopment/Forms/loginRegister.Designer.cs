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
            this.loginBtn.Location = new System.Drawing.Point(150, 114);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(162, 72);
            this.loginBtn.TabIndex = 0;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(578, 114);
            this.registerBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(182, 72);
            this.registerBtn.TabIndex = 1;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // usernameLogTxt
            // 
            this.usernameLogTxt.Location = new System.Drawing.Point(174, 223);
            this.usernameLogTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.usernameLogTxt.Name = "usernameLogTxt";
            this.usernameLogTxt.Size = new System.Drawing.Size(122, 20);
            this.usernameLogTxt.TabIndex = 2;
            // 
            // passwordLogTxt
            // 
            this.passwordLogTxt.Location = new System.Drawing.Point(174, 266);
            this.passwordLogTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passwordLogTxt.Name = "passwordLogTxt";
            this.passwordLogTxt.Size = new System.Drawing.Size(122, 20);
            this.passwordLogTxt.TabIndex = 3;
            this.passwordLogTxt.UseSystemPasswordChar = true;
            // 
            // fullNameRegTxt
            // 
            this.fullNameRegTxt.AcceptsReturn = true;
            this.fullNameRegTxt.Location = new System.Drawing.Point(609, 223);
            this.fullNameRegTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fullNameRegTxt.Name = "fullNameRegTxt";
            this.fullNameRegTxt.Size = new System.Drawing.Size(122, 20);
            this.fullNameRegTxt.TabIndex = 4;
            // 
            // usernameRegTxt
            // 
            this.usernameRegTxt.Location = new System.Drawing.Point(609, 266);
            this.usernameRegTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.usernameRegTxt.Name = "usernameRegTxt";
            this.usernameRegTxt.Size = new System.Drawing.Size(122, 20);
            this.usernameRegTxt.TabIndex = 5;
            // 
            // passwordRegTxt
            // 
            this.passwordRegTxt.Location = new System.Drawing.Point(609, 311);
            this.passwordRegTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passwordRegTxt.Name = "passwordRegTxt";
            this.passwordRegTxt.Size = new System.Drawing.Size(122, 20);
            this.passwordRegTxt.TabIndex = 6;
            this.passwordRegTxt.UseSystemPasswordChar = true;
            // 
            // usernameLogLbl
            // 
            this.usernameLogLbl.AutoSize = true;
            this.usernameLogLbl.Location = new System.Drawing.Point(204, 201);
            this.usernameLogLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernameLogLbl.Name = "usernameLogLbl";
            this.usernameLogLbl.Size = new System.Drawing.Size(55, 13);
            this.usernameLogLbl.TabIndex = 7;
            this.usernameLogLbl.Text = "Username";
            // 
            // passwordLogLbl
            // 
            this.passwordLogLbl.AutoSize = true;
            this.passwordLogLbl.Location = new System.Drawing.Point(204, 248);
            this.passwordLogLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordLogLbl.Name = "passwordLogLbl";
            this.passwordLogLbl.Size = new System.Drawing.Size(53, 13);
            this.passwordLogLbl.TabIndex = 8;
            this.passwordLogLbl.Text = "Password";
            // 
            // firstnameRegLbl
            // 
            this.firstnameRegLbl.AutoSize = true;
            this.firstnameRegLbl.Location = new System.Drawing.Point(642, 201);
            this.firstnameRegLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.firstnameRegLbl.Name = "firstnameRegLbl";
            this.firstnameRegLbl.Size = new System.Drawing.Size(55, 13);
            this.firstnameRegLbl.TabIndex = 9;
            this.firstnameRegLbl.Text = "First name";
            // 
            // usernameRegLbl
            // 
            this.usernameRegLbl.AutoSize = true;
            this.usernameRegLbl.Location = new System.Drawing.Point(642, 248);
            this.usernameRegLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernameRegLbl.Name = "usernameRegLbl";
            this.usernameRegLbl.Size = new System.Drawing.Size(55, 13);
            this.usernameRegLbl.TabIndex = 10;
            this.usernameRegLbl.Text = "Username";
            // 
            // passwordRegLbl
            // 
            this.passwordRegLbl.AutoSize = true;
            this.passwordRegLbl.Location = new System.Drawing.Point(642, 292);
            this.passwordRegLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordRegLbl.Name = "passwordRegLbl";
            this.passwordRegLbl.Size = new System.Drawing.Size(53, 13);
            this.passwordRegLbl.TabIndex = 11;
            this.passwordRegLbl.Text = "Password";
            // 
            // password2RegLbl
            // 
            this.password2RegLbl.AutoSize = true;
            this.password2RegLbl.Location = new System.Drawing.Point(606, 341);
            this.password2RegLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.password2RegLbl.Name = "password2RegLbl";
            this.password2RegLbl.Size = new System.Drawing.Size(131, 13);
            this.password2RegLbl.TabIndex = 13;
            this.password2RegLbl.Text = "Type your password again";
            // 
            // password2RegTxt
            // 
            this.password2RegTxt.Location = new System.Drawing.Point(609, 360);
            this.password2RegTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.password2RegTxt.Name = "password2RegTxt";
            this.password2RegTxt.Size = new System.Drawing.Size(122, 20);
            this.password2RegTxt.TabIndex = 12;
            this.password2RegTxt.UseSystemPasswordChar = true;
            // 
            // LoginRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 467);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LoginRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginRegister_FormClosed);
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