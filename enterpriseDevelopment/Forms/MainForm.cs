using enterpriseDevelopment.Forms;
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
using Tulpep.NotificationWindow;

namespace enterpriseDevelopment
{
    public partial class MainForm : Form
    {
        private bool checkIfFirst = true;


       

        public MainForm()
        {
            InitializeComponent();

            // set reference to Instance class
            Instance.MainForm = this;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //
        private void MainForm_Activated(object sender, EventArgs e)
        {

            // comment to auto login
            if (Instance.StaticUserAccount == null)
            {
                Instance.StaticUserAccount = new UserAccount { UserId = 1, UserFName = "rafraf", LogDate = DateTime.Now.AddDays(-99).AddHours(5) };
            } 
            //  hide the mainform if the StaticUserAccount is empty
            if (Instance.StaticUserAccount == null)
            {
                LoginRegister LoginRegisterObj = new LoginRegister();
                LoginRegisterObj.Activate();
                LoginRegisterObj.Show();
            }
            else
            {
                if (!recurringBGWorker.IsBusy) recurringBGWorker.RunWorkerAsync();
            }

            
        }


        private void contactClickMainForm(object sender, EventArgs e)


        {
            ContactsForm contactsForm = new ContactsForm();
            contactsForm.Activate();
            contactsForm.Show();
        }

        private void transactionClickMainForm(object sender, EventArgs e)
        {

            


            TransactionForm transactionForm = new TransactionForm();
            transactionForm.Activate();
            transactionForm.Show();

        }

        private void repeatBtn_Click(object sender, EventArgs e)
        {
            TransactionForm transactionForm = new TransactionForm(true);
            transactionForm.Activate();
            transactionForm.Show();
        }
        private void event_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.Activate();
            eventForm.Show();
        }

        private void eventRecurring_Click(object sender, EventArgs e)
        {

            EventForm eventForm = new EventForm(true);
            eventForm.Activate();
            eventForm.Show();

        }

        private void summaryBtn_Click(object sender, EventArgs e)
        {
            SummaryForm summaryForm = new SummaryForm();
            summaryForm.Activate();
            summaryForm.Show();
        }

        private void predictBtn_Click(object sender, EventArgs e)
        {
            financialPredictionForm financialPredictionForm = new financialPredictionForm();
            financialPredictionForm.Activate();
            financialPredictionForm.Show();
        }
        //
        private void recurringBGWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            
            BackgroundWorker backgroundWorker = (BackgroundWorker)sender;
            while (!backgroundWorker.CancellationPending)
            {
                runRecurringTransaction();
                runRecurringEvent();
                if (checkIfFirst == true)
                {
                    checkIfFirst = false;
                }
                Instance.StaticUserAccount.LogDate = DateTime.Now;
                new UserRepository().EditLogDate(Instance.StaticUserAccount);
            }
        }
        //
        private async void runRecurringTransaction()
        {
            TransactionRecurringRepository transactionRecurringRepository = new TransactionRecurringRepository();
            TransactionRepository transactionRepo = new TransactionRepository();
            List<TransactionRepeat> transactionRepeats = await Task.Run(() => transactionRecurringRepository.GetTransactions(Instance.StaticUserAccount.UserId));
            foreach (TransactionRepeat transactionRepeat in transactionRepeats)
            {
                if (DateTime.Now > transactionRepeat.subscriptionEndTime && transactionRepeat.subscriptionEndTime != DateTime.MinValue) continue;
                

                DateTime accTime = Instance.StaticUserAccount.LogDate;
                DateTime nowTime = DateTime.Now;
                int days = (nowTime - accTime).Days;
                DateTime recTime = Instance.StaticUserAccount.LogDate;
                TimeSpan ts = new TimeSpan(
                    transactionRepeat.dateTime.Hour,
                    transactionRepeat.dateTime.Minute,
                    transactionRepeat.dateTime.Second
                    );
                recTime = recTime.Date + ts;
                for (int i = 0; i <= days; i++)
                {
                    if (transactionRepeat.subscriptionPeriod.Equals("Weekly"))
                    {
                        if (recTime.DayOfWeek != transactionRepeat.dateTime.DayOfWeek)
                        {
                            recTime = recTime.AddDays(1);
                            continue;
                        }
                    }
                    if (transactionRepeat.subscriptionPeriod.Equals("Monthly"))
                    {
                        if (recTime.Day != transactionRepeat.dateTime.Day)
                        {
                            recTime = recTime.AddDays(1);
                            continue;
                        }
                    }
                    if (transactionRepeat.subscriptionPeriod.Equals("Yearly"))
                    {
                        string recTimeString = recTime.ToString("dd/MM");
                        string createdDateString = transactionRepeat.dateTime.ToString("dd/MM");
                        if (!recTimeString.Equals(createdDateString))
                        {
                            recTime = recTime.AddDays(1);
                            continue;
                        }
                    }
                    if (recTime > accTime && recTime <= nowTime && recTime > transactionRepeat.dateTime)
                    {
                        bool check = await Task.Run(() => transactionRepo.AddTransction(new Transaction
                        {
                            transactionCategory = transactionRepeat.transactionCategory,
                            userIdFk = transactionRepeat.userIdFk,
                            contactIdFk = transactionRepeat.contactIdFk,
                            //
                            incomeExpense = transactionRepeat.incomeExpense,
                            transactionAmount = transactionRepeat.transactionAmount,
                            transactionMessage = transactionRepeat.transactionMessage,
                            dateTime = recTime
                        }));
                        recurringBGWorker.ReportProgress(0, "New Transaction!");
                    }
                    recTime = recTime.AddDays(1);
                }



            }



        }
        // ExecuteRecurringEvent
        private async void runRecurringEvent()
        {
            EventRecurringRepository eventRecurringRepository = new EventRecurringRepository();
            EventRepository eventRepository = new EventRepository();
            List<EventRepeat> eventRepeats = await Task.Run(() => eventRecurringRepository.GetEvents(Instance.StaticUserAccount.UserId));
            foreach (EventRepeat eventRepeat in eventRepeats)
            {
                if (DateTime.Now > eventRepeat.endDate && eventRepeat.endDate != DateTime.MinValue) continue;


                DateTime accessTime = Instance.StaticUserAccount.LogDate;
                DateTime currentTime = DateTime.Now;
                int days = (currentTime - accessTime).Days;
                DateTime recTime = Instance.StaticUserAccount.LogDate;
                TimeSpan timespan = new TimeSpan(
                    eventRepeat.date.Hour,
                    eventRepeat.date.Minute,
                    eventRepeat.date.Second
                    );
                recTime = recTime.Date + timespan;
                for (int i = 0; i <= days; i++)
                {
                    if (eventRepeat.period.Equals("Weekly"))
                    {
                        if (recTime.DayOfWeek != eventRepeat.date.DayOfWeek)
                        {
                            recTime = recTime.AddDays(1);
                            continue;
                        }
                    }
                    if (eventRepeat.period.Equals("Monthly"))
                    {
                        if (recTime.Day != eventRepeat.date.Day)
                        {
                            recTime = recTime.AddDays(1);
                            continue;
                        }
                    }
                    if (eventRepeat.period.Equals("Yearly"))
                    {
                        string recTimeString = recTime.ToString("dd/MM");
                        string createdDateString = eventRepeat.date.ToString("dd/MM");
                        if (!recTimeString.Equals(createdDateString))
                        {
                            recTime = recTime.AddDays(1);
                            continue;
                        }
                    }
                    if (recTime > accessTime && recTime <= currentTime && recTime > eventRepeat.date)
                    {
                        await Task.Run(() => eventRepository.AddEvent(new Event
                        {
                            title = eventRepeat.title,
                            userFK = eventRepeat.userFK,
                            contactFk = eventRepeat.contactFk,
                            //
                            status = eventRepeat.status,
                            location = eventRepeat.location,
                            message = eventRepeat.message,
                            date = recTime
                        }));
                        recurringBGWorker.ReportProgress(0,"New Event!");
                    }
                    recTime = recTime.AddDays(1);
                }



            }



        }

        private void recurringBGWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (checkIfFirst == false)
            {
                string text = (string)e.UserState;
                new NotificationForm(text).Show();
            }
        }

        #region Main page button hover animation

        private void panel3_Click(object sender, EventArgs e)
        {
            // Close Dashboard
            Close();
        }

        private void mainBtn_MouseEnter(object sender, EventArgs e)
        {
            panel4.Visible = true;
            pictureBox1.Visible = false;
        }

        private void mainBtn_MouseLeave(object sender, EventArgs e)
        {
            panel4.Visible = false;
            pictureBox1.Visible = true;
        }

        private void predictBtn_MouseEnter(object sender, EventArgs e)
        {
            panel5.Visible = true;
            pictureBox2.Visible = false;
        }

        private void predictBtn_MouseLeave(object sender, EventArgs e)
        {
            panel5.Visible = false;
            pictureBox2.Visible = true;
        }

        private void eventsBtn_MouseEnter(object sender, EventArgs e)
        {
            panel11.Visible = true;
            pictureBox3.Visible = false;
        }

        private void eventsBtn_MouseLeave(object sender, EventArgs e)
        {
            panel11.Visible = false;
            pictureBox3.Visible = true;
        }

        private void transactionBtn_MouseLeave(object sender, EventArgs e)
        {
            panel7.Visible = false;
            pictureBox4.Visible = true;
        }

        private void transactionBtn_MouseEnter(object sender, EventArgs e)
        {
            panel7.Visible = true;
            pictureBox4.Visible = false;
        }

        private void summaryBtn_MouseEnter(object sender, EventArgs e)
        {
            panel8.Visible = true;
            pictureBox5.Visible = false;
        }

        private void summaryBtn_MouseLeave(object sender, EventArgs e)
        {
            panel8.Visible = false;
            pictureBox5.Visible = true;
        }

        private void ContactBtn_MouseEnter(object sender, EventArgs e)
        {
            panel10.Visible = true;
            pictureBox6.Visible = false;
        }

        private void ContactBtn_MouseLeave(object sender, EventArgs e)
        {
            panel10.Visible = false;
            pictureBox6.Visible = true;
        }

        #endregion

       
    }
}
