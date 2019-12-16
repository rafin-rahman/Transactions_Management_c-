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
    public partial class TransactionForm : Form
    {

        private TransactionRepository transactionRepository;
        private TransactionRecurringRepository TransactionRecurringRepository;
        private bool isRepeating = false;
        public TransactionForm()
        {
            InitializeComponent();
            transactionRepository = new TransactionRepository();
            // When this form in opened, main form will be hidden
            Instance.MainForm.Hide();
        }

        public TransactionForm(bool repeat)
        {
            InitializeComponent();
            isRepeating = repeat;
            if (isRepeating == true)
            {

                listViewTransaction.Columns.Add("Period");
                listViewTransaction.Columns.Add("Ending date");
                TransactionRecurringRepository = new TransactionRecurringRepository();
            }
            
            transactionRepository = new TransactionRepository();
            // When this form in opened, main form will be hidden
            Instance.MainForm.Hide();
        }

        #region Button click events
        private void addBtn_Click(object sender, EventArgs e)
        {
            TransactionAddEdit transactionAddEdit = new TransactionAddEdit();
            transactionAddEdit.Activate();
            transactionAddEdit.Show();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (listViewTransaction.SelectedItems.Count > 0)
            {



                if (isRepeating)
                {
                    TransactionRepeat transaction = (TransactionRepeat)listViewTransaction.SelectedItems[0].Tag;
                    TransactionAddEdit transactionAddEdit = new TransactionAddEdit(transaction);
                    transactionAddEdit.Activate();
                    transactionAddEdit.Show();
                }
                else
                {
                    Transaction transaction = (Transaction)listViewTransaction.SelectedItems[0].Tag;
                    TransactionAddEdit transactionAddEdit = new TransactionAddEdit(transaction);
                    transactionAddEdit.Activate();
                    transactionAddEdit.Show();
                }
            }

         
        }
        #endregion
        private async void deleteBtn_Click(object sender, EventArgs e)
        {
            if (listViewTransaction.SelectedItems.Count > 0)
            {
                if (isRepeating)
                {
                   TransactionRepeat transaction = (TransactionRepeat)listViewTransaction.SelectedItems[0].Tag;

                    DialogResult dialogResult = MessageBox.Show("Do you want do delete the transaction?", "Confirm", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        bool x = await Task.Run(() => TransactionRecurringRepository.DeleteTransaction(transaction));
                        if (x)
                        {
                            MessageBox.Show("Transaction deleted");
                        }
                        else
                        {
                            MessageBox.Show("Transaction not deleted");
                        }
                    }
                }
                else
                {
                    Transaction transaction = (Transaction)listViewTransaction.SelectedItems[0].Tag;

                    DialogResult dialogResult = MessageBox.Show("Do you want do delete the transaction?", "Confirm", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        bool x = await Task.Run(() => transactionRepository.DeleteTransaction(transaction));
                        if (x)
                        {
                            MessageBox.Show("Transaction deleted");
                        }
                        else
                        {
                            MessageBox.Show("Transaction not deleted");
                        }
                    }
                }
            }
        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {
        }

        private void TransactionForm_FormClosed(object sender, FormClosedEventArgs e)
        {

            Instance.MainForm.Activate();
            Instance.MainForm.Show();

            Dispose();
        }

        private async void TransactionForm_Activated(object sender, EventArgs e)
        {
            if (isRepeating)
            {
                List<TransactionRepeat> transactionsList = await Task.Run(() => TransactionRecurringRepository.GetTransactions(Instance.StaticUserAccount.UserId));
                listViewTransaction.Items.Clear();
                foreach (TransactionRepeat transactionRepeat in transactionsList)
                {
                    string endDate = "";
                    if (transactionRepeat.subscriptionEndTime == DateTime.MinValue)
                    {
                        endDate = "N/A";
                    }
                    else
                    {
                        endDate = transactionRepeat.subscriptionEndTime.ToString();
                    }

                    ListViewItem listViewI = new ListViewItem(new string[] { transactionRepeat.transactionAmount.ToString("0.00"), transactionRepeat.typeValue, transactionRepeat.transactionCategory, transactionRepeat.dateTime.ToString(), transactionRepeat.contactName, transactionRepeat.transactionMessage, transactionRepeat.subscriptionPeriod, transactionRepeat.subscriptionEndTime.ToString() });
                    listViewI.Tag = transactionRepeat;
                    listViewTransaction.Items.Add(listViewI);
                }
            }
            else
            {
                List<Transaction> transactionsList = await Task.Run(() => transactionRepository.GetTransactions(Instance.StaticUserAccount.UserId));
                listViewTransaction.Items.Clear();
                foreach (Transaction transaction in transactionsList)
                {
                    ListViewItem listViewI = new ListViewItem(new string[] { transaction.transactionAmount.ToString("0.00"), transaction.typeValue, transaction.transactionCategory, transaction.dateTime.ToString(), transaction.contactName, transaction.transactionMessage });
                    listViewI.Tag = transaction;
                    listViewTransaction.Items.Add(listViewI);
                }
            }
        }

     

        private void panel1_Click(object sender, EventArgs e)
        {
            Instance.MainForm.Dispose();
        }

        private void mainBtn_Click(object sender, EventArgs e)
        {
            Instance.MainForm.Show();

            Close();
        }

        private void predictBtn_Click(object sender, EventArgs e)
        {
            financialPredictionForm financialPredictionForm = new financialPredictionForm();
            financialPredictionForm.Activate();
            financialPredictionForm.Show();
        }

        private void summaryBtn_Click(object sender, EventArgs e)
        {
            SummaryForm summaryForm = new SummaryForm();
            summaryForm.Activate();
            summaryForm.Show();
        }

        private void ContactBtn_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void ContactBtn_Click(object sender, EventArgs e)
        {
            ContactsForm contactsForm = new ContactsForm();
            contactsForm.Activate();
            contactsForm.Show();
        }
    }
}
