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
        }

        private void button1_Click(object sender, EventArgs e)
        {

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

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (listViewContact.SelectedItems.Count > 0)
            {
                Contact contact = (Contact)listViewContact.SelectedItems[0].Tag;
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
}
