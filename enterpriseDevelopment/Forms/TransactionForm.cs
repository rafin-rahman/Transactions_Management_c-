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

        private TransactionRepository transactionRepository;
        private TransactionRecurringRepository TransactionRecurringRepository;
        private bool isRepeating = false;
        public TransactionForm()
        {
            InitializeComponent();
            transactionRepository = new TransactionRepository();
           
            Instance.MainForm.Hide();
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
            
            Instance.MainForm.Hide();
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
                    TransactionRepeat transaction = (TransactionRepeat)listViewTransaction.SelectedItems[0].Tag;
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
                   TransactionRepeat transaction = (TransactionRepeat)listViewTransaction.SelectedItems[0].Tag;

                    DialogResult dialogResult = MessageBox.Show("Do you want do delete the transaction?", "Confirm", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        bool x = await Task.Run(() => TransactionRecurringRepository.DeleteTransaction(transaction));
                        if (x)
                        {
                            MessageBox.Show("Transaction deleted");
                        }
                        else
                        {
                            MessageBox.Show("Transaction not deleted");
                        }
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
                        {
                            MessageBox.Show("Transaction deleted");
                        }
                        else
                        {
                            MessageBox.Show("Transaction not deleted");
                        }
                    }
                }
            }
        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {
        }

        private void TransactionForm_FormClosed(object sender, FormClosedEventArgs e)
        {

            Instance.MainForm.Activate();
            Instance.MainForm.Show();

            Dispose();
        }

        private async void TransactionForm_Activated(object sender, EventArgs e)
        {
            if (isRepeating)
            {
                List<TransactionRepeat> transactionsList = await Task.Run(() => TransactionRecurringRepository.GetTransactions(Instance.StaticUserAccount.UserId));
                listViewTransaction.Items.Clear();
                foreach (TransactionRepeat transactionRepeat in transactionsList)
                {
                    string endDate = "";
                    if (transactionRepeat.subscriptionEndTime == DateTime.MinValue)
                    {
                        endDate = "N/A";
                    }
                    else
                    {
                        endDate = transactionRepeat.subscriptionEndTime.ToString();
                    }
                    ListViewItem listViewI = new ListViewItem(new string[] { transactionRepeat.transactionAmount.ToString("0.00"), transactionRepeat.typeValue, transactionRepeat.transactionCategory, transactionRepeat.dateTime.ToString(), transactionRepeat.contactName, transactionRepeat.transactionMessage, transactionRepeat.subscriptionPeriod, endDate });

                   


                    listViewI.Tag = transactionRepeat;
                    listViewTransaction.Items.Add(listViewI);
                }
            }
            else
            {
                List<Transaction> transactionsList = await Task.Run(() => transactionRepository.GetTransactions(Instance.StaticUserAccount.UserId));
                listViewTransaction.Items.Clear();
                foreach (Transaction transaction in transactionsList)
                {
                    ListViewItem listViewI = new ListViewItem(new string[] { transaction.transactionAmount.ToString("0.00"), transaction.typeValue, transaction.transactionCategory, transaction.dateTime.ToString(), transaction.contactName, transaction.transactionMessage });
                    listViewI.Tag = transaction;
                    listViewTransaction.Items.Add(listViewI);
                }
            }
        }

     

        private void panel1_Click(object sender, EventArgs e)
        {
            Instance.MainForm.Dispose();
        }

        private void mainBtn_Click(object sender, EventArgs e)
        {
            Instance.MainForm.Show();

            Close();
        }

        private void predictBtn_Click(object sender, EventArgs e)
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

        private void ContactBtn_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void ContactBtn_Click(object sender, EventArgs e)
        {
            ContactsForm contactsForm = new ContactsForm();
            contactsForm.Activate();
            contactsForm.Show();
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
                {
                    listViewTransaction.Columns[i].Width = last;
                }
                else if (i == 0)
                {
                    listViewTransaction.Columns[i].Width = last;
                }
                else
                {
                    listViewTransaction.Columns[i].Width = (int)(1.5 * size);
                }


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
    }
}
