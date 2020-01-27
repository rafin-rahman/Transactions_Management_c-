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
        private TransactionRecurring tr;
        private bool isRepeat = false;
       
        public TransactionAddEdit()
        {
            InitializeComponent();
            actionBtn.Text = "Add";
            Text = "Add transaction";
            t = new Transaction { UserFk = UserInstance.StaticUserAccount.Id };
        }
         
        public TransactionAddEdit(Transaction transaction)
        {
            InitializeComponent();
            t = transaction;
            actionBtn.Text = "Edit ";
            Text = "Edit transaction";
            categoryTxt.Text = transaction.Category;
            transactionAmountNum.Value = transaction.Amount;
            if (transaction.IncomeExpense == true)
            {
                incomeRadio.Checked = true;
                expenseRadio.Checked = false;
                // Blue panel show / hide
                incomeHighLight.Visible = true;
                expenseHighLight.Visible = false;
            }
            else
            {
                incomeRadio.Checked = false;
                expenseRadio.Checked = true;
                // Blue panel show / hide
                incomeHighLight.Visible = false;
                expenseHighLight.Visible = true;
            }
            transDateTime.Value = transaction.DateTime;
            messageRichTetx.Text = transaction.Description;
            groupBox1.Visible = false;
            recurrCheck.Visible = false;
        }
        
        public TransactionAddEdit(TransactionRecurring transaction)
        {
            InitializeComponent();
            isRepeat = true;
            tr = transaction;
            actionBtn.Text = "Edit ";
            Text = "Edit recurring transaction";
            categoryTxt.Text = transaction.Category;
            transactionAmountNum.Value = transaction.Amount;
            if (transaction.IncomeExpense == true)
            {
                incomeRadio.Checked = true;
                expenseRadio.Checked = false;
                // Blue panel show / hide
                incomeHighLight.Visible = true;
                expenseHighLight.Visible = false;
            }
            else
            {
                incomeRadio.Checked = false;
                expenseRadio.Checked = true;
                // Blue panel show / hide
                incomeHighLight.Visible = false;
                expenseHighLight.Visible = true;
            }

            transDateTime.Value = transaction.DateTime;
            messageRichTetx.Text = transaction.Description;
            periodCombo.Text = tr.Period;

            if (tr.EndTime == DateTime.MinValue)
            {
                dateTimePicker1.Enabled = false;
                noTimeLimit.Checked = true;
            }
            else
            {
                dateTimePicker1.Value = tr.EndTime;
            }
            
            groupBox1.Visible = true;
            recurrCheck.Visible = false;
        }

        private void setTransContact(List<Contact> list)
        {
            if (t.Id > 0)
            {
                if (t.ContactFk == 0)
                    contactComboBox.Text = "";
                else
                {
                    for (int x = 0; x < list.Count; x++)
                    {
                        if (t.ContactFk == list[x].Id)
                            contactComboBox.SelectedItem = contactComboBox.Items[x];
                    }
                }
            }
        }

        private void setTransRepeatContact(List<Contact> list)
        {
            if (tr.Id > 0)
            {
                if (tr.ContactFk == 0)
                    contactComboBox.Text = "";
                else
                {
                    for (int x = 0; x < list.Count; x++)
                    {
                        if (tr.ContactFk == list[x].Id)
                            contactComboBox.SelectedItem = contactComboBox.Items[x];
                    }
                }
            }
        }

        private async void TransactionAddEdit_Load(object sender, EventArgs e)
        {
            ContactRepository contactRepository = new ContactRepository();
            List<Contact> list = await Task.Run(() => contactRepository.GetContacts(UserInstance.StaticUserAccount.Id));
            contactComboBox.DataSource = list;
            contactComboBox.DisplayMember = "ContactName";

            if (isRepeat)
                setTransRepeatContact(list);
            else
                setTransContact(list);
        }
        
        private void actionBtn_Click(object sender, EventArgs e)
        {
            if (isRepeat)
                addEditransactionRepeat();
            else
                addEditNormTransaction();
        }

        private async void addEditNormTransaction()
        {
            t.Category = categoryTxt.Text;
            t.Amount = transactionAmountNum.Value;
            Contact contact = (Contact)contactComboBox.SelectedItem;

            if (contact == null)
            {
                if (string.IsNullOrWhiteSpace(contactComboBox.Text))
                    t.ContactFk = 0;
                else
                {
                    ContactRepository contactsRepository = new ContactRepository();
                    contactsRepository.AddContact(new Contact { Name = contactComboBox.Text, UserFk = UserInstance.StaticUserAccount.Id });
                }
            }
            else
                t.ContactFk = contact.Id;

            if (incomeRadio.Checked == true)
                t.IncomeExpense = true;
            else if (expenseRadio.Checked == true)
                t.IncomeExpense = false;
            else
                MessageBox.Show("Choose transaction type");

            t.DateTime = transDateTime.Value;
            t.Description = messageRichTetx.Text;
            TransactionRepository transactionRepository = new TransactionRepository();
            
            bool x;
            if (t.Id > 0)
                x = await Task.Run(() => transactionRepository.EditTransaction(t));
            else
                x = await Task.Run(() => transactionRepository.AddTransction(t));

            if (recurrCheck.Checked == true && t.Id == 0)
            {
                TransactionRecurring transactionRepeat = new TransactionRecurring
                {
                    Category = t.Category,
                    Amount = t.Amount,
                    UserFk = t.UserFk,
                    TransactionType = t.TransactionType,
                    DateTime = t.DateTime,
                    Description = t.Description,
                    ContactFk = t.ContactFk,
                    IncomeExpense = t.IncomeExpense
                };
                
                if (noTimeLimit.Checked)
                    transactionRepeat.EndTime = DateTime.MinValue;
                else
                    transactionRepeat.EndTime = dateTimePicker1.Value;

                transactionRepeat.Period = periodCombo.Text;
                TransactionRecurringRepository transactionRecurringRepository = new TransactionRecurringRepository();
                bool i = await Task.Run(() => transactionRecurringRepository.AddTransction(transactionRepeat));
                if (i == false)
                {
                    MessageBox.Show("Ops, something went wrong", "Error");
                    return; 
                }
            }

            if (t.Id > 0 && x == true)
                MessageBox.Show("Transaction Edited!");
            else if (x == true)
                MessageBox.Show("Transaction Added!");
            else
                MessageBox.Show("ops, Something went wrong");

            Close();
            Dispose();
        }
        
        private async void addEditransactionRepeat()
        {
            tr.Category = categoryTxt.Text;
            tr.Amount = transactionAmountNum.Value;

            Contact contact = (Contact)contactComboBox.SelectedItem;
            if (contact == null)
            {
                if (string.IsNullOrWhiteSpace(contactComboBox.Text))
                    tr.ContactFk = 0;
                else
                {
                    ContactRepository contactsRepository = new ContactRepository();
                    tr.ContactFk = await Task.Run(() => contactsRepository.AddContact(new Contact { Name = contactComboBox.Text, UserFk = UserInstance.StaticUserAccount.Id }));
                }
            }

            else
                tr.ContactFk = contact.Id;

            if (incomeRadio.Checked == true)
                tr.IncomeExpense = true;
            else if (expenseRadio.Checked == true)
                tr.IncomeExpense = false;
            else
                MessageBox.Show("Choose transaction type");

            tr.DateTime = transDateTime.Value;
            tr.Description = messageRichTetx.Text;
            TransactionRecurringRepository transactionRepository = new TransactionRecurringRepository();
            
            bool x;
            
            if (noTimeLimit.Checked)
                tr.EndTime = DateTime.MinValue;
            else
                tr.EndTime = dateTimePicker1.Value;

            tr.Period = periodCombo.Text;
            x = await Task.Run(() => transactionRepository.EditTransaction(tr));
            
            if (tr .Id > 0 && x == true)
                MessageBox.Show("Transaction Edited!");
            else
                MessageBox.Show("ops, Something went wrong");

            Close();
            Dispose();
        }

        private void recurrCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (recurrCheck.Checked == true)
                groupBox1.Visible = true;
            else
                groupBox1.Visible = false;
        }

        private void noTimeLimit_CheckedChanged(object sender, EventArgs e)
        {
            if (noTimeLimit.Checked == true)
                dateTimePicker1.Enabled = false;
            else
                dateTimePicker1.Enabled = true;
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

        private void incomeRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (incomeRadio.Checked)
                incomeHighLight.Visible = true;
            else
                incomeHighLight.Visible = false;
        }

        private void expenseRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (expenseRadio.Checked)
                expenseHighLight.Visible = true;
            else
                expenseHighLight.Visible = false;
        }
    }
}
