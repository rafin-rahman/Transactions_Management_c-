﻿using enterpriseDevelopment.Models;
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
            actionBtn.Text = "Add";
            Text = "Add event";
            ev = new Event { userFK = Instance.StaticUserAccount.UserId };

        }

        public EventAddEdit(Event eventObj)
        {
            InitializeComponent();
            actionBtn.Text = "Edit";
            Text = "Edit event";
            titleTxt.Text = eventObj.title;
            messageRichTxt.Text = eventObj.message;
            statusComboBox.SelectedItem = eventObj.status;
            dateTimePick.Value = eventObj.date;
            locationTxt.Text = eventObj.location;
            groupBox1.Visible = false;
            recurrCheck.Visible = false;
        }


        public EventAddEdit(EventRepeat eventRepeat)
        {
            InitializeComponent();
            actionBtn.Text = "Edit";
            Text = "Edit recurring event";
            titleTxt.Text = eventRepeat.title;
            messageRichTxt.Text = eventRepeat.message;
            statusComboBox.SelectedItem = eventRepeat.status;
            dateTimePick.Value = eventRepeat.date;
            locationTxt.Text = eventRepeat.location;
            groupBox1.Visible = false;
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
                    statusComboBox.Text = "";
                }
                else
                {
                    for (int x = 0; x < list.Count; x++)
                    {
                        if (ev.contactFk == list[x].ContactId)
                        {
                            statusComboBox.SelectedItem = statusComboBox.Items[x];
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
                    statusComboBox.Text = "";
                }
                else
                {
                    for (int x = 0; x < list.Count; x++)
                    {
                        if (er.contactFk == list[x].ContactId)
                        {
                            statusComboBox.SelectedItem = statusComboBox.Items[x];
                        }
                    }
                }
            }
        }

        private void EventAddEdit_Load(object sender, EventArgs e)
        {
            ContactRepository contactRepository = new ContactRepository();
            List<Contact> list = contactRepository.GetContacts(Instance.StaticUserAccount.UserId);
            statusComboBox.DataSource = list;
            statusComboBox.DisplayMember = "ContactName";

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
            ev.title = titleTxt.Text;
            ev.message = messageRichTxt.Text;
            ev.date = dateTimePick.Value;
            ev.location = locationTxt.Text;
            ev.status = statusComboBox.Text;

            Contact contact = (Contact)comboBoxEvent.SelectedItem;
            if (contact == null)
            {
                if (string.IsNullOrWhiteSpace(comboBoxEvent.Text))
                {
                    ev.contactFk = 0;
                }
                else
                {
                    ContactRepository contactRepository = new ContactRepository();
                    ev.contactFk = contactRepository.AddContact(new Contact { ContactName = comboBoxEvent.Text, userIdFk = Instance.StaticUserAccount.UserId });

                }
            }
            else
            {
                ev.contactFk = contact.ContactId;
            }

            // Select add event or edit event method from the repository
            EventRepository eventRepository = new EventRepository();
            bool x;
            if (ev.id > 0)
            {
                x = eventRepository.EditEvent(ev);
            }
            else
            {
                x = eventRepository.AddEvent(ev);
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

        private void addEditNormEvent()
        {
            ev.title = titleTxt.Text;
            ev.message = messageRichTxt.Text;

            Contact contact = (Contact)statusComboBox.SelectedItem;
            if (contact == null)
            {
                if (string.IsNullOrWhiteSpace(statusComboBox.Text))
                {
                    ev.contactFk = 0;
                }
                else
                {
                    ContactRepository contactsRepository = new ContactRepository();
                    ev.contactFk = contactsRepository.AddContact(new Contact { ContactName = statusComboBox.Text, userIdFk = Instance.StaticUserAccount.UserId });
                }
            }
            else
            {
                ev.contactFk = contact.ContactId;
            }
            ev.date = dateTimePick.Value;
            ev.location = locationTxt.Text;

            EventRepository eventRepository = new EventRepository();


            bool x;
            if (ev.id > 0)
            {
                x = eventRepository.EditEvent(ev);
            }
            else
            {
                x = eventRepository.AddEvent(ev);
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
                    contactFk = ev.contactFk
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
                bool i = eventRecurringRepository.AddEvent(eventRepeat);
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

        private void addEditEventRepeat()
        {
            er.title = titleTxt.Text;
            er.message = messageRichTxt.Text;

            Contact contact = (Contact)statusComboBox.SelectedItem;
            if (contact == null)
            {
                if (string.IsNullOrWhiteSpace(statusComboBox.Text))
                {
                    er.contactFk = 0;
                }
                else
                {
                    ContactRepository contactsRepository = new ContactRepository();
                    er.contactFk = contactsRepository.AddContact(new Contact { ContactName = statusComboBox.Text, userIdFk = Instance.StaticUserAccount.UserId });
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

            x = eventRecurringRepository.editEvent(er);


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
    }
}
