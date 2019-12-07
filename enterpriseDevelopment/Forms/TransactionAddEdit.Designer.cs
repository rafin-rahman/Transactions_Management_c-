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
            ((System.ComponentModel.ISupportInitialize)(this.transactionAmountNum)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // expenseRadio
            // 
            this.expenseRadio.AutoSize = true;
            this.expenseRadio.Location = new System.Drawing.Point(90, 18);
            this.expenseRadio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.expenseRadio.Name = "expenseRadio";
            this.expenseRadio.Size = new System.Drawing.Size(66, 17);
            this.expenseRadio.TabIndex = 8;
            this.expenseRadio.Text = "Expense";
            this.expenseRadio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category";
            // 
            // categoryTxt
            // 
            this.categoryTxt.Location = new System.Drawing.Point(98, 45);
            this.categoryTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.categoryTxt.Name = "categoryTxt";
            this.categoryTxt.Size = new System.Drawing.Size(52, 20);
            this.categoryTxt.TabIndex = 1;
            // 
            // amountLbl
            // 
            this.amountLbl.AutoSize = true;
            this.amountLbl.Location = new System.Drawing.Point(100, 86);
            this.amountLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.amountLbl.Name = "amountLbl";
            this.amountLbl.Size = new System.Drawing.Size(43, 13);
            this.amountLbl.TabIndex = 2;
            this.amountLbl.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 159);
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
            this.transDateTime.Location = new System.Drawing.Point(98, 186);
            this.transDateTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.transDateTime.Name = "transDateTime";
            this.transDateTime.Size = new System.Drawing.Size(123, 20);
            this.transDateTime.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 86);
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
            this.incomeRadio.Location = new System.Drawing.Point(17, 18);
            this.incomeRadio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.incomeRadio.Name = "incomeRadio";
            this.incomeRadio.Size = new System.Drawing.Size(60, 17);
            this.incomeRadio.TabIndex = 7;
            this.incomeRadio.TabStop = true;
            this.incomeRadio.Text = "Income";
            this.incomeRadio.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 223);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Description";
            // 
            // messageRichTetx
            // 
            this.messageRichTetx.Location = new System.Drawing.Point(100, 252);
            this.messageRichTetx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.messageRichTetx.Name = "messageRichTetx";
            this.messageRichTetx.Size = new System.Drawing.Size(234, 73);
            this.messageRichTetx.TabIndex = 10;
            this.messageRichTetx.Text = "";
            // 
            // actionBtn
            // 
            this.actionBtn.Location = new System.Drawing.Point(100, 339);
            this.actionBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.actionBtn.Name = "actionBtn";
            this.actionBtn.Size = new System.Drawing.Size(73, 43);
            this.actionBtn.TabIndex = 11;
            this.actionBtn.Text = "Action";
            this.actionBtn.UseVisualStyleBackColor = true;
            this.actionBtn.Click += new System.EventHandler(this.actionBtn_Click);
            // 
            // transactionAmountNum
            // 
            this.transactionAmountNum.Location = new System.Drawing.Point(98, 115);
            this.transactionAmountNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.transactionAmountNum.Name = "transactionAmountNum";
            this.transactionAmountNum.Size = new System.Drawing.Size(60, 20);
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
            this.label5.Location = new System.Drawing.Point(219, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Assigned contact";
            // 
            // contactComboBox
            // 
            this.contactComboBox.FormattingEnabled = true;
            this.contactComboBox.Location = new System.Drawing.Point(222, 44);
            this.contactComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.contactComboBox.Name = "contactComboBox";
            this.contactComboBox.Size = new System.Drawing.Size(62, 21);
            this.contactComboBox.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.incomeRadio);
            this.panel1.Controls.Add(this.expenseRadio);
            this.panel1.Location = new System.Drawing.Point(196, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 52);
            this.panel1.TabIndex = 16;
            // 
            // TransactionAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 444);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TransactionAddEdit";
            this.Text = "TransactionAddEdit";
            this.Load += new System.EventHandler(this.TransactionAddEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transactionAmountNum)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
    }
}