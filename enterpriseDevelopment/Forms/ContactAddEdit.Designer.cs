namespace enterpriseDevelopment
{
    partial class ContactAddEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactAddEdit));
            this.titleLbl = new System.Windows.Forms.Label();
            this.actionBtn = new System.Windows.Forms.Button();
            this.contactTxtBox = new System.Windows.Forms.TextBox();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.headerLbl = new System.Windows.Forms.Label();
            this.closePanel = new System.Windows.Forms.Panel();
            this.iconImg = new System.Windows.Forms.PictureBox();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconImg)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold);
            this.titleLbl.Location = new System.Drawing.Point(368, 378);
            this.titleLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(259, 36);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Insert contact name";
            // 
            // actionBtn
            // 
            this.actionBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.actionBtn.FlatAppearance.BorderSize = 0;
            this.actionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actionBtn.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.actionBtn.ForeColor = System.Drawing.Color.White;
            this.actionBtn.Location = new System.Drawing.Point(106, 506);
            this.actionBtn.Margin = new System.Windows.Forms.Padding(2);
            this.actionBtn.Name = "actionBtn";
            this.actionBtn.Size = new System.Drawing.Size(778, 47);
            this.actionBtn.TabIndex = 1;
            this.actionBtn.Text = "Action";
            this.actionBtn.UseVisualStyleBackColor = false;
            this.actionBtn.Click += new System.EventHandler(this.actionBtn_Click);
            // 
            // contactTxtBox
            // 
            this.contactTxtBox.Location = new System.Drawing.Point(299, 447);
            this.contactTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.contactTxtBox.Name = "contactTxtBox";
            this.contactTxtBox.Size = new System.Drawing.Size(369, 20);
            this.contactTxtBox.TabIndex = 2;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.headerPanel.Controls.Add(this.headerLbl);
            this.headerPanel.Controls.Add(this.closePanel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.ImeMode = System.Windows.Forms.ImeMode.On;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1025, 48);
            this.headerPanel.TabIndex = 17;
            // 
            // headerLbl
            // 
            this.headerLbl.AutoSize = true;
            this.headerLbl.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold);
            this.headerLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.headerLbl.Location = new System.Drawing.Point(335, 7);
            this.headerLbl.Name = "headerLbl";
            this.headerLbl.Size = new System.Drawing.Size(333, 37);
            this.headerLbl.TabIndex = 1;
            this.headerLbl.Text = "ADD A NEW CONTACT";
            // 
            // closePanel
            // 
            this.closePanel.BackgroundImage = global::enterpriseDevelopment.Properties.Resources.backButton;
            this.closePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closePanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closePanel.Location = new System.Drawing.Point(970, 7);
            this.closePanel.Margin = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.closePanel.Name = "closePanel";
            this.closePanel.Padding = new System.Windows.Forms.Padding(5);
            this.closePanel.Size = new System.Drawing.Size(32, 30);
            this.closePanel.TabIndex = 0;
            this.closePanel.Click += new System.EventHandler(this.closePanel_Click);
            this.closePanel.MouseEnter += new System.EventHandler(this.closePanel_MouseEnter);
            this.closePanel.MouseLeave += new System.EventHandler(this.closePanel_MouseLeave);
            // 
            // iconImg
            // 
            this.iconImg.Image = ((System.Drawing.Image)(resources.GetObject("iconImg.Image")));
            this.iconImg.Location = new System.Drawing.Point(364, 83);
            this.iconImg.Name = "iconImg";
            this.iconImg.Size = new System.Drawing.Size(263, 235);
            this.iconImg.TabIndex = 18;
            this.iconImg.TabStop = false;
            // 
            // ContactAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 597);
            this.Controls.Add(this.iconImg);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.contactTxtBox);
            this.Controls.Add(this.actionBtn);
            this.Controls.Add(this.titleLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ContactAddEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContactAddEdit";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button actionBtn;
        private System.Windows.Forms.TextBox contactTxtBox;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label headerLbl;
        private System.Windows.Forms.Panel closePanel;
        private System.Windows.Forms.PictureBox iconImg;
    }
}