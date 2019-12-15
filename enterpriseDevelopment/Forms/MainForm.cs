﻿using enterpriseDevelopment.Forms;
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


namespace enterpriseDevelopment
{
    public partial class MainForm : Form
    {
        private bool checkIfFirst = true;
        private bool isCollapsed = true;

        TransactionRepository transactionRepository;
        private List<Transaction> todaysTransaction;
        Panel dashboardPanel;
        public MainForm()
        {
            InitializeComponent();
            transactionRepository = new TransactionRepository();
            todaysTransaction = new List<Transaction>();
            // set reference to Instance class
            Instance.MainForm = this;
            dashboardPanel = new Panel();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Instance.StaticUserAccount == null)
            {
            }
            else
            {
            }
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
                GetTransactionList();
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


            timer.Start();

            

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
                        recurringBGWorker.ReportProgress(0, "New Event!");
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

        private void closePanel_MouseEnter(object sender, EventArgs e)
        {
            this.closePanel.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.closeNewIcon));
        }

        private void closePanel_MouseLeave(object sender, EventArgs e)
        {
            this.closePanel.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.closeHoverIcon));
        }

        private void closePanel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mainBtn_MouseEnter(object sender, EventArgs e)
        {
            panel4.Visible = true;
            pictureBox1.Visible = false;
            mainBtn.Font = new Font(mainBtn.Font, FontStyle.Bold);
            mainBtn.ForeColor = Color.MistyRose;
        }

        private void mainBtn_MouseLeave(object sender, EventArgs e)
        {
            panel4.Visible = false;
            pictureBox1.Visible = true;
            mainBtn.Font = new Font(mainBtn.Font, FontStyle.Regular);
            mainBtn.ForeColor = Color.LavenderBlush;
        }

        private void predictBtn_MouseEnter(object sender, EventArgs e)
        {
            panel5.Visible = true;
            pictureBox2.Visible = false;
            predictBtn.Font = new Font(predictBtn.Font, FontStyle.Bold);
            predictBtn.ForeColor = Color.MistyRose;

        }

        private void predictBtn_MouseLeave(object sender, EventArgs e)
        {
            panel5.Visible = false;
            pictureBox2.Visible = true;
            predictBtn.Font = new Font(predictBtn.Font, FontStyle.Regular);
            predictBtn.ForeColor = Color.LavenderBlush;

        }

        private void eventsBtn_MouseEnter(object sender, EventArgs e)
        {
            panel11.Visible = true;
            pictureBox3.Visible = false;
            eventsBtn.Font = new Font(eventsBtn.Font, FontStyle.Bold);
            eventsBtn.ForeColor = Color.MistyRose;

        }

        private void eventsBtn_MouseLeave(object sender, EventArgs e)
        {
            panel11.Visible = false;
            pictureBox3.Visible = true;
            eventsBtn.Font = new Font(eventsBtn.Font, FontStyle.Regular);
            eventsBtn.ForeColor = Color.LavenderBlush;
        }

        private void transactionBtn_MouseEnter(object sender, EventArgs e)
        {
            panel7.Visible = true;
            pictureBox4.Visible = false;
            transactionBtn.Font = new Font(transactionBtn.Font, FontStyle.Bold);
            transactionBtn.ForeColor = Color.MistyRose;
        }

        private void transactionBtn_MouseLeave(object sender, EventArgs e)
        {
            panel7.Visible = false;
            pictureBox4.Visible = true;
            transactionBtn.Font = new Font(transactionBtn.Font, FontStyle.Regular);
            transactionBtn.ForeColor = Color.MistyRose;
        }

        private void summaryBtn_MouseEnter(object sender, EventArgs e)
        {
            panel8.Visible = true;
            pictureBox5.Visible = false;
            summaryBtn.Font = new Font(summaryBtn.Font, FontStyle.Bold);
            summaryBtn.ForeColor = Color.MistyRose;
        }

        private void summaryBtn_MouseLeave(object sender, EventArgs e)
        {
            panel8.Visible = false;
            pictureBox5.Visible = true;
            summaryBtn.Font = new Font(summaryBtn.Font, FontStyle.Regular);
            summaryBtn.ForeColor = Color.LavenderBlush;
        }

        private void ContactBtn_MouseEnter(object sender, EventArgs e)
        {
            panel10.Visible = true;
            pictureBox6.Visible = false;
            ContactBtn.Font = new Font(ContactBtn.Font, FontStyle.Bold);
            ContactBtn.ForeColor = Color.MistyRose;
        }

        private void ContactBtn_MouseLeave(object sender, EventArgs e)
        {
            panel10.Visible = false;
            pictureBox6.Visible = true;
            ContactBtn.Font = new Font(ContactBtn.Font, FontStyle.Regular);
            ContactBtn.ForeColor = Color.LavenderBlush;
        }

        #endregion

        #region Show dinamically transaction for the current date

        private async void GetTransactionList()
        {
            List<Transaction> transactions = await Task.Run(() => transactionRepository.GetTransactions(Instance.StaticUserAccount.UserId));

            List<Transaction> tempTransactions = new List<Transaction>();

            foreach (Transaction transaction in transactions)
            {
                if (transaction.dateTime.Date == DateTime.Now.Date)
                    tempTransactions.Add(transaction);
            }

            dashboardPanel.Dispose();
            dashboardPanel = new Panel();
            dashboardPanel.BackColor = Color.MistyRose;
            dashboardPanel.Size = new Size(400, 390);
            dashboardPanel.Location = new Point(300, 100);
            dashboardPanel.AutoScroll = true;
            this.Controls.Add(dashboardPanel);


            int count = 0;
            foreach (Transaction transaction in tempTransactions)
            {
                count++;

                Panel internalPanel = new Panel();
                internalPanel.BackColor = Color.MistyRose;
                internalPanel.Size = new Size(280, 30);
                internalPanel.Location = new Point(10, count * 50);

                dashboardPanel.Controls.Add(internalPanel);

                Label incomeTypeLbl = new Label();
                Label amountLbl = new Label();
                string typeTxt = "";
                if (transaction.incomeExpense == true)
                {
                    typeTxt = "+";
                    amountLbl.ForeColor = Color.Green;
                }
                else
                {
                    typeTxt = "-";
                    amountLbl.ForeColor = Color.Red;
                }

                incomeTypeLbl.Text = typeTxt;
                incomeTypeLbl.TextAlign = ContentAlignment.MiddleCenter;
                incomeTypeLbl.Size = new Size(10, 15);
                incomeTypeLbl.Location = new Point(10, 10);
                //incomeTypeLbl.BackColor = Color.GreenYellow;
                internalPanel.Controls.Add(incomeTypeLbl);
                internalPanel.Font = new Font("Calibri", 10, FontStyle.Bold);


                amountLbl.Text = "£" + transaction.transactionAmount;
                amountLbl.Size = new Size(70, 15);
                amountLbl.Location = new Point(30, 10);
                amountLbl.TextAlign = ContentAlignment.MiddleCenter;
                amountLbl.BackColor = Color.AliceBlue;

                internalPanel.Controls.Add(amountLbl);

                Label nameLbl = new Label();
                nameLbl.Text = transaction.transactionCategory;
                nameLbl.Size = new Size(100, 15);
                nameLbl.Location = new Point(90, 10);
                nameLbl.TextAlign = ContentAlignment.MiddleCenter;
                nameLbl.BackColor = Color.LightPink;

                internalPanel.Controls.Add(nameLbl);
            }
        }




        #endregion

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

        private void recurringToggleBtn_Click(object sender, EventArgs e)
        {

            TransactionForm transactionForm = new TransactionForm();
            transactionForm.Activate();
            transactionForm.Show();

        }
    }
}
