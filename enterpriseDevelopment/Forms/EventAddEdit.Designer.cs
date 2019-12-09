namespace enterpriseDevelopment.Forms
{
    partial class EventAddEdit
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
            this.titleTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.messageRichTxt = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePick = new System.Windows.Forms.DateTimePicker();
            this.locationTxt = new System.Windows.Forms.TextBox();
            this.actionBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxEvent = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // titleTxt
            // 
            this.titleTxt.Location = new System.Drawing.Point(158, 98);
            this.titleTxt.Margin = new System.Windows.Forms.Padding(6);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(196, 31);
            this.titleTxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Event title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // messageRichTxt
            // 
            this.messageRichTxt.Location = new System.Drawing.Point(158, 215);
            this.messageRichTxt.Margin = new System.Windows.Forms.Padding(6);
            this.messageRichTxt.Name = "messageRichTxt";
            this.messageRichTxt.Size = new System.Drawing.Size(540, 181);
            this.messageRichTxt.TabIndex = 3;
            this.messageRichTxt.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 427);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date and time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 525);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Location";
            // 
            // dateTimePick
            // 
            this.dateTimePick.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimePick.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePick.Location = new System.Drawing.Point(158, 460);
            this.dateTimePick.Margin = new System.Windows.Forms.Padding(6);
            this.dateTimePick.Name = "dateTimePick";
            this.dateTimePick.Size = new System.Drawing.Size(540, 31);
            this.dateTimePick.TabIndex = 6;
            // 
            // locationTxt
            // 
            this.locationTxt.Location = new System.Drawing.Point(158, 558);
            this.locationTxt.Margin = new System.Windows.Forms.Padding(6);
            this.locationTxt.Name = "locationTxt";
            this.locationTxt.Size = new System.Drawing.Size(540, 31);
            this.locationTxt.TabIndex = 7;
            // 
            // actionBtn
            // 
            this.actionBtn.Location = new System.Drawing.Point(158, 658);
            this.actionBtn.Margin = new System.Windows.Forms.Padding(6);
            this.actionBtn.Name = "actionBtn";
            this.actionBtn.Size = new System.Drawing.Size(324, 98);
            this.actionBtn.TabIndex = 8;
            this.actionBtn.Text = "Action";
            this.actionBtn.UseVisualStyleBackColor = true;
            this.actionBtn.Click += new System.EventHandler(this.actionBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(518, 67);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(353, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Do you want to assign any contact?";
            // 
            // comboBoxEvent
            // 
            this.comboBoxEvent.FormattingEnabled = true;
            this.comboBoxEvent.Location = new System.Drawing.Point(524, 98);
            this.comboBoxEvent.Margin = new System.Windows.Forms.Padding(6);
            this.comboBoxEvent.Name = "comboBoxEvent";
            this.comboBoxEvent.Size = new System.Drawing.Size(238, 33);
            this.comboBoxEvent.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(959, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Is it a task or event?";
            // 
            // statusComboBox
            // 
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Task",
            "Event"});
            this.statusComboBox.Location = new System.Drawing.Point(964, 98);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(121, 33);
            this.statusComboBox.TabIndex = 13;
            this.statusComboBox.Tag = "";
            this.statusComboBox.Text = "Task";
            // 
            // EventAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxEvent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.actionBtn);
            this.Controls.Add(this.locationTxt);
            this.Controls.Add(this.dateTimePick);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.messageRichTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleTxt);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "EventAddEdit";
            this.Text = "EventAddEdit";
            this.Load += new System.EventHandler(this.EventAddEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox messageRichTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePick;
        private System.Windows.Forms.TextBox locationTxt;
        private System.Windows.Forms.Button actionBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxEvent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox statusComboBox;
    }
}