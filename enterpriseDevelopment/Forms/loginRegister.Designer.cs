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
            this.panel1 = new System.Windows.Forms.Panel();
            this.thinLineOne = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.thinLinetwo = new System.Windows.Forms.Panel();
            this.loginIcon = new System.Windows.Forms.PictureBox();
            this.closeBtn = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.registerIcon = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginIcon)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
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
            this.fullNameRegTxt.Text = "Your name";
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
            this.usernameRegTxt.Text = "Create username";
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
            this.passwordRegTxt.Text = "Create password..";
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
            this.password2RegTxt.Size = new System.Drawing.Size(122, 19);
            this.password2RegTxt.TabIndex = 12;
            this.password2RegTxt.Text = "Your password";
            this.password2RegTxt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.password2RegTxt_MouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.thinLineOne);
            this.panel1.Controls.Add(this.usernameLogTxt);
            this.panel1.Location = new System.Drawing.Point(122, 231);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 34);
            this.panel1.TabIndex = 14;
            // 
            // thinLineOne
            // 
            this.thinLineOne.BackColor = System.Drawing.Color.DarkGray;
            this.thinLineOne.Location = new System.Drawing.Point(0, 33);
            this.thinLineOne.Name = "thinLineOne";
            this.thinLineOne.Size = new System.Drawing.Size(149, 1);
            this.thinLineOne.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.Controls.Add(this.passwordLogTxt);
            this.panel3.Controls.Add(this.thinLinetwo);
            this.panel3.Location = new System.Drawing.Point(122, 302);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(149, 34);
            this.panel3.TabIndex = 15;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(83, 476);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Don\'t have an account? ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(216, 478);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Register here";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(83, 476);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Already registered?";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(201, 478);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Login Here";
            this.label4.Visible = false;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.fullNameRegTxt);
            this.panel2.Location = new System.Drawing.Point(41, 224);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(149, 34);
            this.panel2.TabIndex = 16;
            this.panel2.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.Location = new System.Drawing.Point(0, 33);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(149, 1);
            this.panel4.TabIndex = 15;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Window;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.usernameRegTxt);
            this.panel5.Location = new System.Drawing.Point(200, 224);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(149, 34);
            this.panel5.TabIndex = 17;
            this.panel5.Visible = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkGray;
            this.panel6.Location = new System.Drawing.Point(0, 33);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(149, 1);
            this.panel6.TabIndex = 15;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.Window;
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.passwordRegTxt);
            this.panel7.Location = new System.Drawing.Point(41, 296);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(149, 34);
            this.panel7.TabIndex = 17;
            this.panel7.Visible = false;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DarkGray;
            this.panel8.Location = new System.Drawing.Point(0, 33);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(149, 1);
            this.panel8.TabIndex = 15;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.Window;
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Controls.Add(this.password2RegTxt);
            this.panel9.Location = new System.Drawing.Point(196, 296);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(149, 34);
            this.panel9.TabIndex = 17;
            this.panel9.Visible = false;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.DarkGray;
            this.panel10.Location = new System.Drawing.Point(0, 33);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(149, 1);
            this.panel10.TabIndex = 15;
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
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.loginIcon);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginRegister";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Activated += new System.EventHandler(this.LoginRegister_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginRegister_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginIcon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel thinLineOne;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel thinLinetwo;
        private System.Windows.Forms.PictureBox loginIcon;
        private System.Windows.Forms.Panel closeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.PictureBox registerIcon;
    }
}