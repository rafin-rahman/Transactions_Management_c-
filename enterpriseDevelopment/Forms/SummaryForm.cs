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
        private TransactionRepository transactionRepository;
        private List<Transaction> transactions;
        public SummaryForm()
        {
            InitializeComponent();
            Instance.MainForm.Hide();
            transactionRepository = new TransactionRepository();
            // it will select the first index instead of having empty sting in the design
            showByCB.SelectedIndex = 0;


        }
        private void SummaryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Instance.MainForm.Activate();
            Instance.MainForm.Show();
            Dispose();
        }

        private async void showSumBtn_Click(object sender, EventArgs e)
        {

            // set time of the starting period from 12AM
            dateCountStart.Value = dateCountStart.Value.Date + new TimeSpan();
            // set time of the end of the day  from 
            dateCountEnd.Value = dateCountEnd.Value.Date + new TimeSpan(23, 59, 59);

            if (dateCountStart.Value > dateCountEnd.Value)
            {
                MessageBox.Show("Starting date cannot be greater than ending date");
                return;
            }



            if (transactions == null)
            {
                transactions = await Task.Run(() => transactionRepository.GetTransactions(Instance.StaticUserAccount.UserId));

            }

            listVSummary.Items.Clear();


            List<Transaction> tempList = new List<Transaction>();

            for (int i = 0; i < transactions.Count; i++)
            {
                // if the starting date is smaller than the date allocated to transaction OR ending date is bigger than transaction allocated date it will  be removed
                if (transactions[i].dateTime >= dateCountStart.Value && transactions[i].dateTime <= dateCountEnd.Value)
                {
                    tempList.Add(transactions[i]);


                }


            }

            if (showByCB.Text.Equals("Transactions"))
            {

                listVSummary.Columns.Clear();
                listVSummary.Columns.Add("Category", 110);
                listVSummary.Columns.Add("Amount", 110);
                listVSummary.Columns.Add("Income / Expense", 110);
                listVSummary.Columns.Add("Date", 110);
                listVSummary.Columns.Add("Contact", 110);


                foreach (Transaction transaction in tempList)
                {
                    ListViewItem listViewToString = new ListViewItem(new string[] { transaction.transactionCategory.ToString(), transaction.transactionAmount.ToString("0.00"), transaction.typeValue.ToString(), transaction.dateTime.ToString(), transaction.contactName.ToString() });
                    listVSummary.Items.Add(listViewToString);
                }


            }
            // DAYS
            else if (showByCB.Text.Equals("Days"))
            {
                listVSummary.Columns.Clear();
            


                List<DateTime> dateList = new List<DateTime>();
                List<decimal> incomeList = new List<decimal>();
                List<decimal> expenseList = new List<decimal>();
                foreach (Transaction transaction in tempList)
                {
                    int y = -1;

                    for (int x = 0; x < dateList.Count; x++)
                    {
                        if (dateList[x].Date == transaction.dateTime.Date)
                        {
                            y = x;
                            break;
                        }
                    }

                    if (y == -1)
                    {
                        dateList.Add(transaction.dateTime);
                         expenseList.Add(0);
                        incomeList.Add(0);
                        y = dateList.Count - 1;
                    }
                    if (transaction.incomeExpense)
                    {
                        expenseList[y] += transaction.transactionAmount;
                    }
                    else
                    {
                        incomeList[y] += transaction.transactionAmount;
                    }
                }

                listVSummary.Columns.Add("Date", 100);
                listVSummary.Columns.Add("Income", 80);
                listVSummary.Columns.Add("Expense", 80);

                for (int i = 0; i < dateList.Count; i++)
                {
                    ListViewItem listViewItem = new ListViewItem(new string[] {
                        dateList[i].ToShortDateString(),
                        incomeList[i].ToString("0.00"),
                        expenseList[i].ToString("0.00")
                    });
                    listVSummary.Items.Add(listViewItem);
                }


            }

            // MONTHS
            else if (showByCB.Text.Equals("Months"))
            {
                listVSummary.Columns.Clear();

                List<string> monthList = new List<string>();
                List<decimal> incomeList = new List<decimal>();
                List<decimal> expenseList = new List<decimal>();
                foreach (Transaction transaction in tempList)
                {
                    int y = -1;

                    for (int x = 0; x < monthList.Count; x++)
                    {
                        if (monthList[x].Equals(transaction.dateTime.ToString("MM/yyyy")))
                        {
                            y = x;
                            break;
                        }
                    }

                    if (y == -1)
                    {
                        monthList.Add(transaction.dateTime.ToString("MM/yyyy"));
                        expenseList.Add(0);
                        incomeList.Add(0);
                        y = monthList.Count - 1;
                    }
                    if (transaction.incomeExpense)
                    {
                        expenseList[y] += transaction.transactionAmount;
                    }
                    else
                    {
                        incomeList[y] += transaction.transactionAmount;
                    }
                }

                listVSummary.Columns.Add("Date", 100);
                listVSummary.Columns.Add("Income", 80);
                listVSummary.Columns.Add("Expense", 80);

                for (int i = 0; i < monthList.Count; i++)
                {
                    ListViewItem listViewItem = new ListViewItem(new string[] {
                        monthList[i],
                        incomeList[i].ToString("0.00"),
                        expenseList[i].ToString("0.00")
                    });
                    listVSummary.Items.Add(listViewItem);
                }

            }

            // YEARS
            else if (showByCB.Text.Equals("Years"))
            {
                listVSummary.Columns.Clear();

                List<string> yearList = new List<string>();
                List<decimal> incomeList = new List<decimal>();
                List<decimal> expenseList = new List<decimal>();
                foreach (Transaction transaction in tempList)
                {
                    int y = -1;

                    for (int x = 0; x < yearList.Count; x++)
                    {
                        if (yearList[x].Equals(transaction.dateTime.ToString("yyyy")))
                        {
                            y = x;
                            break;
                        }
                    }

                    if (y == -1)
                    {
                        yearList.Add(transaction.dateTime.ToString("yyyy"));
                        expenseList.Add(0);
                        incomeList.Add(0);
                        y = yearList.Count - 1;
                    }
                    if (transaction.incomeExpense)
                    {
                        expenseList[y] += transaction.transactionAmount;
                    }
                    else
                    {
                        incomeList[y] += transaction.transactionAmount;
                    }
                }

                listVSummary.Columns.Add("Date", 100);
                listVSummary.Columns.Add("Income", 80);
                listVSummary.Columns.Add("Expense", 80);

                for (int i = 0; i < yearList.Count; i++)
                {
                    ListViewItem listViewItem = new ListViewItem(new string[] {
                        yearList[i],
                        incomeList[i].ToString("0.00"),
                        expenseList[i].ToString("0.00")
                    });
                    listVSummary.Items.Add(listViewItem);
                }
            }
            else
            {
                MessageBox.Show("Something went wrong while showing items", "Error");
            }








        }

        private void SummaryForm_Load(object sender, EventArgs e)
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

        private void predictBtn_Click(object sender, EventArgs e)
        {
            financialPredictionForm financialPredictionForm = new financialPredictionForm();
            financialPredictionForm.Activate();
            financialPredictionForm.Show();
        }

        private void summaryBtn_Click(object sender, EventArgs e)
        {

        }

        private void SummaryForm_Click(object sender, EventArgs e)
        {
            ContactsForm contactsForm = new ContactsForm();
            contactsForm.Activate();
            contactsForm.Show();
        }

        private void listVSummary_SizeChanged(object sender, EventArgs e)
        {
            SetListViewColumns();
        }

        private void SetListViewColumns()
        {
            int total = listVSummary.Width - 18;
            int count = listVSummary.Columns.Count;
            int size = total / count;
            int last = total - (size * (count - 2));
            for (int i = 0; i < count; i++)
            {
                if (i == count - 1)
                {
                    listVSummary.Columns[i].Width = last;
                }
                else if (i == 0)
                {
                    listVSummary.Columns[i].Width = last;
                }
                else
                {
                    listVSummary.Columns[i].Width = (int)(1.5 * size);
                }


            }
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
    }
}
