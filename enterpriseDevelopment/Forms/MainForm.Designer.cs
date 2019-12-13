namespace enterpriseDevelopment
{
    partial class MainForm
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
            this.ContactBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.transactionBtn = new System.Windows.Forms.Button();
            this.eventsBtn = new System.Windows.Forms.Button();
            this.repeatBtn = new System.Windows.Forms.Button();
            this.eventsRepeatBtn = new System.Windows.Forms.Button();
            this.summaryBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ContactBtn
            // 
            this.ContactBtn.Location = new System.Drawing.Point(1300, 225);
            this.ContactBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ContactBtn.Name = "ContactBtn";
            this.ContactBtn.Size = new System.Drawing.Size(244, 65);
            this.ContactBtn.TabIndex = 0;
            this.ContactBtn.Text = "Contact";
            this.ContactBtn.UseVisualStyleBackColor = true;
            this.ContactBtn.Click += new System.EventHandler(this.contactClickMainForm);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(76)))), ((int)(((byte)(96)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 1154);
            this.panel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Cambria Math", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(400, 179);
            this.button2.TabIndex = 4;
            this.button2.Text = "Main page";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(153)))), ((int)(((byte)(162)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(408, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1640, 37);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(153)))), ((int)(((byte)(162)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(508, 23);
            this.panel3.Margin = new System.Windows.Forms.Padding(6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(236, 248);
            this.panel3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(68, 196);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "schedule";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Track and";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::enterpriseDevelopment.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(52, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // transactionBtn
            // 
            this.transactionBtn.Location = new System.Drawing.Point(1300, 350);
            this.transactionBtn.Margin = new System.Windows.Forms.Padding(4);
            this.transactionBtn.Name = "transactionBtn";
            this.transactionBtn.Size = new System.Drawing.Size(244, 71);
            this.transactionBtn.TabIndex = 5;
            this.transactionBtn.Text = "Transactions";
            this.transactionBtn.UseVisualStyleBackColor = true;
            this.transactionBtn.Click += new System.EventHandler(this.transactionClickMainForm);
            // 
            // eventsBtn
            // 
            this.eventsBtn.Location = new System.Drawing.Point(1300, 466);
            this.eventsBtn.Margin = new System.Windows.Forms.Padding(6);
            this.eventsBtn.Name = "eventsBtn";
            this.eventsBtn.Size = new System.Drawing.Size(244, 75);
            this.eventsBtn.TabIndex = 6;
            this.eventsBtn.Text = "Events";
            this.eventsBtn.UseVisualStyleBackColor = true;
            this.eventsBtn.Click += new System.EventHandler(this.event_Click);
            // 
            // repeatBtn
            // 
            this.repeatBtn.Location = new System.Drawing.Point(1027, 350);
            this.repeatBtn.Name = "repeatBtn";
            this.repeatBtn.Size = new System.Drawing.Size(244, 70);
            this.repeatBtn.TabIndex = 7;
            this.repeatBtn.Text = "Recurring Transaction";
            this.repeatBtn.UseVisualStyleBackColor = true;
            this.repeatBtn.Click += new System.EventHandler(this.repeatBtn_Click);
            // 
            // eventsRepeatBtn
            // 
            this.eventsRepeatBtn.Location = new System.Drawing.Point(1027, 466);
            this.eventsRepeatBtn.Margin = new System.Windows.Forms.Padding(6);
            this.eventsRepeatBtn.Name = "eventsRepeatBtn";
            this.eventsRepeatBtn.Size = new System.Drawing.Size(244, 75);
            this.eventsRepeatBtn.TabIndex = 8;
            this.eventsRepeatBtn.Text = "Recurring Events";
            this.eventsRepeatBtn.UseVisualStyleBackColor = true;
            this.eventsRepeatBtn.Click += new System.EventHandler(this.eventRecurring_Click);
            // 
            // summaryBtn
            // 
            this.summaryBtn.Location = new System.Drawing.Point(1300, 584);
            this.summaryBtn.Name = "summaryBtn";
            this.summaryBtn.Size = new System.Drawing.Size(244, 78);
            this.summaryBtn.TabIndex = 9;
            this.summaryBtn.Text = "Summary";
            this.summaryBtn.UseVisualStyleBackColor = true;
            this.summaryBtn.Click += new System.EventHandler(this.summaryBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2048, 1154);
            this.Controls.Add(this.summaryBtn);
            this.Controls.Add(this.eventsRepeatBtn);
            this.Controls.Add(this.repeatBtn);
            this.Controls.Add(this.eventsBtn);
            this.Controls.Add(this.transactionBtn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ContactBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ContactBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button transactionBtn;
        private System.Windows.Forms.Button eventsBtn;
        private System.Windows.Forms.Button repeatBtn;
        private System.Windows.Forms.Button eventsRepeatBtn;
        private System.Windows.Forms.Button summaryBtn;
    }
}

