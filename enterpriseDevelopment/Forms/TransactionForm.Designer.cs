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
            this.amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.incomeExpense = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contact = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.message = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewTransaction
            // 
            this.listViewTransaction.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.amount,
            this.incomeExpense,
            this.category,
            this.date,
            this.contact,
            this.message});
            this.listViewTransaction.HideSelection = false;
            this.listViewTransaction.Location = new System.Drawing.Point(25, 23);
            this.listViewTransaction.Margin = new System.Windows.Forms.Padding(2);
            this.listViewTransaction.Name = "listViewTransaction";
            this.listViewTransaction.Size = new System.Drawing.Size(686, 242);
            this.listViewTransaction.TabIndex = 0;
            this.listViewTransaction.UseCompatibleStateImageBehavior = false;
            this.listViewTransaction.View = System.Windows.Forms.View.Details;
            this.listViewTransaction.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // amount
            // 
            this.amount.Text = "Amount";
            this.amount.Width = 100;
            // 
            // incomeExpense
            // 
            this.incomeExpense.Text = "Income / Expense";
            this.incomeExpense.Width = 250;
            // 
            // category
            // 
            this.category.Text = "Category";
            this.category.Width = 100;
            // 
            // date
            // 
            this.date.Text = "Date";
            this.date.Width = 100;
            // 
            // contact
            // 
            this.contact.DisplayIndex = 5;
            this.contact.Text = "Contacts";
            this.contact.Width = 173;
            // 
            // message
            // 
            this.message.DisplayIndex = 4;
            this.message.Text = "Description";
            this.message.Width = 300;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(729, 21);
            this.addBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(96, 54);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(729, 91);
            this.editBtn.Margin = new System.Windows.Forms.Padding(2);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(96, 54);
            this.editBtn.TabIndex = 2;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(729, 160);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(2);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(96, 54);
            this.deleteBtn.TabIndex = 3;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 477);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.listViewTransaction);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TransactionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
        private System.Windows.Forms.ColumnHeader amount;
        private System.Windows.Forms.ColumnHeader category;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader message;
        private System.Windows.Forms.ColumnHeader contact;
    }
}