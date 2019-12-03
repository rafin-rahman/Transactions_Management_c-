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
        public TransactionForm()
        {
            InitializeComponent();
            transactionRepository = new TransactionRepository();
            // When this form in opened, main form will be hidden
            Instance.MainForm.Hide();
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {
            Instance.MainForm.Activate();
            Instance.MainForm.Show();

            Dispose();
        }

        private void TransactionForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            TransactionAddEdit transactionAddEdit = new TransactionAddEdit();
            transactionAddEdit.Activate();
            transactionAddEdit.Show();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
