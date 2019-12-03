namespace enterpriseDevelopment.Forms
{
    partial class ContactsForm
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
            this.listViewContact = new System.Windows.Forms.ListView();
            this.ContactNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewContact
            // 
            this.listViewContact.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ContactNameColumn});
            this.listViewContact.FullRowSelect = true;
            this.listViewContact.HideSelection = false;
            this.listViewContact.Location = new System.Drawing.Point(266, 58);
            this.listViewContact.MultiSelect = false;
            this.listViewContact.Name = "listViewContact";
            this.listViewContact.Size = new System.Drawing.Size(191, 688);
            this.listViewContact.TabIndex = 0;
            this.listViewContact.UseCompatibleStateImageBehavior = false;
            this.listViewContact.View = System.Windows.Forms.View.Details;
            this.listViewContact.SelectedIndexChanged += new System.EventHandler(this.listViewContact_SelectedIndexChanged);
            // 
            // ContactNameColumn
            // 
            this.ContactNameColumn.Text = "Contact Name";
            this.ContactNameColumn.Width = 160;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(598, 114);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(300, 162);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(598, 323);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(300, 162);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(598, 543);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(300, 162);
            this.editBtn.TabIndex = 2;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // ContactsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1663, 942);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.listViewContact);
            this.Name = "ContactsForm";
            this.Text = "ContactsForm";
            this.Activated += new System.EventHandler(this.ContactsForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ContactsForm_FormClosed);
            this.Load += new System.EventHandler(this.ContactsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewContact;
        private System.Windows.Forms.ColumnHeader ContactNameColumn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button editBtn;
    }
}