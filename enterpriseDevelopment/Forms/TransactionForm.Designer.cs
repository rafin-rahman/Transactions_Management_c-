namespace enterpriseDevelopment.Forms
{
    partial class TransactionForm
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
            this.listViewTransaction = new System.Windows.Forms.ListView();
            this.addBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.incomeExpense = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewTransaction
            // 
            this.listViewTransaction.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.incomeExpense});
            this.listViewTransaction.HideSelection = false;
            this.listViewTransaction.Location = new System.Drawing.Point(49, 93);
            this.listViewTransaction.Name = "listViewTransaction";
            this.listViewTransaction.Size = new System.Drawing.Size(386, 419);
            this.listViewTransaction.TabIndex = 0;
            this.listViewTransaction.UseCompatibleStateImageBehavior = false;
            this.listViewTransaction.View = System.Windows.Forms.View.Details;
            this.listViewTransaction.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(468, 93);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(192, 103);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(468, 229);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(192, 103);
            this.editBtn.TabIndex = 2;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(468, 360);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(192, 103);
            this.deleteBtn.TabIndex = 3;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // incomeExpense
            // 
            this.incomeExpense.Text = "Income / Expense";
            this.incomeExpense.Width = 183;
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 619);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.listViewTransaction);
            this.Name = "TransactionForm";
            this.Text = "TransactionForm";
            this.Activated += new System.EventHandler(this.TransactionForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TransactionForm_FormClosed);
            this.Load += new System.EventHandler(this.TransactionForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewTransaction;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.ColumnHeader incomeExpense;
    }
}