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
        private bool isCollapsed = true;
        private bool isCollapsed2 = true;
        private bool isRepeating = false;
        private TransactionRepository transactionRepository;
        private TransactionRecurringRepository TransactionRecurringRepository;

        #region CONSTRUCTOR
        public TransactionForm()
        {
            InitializeComponent();
            transactionRepository = new TransactionRepository();
            UserInstance.MainForm.Hide();
            listViewTransaction.HideSelection = true;
        }

        public TransactionForm(bool recurring)
        {
            InitializeComponent();
            isRepeating = recurring;
            if (isRepeating == true)
            {
                listViewTransaction.Columns.Add("Period");
                listViewTransaction.Columns.Add("Ending date");
                listViewTransaction.HideSelection = true;
                TransactionRecurringRepository = new TransactionRecurringRepository();
            }

            transactionRepository = new TransactionRepository();
            UserInstance.MainForm.Hide();
        }
        #endregion
        
        // Loads list of transactions in the list view
        private async void TransactionForm_Activated(object sender, EventArgs e)
        {   // recurrig transaction
            if (isRepeating)
            {
                List<TransactionRecurring> transactionsList = await Task.Run(() => TransactionRecurringRepository.GetTransactions(UserInstance.StaticUserAccount.Id));
                listViewTransaction.Items.Clear();
                foreach (TransactionRecurring transactionRepeat in transactionsList)
                {
                    string endDate = "";
                    if (transactionRepeat.EndTime == DateTime.MinValue)
                        endDate = "N/A";
                    else
                        endDate = transactionRepeat.EndTime.ToString();

                    ListViewItem listViewI = new ListViewItem(new string[] { transactionRepeat.Amount.ToString("0.00"), transactionRepeat.TransactionType, transactionRepeat.Category, transactionRepeat.DateTime.ToString(), transactionRepeat.ContactName, transactionRepeat.Description, transactionRepeat.Period, endDate });

                    listViewI.Tag = transactionRepeat;
                    listViewTransaction.Items.Add(listViewI);
                }
            }
            else
            {   // normal transaction
                List<Transaction> transactionsList = await Task.Run(() => transactionRepository.GetTransactions(UserInstance.StaticUserAccount.Id));
                listViewTransaction.Items.Clear();
                foreach (Transaction transaction in transactionsList)
                {
                    ListViewItem listViewI = new ListViewItem(new string[] { transaction.Amount.ToString("0.00"), transaction.TransactionType, transaction.Category, transaction.DateTime.ToString(), transaction.ContactName, transaction.Description });
                    listViewI.Tag = transaction;
                    listViewTransaction.Items.Add(listViewI);
                }
            }
        }

        #region ADD - EDIT - DELETE 
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
                    TransactionRecurring transaction = (TransactionRecurring)listViewTransaction.SelectedItems[0].Tag;
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

        private async void deleteBtn_Click(object sender, EventArgs e)
        {
            if (listViewTransaction.SelectedItems.Count > 0)
            {
                if (isRepeating)
                {
                    TransactionRecurring transaction = (TransactionRecurring)listViewTransaction.SelectedItems[0].Tag;
                    DialogResult dialogResult = MessageBox.Show("Do you want do delete the transaction?", "Confirm", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        bool x = await Task.Run(() => TransactionRecurringRepository.DeleteTransaction(transaction));

                        if (x)
                            MessageBox.Show("Transaction deleted");
                        else
                            MessageBox.Show("Transaction not deleted");
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
                            MessageBox.Show("Transaction deleted");
                        else
                            MessageBox.Show("Transaction not deleted");
                    }
                }
            }
        }
        #endregion

        #region NAVIGATION BUTTONS
        private void mainBtn_Click(object sender, EventArgs e)
        {
            UserInstance.MainForm.Show();
            Close();
        }

        private void predictBtn_Click(object sender, EventArgs e)
        {
            financialPredictionForm financialPredictionForm = new financialPredictionForm();
            financialPredictionForm.Activate();
            financialPredictionForm.Show();
            Close();
        }

        private void singleEventBtn_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.Activate();
            eventForm.Show();
            Close();
        }

        private void recurringEventBtn_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm(true);
            eventForm.Activate();
            eventForm.Show();
            Close();
        }

        private void singleTransactionBtn_Click(object sender, EventArgs e)
        {
            TransactionForm transactionForm = new TransactionForm();
            transactionForm.Activate();
            transactionForm.Show();
            Close();
        }

        private void recurringTransactionBtn_Click(object sender, EventArgs e)
        {
            TransactionForm transactionForm = new TransactionForm(true);
            transactionForm.Activate();
            transactionForm.Show();
            Close();
        }

        private void summaryBtn_Click(object sender, EventArgs e)
        {
            SummaryForm summaryForm = new SummaryForm();
            summaryForm.Activate();
            summaryForm.Show();
            Close();
        }

        private void contactBtn_Click(object sender, EventArgs e)
        {
            ContactsForm contactsForm = new ContactsForm();
            contactsForm.Activate();
            contactsForm.Show();
            Close();
        }
        #endregion

        #region LIST VIEW COLUMN WIDTH
        private void listViewTransaction_SizeChanged(object sender, EventArgs e)
        {
            SetListViewColumns();
        }
        private void SetListViewColumns()
        {
            int total = listViewTransaction.Width - 18;
            int count = listViewTransaction.Columns.Count;
            int size = total / count;
            int last = total - (size * (count - 2));
            for (int i = 0; i < count; i++)
            {
                if (i == count - 1)
                    listViewTransaction.Columns[i].Width = last;
                else if (i == 0)
                    listViewTransaction.Columns[i].Width = last;
                else
                    listViewTransaction.Columns[i].Width = (int)(1.5 * size);
            }
        }
        #endregion

        #region HOVER ANIMATION
        private void mainBtn_MouseEnter(object sender, EventArgs e)
        {
            mainBoxPanel.Visible = true;
            mainIcon.Visible = false;
            mainBtn.Font = new Font(mainBtn.Font, FontStyle.Bold);
            mainBtn.ForeColor = Color.White;
        }

        private void mainBtn_MouseLeave(object sender, EventArgs e)
        {
            mainBoxPanel.Visible = false;
            mainIcon.Visible = true;
            mainBtn.Font = new Font(mainBtn.Font, FontStyle.Regular);
            mainBtn.ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void predictBtn_MouseEnter(object sender, EventArgs e)
        {
            predictionBoxPanel.Visible = true;
            predictionIcon.Visible = false;
            predictBtn.Font = new Font(predictBtn.Font, FontStyle.Bold);
            predictBtn.ForeColor = Color.White;
        }

        private void predictBtn_MouseLeave(object sender, EventArgs e)
        {
            predictionBoxPanel.Visible = false;
            predictionIcon.Visible = true;
            predictBtn.Font = new Font(predictBtn.Font, FontStyle.Regular);
            predictBtn.ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void eventsBtn_MouseEnter(object sender, EventArgs e)
        {
            eventBoxIcon.Visible = true;
            eventIcon.Visible = false;
            eventsBtn.Font = new Font(eventsBtn.Font, FontStyle.Bold);
            eventsBtn.ForeColor = Color.White;
        }

        private void eventsBtn_MouseLeave(object sender, EventArgs e)
        {
            eventBoxIcon.Visible = false;
            eventIcon.Visible = true;
            eventsBtn.Font = new Font(eventsBtn.Font, FontStyle.Regular);
            eventsBtn.ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void transactionBtn_MouseEnter(object sender, EventArgs e)
        {
            transactionBoxPanel.Visible = true;
            transactionIcon.Visible = false;
            transactionBtn.Font = new Font(transactionBtn.Font, FontStyle.Bold);
            transactionBtn.ForeColor = Color.White;
        }

        private void transactionBtn_MouseLeave(object sender, EventArgs e)
        {
            transactionBoxPanel.Visible = false;
            transactionIcon.Visible = true;
            transactionBtn.Font = new Font(transactionBtn.Font, FontStyle.Regular);
            transactionBtn.ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void summaryBtn_MouseEnter(object sender, EventArgs e)
        {
            summaryBoxPanel.Visible = true;
            summaryIcon.Visible = false;
            summaryBtn.Font = new Font(summaryBtn.Font, FontStyle.Bold);
            summaryBtn.ForeColor = Color.White;
        }

        private void summaryBtn_MouseLeave(object sender, EventArgs e)
        {
            summaryBoxPanel.Visible = false;
            summaryIcon.Visible = true;
            summaryBtn.Font = new Font(summaryBtn.Font, FontStyle.Regular);
            summaryBtn.ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void contactBtn_MouseEnter(object sender, EventArgs e)
        {
            contactBoxPanel.Visible = true;
            contactIcon.Visible = false;
            contactBtn.Font = new Font(contactBtn.Font, FontStyle.Bold);
            contactBtn.ForeColor = Color.White;
        }

        private void contactBtn_MouseLeave(object sender, EventArgs e)
        {
            contactBoxPanel.Visible = false;
            contactIcon.Visible = true;
            contactBtn.Font = new Font(contactBtn.Font, FontStyle.Regular);
            contactBtn.ForeColor = Color.FromArgb(224, 224, 224);
        }
        #endregion

        #region ANIMATION TIMER
        private void eventsBtn_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isCollapsed2)
            {
                eventToogle.Width += 20;
                if (eventToogle.Size == eventToogle.MaximumSize)
                {
                    timer2.Stop();
                    isCollapsed2 = false;
                }
            }
            else
            {
                eventToogle.Width -= 20;
                if (eventToogle.Size == eventToogle.MinimumSize)
                {
                    timer2.Stop();
                    isCollapsed2 = true;
                }
            }
        }

        private void transactionBtn_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                transactionToogle.Width += 20;
                if (transactionToogle.Size == transactionToogle.MaximumSize)
                {
                    timer.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                transactionToogle.Width -= 20;
                if (transactionToogle.Size == transactionToogle.MinimumSize)
                {
                    timer.Stop();
                    isCollapsed = true;
                }
            }
        }
        #endregion
        
        private void TransactionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            UserInstance.MainForm.Activate();
            UserInstance.MainForm.Show();
            Dispose();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            UserInstance.MainForm.Dispose();
        }

        
    }
}
