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
            ((System.ComponentModel.ISupportInitialize)(this.transactionAmountNum)).BeginInit();
            this.SuspendLayout();
            // 
            // expenseRadio
            // 
            this.expenseRadio.AutoSize = true;
            this.expenseRadio.Location = new System.Drawing.Point(548, 223);
            this.expenseRadio.Name = "expenseRadio";
            this.expenseRadio.Size = new System.Drawing.Size(127, 29);
            this.expenseRadio.TabIndex = 8;
            this.expenseRadio.Text = "Expense";
            this.expenseRadio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category";
            // 
            // categoryTxt
            // 
            this.categoryTxt.Location = new System.Drawing.Point(196, 87);
            this.categoryTxt.Name = "categoryTxt";
            this.categoryTxt.Size = new System.Drawing.Size(100, 31);
            this.categoryTxt.TabIndex = 1;
            // 
            // amountLbl
            // 
            this.amountLbl.AutoSize = true;
            this.amountLbl.Location = new System.Drawing.Point(201, 166);
            this.amountLbl.Name = "amountLbl";
            this.amountLbl.Size = new System.Drawing.Size(85, 25);
            this.amountLbl.TabIndex = 2;
            this.amountLbl.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Date of the transaction";
            // 
            // transDateTime
            // 
            this.transDateTime.CustomFormat = "dd/MM/yyyy HH:mm";
            this.transDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.transDateTime.Location = new System.Drawing.Point(196, 357);
            this.transDateTime.Name = "transDateTime";
            this.transDateTime.Size = new System.Drawing.Size(242, 31);
            this.transDateTime.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Income or Expense ?";
            // 
            // incomeRadio
            // 
            this.incomeRadio.AutoSize = true;
            this.incomeRadio.Checked = true;
            this.incomeRadio.Location = new System.Drawing.Point(417, 223);
            this.incomeRadio.Name = "incomeRadio";
            this.incomeRadio.Size = new System.Drawing.Size(112, 29);
            this.incomeRadio.TabIndex = 7;
            this.incomeRadio.TabStop = true;
            this.incomeRadio.Text = "Income";
            this.incomeRadio.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 428);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Description";
            // 
            // messageRichTetx
            // 
            this.messageRichTetx.Location = new System.Drawing.Point(201, 485);
            this.messageRichTetx.Name = "messageRichTetx";
            this.messageRichTetx.Size = new System.Drawing.Size(464, 137);
            this.messageRichTetx.TabIndex = 10;
            this.messageRichTetx.Text = "";
            // 
            // actionBtn
            // 
            this.actionBtn.Location = new System.Drawing.Point(201, 652);
            this.actionBtn.Name = "actionBtn";
            this.actionBtn.Size = new System.Drawing.Size(146, 82);
            this.actionBtn.TabIndex = 11;
            this.actionBtn.Text = "Action";
            this.actionBtn.UseVisualStyleBackColor = true;
            this.actionBtn.Click += new System.EventHandler(this.actionBtn_Click);
            // 
            // transactionAmountNum
            // 
            this.transactionAmountNum.Location = new System.Drawing.Point(196, 221);
            this.transactionAmountNum.Name = "transactionAmountNum";
            this.transactionAmountNum.Size = new System.Drawing.Size(120, 31);
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
            this.label5.Location = new System.Drawing.Point(438, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Assigned contact";
            // 
            // contactComboBox
            // 
            this.contactComboBox.FormattingEnabled = true;
            this.contactComboBox.Location = new System.Drawing.Point(443, 85);
            this.contactComboBox.Name = "contactComboBox";
            this.contactComboBox.Size = new System.Drawing.Size(121, 33);
            this.contactComboBox.TabIndex = 15;
            // 
            // TransactionAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 854);
            this.Controls.Add(this.contactComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.transactionAmountNum);
            this.Controls.Add(this.actionBtn);
            this.Controls.Add(this.messageRichTetx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.expenseRadio);
            this.Controls.Add(this.incomeRadio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.transDateTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.amountLbl);
            this.Controls.Add(this.categoryTxt);
            this.Controls.Add(this.label1);
            this.Name = "TransactionAddEdit";
            this.Text = "TransactionAddEdit";
            this.Load += new System.EventHandler(this.TransactionAddEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transactionAmountNum)).EndInit();
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
    }
}