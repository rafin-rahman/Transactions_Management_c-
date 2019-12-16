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


        public EventForm(bool rec)
        {
            InitializeComponent();
            isRepeating = rec;
            if (isRepeating == true)
            {

                listViewEvent.Columns.Add("Period");
                listViewEvent.Columns.Add("Ending date");
            }

            eventRecurringRepository = new EventRecurringRepository();
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

        private async void EventForm_Activated(object sender, EventArgs e)
        {
            if (isRepeating)
            {
                List<EventRepeat> eventsList = await Task.Run(() => eventRecurringRepository.GetEvents(Instance.StaticUserAccount.UserId));
                listViewEvent.Items.Clear();
                foreach (EventRepeat eventRepeat in eventsList)
                {
                    string endDate = "";
                    if (eventRepeat.endDate == DateTime.MinValue)
                    {
                        endDate = "N/A";
                    }
                    else
                    {
                        endDate = eventRepeat.endDate.ToString();
                    }

                    ListViewItem listViewI = new ListViewItem(new string[] { eventRepeat.title, eventRepeat.status, eventRepeat.location, eventRepeat.message, eventRepeat.contactName, eventRepeat.date.ToString(), eventRepeat.period, endDate });
                    listViewI.Tag = eventRepeat;
                    listViewEvent.Items.Add(listViewI);
                }
            }
            else
            {
                List<Event> eventsList = await Task.Run(() => eventRepository.GetEvents(Instance.StaticUserAccount.UserId));
                listViewEvent.Items.Clear();
                foreach (Event eventObj in eventsList)
                {
                    ListViewItem listViewI = new ListViewItem(new string[] { eventObj.title, eventObj.status, eventObj.location, eventObj.message, eventObj.contactName, eventObj.date.ToString() });
                    listViewI.Tag = eventObj;
                    listViewEvent.Items.Add(listViewI);
                }
            }
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

        private async void deleteBtn_Click(object sender, EventArgs e)
        {
            if (isRepeating)
            {
                EventRepeat eventRepeat = (EventRepeat)listViewEvent.SelectedItems[0].Tag;

                DialogResult dialogResult = MessageBox.Show("Do you want do delete the event?", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    bool x = await Task.Run(() => eventRecurringRepository.deleteEvent(eventRepeat));
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
                    bool x = await Task.Run(() => eventRepository.DeleteEvent(eventObj));
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

        private void listViewEvent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mainBtn_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Dispose();
          
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
           this.panel1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.closeHover));
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            this.panel1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.close));
        }
    }
}
