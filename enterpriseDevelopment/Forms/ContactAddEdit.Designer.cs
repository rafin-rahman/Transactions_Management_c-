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
            this.label1 = new System.Windows.Forms.Label();
            this.actionBtn = new System.Windows.Forms.Button();
            this.contactTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // actionBtn
            // 
            this.actionBtn.Location = new System.Drawing.Point(240, 218);
            this.actionBtn.Name = "actionBtn";
            this.actionBtn.Size = new System.Drawing.Size(100, 64);
            this.actionBtn.TabIndex = 1;
            this.actionBtn.Text = "Action";
            this.actionBtn.UseVisualStyleBackColor = true;
            this.actionBtn.Click += new System.EventHandler(this.actionBtn_Click);
            // 
            // contactTxtBox
            // 
            this.contactTxtBox.Location = new System.Drawing.Point(240, 170);
            this.contactTxtBox.Name = "contactTxtBox";
            this.contactTxtBox.Size = new System.Drawing.Size(100, 31);
            this.contactTxtBox.TabIndex = 2;
            // 
            // ContactAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 899);
            this.Controls.Add(this.contactTxtBox);
            this.Controls.Add(this.actionBtn);
            this.Controls.Add(this.label1);
            this.Name = "ContactAddEdit";
            this.Text = "ContactAddEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button actionBtn;
        private System.Windows.Forms.TextBox contactTxtBox;
    }
}