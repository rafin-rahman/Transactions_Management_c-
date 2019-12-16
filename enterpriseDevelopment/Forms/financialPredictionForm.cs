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

        private List<Transaction> transactions;
        private List<TransactionRepeat> transactionRepeats;
        private TransactionRepository transactionRepository;
        private TransactionRecurringRepository transactionRecurringRepository;
        private decimal GetAvg()
        {
            decimal sumDayOfWeek = 0;
            decimal sumDayOfMonth = 0;
            decimal sumLastMonth = 0;

            List<DateTime> datesOfWeek = new List<DateTime>();
            List<DateTime> datesOfMonth = new List<DateTime>();
            List<DateTime> datesOfLastMonth = new List<DateTime>();

            DateTime predicDate = datePicker.SelectionRange.Start;
            DateTime lastMonth = predicDate.AddMonths(-1);

            foreach (Transaction t in transactions)
            {
                if (t.dateTime.DayOfWeek == predicDate.DayOfWeek)
                {
                    sumDayOfWeek += t.transactionAmount;
                    if (!datesOfWeek.Contains(t.dateTime.Date))
                    {
                        datesOfWeek.Add(t.dateTime.Date);
                    }
                }

                if (t.dateTime.Day == predicDate.Day)
                {
                    sumDayOfMonth += t.transactionAmount;
                    if (!datesOfWeek.Contains(t.dateTime.Date))
                    {
                        datesOfWeek.Add(t.dateTime.Date);
                    }
                }

                if (t.dateTime >= lastMonth)
                {
                    sumLastMonth += t.transactionAmount;
                    if (!datesOfLastMonth.Contains(t.dateTime.Date))
                    {
                        datesOfLastMonth.Add(t.dateTime.Date);
                    }
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
            {
                average = sumOfAvg / n;
            }

            return average;
        }
        private decimal GetRecurringAmount()
        {
            decimal totRecurring = 0;
            DateTime predicDate = datePicker.SelectionRange.Start;
            foreach (TransactionRepeat transactionRepeat in transactionRepeats)
            {
                string tDateString = transactionRepeat.dateTime.ToString("dd/MM");
                string predictDateString = predicDate.ToString("dd/MM");
                if (transactionRepeat.subscriptionPeriod.Equals("Yearly"))
                {
                    if (tDateString.Equals(predictDateString))
                    {
                        totRecurring += transactionRepeat.transactionAmount;
                    }
                }

                if (transactionRepeat.subscriptionPeriod.Equals("Monthly"))
                {
                    if (transactionRepeat.dateTime.Day == predicDate.Day)
                    {
                        totRecurring += transactionRepeat.transactionAmount;
                    }
                }

                if (transactionRepeat.subscriptionPeriod.Equals("Weekly"))
                {
                    if (transactionRepeat.dateTime.DayOfWeek == predicDate.DayOfWeek)
                    {
                        totRecurring += transactionRepeat.transactionAmount;
                    }
                }


                if (transactionRepeat.subscriptionPeriod.Equals("Daily"))
                {
                    totRecurring += transactionRepeat.transactionAmount;

                }


            }

            return totRecurring;
        }

        public financialPredictionForm()
        {
            InitializeComponent();
            transactionRepository = new TransactionRepository();
            transactionRecurringRepository = new TransactionRecurringRepository();
        }



        private async void predictBtn_Click(object sender, EventArgs e)
        {
            if (transactions == null)
            {
                transactions = await Task.Run(() => transactionRepository.GetTransactions(Instance.StaticUserAccount.UserId));
                List<Transaction> tempTransactions = new List<Transaction>();
                foreach (Transaction transaction in transactions)
                {
                    if (transaction.incomeExpense == false)
                    {
                        tempTransactions.Add(transaction);
                    }
                }
                transactions = tempTransactions;
            }

            if (transactionRepeats == null)
            {
                transactionRepeats = await Task.Run(() => transactionRecurringRepository.GetTransactions(Instance.StaticUserAccount.UserId));
                List<TransactionRepeat> tempTransactions = new List<TransactionRepeat>();
                foreach (TransactionRepeat transaction in transactionRepeats)
                {
                    if (transaction.incomeExpense == false)
                    {
                        tempTransactions.Add(transaction);
                    }
                }
                transactionRepeats = tempTransactions;
            }

            decimal average = GetAvg();

            decimal totalRecurring = GetRecurringAmount();

            if (average > totalRecurring)
            {
                resultLbl.Text = "The result is " + average;
            }
            else
            {
                resultLbl.Text = "The result is " + totalRecurring;
            }
        }

        private void financialPredictionForm_Load(object sender, EventArgs e)
        {

        }

        private void closePanel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void closePanel_MouseEnter(object sender, EventArgs e)
        {
            this.closePanel.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.closeHover));
        }

        private void closePanel_MouseLeave(object sender, EventArgs e)
        {
            this.closePanel.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.close));
        }

        private void mainBtn_Click(object sender, EventArgs e)
        {
            Instance.MainForm.Show();

            Close();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void ContactBtn_Click(object sender, EventArgs e)
        {
            ContactsForm contactsForm = new ContactsForm();
            contactsForm.Activate();
            contactsForm.Show();
        }
    }
}
