using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace enterpriseDevelopment.Forms
{
    public partial class ContactsForm : Form
    {
        // Instance of contact repository
        private ContactRepository ContactRepository;
        public ContactsForm()
        {
            InitializeComponent();
            ContactRepository = new ContactRepository();
            // When this form in opened, main form will be hidden
            Instance.MainForm.Hide();
        }
        
        private void addBtn_Click(object sender, EventArgs e)
        {
            ContactAddEdit contactAddEdit = new ContactAddEdit();
            contactAddEdit.Activate();
            contactAddEdit.Show();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (listViewContact.SelectedItems.Count > 0)
            {
                Contact contact = (Contact)listViewContact.SelectedItems[0].Tag;
                DialogResult dialogResult = MessageBox.Show("Do you want do delete this contact?", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    bool x = ContactRepository.DeleteContact(contact);
                    if (x)
                    {
                        MessageBox.Show("Contact deleted");
                    }
                    else
                    {
                        MessageBox.Show("Contact not deleted");
                    }
                }
            }
        }

        private void ContactsForm_Activated(object sender, EventArgs e)
        {
            List<Contact> ContactList = ContactRepository.GetContacts(Instance.StaticUserAccount.UserId);
            listViewContact.Items.Clear();
            foreach (Contact contact in ContactList)
            {
                ListViewItem lvi = new ListViewItem(new string[] { contact.ContactName });
                lvi.Tag = contact;
                listViewContact.Items.Add(lvi);
            }
        }
         
        private void editBtn_Click(object sender, EventArgs e)
        {
            if (listViewContact.SelectedItems.Count > 0 )
            {

                Contact contact = (Contact)listViewContact.SelectedItems[0].Tag;
                ContactAddEdit contactAddEdit = new ContactAddEdit(contact);
                contactAddEdit.Activate();
                contactAddEdit.Show();
            }
        }

        private void ContactsForm_FormClosed(object sender, FormClosedEventArgs e)
        {

            Instance.MainForm.Activate();
            Instance.MainForm.Show();

            Dispose();
        }

        private void listViewContact_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ContactsForm_Load(object sender, EventArgs e)
        {

        }

        
       
    }
}
