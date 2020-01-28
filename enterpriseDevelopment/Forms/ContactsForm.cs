﻿using System;
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
    public partial class ContactsForm : Form
    {
        // used for Transaction and Event button animation
        private bool isCollapsed = true;
        private bool isCollapsed2 = true;
        private ContactRepository contactRepository;

        // constructor
        public ContactsForm()
        {
            InitializeComponent();
            contactRepository = new ContactRepository();
            UserInstance.MainForm.Hide();
            contactListView.HideSelection = true;
        }

        private async void ContactsForm_Activated(object sender, EventArgs e)
        {
            List<Contact> ContactList = await Task.Run(() => contactRepository.GetContacts(UserInstance.StaticUserAccount.Id));
            contactListView.Items.Clear();
            foreach (Contact contact in ContactList)
            {
                ListViewItem lvi = new ListViewItem(new string[] { contact.Name });
                // Tag is useful when selecting the entire row, the whole contact object will be selected
                lvi.Tag = contact;
                contactListView.Items.Add(lvi);
            }
        }

        #region ADD - EDIT - DELETE
        private void addBtn_Click(object sender, EventArgs e)
        {
            ContactAddEdit contactAddEdit = new ContactAddEdit();
            contactAddEdit.Activate();
            contactAddEdit.Show();
        }
        
        private void editBtn_Click(object sender, EventArgs e)
        {
            if (contactListView.SelectedItems.Count > 0)
            {
                Contact contact = (Contact)contactListView.SelectedItems[0].Tag;
                ContactAddEdit contactAddEdit = new ContactAddEdit(contact);
                contactAddEdit.Activate();
                contactAddEdit.Show();
            }
        }

        private async void deleteBtn_Click(object sender, EventArgs e)
        {
            if (contactListView.SelectedItems.Count > 0)
            {
                Contact contact = (Contact)contactListView.SelectedItems[0].Tag;
                DialogResult dialogResult = MessageBox.Show("Do you want do delete this contact?", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    bool x = await Task.Run(() => contactRepository.DeleteContact(contact));
                    if (x)
                        MessageBox.Show("Contact deleted");
                    else
                        MessageBox.Show("Contact not deleted");
                }
            }
        }
        #endregion

        #region NAVIGATION BUTTONS

        private void mainBtn_Click(object sender, EventArgs e)
        {
            UserInstance.MainForm.Show();
            Close();
        }

        private void predictBtn_Click(object sender, EventArgs e)
        {
            financialPredictionForm financialPredictionForm = new financialPredictionForm();
            financialPredictionForm.Activate();
            financialPredictionForm.Show();
            Close();
        }
        
        private void summaryBtn_Click(object sender, EventArgs e)
        {
            SummaryForm summaryForm = new SummaryForm();
            summaryForm.Activate();
            summaryForm.Show();
            Close();
        }

        // Animated buttons click
        private void repeatBtn_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm(true);
            eventForm.Activate();
            eventForm.Show();
            Close();
        }

        private void recurringToggleBtn_Click(object sender, EventArgs e)
        {
            TransactionForm transactionForm = new TransactionForm();
            transactionForm.Activate();
            transactionForm.Show();
            Close();
        }

        private void eventsRepeatBtn_Click(object sender, EventArgs e)
        {
            TransactionForm transactionForm = new TransactionForm(true);
            transactionForm.Activate();
            transactionForm.Show();
            Close();
        }

        private void singleEventBtn_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.Activate();
            eventForm.Show();
        }

        #endregion

        #region NAVIGATION BUTTONS HOVER ANIMATION
        private void mainBtn_MouseEnter(object sender, EventArgs e)
        {
            mainBoxPanel.Visible = true;
            mainIcon.Visible = false;
            mainBtn.Font = new Font(mainBtn.Font, FontStyle.Bold);
            mainBtn.ForeColor = Color.White;
        }

        private void mainBtn_MouseLeave(object sender, EventArgs e)
        {
            mainBoxPanel.Visible = false;
            mainIcon.Visible = true;
            mainBtn.Font = new Font(mainBtn.Font, FontStyle.Regular);
            mainBtn.ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void summaryBtn_MouseEnter(object sender, EventArgs e)
        {
            summaryBoxPanel.Visible = true;
            summaryIcon.Visible = false;
            summaryBtn.Font = new Font(summaryBtn.Font, FontStyle.Bold);
            summaryBtn.ForeColor = Color.White;
        }

        private void summaryBtn_MouseLeave(object sender, EventArgs e)
        {
            summaryBoxPanel.Visible = false;
            summaryIcon.Visible = true;
            summaryBtn.Font = new Font(summaryBtn.Font, FontStyle.Regular);
            summaryBtn.ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void transactionBtn_MouseEnter(object sender, EventArgs e)
        {
            transactionBoxPanel.Visible = true;
            transactionIcon.Visible = false;
            transactionBtn.Font = new Font(transactionBtn.Font, FontStyle.Bold);
            transactionBtn.ForeColor = Color.White;
        }

        private void transactionBtn_MouseLeave(object sender, EventArgs e)
        {
            transactionBoxPanel.Visible = false;
            transactionIcon.Visible = true;
            transactionBtn.Font = new Font(transactionBtn.Font, FontStyle.Regular);
            transactionBtn.ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void eventsBtn_MouseEnter(object sender, EventArgs e)
        {
            eventBoxPanel.Visible = true;
            eventIcon.Visible = false;
            eventsBtn.Font = new Font(eventsBtn.Font, FontStyle.Bold);
            eventsBtn.ForeColor = Color.White;
        }

        private void eventsBtn_MouseLeave(object sender, EventArgs e)
        {
            eventBoxPanel.Visible = false;
            eventIcon.Visible = true;
            eventsBtn.Font = new Font(eventsBtn.Font, FontStyle.Regular);
            eventsBtn.ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void predictBtn_MouseEnter(object sender, EventArgs e)
        {
            predictionBoxPanel.Visible = true;
            predictionIcon.Visible = false;
            predictBtn.Font = new Font(predictBtn.Font, FontStyle.Bold);
            predictBtn.ForeColor = Color.White;
        }

        private void predictBtn_MouseLeave(object sender, EventArgs e)
        {
            predictionBoxPanel.Visible = false;
            predictionIcon.Visible = true;
            predictBtn.Font = new Font(predictBtn.Font, FontStyle.Regular);
            predictBtn.ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void contactBtn_MouseEnter(object sender, EventArgs e)
        {
            contactBoxPanel.Visible = true;
            contactIcon.Visible = false;
            contactBtn.Font = new Font(contactBtn.Font, FontStyle.Bold);
            contactBtn.ForeColor = Color.White;
        }

        private void contactBtn_MouseLeave(object sender, EventArgs e)
        {
            contactBoxPanel.Visible = false;
            contactIcon.Visible = true;
            contactBtn.Font = new Font(contactBtn.Font, FontStyle.Regular);
            contactBtn.ForeColor = Color.FromArgb(224, 224, 224);
        }
        #endregion

        #region ANIMATION TIMER
        private void eventsBtn_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isCollapsed2)
            {
                eventToogle.Width += 20;
                if (eventToogle.Size == eventToogle.MaximumSize)
                {
                    timer2.Stop();
                    isCollapsed2 = false;
                }
            }
            else
            {
                eventToogle.Width -= 20;
                if (eventToogle.Size == eventToogle.MinimumSize)
                {
                    timer2.Stop();
                    isCollapsed2 = true;
                }
            }
        }

        private void transactionBtn_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                transactionToogle.Width += 20;
                if (transactionToogle.Size == transactionToogle.MaximumSize)
                {
                    timer.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                transactionToogle.Width -= 20;
                if (transactionToogle.Size == transactionToogle.MinimumSize)
                {
                    timer.Stop();
                    isCollapsed = true;
                }
            }
        }
        
        #endregion
        
        private void ContactsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            UserInstance.MainForm.Dispose();
        }
    }
}
