using enterpriseDevelopment.Models;
using enterpriseDevelopment.Repositories;
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
    public partial class TransactionAddEdit : Form
    {
        private Transaction t;

        public TransactionAddEdit()
        {
            InitializeComponent();
            actionBtn.Text = "Add";
            //Text is the window name in the top left corner 
            Text = "Add transaction";
            t = new Transaction { userIdFk = Instance.StaticUserAccount.UserId };
        }

        public TransactionAddEdit(Transaction transaction)
        {
            InitializeComponent();
            t = transaction;
            actionBtn.Text = "Edit ";
            //Text is the window name in the top left corner 
            Text = "Edit transaction";
            categoryTxt.Text = transaction.transactionCategory;
            transactionAmountNum.Value = transaction.transactionAmount;
            if (transaction.incomeExpense == true)
            {
                incomeRadio.Checked = true;
                expenseRadio.Checked = false;
            }
            else
            {
                incomeRadio.Checked = false;
                expenseRadio.Checked = true;
            }
            transDateTime.Value = transaction.dateTime;
            messageRichTetx.Text = transaction.transactionMessage;
        }

        private void listViewTransaction_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void TransactionAddEdit_Load(object sender, EventArgs e)
        {
            ContactRepository contactRepository = new ContactRepository();
            List<Contact> list = contactRepository.GetContacts(Instance.StaticUserAccount.UserId);
            contactComboBox.DataSource = list;
            contactComboBox.DisplayMember = "ContactName";

            if (t.transactionId > 0)
            {
                if (t.contactIdFk == 0)
                {
                    contactComboBox.Text = "";
                }
                else
                {
                    for (int x = 0; x < list.Count; x++)
                    {
                        if (t.contactIdFk == list[x].ContactId)
                        {
                            contactComboBox.SelectedItem = contactComboBox.Items[x];
                        }
                    }
                }
            }

        }

        private void actionBtn_Click(object sender, EventArgs e)
        {
            // On button click it stores all the form filled from the user into the transaction object
            t.transactionCategory = categoryTxt.Text;
            t.transactionAmount = transactionAmountNum.Value;

            Contact contact = (Contact)contactComboBox.SelectedItem;
            if (contact == null)
            {
                if (string.IsNullOrWhiteSpace(contactComboBox.Text))
                {
                    t.contactIdFk = 0;
                }
                else
                {
                    ContactRepository contactsRepository = new ContactRepository();
                    t.contactIdFk = contactsRepository.AddContact(new Contact { ContactName = contactComboBox.Text, userIdFk = Instance.StaticUserAccount.UserId });
                }
            }
            else
            {
                t.contactIdFk = contact.ContactId;
            }

            if (incomeRadio.Checked == true)
            {
                t.incomeExpense = true;

            }
            else if (expenseRadio.Checked == true)
            {
                t.incomeExpense = false;
            }
            else
            {
                MessageBox.Show("Choose transaction type");
            }

            t.dateTime = transDateTime.Value;
            t.transactionMessage = messageRichTetx.Text;

            TransactionRepository transactionRepository = new TransactionRepository();

            bool x;
            if (t.transactionId > 0)
            {
                x = transactionRepository.EditTransaction(t);
            }
            else
            {
                x = transactionRepository.AddTransction(t);
            }

            if (t.transactionId > 0 && x == true)
            {
                MessageBox.Show("Transaction Edited!");
            }
            else if (x == true)
            {
                MessageBox.Show("Transaction Added!");
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
