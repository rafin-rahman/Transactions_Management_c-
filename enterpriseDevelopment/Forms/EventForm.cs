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
        private EventRecurringRepository eventRecurringRepository;
        private bool isRepeating = false;
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

        private void editBtn_Click(object sender, EventArgs e)
        {

            if (listViewEvent.SelectedItems.Count > 0)
            {



                if (isRepeating)
                {
                    EventRepeat eventRepeat = (EventRepeat)listViewEvent.SelectedItems[0].Tag;
                    EventAddEdit eventAddEdit = new EventAddEdit(eventRepeat);
                    eventAddEdit.Activate();
                    eventAddEdit.Show();
                }
                else
                {
                    Event eventObj = (Event)listViewEvent.SelectedItems[0].Tag;
                    EventAddEdit eventAddEdit = new EventAddEdit(eventObj);
                    eventAddEdit.Activate();
                    eventAddEdit.Show();
                }
            }



        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (isRepeating)
            {
                EventRepeat eventRepeat = (EventRepeat)listViewEvent.SelectedItems[0].Tag;

                DialogResult dialogResult = MessageBox.Show("Do you want do delete the event?", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    bool x = eventRecurringRepository.deleteEvent(eventRepeat);
                    if (x)
                    {
                        MessageBox.Show("Event deleted");
                    }
                    else
                    {
                        MessageBox.Show("Event not deleted");
                    }
                }
            }
            else
            {
                Event eventObj = (Event)listViewEvent.SelectedItems[0].Tag;

                DialogResult dialogResult = MessageBox.Show("Do you want do delete the Event?", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    bool x = eventRepository.DeleteEvent(eventObj);
                    if (x)
                    {
                        MessageBox.Show("Event deleted");
                    }
                    else
                    {
                        MessageBox.Show("Event not deleted");
                    }
                }
            }
        }
    }
}
