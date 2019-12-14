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

            bool checkIfFirst = true;
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
        private void runRecurringTransaction()
        {
            TransactionRecurringRepository transactionRecurringRepository = new TransactionRecurringRepository();
            TransactionRepository transactionRepo = new TransactionRepository();
            List<TransactionRepeat> transactionRepeats = transactionRecurringRepository.GetTransactions(Instance.StaticUserAccount.UserId);
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
                        transactionRepo.AddTransction(new Transaction
                        {
                            transactionCategory = transactionRepeat.transactionCategory,
                            userIdFk = transactionRepeat.userIdFk,
                            contactIdFk = transactionRepeat.contactIdFk,
                            //
                            incomeExpense = transactionRepeat.incomeExpense,
                            transactionAmount = transactionRepeat.transactionAmount,
                            transactionMessage = transactionRepeat.transactionMessage,
                            dateTime = recTime
                        });
                        recurringBGWorker.ReportProgress(0);
                    }
                    recTime = recTime.AddDays(1);
                }



            }



        }
        // ExecuteRecurringEvent
        private void runRecurringEvent()
        {
            EventRecurringRepository eventRecurringRepository = new EventRecurringRepository();
            EventRepository eventRepository = new EventRepository();
            List<EventRepeat> eventRepeats = eventRecurringRepository.GetEvents(Instance.StaticUserAccount.UserId);
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
                        eventRepository.AddEvent(new Event
                        {
                            title = eventRepeat.title,
                            userFK = eventRepeat.userFK,
                            contactFk = eventRepeat.contactFk,
                            //
                            status = eventRepeat.status,
                            location = eventRepeat.location,
                            message = eventRepeat.message,
                            date = recTime
                        });
                        recurringBGWorker.ReportProgress(0);
                    }
                    recTime = recTime.AddDays(1);
                }



            }



        }

        private void recurringBGWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (checkIfFirst == false)
            {
                new NotificationForm().Show();
            }
        }

        private void notificationBtn_Click(object sender, EventArgs e)
        {
            NotificationForm notificationForm = new NotificationForm();
            notificationForm.Activate();
            notificationForm.Show();

        }
    }
}
