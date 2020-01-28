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
    public partial class SummaryForm : Form
    {
        private bool isCollapsed = true;
        private bool isCollapsed2 = true;
        private TransactionRepository transactionRepository;
        private List<Transaction> transactions;

        #region CONSTRUCTOR
        public SummaryForm()
        {
            InitializeComponent();
            UserInstance.MainForm.Hide();
            transactionRepository = new TransactionRepository();
            // it will select the first index instead of having empty string in the design
            showByComboBox.SelectedIndex = 0;
        }
        private void SummaryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            UserInstance.MainForm.Activate();
            UserInstance.MainForm.Show();
            Dispose();
        }
        #endregion

        private async void summaryBtn_Click(object sender, EventArgs e)
        {
            // set time of the starting period from 12AM
            startDate.Value = startDate.Value.Date + new TimeSpan();
            // set time of the end of the day  to 23:59:59
            endDate.Value = endDate.Value.Date + new TimeSpan(23, 59, 59);

            if (startDate.Value > endDate.Value)
            {
                MessageBox.Show("Starting date cannot be greater than ending date");
                return;
            }

            if (transactions == null)
                transactions = await Task.Run(() => transactionRepository.GetTransactions(UserInstance.StaticUserAccount.Id));

            listViewSummary.Items.Clear();
            List<Transaction> tempList = new List<Transaction>();

            for (int i = 0; i < transactions.Count; i++)
            {
                // if the starting date is smaller than the date allocated to transaction OR ending date is bigger than transaction allocated date it will  be removed
                if (transactions[i].DateTime >= startDate.Value && transactions[i].DateTime <= endDate.Value)
                    tempList.Add(transactions[i]);
            }

            if (showByComboBox.Text.Equals("Transactions"))
            {
                listViewSummary.Columns.Clear();
                listViewSummary.Columns.Add("Category", 110);
                listViewSummary.Columns.Add("Amount", 110);
                listViewSummary.Columns.Add("Income / Expense", 110);
                listViewSummary.Columns.Add("Date", 110);
                listViewSummary.Columns.Add("Contact", 110);

                foreach (Transaction transaction in tempList)
                {
                    ListViewItem listViewToString = new ListViewItem(new string[] { transaction.Category.ToString(), transaction.Amount.ToString("0.00"), transaction.TransactionType.ToString(), transaction.DateTime.ToString(), transaction.ContactName.ToString() });
                    listViewSummary.Items.Add(listViewToString);
                }
            }
            // DAYS
            else if (showByComboBox.Text.Equals("Days"))
            {
                listViewSummary.Columns.Clear();
                List<DateTime> dateList = new List<DateTime>();
                List<decimal> incomeList = new List<decimal>();
                List<decimal> expenseList = new List<decimal>();
                foreach (Transaction transaction in tempList)
                {
                    int y = -1;

                    for (int x = 0; x < dateList.Count; x++)
                    {
                        if (dateList[x].Date == transaction.DateTime.Date)
                        {
                            y = x;
                            break;
                        }
                    }

                    if (y == -1)
                    {
                        dateList.Add(transaction.DateTime);
                         expenseList.Add(0);
                        incomeList.Add(0);
                        y = dateList.Count - 1;
                    }
                    if (transaction.IncomeExpense)
                    {
                        expenseList[y] += transaction.Amount;
                    }
                    else
                    {
                        incomeList[y] += transaction.Amount;
                    }
                }

                listViewSummary.Columns.Add("Date", 100);
                listViewSummary.Columns.Add("Income", 80);
                listViewSummary.Columns.Add("Expense", 80);

                for (int i = 0; i < dateList.Count; i++)
                {
                    ListViewItem listViewItem = new ListViewItem(new string[] {
                        dateList[i].ToShortDateString(),
                        incomeList[i].ToString("0.00"),
                        expenseList[i].ToString("0.00")
                    });
                    listViewSummary.Items.Add(listViewItem);
                }
            }

            // MONTHS
            else if (showByComboBox.Text.Equals("Months"))
            {
                listViewSummary.Columns.Clear();
                List<string> monthList = new List<string>();
                List<decimal> incomeList = new List<decimal>();
                List<decimal> expenseList = new List<decimal>();
                foreach (Transaction transaction in tempList)
                {
                    int y = -1;

                    for (int x = 0; x < monthList.Count; x++)
                    {
                        if (monthList[x].Equals(transaction.DateTime.ToString("MM/yyyy")))
                        {
                            y = x;
                            break;
                        }
                    }

                    if (y == -1)
                    {
                        monthList.Add(transaction.DateTime.ToString("MM/yyyy"));
                        expenseList.Add(0);
                        incomeList.Add(0);
                        y = monthList.Count - 1;
                    }
                    if (transaction.IncomeExpense)
                        expenseList[y] += transaction.Amount;
                    else
                        incomeList[y] += transaction.Amount;
                }

                listViewSummary.Columns.Add("Date", 100);
                listViewSummary.Columns.Add("Income", 80);
                listViewSummary.Columns.Add("Expense", 80);

                for (int i = 0; i < monthList.Count; i++)
                {
                    ListViewItem listViewItem = new ListViewItem(new string[] {
                        monthList[i],
                        incomeList[i].ToString("0.00"),
                        expenseList[i].ToString("0.00")
                    });
                    listViewSummary.Items.Add(listViewItem);
                }
            }

            // YEARS
            else if (showByComboBox.Text.Equals("Years"))
            {
                listViewSummary.Columns.Clear();
                List<string> yearList = new List<string>();
                List<decimal> incomeList = new List<decimal>();
                List<decimal> expenseList = new List<decimal>();
                foreach (Transaction transaction in tempList)
                {
                    int y = -1;

                    for (int x = 0; x < yearList.Count; x++)
                    {
                        if (yearList[x].Equals(transaction.DateTime.ToString("yyyy")))
                        {
                            y = x;
                            break;
                        }
                    }

                    if (y == -1)
                    {
                        yearList.Add(transaction.DateTime.ToString("yyyy"));
                        expenseList.Add(0);
                        incomeList.Add(0);
                        y = yearList.Count - 1;
                    }
                    if (transaction.IncomeExpense)
                        expenseList[y] += transaction.Amount;
                    else
                        incomeList[y] += transaction.Amount;
                }

                listViewSummary.Columns.Add("Date", 100);
                listViewSummary.Columns.Add("Income", 80);
                listViewSummary.Columns.Add("Expense", 80);

                for (int i = 0; i < yearList.Count; i++)
                {
                    ListViewItem listViewItem = new ListViewItem(new string[] {
                        yearList[i],
                        incomeList[i].ToString("0.00"),
                        expenseList[i].ToString("0.00")
                    });
                    listViewSummary.Items.Add(listViewItem);
                }
            }
            else
                MessageBox.Show("Something went wrong while showing items", "Error");
        }

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
        
        

        private void eventBtn_Click(object sender, EventArgs e)
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

        private void reucurringTransactionBtn_Click(object sender, EventArgs e)
        {
            TransactionForm transactionForm = new TransactionForm(true);
            transactionForm.Activate();
            transactionForm.Show();
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

        private void listViewSummary_SizeChanged(object sender, EventArgs e)
        {
            SetListViewColumns();
        }
        // sets the column width based on the window size
        private void SetListViewColumns()
        {
            int total = listViewSummary.Width - 18;
            int count = listViewSummary.Columns.Count;
            int size = total / count;
            int last = total - (size * (count - 2));
            for (int i = 0; i < count; i++)
            {
                if (i == count - 1)
                    listViewSummary.Columns[i].Width = last;

                else if (i == 0)
                    listViewSummary.Columns[i].Width = last;
                else
                    listViewSummary.Columns[i].Width = (int)(1.5 * size);
            }
        }

        #region BUTTONS HOVER ANIMATION
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
            eventBoxPanel.Visible = true;
            eventIcon.Visible = false;
            eventsBtn.Font = new Font(eventsBtn.Font, FontStyle.Bold);
            eventsBtn.ForeColor = Color.White;
        }

        private void eventsBtn_MouseLeave(object sender, EventArgs e)
        {
            eventBoxPanel.Visible = false;
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
            summaryBtn0.Font = new Font(summaryBtn0.Font, FontStyle.Bold);
            summaryBtn0.ForeColor = Color.White;
        }

        private void summaryBtn_MouseLeave(object sender, EventArgs e)
        {
            summaryBoxPanel.Visible = false;
            summaryIcon.Visible = true;
            summaryBtn0.Font = new Font(summaryBtn0.Font, FontStyle.Regular);
            summaryBtn0.ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void contactBtn_MouseEnter(object sender, EventArgs e)
        {
            contactBoxPanel.Visible = true;
            contactIcon.Visible = false;
            ContactBtn.Font = new Font(ContactBtn.Font, FontStyle.Bold);
            ContactBtn.ForeColor = Color.White;
        }

        private void contactBtn_MouseLeave(object sender, EventArgs e)
        {
            contactBoxPanel.Visible = false;
            contactIcon.Visible = true;
            ContactBtn.Font = new Font(ContactBtn.Font, FontStyle.Regular);
            ContactBtn.ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void closePanel_MouseEnter(object sender, EventArgs e)
        {
            this.closePanel.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.closeHover));
        }

        private void closePanel_MouseLeave(object sender, EventArgs e)
        {
            this.closePanel.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.close));
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

        private void closePanel_Click(object sender, EventArgs e)
        {
            UserInstance.MainForm.Dispose();
        }
    }
}
