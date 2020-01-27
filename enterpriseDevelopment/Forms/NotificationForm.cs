using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
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
            // setting form potional to manual
            StartPosition = FormStartPosition.Manual;
            // getting screensize 
            Rectangle size = Screen.PrimaryScreen.WorkingArea;
            // setting the location
            Location = new Point(10, size.Height - Height - 10);
            // starting a bg worker
            bgWorkerNotification.RunWorkerAsync();
            messageLbl.Text = text;
        }

        private void notificationClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void NotificationForm_MouseHover(object sender, EventArgs e)
        {
            headerLbl.Visible = true;
        }

        private void NotificationForm_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.DarkGray;
        }

        private void NotificationForm_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.LightGray;
        }

        private void headerLbl_MouseHover(object sender, EventArgs e)
        {
            headerLbl.Visible = true;
        }

        private void headerLbl_MouseEnter(object sender, EventArgs e)
        {
            headerLbl.Visible = true;
        }
        // DoWork = wait 5 seconds
        private void bgWorkerNotification_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(5000);
        }
        // At end of the task it close the form
        private void bgWorkerNotification_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Dispose();
        }

        private void playSoundOnLoad()
        {
            SoundPlayer popUp = new SoundPlayer(Properties.Resources.notification);
            popUp.Play();
        }

        private void NotificationForm_Load(object sender, EventArgs e)
        {
            playSoundOnLoad();
        } 
    }
}
