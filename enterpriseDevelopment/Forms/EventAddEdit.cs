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

        private Event eventPrivate;

        public EventAddEdit()
        {
            InitializeComponent();
            actionBtn.Text = "Add";
            Text = "Add event";
            eventPrivate = new Event { userFK = Instance.StaticUserAccount.UserId };

        }

        public EventAddEdit(Event eventObj)
        {
            InitializeComponent();
            actionBtn.Text = "Edit";
            Text = "Edit event";
            titleTxt.Text = eventObj.title;
            messageRichTxt.Text = eventObj.message;

        }

        private void EventAddEdit_Load(object sender, EventArgs e)
        {
            ContactRepository contactRepository = new ContactRepository();
            List<Contact> list = contactRepository.GetContacts(Instance.StaticUserAccount.UserId);
            comboBoxEvent.DataSource = list;
            comboBoxEvent.DisplayMember = "ContactName";

            if (eventPrivate.id > 0)
            {
                if (eventPrivate.contactFk == 0)
                {
                    comboBoxEvent.Text = "";
                }
                else
                {
                    for (int x = 0; x < list.Count; x++)
                    {
                        if (eventPrivate.contactFk == list[x].ContactId)
                        {
                            comboBoxEvent.SelectedItem = comboBoxEvent.Items[x];
                        }
                    }
                }
            }
        }

        private void actionBtn_Click(object sender, EventArgs e)
        {
            eventPrivate.title = titleTxt.Text;
            eventPrivate.message = messageRichTxt.Text;
            eventPrivate.date = dateTimePick.Value;
            eventPrivate.location = locationTxt.Text;
            eventPrivate.status = statusComboBox.Text;

            Contact contact = (Contact)comboBoxEvent.SelectedItem;
            if(contact == null)
            {
                if(string.IsNullOrWhiteSpace(comboBoxEvent.Text))
                {
                    eventPrivate.contactFk = 0;
                }
                else
                {
                    ContactRepository contactRepository = new ContactRepository();
                    eventPrivate.contactFk = contactRepository.AddContact(new Contact { ContactName = comboBoxEvent.Text, userIdFk = Instance.StaticUserAccount.UserId });

                }
            }
            else
            {
                eventPrivate.contactFk = contact.ContactId;
            }

            // Select add event or edit event method from the repository
            EventRepository eventRepository = new EventRepository();
            bool x;
            if (eventPrivate.id > 0)
            {
                x = eventRepository.EditEvent(eventPrivate);
            }
            else
            {
                x = eventRepository.AddEvent(eventPrivate);
            }
            if (eventPrivate.id > 0 && x == true)
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

      
    }
}
