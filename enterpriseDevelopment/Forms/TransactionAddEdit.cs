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

            groupBox1.Visible = false;
            recurrCheck.Visible = false;

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

            if (recurrCheck.Checked == true && t.transactionId == 0)
            {
                TransactionRepeat transactionRepeat = new TransactionRepeat {
                    transactionCategory = t.transactionCategory,
                transactionAmount = t.transactionAmount,
                userIdFk = t.userIdFk,
                typeValue = t.typeValue,
                dateTime = t.dateTime,
                transactionMessage = t.transactionMessage,
                contactIdFk = t.contactIdFk
                };


                if (noTimeLimit.Checked)
                {
                    transactionRepeat.subscriptionEndTime = DateTime.MinValue;
                }
                else
                {
                    transactionRepeat.subscriptionEndTime = dateTimePicker1.Value;
                }
                transactionRepeat.subscriptionPeriod = periodCombo.Text;

                TransactionRecurringRepository transactionRecurringRepository = new TransactionRecurringRepository();
               bool i = transactionRecurringRepository.AddTransction(transactionRepeat);
                if (i == false)
                {
                    MessageBox.Show("Ops, something went wrong", "Error");
                    return;
                }
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

        private void recurrCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (recurrCheck.Checked == true)
            {
                groupBox1.Visible = true;
            }
            else
            {
                groupBox1.Visible = false;
            }
        }

        private void noTimeLimit_CheckedChanged(object sender, EventArgs e)
        {
            if (noTimeLimit.Checked == true)
            {
                dateTimePicker1.Enabled = false;
            }
            else
            {
                dateTimePicker1.Enabled = true;
            }
        }
    }
}
