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
        private Transaction transaction;
        private TransactionRecurring recurringTransaction;
        private bool isRepeat = false;

        #region CONTRUCTOR
        //  transaction add 
        public TransactionAddEdit()
        {
            InitializeComponent();
            actionBtn.Text = "Add";
            Text = "Add transaction";
            transaction = new Transaction { UserFk = UserInstance.StaticUserAccount.Id };
        }
        // transaction edit   
        public TransactionAddEdit(Transaction transaction)
        {
            InitializeComponent();
            this.transaction = transaction;
            actionBtn.Text = "Edit ";
            Text = "Edit transaction";
            categoryTxt.Text = transaction.Category;
            transactionAmount.Value = transaction.Amount;
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
            transactionDateTimePicker.Value = transaction.DateTime;
            messageRichTetx.Text = transaction.Description;
            groupBox1.Visible = false;
            recurrCheckBox.Visible = false;
        }
        // recurring transaction edit 
        public TransactionAddEdit(TransactionRecurring transaction)
        {
            InitializeComponent();
            isRepeat = true;
            recurringTransaction = transaction;
            actionBtn.Text = "Edit ";
            Text = "Edit recurring transaction";
            categoryTxt.Text = transaction.Category;
            transactionAmount.Value = transaction.Amount;
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

            transactionDateTimePicker.Value = transaction.DateTime;
            messageRichTetx.Text = transaction.Description;
            periodCombo.Text = recurringTransaction.Period;

            if (recurringTransaction.EndTime == DateTime.MinValue)
            {
                dateTimePicker1.Enabled = false;
                noTimeLimitCheckBox.Checked = true;
            }
            else
            {
                dateTimePicker1.Value = recurringTransaction.EndTime;
            }

            groupBox1.Visible = true;
            recurrCheckBox.Visible = false;
        }
        #endregion
        
        // showing list of contacts and selecting the assigned contact for the transaction
        private async void TransactionAddEdit_Load(object sender, EventArgs e)
        {
            ContactRepository contactRepository = new ContactRepository();
            List<Contact> list = await Task.Run(() => contactRepository.GetContacts(UserInstance.StaticUserAccount.Id));
            contactComboBox.DataSource = list;
            contactComboBox.DisplayMember = "Name";

            if (isRepeat)
                // allocating contact to a recurring transaction
                setRecurringTransactionContact(list);
            else
                // allocating contact to a normal transaction
                setTransactionContact(list);
        }

        #region ADD & EDIT TRANSACTIONS
        // chosing it it's recurring or normal transaction
        private void actionBtn_Click(object sender, EventArgs e)
        {
            if (isRepeat)
                addEdiRecurringTransaction();
            else
                addEditNormTransaction();
        }

        private async void addEditNormTransaction()
        {
            transaction.Category = categoryTxt.Text;
            transaction.Amount = transactionAmount.Value;
            Contact contact = (Contact)contactComboBox.SelectedItem;

            if (contact == null)
            {
                if (string.IsNullOrWhiteSpace(contactComboBox.Text))
                    transaction.ContactFk = 0;
                else
                {   // adding new contact to repository if it does not exist in the list
                    ContactRepository contactsRepository = new ContactRepository();
                    contactsRepository.AddContact(new Contact { Name = contactComboBox.Text, UserFk = UserInstance.StaticUserAccount.Id });
                }
            }
            else
                transaction.ContactFk = contact.Id;

            if (incomeRadio.Checked == true)
                transaction.IncomeExpense = true;
            else if (expenseRadio.Checked == true)
                transaction.IncomeExpense = false;
            else
                MessageBox.Show("Choose transaction type");

            transaction.DateTime = transactionDateTimePicker.Value;
            transaction.Description = messageRichTetx.Text;
            TransactionRepository transactionRepository = new TransactionRepository();

            bool x;
            // if the transaction has an ID bigger than 0 it means it already exist and it will be edited
            if (transaction.Id > 0)
                x = await Task.Run(() => transactionRepository.EditTransaction(transaction));
            else
                // if the transaction does not have ID bigger than 0 it means it's a new transaction
                x = await Task.Run(() => transactionRepository.AddTransction(transaction));

            // if recurring check box if ticked, will be added as recurring transaction
            if (recurrCheckBox.Checked == true && transaction.Id == 0)
            {
                TransactionRecurring recurringTransaction = new TransactionRecurring
                {
                    Category = transaction.Category,
                    Amount = transaction.Amount,
                    UserFk = transaction.UserFk,
                    TransactionType = transaction.TransactionType,
                    DateTime = transaction.DateTime,
                    Description = transaction.Description,
                    ContactFk = transaction.ContactFk,
                    IncomeExpense = transaction.IncomeExpense
                };

                if (noTimeLimitCheckBox.Checked)
                    // if the transaction has an infinite duration, it will have the min date value
                    recurringTransaction.EndTime = DateTime.MinValue;
                else
                    recurringTransaction.EndTime = dateTimePicker1.Value;

                recurringTransaction.Period = periodCombo.Text;

                TransactionRecurringRepository transactionRecurringRepository = new TransactionRecurringRepository();
                bool i = await Task.Run(() => transactionRecurringRepository.AddTransction(recurringTransaction));
                if (i == false)
                {
                    MessageBox.Show("Ops, something went wrong", "Error");
                    return;
                }
            }
            // if transaction ID is bigger than 0 it will be edited, otherwise it will be added as new
            if (transaction.Id > 0 && x == true)
                MessageBox.Show("Transaction Edited!");
            else if (x == true)
                MessageBox.Show("Transaction Added!");
            else
                MessageBox.Show("ops, Something went wrong");

            Close();
            Dispose();
        }

        private async void addEdiRecurringTransaction()
        {
            recurringTransaction.Category = categoryTxt.Text;
            recurringTransaction.Amount = transactionAmount.Value;


            Contact contact = (Contact)contactComboBox.SelectedItem;
            if (contact == null)
            {
                if (string.IsNullOrWhiteSpace(contactComboBox.Text))
                    // if there's not selected contact it will have an ID of 0, and null value in the db
                    recurringTransaction.ContactFk = 0;
                else
                {
                    ContactRepository contactsRepository = new ContactRepository();
                    recurringTransaction.ContactFk = await Task.Run(() => contactsRepository.AddContact(new Contact { Name = contactComboBox.Text, UserFk = UserInstance.StaticUserAccount.Id }));
                }
            }

            else
                recurringTransaction.ContactFk = contact.Id;
            // true = income, false = expense
            if (incomeRadio.Checked == true)
                recurringTransaction.IncomeExpense = true;
            else if (expenseRadio.Checked == true)
                recurringTransaction.IncomeExpense = false;
            else
                MessageBox.Show("Choose transaction type");

            recurringTransaction.DateTime = transactionDateTimePicker.Value;
            recurringTransaction.Description = messageRichTetx.Text;
            TransactionRecurringRepository transactionRepository = new TransactionRecurringRepository();

            bool x;
            // set min date value if the transaction is infinite
            if (noTimeLimitCheckBox.Checked)
                recurringTransaction.EndTime = DateTime.MinValue;
            else
                recurringTransaction.EndTime = dateTimePicker1.Value;

            recurringTransaction.Period = periodCombo.Text;
            x = await Task.Run(() => transactionRepository.EditTransaction(recurringTransaction));

            if (recurringTransaction.Id > 0 && x == true)
                MessageBox.Show("Transaction Edited!");
            else
                MessageBox.Show("ops, Something went wrong");

            Close();
            Dispose();
        }
        #endregion

        #region SET CONTACT TO A TRANSACTION
        private void setTransactionContact(List<Contact> list)
        {
            if (transaction.Id > 0)
            { // if no contact is assigned, show empty string
                if (transaction.ContactFk == 0)
                    contactComboBox.Text = "";
                else
                {
                    for (int x = 0; x < list.Count; x++)
                    {
                        if (transaction.ContactFk == list[x].Id)
                            contactComboBox.SelectedItem = contactComboBox.Items[x];
                    }
                }
            }
        }

        private void setRecurringTransactionContact(List<Contact> list)
        {
            if (recurringTransaction.Id > 0)
            {// if no contact is assigned, show empty string
                if (recurringTransaction.ContactFk == 0)
                    contactComboBox.Text = "";
                else
                {
                    for (int x = 0; x < list.Count; x++)
                    {
                        if (recurringTransaction.ContactFk == list[x].Id)
                            contactComboBox.SelectedItem = contactComboBox.Items[x];
                    }
                }
            }
        }
        #endregion
        
        // toggle recurring transaction panel
        private void recurrCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (recurrCheckBox.Checked == true)
                groupBox1.Visible = true;
            else
                groupBox1.Visible = false;
        }

        // enable / disable the date picker if it's checked
        private void noTimeLimit_CheckedChanged(object sender, EventArgs e)
        {
            if (noTimeLimitCheckBox.Checked == true)
                dateTimePicker1.Enabled = false;
            else
                dateTimePicker1.Enabled = true;
        }

        #region ANIMATION BAR FOR INCOME AND EXPENSE CHECK BOX
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
        #endregion
        
        #region HOVER ANIMATION
        private void closePanel_MouseEnter(object sender, EventArgs e)
        {
            this.closePanel.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.backButtonHover));
        }

        private void closePanel_MouseLeave(object sender, EventArgs e)
        {
            this.closePanel.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.backButton));
        }
        #endregion

        private void closePanel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
