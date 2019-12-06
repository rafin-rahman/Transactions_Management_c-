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
        public TransactionForm()
        {
            InitializeComponent();
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

                Contact contact = (Contact)listViewTransaction.SelectedItems[0].Tag;
                ContactAddEdit contactAddEdit = new ContactAddEdit(contact);
                contactAddEdit.Activate();
                contactAddEdit.Show();
            }

         
        }
        #endregion

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (listViewTransaction.SelectedItems.Count > 0)
            {
                Transaction transaction = (Transaction)listViewTransaction.SelectedItems[0].Tag;

                DialogResult dialogResult = MessageBox.Show("Do you want do delete the transaction?", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes) { 
                bool x = transactionRepository.DeleteTransaction(transaction);
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

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void TransactionForm_Activated(object sender, EventArgs e)
        {
            List<Transaction> transactionsList = transactionRepository.GetTransactions(Instance.StaticUserAccount.UserId);
            listViewTransaction.Items.Clear();
            foreach (Transaction transaction in transactionsList)
            {
                ListViewItem listViewI = new ListViewItem(new string[] { transaction.transactionAmount.ToString(),transaction.typeValue,transaction.transactionCategory, transaction.dateTime.ToString() ,transaction.contactName,transaction.transactionMessage });
                listViewI.Tag = transaction;
                listViewTransaction.Items.Add(listViewI);
            }
        }
    }
}
