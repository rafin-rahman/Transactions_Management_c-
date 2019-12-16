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
        private EventRepeat er;
        private bool isRepeat = false;

        public EventAddEdit()
        {
            InitializeComponent();
            actionBtn.Text = "ADD EVENT / TASK";
            Text = "Add event";
            ev = new Event { userFK = Instance.StaticUserAccount.UserId };

        }

        public EventAddEdit(Event eventObj)
        {
            InitializeComponent();
            ev = eventObj;
            actionBtn.Text = "Edit";
            Text = "Edit event";
            titleTxt.Text = eventObj.title;
            messageRichTxt.Text = eventObj.message;
            statusComboBox.SelectedItem = eventObj.status;
            dateTimePick.Value = eventObj.date;
            locationTxt.Text = eventObj.location;
            groupBox1.Visible = false;
            recurrCheck.Visible = true;
        }


        public EventAddEdit(EventRepeat eventRepeat)
        {
            InitializeComponent();
            isRepeat = true;
            er = eventRepeat;
            actionBtn.Text = "Edit";
            Text = "Edit recurring event";
            titleTxt.Text = eventRepeat.title;
            messageRichTxt.Text = eventRepeat.message;
            statusComboBox.SelectedItem = eventRepeat.status;
            dateTimePick.Value = eventRepeat.date;
            locationTxt.Text = eventRepeat.location;
            groupBox1.Visible = true;
            recurrCheck.Visible = false;

            if (er.endDate == DateTime.MinValue)
            {
                dateTimePicker1.Enabled = false;
                noTimeLimit.Checked = true;
            }
            else
            {
                dateTimePicker1.Value = er.endDate;
            }
        }

        private void setEventContact(List<Contact> list)
        {
            if (ev.id > 0)
            {
                if (ev.contactFk == 0)
                {
                    comboBoxEvent.Text = "";
                }
                else
                {
                    for (int x = 0; x < list.Count; x++)
                    {
                        if (ev.contactFk == list[x].ContactId)
                        {
                            comboBoxEvent.SelectedItem = comboBoxEvent.Items[x];
                        }
                    }
                }
            }
        }

        private void setEventRepeatContact(List<Contact> list)
        {
            if (er.id > 0)
            {
                if (er.contactFk == 0)
                {
                    comboBoxEvent.Text = "";
                }
                else
                {
                    for (int x = 0; x < list.Count; x++)
                    {
                        if (er.contactFk == list[x].ContactId)
                        {
                            comboBoxEvent.SelectedItem = comboBoxEvent.Items[x];
                        }
                    }
                }
            }
        }

        private async void EventAddEdit_Load(object sender, EventArgs e)
        {
            ContactRepository contactRepository = new ContactRepository();
            List<Contact> list = await Task.Run(() => contactRepository.GetContacts(Instance.StaticUserAccount.UserId));
            comboBoxEvent.DataSource = list;
            comboBoxEvent.DisplayMember = "ContactName";

            if (isRepeat)
            {
                setEventRepeatContact(list);
            }
            else
            {
                setEventContact(list);
            }
        }

        private void actionBtn_Click(object sender, EventArgs e)
        {

            if (isRepeat)
            {
                addEditEventRepeat();
            } else
            {
                addEditNormEvent();
            }

        }
       

        private async void addEditNormEvent()
        {
            ev.title = titleTxt.Text;
            ev.message = messageRichTxt.Text;

            Contact contact = (Contact)comboBoxEvent.SelectedItem;
            if (contact == null)
            {
                if (string.IsNullOrWhiteSpace(comboBoxEvent.Text))
                {
                    ev.contactFk = 0;
                }
                else
                {
                    ContactRepository contactsRepository = new ContactRepository();
                    ev.contactFk = await Task.Run(() => contactsRepository.AddContact(new Contact { ContactName = comboBoxEvent.Text, userIdFk = Instance.StaticUserAccount.UserId }));
                }
            }
            else
            {
                ev.contactFk = contact.ContactId;
            }
            ev.date = dateTimePick.Value;
            ev.location = locationTxt.Text;

            ev.status = statusComboBox.Text;

            EventRepository eventRepository = new EventRepository();


            bool x;
            if (ev.id > 0)
            {
                x = await Task.Run(() => eventRepository.EditEvent(ev));
            }
            else
            {
                x = await Task.Run(() => eventRepository.AddEvent(ev));
            }

            if (recurrCheck.Checked == true && ev.id == 0)
            {
                EventRepeat eventRepeat = new EventRepeat
                {
                    title = ev.title,
                    message = ev.message,
                    userFK = ev.userFK,
                    status = ev.status,
                    date = ev.date,
                    contactFk = ev.contactFk,
                    location = ev.location
                };


                if (noTimeLimit.Checked)
                {
                    eventRepeat.endDate = DateTime.MinValue;
                }
                else
                {
                    eventRepeat.endDate = dateTimePicker1.Value;
                }
                eventRepeat.period = periodCombo.Text;

                EventRecurringRepository eventRecurringRepository = new EventRecurringRepository();
                bool i = await Task.Run(() => eventRecurringRepository.AddEvent(eventRepeat));
                if (i == false)
                {
                    MessageBox.Show("Ops, something went wrong", "Error");
                    return;
                }
            }

            if (ev.id > 0 && x == true)
            {
                MessageBox.Show("Event Edited!");
            }
            else if (x == true)
            {
                MessageBox.Show("Event Added!");
            }
            else
            {
                MessageBox.Show("ops, Something went wrong");
            }
            Close();
            Dispose();
        }

        private async void addEditEventRepeat()
        {
            er.title = titleTxt.Text;
            er.message = messageRichTxt.Text;

            Contact contact = (Contact)comboBoxEvent.SelectedItem;
            if (contact == null)
            {
                if (string.IsNullOrWhiteSpace(comboBoxEvent.Text))
                {
                    er.contactFk = 0;
                }
                else
                {
                    ContactRepository contactsRepository = new ContactRepository();
                    er.contactFk = await Task.Run(() => contactsRepository.AddContact(new Contact { ContactName = comboBoxEvent.Text, userIdFk = Instance.StaticUserAccount.UserId }));
                }
            }
            else
            {
                er.contactFk = contact.ContactId;
            }

           

            er.date = dateTimePick.Value;
            er.location = locationTxt.Text;

            EventRecurringRepository eventRecurringRepository = new EventRecurringRepository();


            bool x;


            if (noTimeLimit.Checked)
            {
                er.endDate = DateTime.MinValue;
            }
            else
            {
                er.endDate = dateTimePicker1.Value;
            }
            er.period = periodCombo.Text;

            x = await Task.Run(() => eventRecurringRepository.editEvent(er));


            if (er.id > 0 && x == true)
            {
                MessageBox.Show("Event Edited!");
            }

            else
            {
                MessageBox.Show("ops, Something went wrong");
            }
            Close();
            Dispose();
        }

        private void recurrCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (recurrCheck.Checked == true)
            {
                groupBox1.Visible = true;
            }
            else
            {
                groupBox1.Visible = false;
            }
        }

        private void noTimeLimit_CheckedChanged(object sender, EventArgs e)
        {
            if (noTimeLimit.Checked == true)
            {
                dateTimePicker1.Enabled = false;
            }
            else
            {
                dateTimePicker1.Enabled = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void closePanel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void messageRichTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxEvent_SelectedIndexChanged(object sender, EventArgs e)
        {

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
