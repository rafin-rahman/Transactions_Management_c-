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

        private Event normalEvent;
        private EventRecurring recurringEvent;
        private bool isRepeat = false;

        #region CONSTRUCTOR
        // Add event
        public EventAddEdit()
        {
            InitializeComponent();
            actionBtn.Text = "ADD EVENT / TASK";
            Text = "Add event";
            normalEvent = new Event { UserFK = UserInstance.StaticUserAccount.Id };
        }
        // Edit normal event form
        public EventAddEdit(Event normalEvent)
        {
            InitializeComponent();
            this.normalEvent = normalEvent;
            actionBtn.Text = "Edit";
            Text = "Edit event";
            titleTxt.Text = normalEvent.Title;
            messageRichTxt.Text = normalEvent.Message;
            statusComboBox.SelectedItem = normalEvent.Status;
            dateTimePick.Value = normalEvent.Date;
            locationTxt.Text = normalEvent.Location;
            groupBox1.Visible = false;
            recurrCheck.Visible = true;
        }
        // Edit recurring event form
        public EventAddEdit(EventRecurring recurringEvent)
        {
            InitializeComponent();
            isRepeat = true;
            this.recurringEvent = recurringEvent;
            actionBtn.Text = "Edit";
            Text = "Edit recurring event";
            titleTxt.Text = recurringEvent.Title;
            messageRichTxt.Text = recurringEvent.Message;
            statusComboBox.SelectedItem = recurringEvent.Status;
            dateTimePick.Value = recurringEvent.Date;
            locationTxt.Text = recurringEvent.Location;
            groupBox1.Visible = true;
            recurrCheck.Visible = false;

            if (this.recurringEvent.EndDate == DateTime.MinValue)
            {
                dateTimePicker1.Enabled = false;
                noTimeLimit.Checked = true;
            }
            else
            {
                dateTimePicker1.Value = this.recurringEvent.EndDate;
            }
        }
        #endregion

        #region SET CONTACT TO AN EVENT
        private void setEventContact(List<Contact> list)
        {
            if (normalEvent.Id > 0)
            {
                if (normalEvent.ContactFk == 0)
                    comboBoxEvent.Text = "";
                else
                {
                    for (int x = 0; x < list.Count; x++)
                    {
                        if (normalEvent.ContactFk == list[x].Id)
                            comboBoxEvent.SelectedItem = comboBoxEvent.Items[x];
                    }
                }
            }
        }

        private void setRecurringEventContact(List<Contact> list)
        {
            if (recurringEvent.Id > 0)
            {
                if (recurringEvent.ContactFk == 0)
                    comboBoxEvent.Text = "";
                else
                {
                    for (int x = 0; x < list.Count; x++)
                    {
                        if (recurringEvent.ContactFk == list[x].Id)
                            comboBoxEvent.SelectedItem = comboBoxEvent.Items[x];
                    }
                }
            }
        }
        #endregion
        
        private async void EventAddEdit_Load(object sender, EventArgs e)
        {// Getting contact from repository and showing in the contact dropdown list
            ContactRepository contactRepository = new ContactRepository();
            List<Contact> list = await Task.Run(() => contactRepository.GetContacts(UserInstance.StaticUserAccount.Id));
            comboBoxEvent.DataSource = list;
            comboBoxEvent.DisplayMember = "Name";

            if (isRepeat)
                setRecurringEventContact(list);
            else
                setEventContact(list);
        }

        #region ADD & EDIT EVENT
        private void actionBtn_Click(object sender, EventArgs e)
        {

            if (isRepeat)
                addEditEventRepeat();
            else
                addEditNormEvent();
        }

        private async void addEditNormEvent()
        {
            normalEvent.Title = titleTxt.Text;
            normalEvent.Message = messageRichTxt.Text;

            Contact contact = (Contact)comboBoxEvent.SelectedItem;
            if (contact == null)
            {
                if (string.IsNullOrWhiteSpace(comboBoxEvent.Text))
                    normalEvent.ContactFk = 0;
                else
                {
                    ContactRepository contactsRepository = new ContactRepository();
                    normalEvent.ContactFk = contactsRepository.AddContact(new Contact { Name = comboBoxEvent.Text, UserFk = UserInstance.StaticUserAccount.Id });
                }
            }
            else
                normalEvent.ContactFk = contact.Id;

            normalEvent.Date = dateTimePick.Value;
            normalEvent.Location = locationTxt.Text;
            normalEvent.Status = statusComboBox.Text;

            EventRepository eventRepository = new EventRepository();

            bool x;
            if (normalEvent.Id > 0)
                x = await Task.Run(() => eventRepository.EditEvent(normalEvent));
            else
                x = await Task.Run(() => eventRepository.AddEvent(normalEvent));

            if (recurrCheck.Checked == true && normalEvent.Id == 0)
            {
                EventRecurring eventRepeat = new EventRecurring
                {
                    Title = normalEvent.Title,
                    Message = normalEvent.Message,
                    UserFK = normalEvent.UserFK,
                    Status = normalEvent.Status,
                    Date = normalEvent.Date,
                    ContactFk = normalEvent.ContactFk,
                    Location = normalEvent.Location
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

            if (normalEvent.Id > 0 && x == true)
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
            recurringEvent.Title = titleTxt.Text;
            recurringEvent.Message = messageRichTxt.Text;

            Contact contact = (Contact)comboBoxEvent.SelectedItem;
            if (contact == null)
            {
                if (string.IsNullOrWhiteSpace(comboBoxEvent.Text))
                    recurringEvent.ContactFk = 0;
                else
                {
                    ContactRepository contactsRepository = new ContactRepository();
                    recurringEvent.ContactFk = await Task.Run(() => contactsRepository.AddContact(new Contact { Name = comboBoxEvent.Text, UserFk = UserInstance.StaticUserAccount.Id }));
                }
            }
            else
                recurringEvent.ContactFk = contact.Id;



            recurringEvent.Date = dateTimePick.Value;
            recurringEvent.Location = locationTxt.Text;

            EventRecurringRepository eventRecurringRepository = new EventRecurringRepository();

            bool x;

            if (noTimeLimit.Checked)
                recurringEvent.EndDate = DateTime.MinValue;
            else
                recurringEvent.EndDate = dateTimePicker1.Value;
            recurringEvent.Period = periodCombo.Text;

            x = await Task.Run(() => eventRecurringRepository.editEvent(recurringEvent));

            if (recurringEvent.Id > 0 && x == true)
                MessageBox.Show("Event Edited!");
            else
                MessageBox.Show("ops, Something went wrong");

            Close();
            Dispose();
        }
        #endregion
        
        // toggle recurring event panel
        private void recurrCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (recurrCheck.Checked == true)
                groupBox1.Visible = true;
            else
                groupBox1.Visible = false;
        }

        // enable / disable the date picker if it's checked
        private void noTimeLimit_CheckedChanged(object sender, EventArgs e)
        {
            if (noTimeLimit.Checked == true)
                dateTimePicker1.Enabled = false;
            else
                dateTimePicker1.Enabled = true;
        }

        #region HOVER ANIMATION
        private void closePanel_MouseEnter(object sender, EventArgs e)
        {
            this.closePanel.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.backButtonHover));
        }

        private void closePanel_MouseLeave(object sender, EventArgs e)
        {
            this.closePanel.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.backButton));
        }
        #endregion
        
        private void closePanel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
