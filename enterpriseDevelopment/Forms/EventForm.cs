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
    public partial class EventForm : Form
    {
        private EventRepository eventRepository;
        public EventForm()
        {
            InitializeComponent();
            eventRepository = new EventRepository();
            Instance.MainForm.Hide();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            EventAddEdit eventAddEdit = new EventAddEdit();
            eventAddEdit.Activate();
            eventAddEdit.Show();
        }

        private void EventForm_Load(object sender, EventArgs e)
        {

        }

        private void EventForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Instance.MainForm.Activate();
            Instance.MainForm.Show();

            Dispose();
        }

        private void EventForm_Activated(object sender, EventArgs e)
        {
           
        }
    }
}
