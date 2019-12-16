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
        private TransactionRepeat tr;
        private bool isRepeat = false;
       
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
        // Edit ONLY recurrring transaction
        //Constructor
        public TransactionAddEdit(TransactionRepeat transaction)
        {
            InitializeComponent();
            isRepeat = true;
            tr = transaction;
            actionBtn.Text = "Edit ";
            //Text is the window name in the top left corner 
            Text = "Edit recurring transaction";
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
            periodCombo.Text = tr.subscriptionPeriod;
            if (tr.subscriptionEndTime == DateTime.MinValue)
            {
                dateTimePicker1.Enabled = false;
                noTimeLimit.Checked = true;
            }
            else
            {
                dateTimePicker1.Value = tr.subscriptionEndTime;
            }


            groupBox1.Visible = true;
            recurrCheck.Visible = false;

        }

        private void setTransContact(List<Contact> list)
        {
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

        private void setTransRepeatContact(List<Contact> list)
        {
            if (tr.transactionId > 0)
            {
                if (tr.contactIdFk == 0)
                {
                    contactComboBox.Text = "";
                }
                else
                {
                    for (int x = 0; x < list.Count; x++)
                    {
                        if (tr.contactIdFk == list[x].ContactId)
                        {
                            contactComboBox.SelectedItem = contactComboBox.Items[x];
                        }
                    }
                }
            }
        }

        private async void TransactionAddEdit_Load(object sender, EventArgs e)
        {
            ContactRepository contactRepository = new ContactRepository();
            List<Contact> list = await Task.Run(() => contactRepository.GetContacts(Instance.StaticUserAccount.UserId));
            contactComboBox.DataSource = list;
            contactComboBox.DisplayMember = "ContactName";

            if (isRepeat)
            {
                setTransRepeatContact(list);
            }
            else
            {
                setTransContact(list);
            }
        }
        
        private void actionBtn_Click(object sender, EventArgs e)
        {
            if (isRepeat)
            {
                addEditransactionRepeat();
            }
            else
            {
                addEditNormTransaction();
            }

        }

        private async void addEditNormTransaction()
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
                    t.contactIdFk = await Task.Run(() => contactsRepository.AddContact(new Contact { ContactName = contactComboBox.Text, userIdFk = Instance.StaticUserAccount.UserId }));
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
                x = await Task.Run(() => transactionRepository.EditTransaction(t));
            }
            else
            {
                x = await Task.Run(() => transactionRepository.AddTransction(t));
            }

            if (recurrCheck.Checked == true && t.transactionId == 0)
            {
                TransactionRepeat transactionRepeat = new TransactionRepeat
                {
                    transactionCategory = t.transactionCategory,
                    transactionAmount = t.transactionAmount,
                    userIdFk = t.userIdFk,
                    typeValue = t.typeValue,
                    dateTime = t.dateTime,
                    transactionMessage = t.transactionMessage,
                    contactIdFk = t.contactIdFk,
                    incomeExpense = t.incomeExpense
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
                bool i = await Task.Run(() => transactionRecurringRepository.AddTransction(transactionRepeat));
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
        
        private async void addEditransactionRepeat()
        {
            tr.transactionCategory = categoryTxt.Text;
            tr.transactionAmount = transactionAmountNum.Value;

            Contact contact = (Contact)contactComboBox.SelectedItem;
            if (contact == null)
            {
                if (string.IsNullOrWhiteSpace(contactComboBox.Text))
                {
                    tr.contactIdFk = 0;
                }
                else
                {
                    ContactRepository contactsRepository = new ContactRepository();
                    tr.contactIdFk = await Task.Run(() => contactsRepository.AddContact(new Contact { ContactName = contactComboBox.Text, userIdFk = Instance.StaticUserAccount.UserId }));
                }
            }
            else
            {
                tr.contactIdFk = contact.ContactId;
            }

            if (incomeRadio.Checked == true)
            {
                tr.incomeExpense = true;

            }
            else if (expenseRadio.Checked == true)
            {
                tr.incomeExpense = false;
            }
            else
            {
                MessageBox.Show("Choose transaction type");
            }

            tr.dateTime = transDateTime.Value;
            tr.transactionMessage = messageRichTetx.Text;

            TransactionRecurringRepository transactionRepository = new TransactionRecurringRepository();


            bool x;


            if (noTimeLimit.Checked)
            {
                tr.subscriptionEndTime = DateTime.MinValue;
            }
            else
            {
                tr.subscriptionEndTime = dateTimePicker1.Value;
            }
            tr.subscriptionPeriod = periodCombo.Text;

            x = await Task.Run(() => transactionRepository.EditTransaction(tr));


            if (tr .transactionId > 0 && x == true)
            {
                MessageBox.Show("Transaction Edited!");
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

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
