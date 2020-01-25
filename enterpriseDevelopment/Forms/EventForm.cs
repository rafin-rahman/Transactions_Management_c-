﻿using enterpriseDevelopment.Forms;
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
        private bool isCollapsed = true;
        private bool isCollapsed2 = true;
        private EventRepository eventRepository;
        private EventRecurringRepository eventRecurringRepository;
        private bool isRepeating = false;
        public EventForm()
        {
            InitializeComponent();
            eventRepository = new EventRepository();
            Instance.MainForm.Hide();
            listViewEvent.HideSelection = true;
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

        private void mainBtn_Click(object sender, EventArgs e)
        {
            Instance.MainForm.Show();
            Close();
        }

       

        private void panel1_Click(object sender, EventArgs e)
        {
            Instance.MainForm.Dispose();
          
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
           this.panel1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.closeHover));
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            this.panel1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.close));
        }

       

        private void mainBtn_Click_1(object sender, EventArgs e)
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

        private void ContactBtn_Click(object sender, EventArgs e)
        {
            ContactsForm contactsForm = new ContactsForm();
            contactsForm.Activate();
            contactsForm.Show();
        }

        private void listViewEvent_SizeChanged(object sender, EventArgs e)
        {
            SetListViewColumns();
        }

        private void SetListViewColumns()
        {
            int total = listViewEvent.Width - 18;
            int count = listViewEvent.Columns.Count;
            int size = total / count;
            int last = total - (size * (count - 2));
            for (int i = 0; i < count; i++)
            {
                if (i == count - 1)
                {
                    listViewEvent.Columns[i].Width = last;
                }
                else if (i == 0)
                {
                    listViewEvent.Columns[i].Width = last;
                }
                else
                {
                    listViewEvent.Columns[i].Width = (int)(1.5 * size);
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

        private void eventsBtn_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void transactionBtn_Click(object sender, EventArgs e)
        {
            timer.Start();
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
