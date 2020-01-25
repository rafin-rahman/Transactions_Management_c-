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
            Instance.MainForm.Dispose();
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

        private void mainBtn_MouseEnter(object sender, EventArgs e)
        {
            panel4.Visible = true;
            pictureBox1.Visible = false;
            mainBtn.Font = new Font(mainBtn.Font, FontStyle.Bold);
            mainBtn.ForeColor = Color.White;
        }

        private void mainBtn_MouseLeave(object sender, EventArgs e)
        {
            panel4.Visible = false;
            pictureBox1.Visible = true;
            mainBtn.Font = new Font(mainBtn.Font, FontStyle.Regular);
            mainBtn.ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            panel5.Visible = false;
            pictureBox2.Visible = true;
            predictionBtn.Font = new Font(predictionBtn.Font, FontStyle.Regular);
            predictionBtn.ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            panel5.Visible = true;
            pictureBox2.Visible = false;
            predictionBtn.Font = new Font(predictionBtn.Font, FontStyle.Bold);
            predictionBtn.ForeColor = Color.White;
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

        private void ContactBtn_MouseEnter(object sender, EventArgs e)
        {
            panel10.Visible = true;
            pictureBox6.Visible = false;
            ContactBtn.Font = new Font(ContactBtn.Font, FontStyle.Bold);
            ContactBtn.ForeColor = Color.White;
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

        private void ContactBtn_MouseLeave(object sender, EventArgs e)
        {
            panel10.Visible = false;
            pictureBox6.Visible = true;
            ContactBtn.Font = new Font(ContactBtn.Font, FontStyle.Regular);
            ContactBtn.ForeColor = Color.FromArgb(224, 224, 224);
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

        private void eventsBtn_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void transactionBtn_Click(object sender, EventArgs e)
        {
            timer.Start();
        }
    }
}
