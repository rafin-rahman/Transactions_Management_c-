using enterpriseDevelopment.Forms;
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

        private void MainForm_Activated(object sender, EventArgs e)
        {
            Instance.StaticUserAccount = new UserAccount { UserId = 5, UserFName = "rafraf" };
            // hide the mainform if the StaticUserAccount is empty
            if (Instance.StaticUserAccount == null)
            {
                LoginRegister LoginRegisterObj = new LoginRegister();
                LoginRegisterObj.Activate();
                LoginRegisterObj.Show();
            }
        }


        private void contactClickMainForm(object sender, EventArgs e)

            
        {
            ContactsForm contactsForm = new ContactsForm();
            contactsForm.Activate();
            contactsForm.Show();
        }
    }
}
