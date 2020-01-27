namespace enterpriseDevelopment.Forms
{
    partial class NotificationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotificationForm));
            this.closeLbl = new System.Windows.Forms.Label();
            this.darkGreyPanel = new System.Windows.Forms.Panel();
            this.headerLbl = new System.Windows.Forms.Label();
            this.bgWorkerNotification = new System.ComponentModel.BackgroundWorker();
            this.messageLbl = new System.Windows.Forms.Label();
            this.darkGreyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeLbl
            // 
            this.closeLbl.AutoSize = true;
            this.closeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.closeLbl.Location = new System.Drawing.Point(22, 16);
            this.closeLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.closeLbl.Name = "closeLbl";
            this.closeLbl.Size = new System.Drawing.Size(36, 36);
            this.closeLbl.TabIndex = 0;
            this.closeLbl.Text = "X";
            this.closeLbl.Click += new System.EventHandler(this.notificationClose_Click);
            // 
            // darkGreyPanel
            // 
            this.darkGreyPanel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.darkGreyPanel.Controls.Add(this.closeLbl);
            this.darkGreyPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.darkGreyPanel.Location = new System.Drawing.Point(347, 0);
            this.darkGreyPanel.Margin = new System.Windows.Forms.Padding(2);
            this.darkGreyPanel.Name = "darkGreyPanel";
            this.darkGreyPanel.Size = new System.Drawing.Size(69, 69);
            this.darkGreyPanel.TabIndex = 1;
            // 
            // headerLbl
            // 
            this.headerLbl.AutoSize = true;
            this.headerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.headerLbl.Location = new System.Drawing.Point(2, 16);
            this.headerLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.headerLbl.Name = "headerLbl";
            this.headerLbl.Size = new System.Drawing.Size(99, 36);
            this.headerLbl.TabIndex = 2;
            this.headerLbl.Text = "OPEN";
            this.headerLbl.Visible = false;
            this.headerLbl.MouseEnter += new System.EventHandler(this.headerLbl_MouseEnter);
            this.headerLbl.MouseHover += new System.EventHandler(this.headerLbl_MouseHover);
            // 
            // bgWorkerNotification
            // 
            this.bgWorkerNotification.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorkerNotification_DoWork);
            this.bgWorkerNotification.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorkerNotification_RunWorkerCompleted);
            // 
            // messageLbl
            // 
            this.messageLbl.AutoSize = true;
            this.messageLbl.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.messageLbl.Location = new System.Drawing.Point(102, 20);
            this.messageLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.messageLbl.Name = "messageLbl";
            this.messageLbl.Size = new System.Drawing.Size(218, 29);
            this.messageLbl.TabIndex = 3;
            this.messageLbl.Text = "NEW TRANSACTION!";
            // 
            // NotificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(416, 69);
            this.Controls.Add(this.messageLbl);
            this.Controls.Add(this.headerLbl);
            this.Controls.Add(this.darkGreyPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NotificationForm";
            this.Text = "NotificationForm";
            this.Load += new System.EventHandler(this.NotificationForm_Load);
            this.MouseEnter += new System.EventHandler(this.NotificationForm_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.NotificationForm_MouseLeave);
            this.MouseHover += new System.EventHandler(this.NotificationForm_MouseHover);
            this.darkGreyPanel.ResumeLayout(false);
            this.darkGreyPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label closeLbl;
        private System.Windows.Forms.Panel darkGreyPanel;
        private System.Windows.Forms.Label headerLbl;
        private System.ComponentModel.BackgroundWorker bgWorkerNotification;
        private System.Windows.Forms.Label messageLbl;
    }
}