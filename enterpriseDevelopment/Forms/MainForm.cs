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

namespace enterpriseDevelopment
{
    public partial class MainForm : Form
    {
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

            if (!recurringBGWorker.IsBusy) recurringBGWorker.RunWorkerAsync();
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
            }
        }
        //
        private void runRecurringTransaction()
        {
            TransactionRecurringRepository transactionRecurringRepository = new TransactionRecurringRepository();
            TransactionRepository transactionRepo  = new TransactionRepository();
            List<TransactionRepeat> transactionRepeats = transactionRecurringRepository.GetTransactions(Instance.StaticUserAccount.UserId);
            foreach(TransactionRepeat transactionRepeat in transactionRepeats)
            {
                switch (transactionRepeat.subscriptionPeriod)
                {
                    case "Daily":
                        DateTime accessTime = Instance.StaticUserAccount.LogDate;
                        DateTime currentTime = DateTime.Now;
                        int days = (currentTime - accessTime).Days;
                        DateTime rTransTime = Instance.StaticUserAccount.LogDate;
                        TimeSpan ts = new TimeSpan(
                            transactionRepeat.dateTime.Hour,
                            transactionRepeat.dateTime.Minute,
                            transactionRepeat.dateTime.Second
                            );
                        rTransTime = rTransTime.Date + ts;
                        for (int i = 0; i <= days; i++)
                        {
                            if (rTransTime > accessTime && rTransTime <= currentTime && rTransTime > transactionRepeat.dateTime)
                            {
                                transactionRepo.AddTransction(new Transaction
                                {
                                    transactionCategory = transactionRepeat.transactionCategory,
                                    userIdFk = transactionRepeat.userIdFk,
                                    contactIdFk = transactionRepeat.contactIdFk,
                                    incomeExpense = transactionRepeat.incomeExpense,
                                    transactionAmount = transactionRepeat.transactionAmount,
                                    transactionMessage = transactionRepeat.transactionMessage,
                                    dateTime = rTransTime
                                });
                            }
                            Instance.StaticUserAccount.LogDate = currentTime;
                            rTransTime = rTransTime.AddDays(1);
                        }
                        break;
                }
            }
        }


    private void recurringBGWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {

    }
}
}
