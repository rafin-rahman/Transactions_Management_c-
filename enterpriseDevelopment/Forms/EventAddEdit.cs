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
    public partial class EventAddEdit : Form
    {

        private Event ev;
        private EventRecurring er;
        private bool isRepeat = false;

        public EventAddEdit()
        {
            InitializeComponent();
            actionBtn.Text = "ADD EVENT / TASK";
            Text = "Add event";
            ev = new Event { UserFK = UserInstance.StaticUserAccount.Id };
        }

        public EventAddEdit(Event eventObj)
        {
            InitializeComponent();
            ev = eventObj;
            actionBtn.Text = "Edit";
            Text = "Edit event";
            titleTxt.Text = eventObj.Title;
            messageRichTxt.Text = eventObj.Message;
            statusComboBox.SelectedItem = eventObj.Status;
            dateTimePick.Value = eventObj.Date;
            locationTxt.Text = eventObj.Location;
            groupBox1.Visible = false;
            recurrCheck.Visible = true;
        }


        public EventAddEdit(EventRecurring eventRepeat)
        {
            InitializeComponent();
            isRepeat = true;
            er = eventRepeat;
            actionBtn.Text = "Edit";
            Text = "Edit recurring event";
            titleTxt.Text = eventRepeat.Title;
            messageRichTxt.Text = eventRepeat.Message;
            statusComboBox.SelectedItem = eventRepeat.Status;
            dateTimePick.Value = eventRepeat.Date;
            locationTxt.Text = eventRepeat.Location;
            groupBox1.Visible = true;
            recurrCheck.Visible = false;

            if (er.EndDate == DateTime.MinValue)
            {
                dateTimePicker1.Enabled = false;
                noTimeLimit.Checked = true;
            }
            else
            {
                dateTimePicker1.Value = er.EndDate;
            }
        }

        private void setEventContact(List<Contact> list)
        {
            if (ev.Id > 0)
            {
                if (ev.ContactFk == 0)
                    comboBoxEvent.Text = "";
                else
                {
                    for (int x = 0; x < list.Count; x++)
                    {
                        if (ev.ContactFk == list[x].Id)
                            comboBoxEvent.SelectedItem = comboBoxEvent.Items[x];
                    }
                }
            }
        }

        private void setEventRepeatContact(List<Contact> list)
        {
            if (er.Id > 0)
            {
                if (er.ContactFk == 0)
                    comboBoxEvent.Text = "";
                else
                {
                    for (int x = 0; x < list.Count; x++)
                    {
                        if (er.ContactFk == list[x].Id)
                            comboBoxEvent.SelectedItem = comboBoxEvent.Items[x];
                    }
                }
            }
        }

        private async void EventAddEdit_Load(object sender, EventArgs e)
        {
            ContactRepository contactRepository = new ContactRepository();
            List<Contact> list = await Task.Run(() => contactRepository.GetContacts(UserInstance.StaticUserAccount.Id));
            comboBoxEvent.DataSource = list;
            comboBoxEvent.DisplayMember = "ContactName";

            if (isRepeat)
                setEventRepeatContact(list);
            else
                setEventContact(list);
        }

        private void actionBtn_Click(object sender, EventArgs e)
        {

            if (isRepeat)
                addEditEventRepeat();
            else
                addEditNormEvent();
        }


        private async void addEditNormEvent()
        {
            ev.Title = titleTxt.Text;
            ev.Message = messageRichTxt.Text;

            Contact contact = (Contact)comboBoxEvent.SelectedItem;
            if (contact == null)
            {
                if (string.IsNullOrWhiteSpace(comboBoxEvent.Text))
                    ev.ContactFk = 0;
                else
                {
                    ContactRepository contactsRepository = new ContactRepository();
                    ev.ContactFk = await Task.Run(() => contactsRepository.AddContact(new Contact { Name = comboBoxEvent.Text, UserFk = UserInstance.StaticUserAccount.Id }));
                }
            }
            else
                ev.ContactFk = contact.Id;

            ev.Date = dateTimePick.Value;
            ev.Location = locationTxt.Text;
            ev.Status = statusComboBox.Text;

            EventRepository eventRepository = new EventRepository();

            bool x;
            if (ev.Id > 0)
                x = await Task.Run(() => eventRepository.EditEvent(ev));
            else
                x = await Task.Run(() => eventRepository.AddEvent(ev));

            if (recurrCheck.Checked == true && ev.Id == 0)
            {
                EventRecurring eventRepeat = new EventRecurring
                {
                    Title = ev.Title,
                    Message = ev.Message,
                    UserFK = ev.UserFK,
                    Status = ev.Status,
                    Date = ev.Date,
                    ContactFk = ev.ContactFk,
                    Location = ev.Location
                };

                if (noTimeLimit.Checked)
                    eventRepeat.EndDate = DateTime.MinValue;
                else
                    eventRepeat.EndDate = dateTimePicker1.Value;

                eventRepeat.Period = periodCombo.Text;

                EventRecurringRepository eventRecurringRepository = new EventRecurringRepository();
                bool i = await Task.Run(() => eventRecurringRepository.AddEvent(eventRepeat));
                if (i == false)
                {
                    MessageBox.Show("Ops, something went wrong", "Error");
                    return;
                }
            }

            if (ev.Id > 0 && x == true)
                MessageBox.Show("Event Edited!");
            else if (x == true)
                MessageBox.Show("Event Added!");
            else
                MessageBox.Show("ops, Something went wrong");

            Close();
            Dispose();
        }

        private async void addEditEventRepeat()
        {
            er.Title = titleTxt.Text;
            er.Message = messageRichTxt.Text;

            Contact contact = (Contact)comboBoxEvent.SelectedItem;
            if (contact == null)
            {
                if (string.IsNullOrWhiteSpace(comboBoxEvent.Text))
                    er.ContactFk = 0;
                else
                {
                    ContactRepository contactsRepository = new ContactRepository();
                    er.ContactFk = await Task.Run(() => contactsRepository.AddContact(new Contact { Name = comboBoxEvent.Text, UserFk = UserInstance.StaticUserAccount.Id }));
                }
            }
            else
                er.ContactFk = contact.Id;



            er.Date = dateTimePick.Value;
            er.Location = locationTxt.Text;

            EventRecurringRepository eventRecurringRepository = new EventRecurringRepository();
            
            bool x;
            
            if (noTimeLimit.Checked)
                er.EndDate = DateTime.MinValue;
            else
                er.EndDate = dateTimePicker1.Value;
            er.Period = periodCombo.Text;

            x = await Task.Run(() => eventRecurringRepository.editEvent(er));
            
            if (er.Id > 0 && x == true)
                MessageBox.Show("Event Edited!");
            else
                MessageBox.Show("ops, Something went wrong");

            Close();
            Dispose();
        }

        private void recurrCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (recurrCheck.Checked == true)
                groupBox1.Visible = true;
            else
                groupBox1.Visible = false;
        }

        private void noTimeLimit_CheckedChanged(object sender, EventArgs e)
        {
            if (noTimeLimit.Checked == true)
                dateTimePicker1.Enabled = false;
            else
                dateTimePicker1.Enabled = true;
        }

        private void closePanel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void closePanel_MouseEnter(object sender, EventArgs e)
        {
            this.closePanel.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.backButtonHover));
        }

        private void closePanel_MouseLeave(object sender, EventArgs e)
        {
            this.closePanel.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.backButton));
        }
    }
}
