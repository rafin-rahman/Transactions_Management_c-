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
        private Contact contact;
        public ContactAddEdit()
        {
            InitializeComponent();
            actionBtn.Text = "Add";
            Text = "Add contact";
            contact = new Contact { UserFk = UserInstance.StaticUserAccount.Id };
        }

        public ContactAddEdit(Contact contact)
        {
            InitializeComponent();
            this.contact = contact;
            actionBtn.Text = "Edit";
            Text = "Edit contact";
            contactTxtBox.Text = contact.Name;
        }

        private async void actionBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(contactTxtBox.Text))
            {
                MessageBox.Show("Cannot leave empty field");
                return;
            }
            contact.Name = contactTxtBox.Text;
            ContactRepository contactRepository = new ContactRepository();

            bool x = false;

            if (contact.Id > 0)
                x = await Task.Run(() => contactRepository.EditContact(contact));
            else
            {
                int i = await Task.Run(() => contactRepository.AddContact(contact));
                if (i > 0) x = true;
            }

            if (contact.Id > 0 && x == true)
                MessageBox.Show("Contact Edited!");
            else if (x == true)
                MessageBox.Show("Contact Added!");
            else
                MessageBox.Show("ops, Something went wrong");

            Close();
            Dispose();
        }

        private void closePanel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void closePanel_MouseEnter(object sender, EventArgs e)
        {
            this.closePanel.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.backButtonHover));
        }

        private void closePanel_MouseLeave(object sender, EventArgs e)
        {
            this.closePanel.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.backButton));
        }
    }
}
