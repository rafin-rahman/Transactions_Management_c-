namespace enterpriseDevelopment.Forms
{
    partial class TransactionAddEdit
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
            this.expenseRadio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.categoryTxt = new System.Windows.Forms.TextBox();
            this.amountLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.transDateTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.incomeRadio = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.messageRichTetx = new System.Windows.Forms.RichTextBox();
            this.actionBtn = new System.Windows.Forms.Button();
            this.transactionAmountNum = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.contactComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.recurrCheck = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.periodCombo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.noTimeLimit = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.closePanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.transactionAmountNum)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // expenseRadio
            // 
            this.expenseRadio.AutoSize = true;
            this.expenseRadio.FlatAppearance.BorderSize = 3;
            this.expenseRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expenseRadio.Location = new System.Drawing.Point(90, 18);
            this.expenseRadio.Margin = new System.Windows.Forms.Padding(2);
            this.expenseRadio.Name = "expenseRadio";
            this.expenseRadio.Size = new System.Drawing.Size(65, 17);
            this.expenseRadio.TabIndex = 8;
            this.expenseRadio.Text = "Expense";
            this.expenseRadio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category";
            // 
            // categoryTxt
            // 
            this.categoryTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.categoryTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.categoryTxt.Location = new System.Drawing.Point(267, 128);
            this.categoryTxt.Margin = new System.Windows.Forms.Padding(2);
            this.categoryTxt.Name = "categoryTxt";
            this.categoryTxt.Size = new System.Drawing.Size(52, 13);
            this.categoryTxt.TabIndex = 1;
            // 
            // amountLbl
            // 
            this.amountLbl.AutoSize = true;
            this.amountLbl.Location = new System.Drawing.Point(269, 169);
            this.amountLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.amountLbl.Name = "amountLbl";
            this.amountLbl.Size = new System.Drawing.Size(43, 13);
            this.amountLbl.TabIndex = 2;
            this.amountLbl.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 242);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Date of the transaction";
            // 
            // transDateTime
            // 
            this.transDateTime.CustomFormat = "dd/MM/yyyy HH:mm";
            this.transDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.transDateTime.Location = new System.Drawing.Point(267, 269);
            this.transDateTime.Margin = new System.Windows.Forms.Padding(2);
            this.transDateTime.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.transDateTime.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.transDateTime.Name = "transDateTime";
            this.transDateTime.Size = new System.Drawing.Size(123, 20);
            this.transDateTime.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Income or Expense ?";
            // 
            // incomeRadio
            // 
            this.incomeRadio.AutoSize = true;
            this.incomeRadio.Checked = true;
            this.incomeRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.incomeRadio.Location = new System.Drawing.Point(17, 18);
            this.incomeRadio.Margin = new System.Windows.Forms.Padding(2);
            this.incomeRadio.Name = "incomeRadio";
            this.incomeRadio.Size = new System.Drawing.Size(59, 17);
            this.incomeRadio.TabIndex = 7;
            this.incomeRadio.TabStop = true;
            this.incomeRadio.Text = "Income";
            this.incomeRadio.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 306);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Description";
            // 
            // messageRichTetx
            // 
            this.messageRichTetx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.messageRichTetx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.messageRichTetx.Location = new System.Drawing.Point(269, 335);
            this.messageRichTetx.Margin = new System.Windows.Forms.Padding(2);
            this.messageRichTetx.Name = "messageRichTetx";
            this.messageRichTetx.Size = new System.Drawing.Size(234, 73);
            this.messageRichTetx.TabIndex = 10;
            this.messageRichTetx.Text = "";
            // 
            // actionBtn
            // 
            this.actionBtn.Location = new System.Drawing.Point(269, 422);
            this.actionBtn.Margin = new System.Windows.Forms.Padding(2);
            this.actionBtn.Name = "actionBtn";
            this.actionBtn.Size = new System.Drawing.Size(73, 43);
            this.actionBtn.TabIndex = 11;
            this.actionBtn.Text = "Action";
            this.actionBtn.UseVisualStyleBackColor = true;
            this.actionBtn.Click += new System.EventHandler(this.actionBtn_Click);
            // 
            // transactionAmountNum
            // 
            this.transactionAmountNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.transactionAmountNum.Location = new System.Drawing.Point(267, 198);
            this.transactionAmountNum.Margin = new System.Windows.Forms.Padding(2);
            this.transactionAmountNum.Name = "transactionAmountNum";
            this.transactionAmountNum.Size = new System.Drawing.Size(60, 16);
            this.transactionAmountNum.TabIndex = 12;
            this.transactionAmountNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(388, 106);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Assigned contact";
            // 
            // contactComboBox
            // 
            this.contactComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.contactComboBox.FormattingEnabled = true;
            this.contactComboBox.Location = new System.Drawing.Point(391, 127);
            this.contactComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.contactComboBox.Name = "contactComboBox";
            this.contactComboBox.Size = new System.Drawing.Size(62, 21);
            this.contactComboBox.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.incomeRadio);
            this.panel1.Controls.Add(this.expenseRadio);
            this.panel1.Location = new System.Drawing.Point(365, 198);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 52);
            this.panel1.TabIndex = 16;
            // 
            // recurrCheck
            // 
            this.recurrCheck.AutoSize = true;
            this.recurrCheck.Location = new System.Drawing.Point(407, 271);
            this.recurrCheck.Margin = new System.Windows.Forms.Padding(2);
            this.recurrCheck.Name = "recurrCheck";
            this.recurrCheck.Size = new System.Drawing.Size(131, 17);
            this.recurrCheck.TabIndex = 17;
            this.recurrCheck.Text = "Recurring Transaction";
            this.recurrCheck.UseVisualStyleBackColor = true;
            this.recurrCheck.CheckedChanged += new System.EventHandler(this.recurrCheck_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.periodCombo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.noTimeLimit);
            this.groupBox1.Location = new System.Drawing.Point(545, 267);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(188, 156);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Option";
            this.groupBox1.Visible = false;
            // 
            // periodCombo
            // 
            this.periodCombo.FormattingEnabled = true;
            this.periodCombo.Items.AddRange(new object[] {
            "Daily",
            "Weekly",
            "Monthly",
            "Yearly"});
            this.periodCombo.Location = new System.Drawing.Point(54, 35);
            this.periodCombo.Margin = new System.Windows.Forms.Padding(2);
            this.periodCombo.Name = "periodCombo";
            this.periodCombo.Size = new System.Drawing.Size(62, 21);
            this.periodCombo.TabIndex = 5;
            this.periodCombo.Text = "Daily";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 64);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "End time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Period";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(21, 81);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(156, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // noTimeLimit
            // 
            this.noTimeLimit.AutoSize = true;
            this.noTimeLimit.Location = new System.Drawing.Point(54, 127);
            this.noTimeLimit.Margin = new System.Windows.Forms.Padding(2);
            this.noTimeLimit.Name = "noTimeLimit";
            this.noTimeLimit.Size = new System.Drawing.Size(69, 17);
            this.noTimeLimit.TabIndex = 1;
            this.noTimeLimit.Text = "Unlimited";
            this.noTimeLimit.UseVisualStyleBackColor = true;
            this.noTimeLimit.CheckedChanged += new System.EventHandler(this.noTimeLimit_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.closePanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1009, 48);
            this.panel2.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label9.Location = new System.Drawing.Point(357, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(295, 37);
            this.label9.TabIndex = 1;
            this.label9.Text = "ADD A NEW EVENT";
            // 
            // closePanel
            // 
            this.closePanel.BackgroundImage = global::enterpriseDevelopment.Properties.Resources.close;
            this.closePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closePanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closePanel.Location = new System.Drawing.Point(970, 7);
            this.closePanel.Margin = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.closePanel.Name = "closePanel";
            this.closePanel.Padding = new System.Windows.Forms.Padding(5);
            this.closePanel.Size = new System.Drawing.Size(32, 30);
            this.closePanel.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.button1.Location = new System.Drawing.Point(31, 481);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(932, 51);
            this.button1.TabIndex = 20;
            this.button1.Text = "Action";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // TransactionAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1009, 558);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.recurrCheck);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.contactComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.transactionAmountNum);
            this.Controls.Add(this.actionBtn);
            this.Controls.Add(this.messageRichTetx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.transDateTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.amountLbl);
            this.Controls.Add(this.categoryTxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TransactionAddEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TransactionAddEdit";
            this.Load += new System.EventHandler(this.TransactionAddEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transactionAmountNum)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox categoryTxt;
        private System.Windows.Forms.Label amountLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker transDateTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton incomeRadio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox messageRichTetx;
        private System.Windows.Forms.Button actionBtn;
        private System.Windows.Forms.NumericUpDown transactionAmountNum;
        private System.Windows.Forms.RadioButton expenseRadio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox contactComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox recurrCheck;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox noTimeLimit;
        private System.Windows.Forms.ComboBox periodCombo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel closePanel;
        private System.Windows.Forms.Button button1;
    }
}