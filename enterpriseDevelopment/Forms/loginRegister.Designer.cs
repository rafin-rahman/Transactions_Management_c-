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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginRegister));
            this.loginBtn = new System.Windows.Forms.Button();
            this.registerBtn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.usernameLogTxt = new System.Windows.Forms.TextBox();
            this.passwordLogTxt = new System.Windows.Forms.TextBox();
            this.fullNameRegTxt = new System.Windows.Forms.TextBox();
            this.usernameRegTxt = new System.Windows.Forms.TextBox();
            this.passwordRegTxt = new System.Windows.Forms.TextBox();
            this.password2RegTxt = new System.Windows.Forms.TextBox();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.thinLineOne = new System.Windows.Forms.Panel();
            this.logPwdPanel = new System.Windows.Forms.Panel();
            this.thinLinetwo = new System.Windows.Forms.Panel();
            this.loginIcon = new System.Windows.Forms.PictureBox();
            this.closeBtn = new System.Windows.Forms.Panel();
            this.dontHaveAccLbl = new System.Windows.Forms.Label();
            this.registerHereLbl = new System.Windows.Forms.Label();
            this.alreadyRegLbl = new System.Windows.Forms.Label();
            this.loginHereLbl = new System.Windows.Forms.Label();
            this.fullNamePanel = new System.Windows.Forms.Panel();
            this.bottomLineP1 = new System.Windows.Forms.Panel();
            this.usernamePanel = new System.Windows.Forms.Panel();
            this.bottomLineP2 = new System.Windows.Forms.Panel();
            this.pwdPanel = new System.Windows.Forms.Panel();
            this.bottomLineP3 = new System.Windows.Forms.Panel();
            this.pwd2Panel = new System.Windows.Forms.Panel();
            this.bottomLineP14 = new System.Windows.Forms.Panel();
            this.registerIcon = new System.Windows.Forms.PictureBox();
            this.loginPanel.SuspendLayout();
            this.logPwdPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginIcon)).BeginInit();
            this.fullNamePanel.SuspendLayout();
            this.usernamePanel.SuspendLayout();
            this.pwdPanel.SuspendLayout();
            this.pwd2Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registerIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.Location = new System.Drawing.Point(146, 382);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(2);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(108, 29);
            this.loginBtn.TabIndex = 0;
            this.loginBtn.Text = "Enter";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // registerBtn
            // 
            this.registerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.registerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerBtn.Location = new System.Drawing.Point(146, 382);
            this.registerBtn.Margin = new System.Windows.Forms.Padding(2);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(108, 29);
            this.registerBtn.TabIndex = 1;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Visible = false;
            this.registerBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // usernameLogTxt
            // 
            this.usernameLogTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameLogTxt.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLogTxt.ForeColor = System.Drawing.Color.DarkGray;
            this.usernameLogTxt.Location = new System.Drawing.Point(10, 9);
            this.usernameLogTxt.Margin = new System.Windows.Forms.Padding(2);
            this.usernameLogTxt.Name = "usernameLogTxt";
            this.usernameLogTxt.Size = new System.Drawing.Size(122, 19);
            this.usernameLogTxt.TabIndex = 2;
            this.usernameLogTxt.Text = "Type username...";
            this.usernameLogTxt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.usernameLogTxt_MouseClick);
            // 
            // passwordLogTxt
            // 
            this.passwordLogTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordLogTxt.Font = new System.Drawing.Font("Cambria", 12F);
            this.passwordLogTxt.ForeColor = System.Drawing.Color.DarkGray;
            this.passwordLogTxt.Location = new System.Drawing.Point(10, 9);
            this.passwordLogTxt.Margin = new System.Windows.Forms.Padding(2);
            this.passwordLogTxt.Name = "passwordLogTxt";
            this.passwordLogTxt.Size = new System.Drawing.Size(122, 19);
            this.passwordLogTxt.TabIndex = 3;
            this.passwordLogTxt.Text = "Your password";
            this.passwordLogTxt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.passwordLogTxt_MouseClick);
            // 
            // fullNameRegTxt
            // 
            this.fullNameRegTxt.AcceptsReturn = true;
            this.fullNameRegTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fullNameRegTxt.Font = new System.Drawing.Font("Cambria", 12F);
            this.fullNameRegTxt.ForeColor = System.Drawing.Color.DarkGray;
            this.fullNameRegTxt.Location = new System.Drawing.Point(11, 9);
            this.fullNameRegTxt.Margin = new System.Windows.Forms.Padding(2);
            this.fullNameRegTxt.Name = "fullNameRegTxt";
            this.fullNameRegTxt.Size = new System.Drawing.Size(122, 19);
            this.fullNameRegTxt.TabIndex = 4;
            this.fullNameRegTxt.Text = "Type full name";
            this.fullNameRegTxt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.fullNameRegTxt_MouseClick);
            // 
            // usernameRegTxt
            // 
            this.usernameRegTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameRegTxt.Font = new System.Drawing.Font("Cambria", 12F);
            this.usernameRegTxt.ForeColor = System.Drawing.Color.DarkGray;
            this.usernameRegTxt.Location = new System.Drawing.Point(11, 9);
            this.usernameRegTxt.Margin = new System.Windows.Forms.Padding(2);
            this.usernameRegTxt.Name = "usernameRegTxt";
            this.usernameRegTxt.Size = new System.Drawing.Size(122, 19);
            this.usernameRegTxt.TabIndex = 5;
            this.usernameRegTxt.Text = "Type username";
            this.usernameRegTxt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.usernameRegTxt_MouseClick);
            // 
            // passwordRegTxt
            // 
            this.passwordRegTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordRegTxt.Font = new System.Drawing.Font("Cambria", 12F);
            this.passwordRegTxt.ForeColor = System.Drawing.Color.DarkGray;
            this.passwordRegTxt.Location = new System.Drawing.Point(11, 9);
            this.passwordRegTxt.Margin = new System.Windows.Forms.Padding(2);
            this.passwordRegTxt.Name = "passwordRegTxt";
            this.passwordRegTxt.Size = new System.Drawing.Size(122, 19);
            this.passwordRegTxt.TabIndex = 6;
            this.passwordRegTxt.Text = "Type password";
            this.passwordRegTxt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.passwordRegTxt_MouseClick);
            // 
            // password2RegTxt
            // 
            this.password2RegTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password2RegTxt.Font = new System.Drawing.Font("Cambria", 12F);
            this.password2RegTxt.ForeColor = System.Drawing.Color.DarkGray;
            this.password2RegTxt.Location = new System.Drawing.Point(11, 9);
            this.password2RegTxt.Margin = new System.Windows.Forms.Padding(2);
            this.password2RegTxt.Name = "password2RegTxt";
            this.password2RegTxt.Size = new System.Drawing.Size(136, 19);
            this.password2RegTxt.TabIndex = 12;
            this.password2RegTxt.Text = "Confirm password";
            this.password2RegTxt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.password2RegTxt_MouseClick);
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.SystemColors.Window;
            this.loginPanel.Controls.Add(this.thinLineOne);
            this.loginPanel.Controls.Add(this.usernameLogTxt);
            this.loginPanel.Location = new System.Drawing.Point(122, 231);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(149, 34);
            this.loginPanel.TabIndex = 14;
            // 
            // thinLineOne
            // 
            this.thinLineOne.BackColor = System.Drawing.Color.DarkGray;
            this.thinLineOne.Location = new System.Drawing.Point(0, 33);
            this.thinLineOne.Name = "thinLineOne";
            this.thinLineOne.Size = new System.Drawing.Size(149, 1);
            this.thinLineOne.TabIndex = 15;
            // 
            // logPwdPanel
            // 
            this.logPwdPanel.BackColor = System.Drawing.SystemColors.Window;
            this.logPwdPanel.Controls.Add(this.passwordLogTxt);
            this.logPwdPanel.Controls.Add(this.thinLinetwo);
            this.logPwdPanel.Location = new System.Drawing.Point(122, 302);
            this.logPwdPanel.Name = "logPwdPanel";
            this.logPwdPanel.Size = new System.Drawing.Size(149, 34);
            this.logPwdPanel.TabIndex = 15;
            // 
            // thinLinetwo
            // 
            this.thinLinetwo.BackColor = System.Drawing.Color.DarkGray;
            this.thinLinetwo.Location = new System.Drawing.Point(0, 33);
            this.thinLinetwo.Name = "thinLinetwo";
            this.thinLinetwo.Size = new System.Drawing.Size(149, 1);
            this.thinLinetwo.TabIndex = 16;
            // 
            // loginIcon
            // 
            this.loginIcon.Image = ((System.Drawing.Image)(resources.GetObject("loginIcon.Image")));
            this.loginIcon.Location = new System.Drawing.Point(122, 43);
            this.loginIcon.Name = "loginIcon";
            this.loginIcon.Size = new System.Drawing.Size(147, 163);
            this.loginIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loginIcon.TabIndex = 17;
            this.loginIcon.TabStop = false;
            // 
            // closeBtn
            // 
            this.closeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeBtn.BackgroundImage")));
            this.closeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeBtn.Location = new System.Drawing.Point(337, 13);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Padding = new System.Windows.Forms.Padding(5);
            this.closeBtn.Size = new System.Drawing.Size(12, 14);
            this.closeBtn.TabIndex = 18;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // dontHaveAccLbl
            // 
            this.dontHaveAccLbl.AutoSize = true;
            this.dontHaveAccLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dontHaveAccLbl.Location = new System.Drawing.Point(83, 476);
            this.dontHaveAccLbl.Name = "dontHaveAccLbl";
            this.dontHaveAccLbl.Size = new System.Drawing.Size(138, 15);
            this.dontHaveAccLbl.TabIndex = 19;
            this.dontHaveAccLbl.Text = "Don\'t have an account? ";
            // 
            // registerHereLbl
            // 
            this.registerHereLbl.AutoSize = true;
            this.registerHereLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerHereLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerHereLbl.ForeColor = System.Drawing.Color.Brown;
            this.registerHereLbl.Location = new System.Drawing.Point(216, 478);
            this.registerHereLbl.Name = "registerHereLbl";
            this.registerHereLbl.Size = new System.Drawing.Size(83, 13);
            this.registerHereLbl.TabIndex = 20;
            this.registerHereLbl.Text = "Register here";
            this.registerHereLbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // alreadyRegLbl
            // 
            this.alreadyRegLbl.AutoSize = true;
            this.alreadyRegLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.alreadyRegLbl.Location = new System.Drawing.Point(83, 476);
            this.alreadyRegLbl.Name = "alreadyRegLbl";
            this.alreadyRegLbl.Size = new System.Drawing.Size(112, 15);
            this.alreadyRegLbl.TabIndex = 21;
            this.alreadyRegLbl.Text = "Already registered?";
            this.alreadyRegLbl.Visible = false;
            // 
            // loginHereLbl
            // 
            this.loginHereLbl.AutoSize = true;
            this.loginHereLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginHereLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginHereLbl.ForeColor = System.Drawing.Color.Brown;
            this.loginHereLbl.Location = new System.Drawing.Point(201, 478);
            this.loginHereLbl.Name = "loginHereLbl";
            this.loginHereLbl.Size = new System.Drawing.Size(69, 13);
            this.loginHereLbl.TabIndex = 22;
            this.loginHereLbl.Text = "Login Here";
            this.loginHereLbl.Visible = false;
            this.loginHereLbl.Click += new System.EventHandler(this.loginHereLbl_Click);
            // 
            // fullNamePanel
            // 
            this.fullNamePanel.BackColor = System.Drawing.SystemColors.Window;
            this.fullNamePanel.Controls.Add(this.bottomLineP1);
            this.fullNamePanel.Controls.Add(this.fullNameRegTxt);
            this.fullNamePanel.Location = new System.Drawing.Point(41, 224);
            this.fullNamePanel.Name = "fullNamePanel";
            this.fullNamePanel.Size = new System.Drawing.Size(149, 34);
            this.fullNamePanel.TabIndex = 16;
            this.fullNamePanel.Visible = false;
            // 
            // bottomLineP1
            // 
            this.bottomLineP1.BackColor = System.Drawing.Color.DarkGray;
            this.bottomLineP1.Location = new System.Drawing.Point(0, 33);
            this.bottomLineP1.Name = "bottomLineP1";
            this.bottomLineP1.Size = new System.Drawing.Size(149, 1);
            this.bottomLineP1.TabIndex = 15;
            // 
            // usernamePanel
            // 
            this.usernamePanel.BackColor = System.Drawing.SystemColors.Window;
            this.usernamePanel.Controls.Add(this.bottomLineP2);
            this.usernamePanel.Controls.Add(this.usernameRegTxt);
            this.usernamePanel.Location = new System.Drawing.Point(200, 224);
            this.usernamePanel.Name = "usernamePanel";
            this.usernamePanel.Size = new System.Drawing.Size(149, 34);
            this.usernamePanel.TabIndex = 17;
            this.usernamePanel.Visible = false;
            // 
            // bottomLineP2
            // 
            this.bottomLineP2.BackColor = System.Drawing.Color.DarkGray;
            this.bottomLineP2.Location = new System.Drawing.Point(0, 33);
            this.bottomLineP2.Name = "bottomLineP2";
            this.bottomLineP2.Size = new System.Drawing.Size(149, 1);
            this.bottomLineP2.TabIndex = 15;
            // 
            // pwdPanel
            // 
            this.pwdPanel.BackColor = System.Drawing.SystemColors.Window;
            this.pwdPanel.Controls.Add(this.bottomLineP3);
            this.pwdPanel.Controls.Add(this.passwordRegTxt);
            this.pwdPanel.Location = new System.Drawing.Point(41, 296);
            this.pwdPanel.Name = "pwdPanel";
            this.pwdPanel.Size = new System.Drawing.Size(149, 34);
            this.pwdPanel.TabIndex = 17;
            this.pwdPanel.Visible = false;
            // 
            // bottomLineP3
            // 
            this.bottomLineP3.BackColor = System.Drawing.Color.DarkGray;
            this.bottomLineP3.Location = new System.Drawing.Point(0, 33);
            this.bottomLineP3.Name = "bottomLineP3";
            this.bottomLineP3.Size = new System.Drawing.Size(149, 1);
            this.bottomLineP3.TabIndex = 15;
            // 
            // pwd2Panel
            // 
            this.pwd2Panel.BackColor = System.Drawing.SystemColors.Window;
            this.pwd2Panel.Controls.Add(this.bottomLineP14);
            this.pwd2Panel.Controls.Add(this.password2RegTxt);
            this.pwd2Panel.Location = new System.Drawing.Point(196, 296);
            this.pwd2Panel.Name = "pwd2Panel";
            this.pwd2Panel.Size = new System.Drawing.Size(149, 34);
            this.pwd2Panel.TabIndex = 17;
            this.pwd2Panel.Visible = false;
            // 
            // bottomLineP14
            // 
            this.bottomLineP14.BackColor = System.Drawing.Color.DarkGray;
            this.bottomLineP14.Location = new System.Drawing.Point(0, 33);
            this.bottomLineP14.Name = "bottomLineP14";
            this.bottomLineP14.Size = new System.Drawing.Size(149, 1);
            this.bottomLineP14.TabIndex = 15;
            // 
            // registerIcon
            // 
            this.registerIcon.Image = ((System.Drawing.Image)(resources.GetObject("registerIcon.Image")));
            this.registerIcon.Location = new System.Drawing.Point(122, 43);
            this.registerIcon.Name = "registerIcon";
            this.registerIcon.Size = new System.Drawing.Size(147, 163);
            this.registerIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.registerIcon.TabIndex = 23;
            this.registerIcon.TabStop = false;
            // 
            // LoginRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(177)))), ((int)(((byte)(160)))));
            this.ClientSize = new System.Drawing.Size(373, 551);
            this.Controls.Add(this.registerIcon);
            this.Controls.Add(this.pwd2Panel);
            this.Controls.Add(this.pwdPanel);
            this.Controls.Add(this.usernamePanel);
            this.Controls.Add(this.fullNamePanel);
            this.Controls.Add(this.loginHereLbl);
            this.Controls.Add(this.alreadyRegLbl);
            this.Controls.Add(this.registerHereLbl);
            this.Controls.Add(this.dontHaveAccLbl);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.loginIcon);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.logPwdPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginRegister";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Activated += new System.EventHandler(this.LoginRegister_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginRegister_FormClosed);
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.logPwdPanel.ResumeLayout(false);
            this.logPwdPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginIcon)).EndInit();
            this.fullNamePanel.ResumeLayout(false);
            this.fullNamePanel.PerformLayout();
            this.usernamePanel.ResumeLayout(false);
            this.usernamePanel.PerformLayout();
            this.pwdPanel.ResumeLayout(false);
            this.pwdPanel.PerformLayout();
            this.pwd2Panel.ResumeLayout(false);
            this.pwd2Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registerIcon)).EndInit();
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
        private System.Windows.Forms.TextBox password2RegTxt;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Panel thinLineOne;
        private System.Windows.Forms.Panel logPwdPanel;
        private System.Windows.Forms.Panel thinLinetwo;
        private System.Windows.Forms.PictureBox loginIcon;
        private System.Windows.Forms.Panel closeBtn;
        private System.Windows.Forms.Label dontHaveAccLbl;
        private System.Windows.Forms.Label registerHereLbl;
        private System.Windows.Forms.Label alreadyRegLbl;
        private System.Windows.Forms.Label loginHereLbl;
        private System.Windows.Forms.Panel fullNamePanel;
        private System.Windows.Forms.Panel bottomLineP1;
        private System.Windows.Forms.Panel usernamePanel;
        private System.Windows.Forms.Panel bottomLineP2;
        private System.Windows.Forms.Panel pwdPanel;
        private System.Windows.Forms.Panel bottomLineP3;
        private System.Windows.Forms.Panel pwd2Panel;
        private System.Windows.Forms.Panel bottomLineP14;
        private System.Windows.Forms.PictureBox registerIcon;
    }
}