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
        private TransactionRepository transactionRepository;
        private TransactionRecurringRepository TransactionRecurringRepository;
        private bool isRepeating = false;
        public TransactionForm()
        {
            InitializeComponent();
            transactionRepository = new TransactionRepository();
            UserInstance.MainForm.Hide();
            listViewTransaction.HideSelection = true;
        }

        public TransactionForm(bool repeat)
        {
            InitializeComponent();
            isRepeating = repeat;
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
        #endregion
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

        private void TransactionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            UserInstance.MainForm.Activate();
            UserInstance.MainForm.Show();
            Dispose();
        }

        private async void TransactionForm_Activated(object sender, EventArgs e)
        {
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
            {
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

        private void panel1_Click(object sender, EventArgs e)
        {
            UserInstance.MainForm.Dispose();
        }

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

        private void summaryBtn_Click(object sender, EventArgs e)
        {
            SummaryForm summaryForm = new SummaryForm();
            summaryForm.Activate();
            summaryForm.Show();
            Close();
        }

        private void ContactBtn_Click(object sender, EventArgs e)
        {
            ContactsForm contactsForm = new ContactsForm();
            contactsForm.Activate();
            contactsForm.Show();
            Close();
        }

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

        private void mainBtn_MouseEnter(object sender, EventArgs e)
        {
            panel14.Visible = true;
            pictureBox1.Visible = false;
            mainBtn.Font = new Font(mainBtn.Font, FontStyle.Bold);
            mainBtn.ForeColor = Color.White;
        }

        private void mainBtn_MouseLeave(object sender, EventArgs e)
        {
            panel14.Visible = false;
            pictureBox1.Visible = true;
            mainBtn.Font = new Font(mainBtn.Font, FontStyle.Regular);
            mainBtn.ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void predictBtn_MouseEnter(object sender, EventArgs e)
        {
            panel5.Visible = true;
            pictureBox2.Visible = false;
            predictBtn.Font = new Font(predictBtn.Font, FontStyle.Bold);
            predictBtn.ForeColor = Color.White;
        }

        private void predictBtn_MouseLeave(object sender, EventArgs e)
        {
            panel5.Visible = false;
            pictureBox2.Visible = true;
            predictBtn.Font = new Font(predictBtn.Font, FontStyle.Regular);
            predictBtn.ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void eventsBtn_MouseEnter(object sender, EventArgs e)
        {
            panel11.Visible = true;
            pictureBox3.Visible = false;
            eventsBtn.Font = new Font(eventsBtn.Font, FontStyle.Bold);
            eventsBtn.ForeColor = Color.White;
        }

        private void eventsBtn_MouseLeave(object sender, EventArgs e)
        {
            panel11.Visible = false;
            pictureBox3.Visible = true;
            eventsBtn.Font = new Font(eventsBtn.Font, FontStyle.Regular);
            eventsBtn.ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void transactionBtn_MouseEnter(object sender, EventArgs e)
        {
            panel7.Visible = true;
            pictureBox4.Visible = false;
            transactionBtn.Font = new Font(transactionBtn.Font, FontStyle.Bold);
            transactionBtn.ForeColor = Color.White;
        }

        private void transactionBtn_MouseLeave(object sender, EventArgs e)
        {
            panel7.Visible = false;
            pictureBox4.Visible = true;
            transactionBtn.Font = new Font(transactionBtn.Font, FontStyle.Regular);
            transactionBtn.ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void summaryBtn_MouseEnter(object sender, EventArgs e)
        {
            panel8.Visible = true;
            pictureBox5.Visible = false;
            summaryBtn.Font = new Font(summaryBtn.Font, FontStyle.Bold);
            summaryBtn.ForeColor = Color.White;
        }

        private void summaryBtn_MouseLeave(object sender, EventArgs e)
        {
            panel8.Visible = false;
            pictureBox5.Visible = true;
            summaryBtn.Font = new Font(summaryBtn.Font, FontStyle.Regular);
            summaryBtn.ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void ContactBtn_MouseEnter(object sender, EventArgs e)
        {
            panel10.Visible = true;
            pictureBox6.Visible = false;
            ContactBtn.Font = new Font(ContactBtn.Font, FontStyle.Bold);
            ContactBtn.ForeColor = Color.White;
        }

        private void ContactBtn_MouseLeave(object sender, EventArgs e)
        {
            panel10.Visible = false;
            pictureBox6.Visible = true;
            ContactBtn.Font = new Font(ContactBtn.Font, FontStyle.Regular);
            ContactBtn.ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void eventsBtn_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void transactionBtn_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelToggle1.Width += 20;
                if (panelToggle1.Size == panelToggle1.MaximumSize)
                {
                    timer.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                panelToggle1.Width -= 20;
                if (panelToggle1.Size == panelToggle1.MinimumSize)
                {
                    timer.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isCollapsed2)
            {
                panelToogle2.Width += 20;
                if (panelToogle2.Size == panelToogle2.MaximumSize)
                {
                    timer2.Stop();
                    isCollapsed2 = false;
                }
            }
            else
            {
                panelToogle2.Width -= 20;
                if (panelToogle2.Size == panelToogle2.MinimumSize)
                {
                    timer2.Stop();
                    isCollapsed2 = true;
                }
            }
        }

        private void allEventBtn_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.Activate();
            eventForm.Show();
            Close();
        }

        private void repeatBtn_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm(true);
            eventForm.Activate();
            eventForm.Show();
            Close();
        }

        private void recurringToggleBtn_Click(object sender, EventArgs e)
        {
            TransactionForm transactionForm = new TransactionForm();
            transactionForm.Activate();
            transactionForm.Show();
            Close();
        }

        private void eventsRepeatBtn_Click(object sender, EventArgs e)
        {
            TransactionForm transactionForm = new TransactionForm(true);
            transactionForm.Activate();
            transactionForm.Show();
            Close();
        }
    }
}
