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
    public partial class financialPredictionForm : Form
    {
        private bool isCollapsed = true;
        private bool isCollapsed2 = true;
        private List<Transaction> transactions;
        private List<TransactionRecurring> recurringTransactions;
        private TransactionRepository transactionRepository;
        private TransactionRecurringRepository transactionRecurringRepository;

        public financialPredictionForm()
        {
            InitializeComponent();
            transactionRepository = new TransactionRepository();
            transactionRecurringRepository = new TransactionRecurringRepository();
        }

        
        private decimal GetPrediction()
        {
            decimal sumDayOfWeek = 0;
            decimal sumDayOfMonth = 0;
            decimal sumLastMonth = 0;

            List<DateTime> datesOfWeek = new List<DateTime>();
            List<DateTime> datesOfMonth = new List<DateTime>();
            List<DateTime> datesOfLastMonth = new List<DateTime>();
            // Gets the prediction date from the user
            DateTime predicDate = datePicker.SelectionRange.Start;
            // Deducts 1 month from the date chosen above
            DateTime lastMonth = predicDate.AddMonths(-1);

            foreach (Transaction transaction in transactions)
            {   // getting transaction which has the same day of the prediction day 
                // eg. preicted day is a Monday, it will get all the transaction of the previous mondays
                if (transaction.DateTime.DayOfWeek == predicDate.DayOfWeek)
                {
                    sumDayOfWeek += transaction.Amount;
                    if (!datesOfWeek.Contains(transaction.DateTime.Date))
                        datesOfWeek.Add(transaction.DateTime.Date);
                }
                // getting transaction which has the same month of the prediction month 
                // eg. 26/10/2019, 26/11/2019 and 26/12/2019
                if (transaction.DateTime.Day == predicDate.Day)
                {
                    sumDayOfMonth += transaction.Amount;
                    if (!datesOfWeek.Contains(transaction.DateTime.Date))
                        datesOfWeek.Add(transaction.DateTime.Date);
                }
                // getting transaction of the month before the predicted day
                if (transaction.DateTime >= lastMonth)
                {
                    sumLastMonth += transaction.Amount;
                    if (!datesOfLastMonth.Contains(transaction.DateTime.Date))
                        datesOfLastMonth.Add(transaction.DateTime.Date);
                }
            }
            
            decimal sumOfAvg = 0;
            
            int n = 0;
            if (datesOfWeek.Count > 0)
            {
                n++;
                sumOfAvg += sumDayOfWeek / datesOfWeek.Count;
            }

            if (datesOfMonth.Count > 0)
            {
                n++;
                sumOfAvg += sumDayOfMonth / datesOfMonth.Count;
            }

            if (datesOfLastMonth.Count > 0)
            {
                n++;
                sumOfAvg += sumLastMonth / datesOfLastMonth.Count;
            }
            
            decimal average = 0;

            if (n > 0)
                average = sumOfAvg / n;

            return average;
        }

        private decimal GetRecurringAmount()
        {
            decimal totRecurring = 0;
            DateTime predicDate = datePicker.SelectionRange.Start;
            foreach (TransactionRecurring transactionRepeat in recurringTransactions)
            {
                string tDateString = transactionRepeat.DateTime.ToString("dd/MM");
                string predictDateString = predicDate.ToString("dd/MM");
                if (transactionRepeat.Period.Equals("Yearly"))
                {
                    if (tDateString.Equals(predictDateString))
                        totRecurring += transactionRepeat.Amount;
                }

                if (transactionRepeat.Period.Equals("Monthly"))
                {
                    if (transactionRepeat.DateTime.Day == predicDate.Day)
                        totRecurring += transactionRepeat.Amount;
                }

                if (transactionRepeat.Period.Equals("Weekly"))
                {
                    if (transactionRepeat.DateTime.DayOfWeek == predicDate.DayOfWeek)
                        totRecurring += transactionRepeat.Amount;
                }
                
                if (transactionRepeat.Period.Equals("Daily"))
                    totRecurring += transactionRepeat.Amount;
            }
            return totRecurring;
        }

        private async void predictBtn_Click(object sender, EventArgs e)
        {
            if (transactions == null)
            {
                transactions = await Task.Run(() => transactionRepository.GetTransactions(UserInstance.StaticUserAccount.Id));
                List<Transaction> tempTransactions = new List<Transaction>();
                foreach (Transaction transaction in transactions)
                {
                    if (transaction.IncomeExpense == false)
                        tempTransactions.Add(transaction);
                }
                transactions = tempTransactions;
            }

            if (recurringTransactions == null)
            {
                recurringTransactions = await Task.Run(() => transactionRecurringRepository.GetTransactions(UserInstance.StaticUserAccount.Id));
                List<TransactionRecurring> tempTransactions = new List<TransactionRecurring>();
                foreach (TransactionRecurring transaction in recurringTransactions)
                {
                    if (transaction.IncomeExpense == false)
                        tempTransactions.Add(transaction);
                }
                recurringTransactions = tempTransactions;
            }

            decimal average = GetPrediction();
            decimal totalRecurring = GetRecurringAmount();

            if (average > totalRecurring)
                resultLbl.Text = "The result is " + average;
            else
                resultLbl.Text = "The result is " + totalRecurring;
        }

        #region NAVIGATION BUTTONS HOVER ANIMATION
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
                transactionToggle.Width += 20;
                if (transactionToggle.Size == transactionToggle.MaximumSize)
                {
                    timer.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                transactionToggle.Width -= 20;
                if (transactionToggle.Size == transactionToggle.MinimumSize)
                {
                    timer.Stop();
                    isCollapsed = true;
                }
            }
        }
        #endregion

        #region NAVIGATION BUTTONS CLICK
        private void mainBtn_Click(object sender, EventArgs e)
        {
            UserInstance.MainForm.Show();
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

        private void transactiontBtn_Click(object sender, EventArgs e)
        {
            TransactionForm transactionForm = new TransactionForm(true);
            transactionForm.Activate();
            transactionForm.Show();
            Close();
        }

        private void recurringTransactionBtn_Click(object sender, EventArgs e)
        {
            TransactionForm transactionForm = new TransactionForm();
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

        #region CLOSE BUTTON HOVER ANIMATION
        private void closePanel_MouseEnter(object sender, EventArgs e)
        {
            this.closePanel.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.closeHover));
        }

        private void closePanel_MouseLeave(object sender, EventArgs e)
        {
            this.closePanel.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.close));
        }
        #endregion

        private void closePanel_Click(object sender, EventArgs e)
        {
            UserInstance.MainForm.Dispose();
        }
    }
}
