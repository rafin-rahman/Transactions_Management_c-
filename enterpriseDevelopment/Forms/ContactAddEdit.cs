using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace enterpriseDevelopment
{
    public partial class ContactAddEdit : Form
    {
        private Contact c;
        public ContactAddEdit()
        {
            InitializeComponent();
            actionBtn.Text = "Add";
            Text = "Add contact";
            c = new Contact { userIdFk = Instance.StaticUserAccount.UserId };
        }

        public ContactAddEdit(Contact contact)
        {
            InitializeComponent();
            c = contact;
            actionBtn.Text = "Edit";
            Text = "Edit contact";
            contactTxtBox.Text = contact.ContactName;
        }

        private async void actionBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(contactTxtBox.Text))
            {
                MessageBox.Show("Cannot leave empty field");
                return;
            }
            c.ContactName = contactTxtBox.Text;
            ContactRepository contactRepository = new ContactRepository();

            bool x = false;

            if (c.ContactId > 0)
            {
                x = await Task.Run(() => contactRepository.EditContact(c));
            }
            else
            {
                int i = await Task.Run(() => contactRepository.AddContact(c));
                if (i > 0) x = true;
            }

            if (c.ContactId > 0 && x == true)
            {
                MessageBox.Show("Contact Edited!");
            }
            else if (x == true) {
                MessageBox.Show("Contact Added!");
            }
            else
            {
                MessageBox.Show("ops, Something went wrong");
            }
            Close();
            Dispose();
        }
    }
}
