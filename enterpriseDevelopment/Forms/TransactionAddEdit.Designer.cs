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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionAddEdit));
            this.expenseRadio = new System.Windows.Forms.RadioButton();
            this.categoryTxt = new System.Windows.Forms.TextBox();
            this.transactionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.incomeRadio = new System.Windows.Forms.RadioButton();
            this.messageRichTetx = new System.Windows.Forms.RichTextBox();
            this.transactionAmount = new System.Windows.Forms.NumericUpDown();
            this.contactComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.expenseHighLight = new System.Windows.Forms.Panel();
            this.incomeHighLight = new System.Windows.Forms.Panel();
            this.recurrCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.periodCombo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.noTimeLimitCheckBox = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.closePanel = new System.Windows.Forms.Panel();
            this.actionBtn = new System.Windows.Forms.Button();
            this.categoryLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.transactionAmount)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.expenseRadio.CheckedChanged += new System.EventHandler(this.expenseRadio_CheckedChanged);
            // 
            // categoryTxt
            // 
            this.categoryTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.categoryTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.categoryTxt.Location = new System.Drawing.Point(5, 12);
            this.categoryTxt.Margin = new System.Windows.Forms.Padding(2);
            this.categoryTxt.Name = "categoryTxt";
            this.categoryTxt.Size = new System.Drawing.Size(118, 13);
            this.categoryTxt.TabIndex = 1;
            // 
            // transDateTime
            // 
            this.transactionDateTimePicker.CustomFormat = "dd/MM/yyyy HH:mm";
            this.transactionDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.transactionDateTimePicker.Location = new System.Drawing.Point(285, 271);
            this.transactionDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.transactionDateTimePicker.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.transactionDateTimePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.transactionDateTimePicker.Name = "transDateTime";
            this.transactionDateTimePicker.Size = new System.Drawing.Size(123, 20);
            this.transactionDateTimePicker.TabIndex = 5;
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
            this.incomeRadio.CheckedChanged += new System.EventHandler(this.incomeRadio_CheckedChanged);
            // 
            // messageRichTetx
            // 
            this.messageRichTetx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.messageRichTetx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.messageRichTetx.Location = new System.Drawing.Point(10, 10);
            this.messageRichTetx.Margin = new System.Windows.Forms.Padding(2);
            this.messageRichTetx.Name = "messageRichTetx";
            this.messageRichTetx.Size = new System.Drawing.Size(340, 111);
            this.messageRichTetx.TabIndex = 10;
            this.messageRichTetx.Text = "";
            // 
            // transactionAmount
            // 
            this.transactionAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.transactionAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.transactionAmount.DecimalPlaces = 2;
            this.transactionAmount.Location = new System.Drawing.Point(287, 204);
            this.transactionAmount.Margin = new System.Windows.Forms.Padding(5);
            this.transactionAmount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.transactionAmount.Name = "transactionAmount";
            this.transactionAmount.Size = new System.Drawing.Size(121, 16);
            this.transactionAmount.TabIndex = 12;
            this.transactionAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // contactComboBox
            // 
            this.contactComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.contactComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.contactComboBox.FormattingEnabled = true;
            this.contactComboBox.Location = new System.Drawing.Point(506, 116);
            this.contactComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.contactComboBox.Name = "contactComboBox";
            this.contactComboBox.Size = new System.Drawing.Size(172, 21);
            this.contactComboBox.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.expenseHighLight);
            this.panel1.Controls.Add(this.incomeHighLight);
            this.panel1.Controls.Add(this.incomeRadio);
            this.panel1.Controls.Add(this.expenseRadio);
            this.panel1.Location = new System.Drawing.Point(506, 204);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 52);
            this.panel1.TabIndex = 16;
            // 
            // expenseHighLight
            // 
            this.expenseHighLight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.expenseHighLight.Location = new System.Drawing.Point(110, 40);
            this.expenseHighLight.Name = "expenseHighLight";
            this.expenseHighLight.Size = new System.Drawing.Size(36, 3);
            this.expenseHighLight.TabIndex = 31;
            this.expenseHighLight.Visible = false;
            // 
            // incomeHighLight
            // 
            this.incomeHighLight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.incomeHighLight.Location = new System.Drawing.Point(35, 40);
            this.incomeHighLight.Name = "incomeHighLight";
            this.incomeHighLight.Size = new System.Drawing.Size(36, 3);
            this.incomeHighLight.TabIndex = 30;
            // 
            // recurrCheckBox
            // 
            this.recurrCheckBox.AutoSize = true;
            this.recurrCheckBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.recurrCheckBox.Location = new System.Drawing.Point(765, 90);
            this.recurrCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.recurrCheckBox.Name = "recurrCheckBox";
            this.recurrCheckBox.Size = new System.Drawing.Size(176, 23);
            this.recurrCheckBox.TabIndex = 17;
            this.recurrCheckBox.Text = "Recurring Transaction";
            this.recurrCheckBox.UseVisualStyleBackColor = true;
            this.recurrCheckBox.CheckedChanged += new System.EventHandler(this.recurrCheck_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.periodCombo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.noTimeLimitCheckBox);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(716, 127);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(247, 229);
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
            this.periodCombo.Location = new System.Drawing.Point(99, 48);
            this.periodCombo.Margin = new System.Windows.Forms.Padding(2);
            this.periodCombo.Name = "periodCombo";
            this.periodCombo.Size = new System.Drawing.Size(62, 27);
            this.periodCombo.TabIndex = 5;
            this.periodCombo.Text = "Daily";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(74, 110);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 36);
            this.label7.TabIndex = 4;
            this.label7.Text = "End time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(95, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 26);
            this.label6.TabIndex = 3;
            this.label6.Text = "Period";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(59, 148);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(156, 27);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // noTimeLimitCheckBox
            // 
            this.noTimeLimitCheckBox.AutoSize = true;
            this.noTimeLimitCheckBox.Location = new System.Drawing.Point(49, 179);
            this.noTimeLimitCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.noTimeLimitCheckBox.Name = "noTimeLimitCheckBox";
            this.noTimeLimitCheckBox.Size = new System.Drawing.Size(166, 23);
            this.noTimeLimitCheckBox.TabIndex = 1;
            this.noTimeLimitCheckBox.Text = "Set infinite duration";
            this.noTimeLimitCheckBox.UseVisualStyleBackColor = true;
            this.noTimeLimitCheckBox.CheckedChanged += new System.EventHandler(this.noTimeLimit_CheckedChanged);
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
            this.label9.Location = new System.Drawing.Point(323, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(410, 37);
            this.label9.TabIndex = 1;
            this.label9.Text = "ADD A NEW TRANSACTION";
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
            this.closePanel.Click += new System.EventHandler(this.closePanel_Click);
            this.closePanel.MouseEnter += new System.EventHandler(this.closePanel_MouseEnter);
            this.closePanel.MouseLeave += new System.EventHandler(this.closePanel_MouseLeave);
            // 
            // actionBtn
            // 
            this.actionBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.actionBtn.FlatAppearance.BorderSize = 0;
            this.actionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actionBtn.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionBtn.ForeColor = System.Drawing.Color.White;
            this.actionBtn.Location = new System.Drawing.Point(31, 481);
            this.actionBtn.Name = "actionBtn";
            this.actionBtn.Size = new System.Drawing.Size(932, 51);
            this.actionBtn.TabIndex = 20;
            this.actionBtn.Text = "Action";
            this.actionBtn.UseVisualStyleBackColor = false;
            this.actionBtn.Click += new System.EventHandler(this.actionBtn_Click);
            // 
            // categoryLbl
            // 
            this.categoryLbl.AutoSize = true;
            this.categoryLbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLbl.Location = new System.Drawing.Point(310, 87);
            this.categoryLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.categoryLbl.Name = "categoryLbl";
            this.categoryLbl.Size = new System.Drawing.Size(70, 19);
            this.categoryLbl.TabIndex = 21;
            this.categoryLbl.Text = "Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(537, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "Assign a contact ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(310, 175);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 19);
            this.label5.TabIndex = 23;
            this.label5.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(502, 175);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 19);
            this.label3.TabIndex = 24;
            this.label3.Text = "Is it an Income or Expense?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(283, 237);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 19);
            this.label2.TabIndex = 25;
            this.label2.Text = "Transaction date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(281, 322);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 19);
            this.label4.TabIndex = 26;
            this.label4.Text = "Transaction description";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 255);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.categoryTxt);
            this.panel3.Location = new System.Drawing.Point(285, 115);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(130, 34);
            this.panel3.TabIndex = 28;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel4.Controls.Add(this.messageRichTetx);
            this.panel4.Location = new System.Drawing.Point(285, 344);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(358, 124);
            this.panel4.TabIndex = 29;
            // 
            // TransactionAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1009, 558);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.contactComboBox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.categoryLbl);
            this.Controls.Add(this.actionBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.recurrCheckBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.transactionAmount);
            this.Controls.Add(this.transactionDateTimePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TransactionAddEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TransactionAddEdit";
            this.Load += new System.EventHandler(this.TransactionAddEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transactionAmount)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox categoryTxt;
        private System.Windows.Forms.DateTimePicker transactionDateTimePicker;
        private System.Windows.Forms.RadioButton incomeRadio;
        private System.Windows.Forms.RichTextBox messageRichTetx;
        private System.Windows.Forms.NumericUpDown transactionAmount;
        private System.Windows.Forms.RadioButton expenseRadio;
        private System.Windows.Forms.ComboBox contactComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox recurrCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox noTimeLimitCheckBox;
        private System.Windows.Forms.ComboBox periodCombo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel closePanel;
        private System.Windows.Forms.Button actionBtn;
        private System.Windows.Forms.Label categoryLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel expenseHighLight;
        private System.Windows.Forms.Panel incomeHighLight;
    }
}