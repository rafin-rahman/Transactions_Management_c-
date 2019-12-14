using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace enterpriseDevelopment.Forms
{
    public partial class NotificationForm : Form
    {
        public NotificationForm(string text)
        {
            InitializeComponent();

            StartPosition = FormStartPosition.Manual;
            Rectangle size = Screen.PrimaryScreen.WorkingArea;
            Location = new Point(10 , size.Height - Height- 10);
            bgWorkerNotification.RunWorkerAsync();
            labelNewTrans.Text = text;

        }

        private void notificationClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void NotificationForm_MouseHover(object sender, EventArgs e)
        {
            label2.Visible = true;
        }

        private void NotificationForm_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.DarkGray;
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NotificationForm_MouseEnter(object sender, EventArgs e)
        {

            BackColor = Color.LightGray;
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.Visible = true;
            
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.Visible = true;
        }

        private void bgWorkerNotification_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(5000);
            
        }

        private void bgWorkerNotification_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Dispose();
        }
    }
}
