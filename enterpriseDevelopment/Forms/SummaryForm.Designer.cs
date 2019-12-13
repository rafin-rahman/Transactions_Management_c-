namespace enterpriseDevelopment.Forms
{
    partial class SummaryForm
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
            this.listVSummary = new System.Windows.Forms.ListView();
            this.dateCountStart = new System.Windows.Forms.DateTimePicker();
            this.dateCountEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.showByCB = new System.Windows.Forms.ComboBox();
            this.showSumBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listVSummary
            // 
            this.listVSummary.FullRowSelect = true;
            this.listVSummary.HideSelection = false;
            this.listVSummary.Location = new System.Drawing.Point(48, 42);
            this.listVSummary.MultiSelect = false;
            this.listVSummary.Name = "listVSummary";
            this.listVSummary.Size = new System.Drawing.Size(1867, 789);
            this.listVSummary.TabIndex = 0;
            this.listVSummary.UseCompatibleStateImageBehavior = false;
            this.listVSummary.View = System.Windows.Forms.View.Details;
            // 
            // dateCountStart
            // 
            this.dateCountStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateCountStart.Location = new System.Drawing.Point(547, 916);
            this.dateCountStart.MaxDate = new System.DateTime(2500, 12, 31, 0, 0, 0, 0);
            this.dateCountStart.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateCountStart.Name = "dateCountStart";
            this.dateCountStart.Size = new System.Drawing.Size(200, 31);
            this.dateCountStart.TabIndex = 3;
            // 
            // dateCountEnd
            // 
            this.dateCountEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateCountEnd.Location = new System.Drawing.Point(1096, 916);
            this.dateCountEnd.MaxDate = new System.DateTime(2500, 12, 31, 0, 0, 0, 0);
            this.dateCountEnd.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateCountEnd.Name = "dateCountEnd";
            this.dateCountEnd.Size = new System.Drawing.Size(200, 31);
            this.dateCountEnd.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(542, 865);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Start date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1091, 865);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "End date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(542, 995);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Show by";
            // 
            // showByCB
            // 
            this.showByCB.FormattingEnabled = true;
            this.showByCB.Items.AddRange(new object[] {
            "Transactions",
            "Days",
            "Months",
            "Years"});
            this.showByCB.Location = new System.Drawing.Point(547, 1040);
            this.showByCB.Name = "showByCB";
            this.showByCB.Size = new System.Drawing.Size(115, 33);
            this.showByCB.TabIndex = 10;
            this.showByCB.Text = "Transactions";
            // 
            // showSumBtn
            // 
            this.showSumBtn.Location = new System.Drawing.Point(859, 995);
            this.showSumBtn.Name = "showSumBtn";
            this.showSumBtn.Size = new System.Drawing.Size(161, 78);
            this.showSumBtn.TabIndex = 11;
            this.showSumBtn.Text = "Show list";
            this.showSumBtn.UseVisualStyleBackColor = true;
            this.showSumBtn.Click += new System.EventHandler(this.showSumBtn_Click);
            // 
            // SummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1965, 1148);
            this.Controls.Add(this.showSumBtn);
            this.Controls.Add(this.showByCB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateCountEnd);
            this.Controls.Add(this.dateCountStart);
            this.Controls.Add(this.listVSummary);
            this.Name = "SummaryForm";
            this.Text = " ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SummaryForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listVSummary;
        private System.Windows.Forms.DateTimePicker dateCountStart;
        private System.Windows.Forms.DateTimePicker dateCountEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox showByCB;
        private System.Windows.Forms.Button showSumBtn;
    }
}