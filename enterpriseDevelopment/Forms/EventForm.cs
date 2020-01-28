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
        // used for Transaction and Event button animation
        private bool isCollapsed = true;
        private bool isCollapsed2 = true;
        private EventRepository eventRepository;
        private EventRecurringRepository eventRecurringRepository;
        // Detect if the selected event is recurring or not
        private bool isRepeating = false;

        public EventForm()
        {
            InitializeComponent();
            eventRepository = new EventRepository();
            UserInstance.MainForm.Hide();
            // The list view start with no item selected 
            listViewEvent.HideSelection = true;
        }
        
        public EventForm(bool recurring)
        {
            InitializeComponent();
            listViewEvent.HideSelection = true;
            isRepeating = recurring;
            if (isRepeating == true)
            {
                listViewEvent.Columns.Add("Period");
                listViewEvent.Columns.Add("Ending date");
            }

            eventRecurringRepository = new EventRecurringRepository();
            UserInstance.MainForm.Hide();
        }

        private async void EventForm_Activated(object sender, EventArgs e)
        {
            if (isRepeating)
            {
                List<EventRecurring> eventsList = await Task.Run(() => eventRecurringRepository.GetEvents(UserInstance.StaticUserAccount.Id));
                listViewEvent.Items.Clear();
                foreach (EventRecurring recurringEvent in eventsList)
                {
                    string endDate = "";
                    if (recurringEvent.EndDate == DateTime.MinValue)
                        endDate = "N/A";
                    else
                        endDate = recurringEvent.EndDate.ToString();

                    ListViewItem listViewI = new ListViewItem(new string[] { recurringEvent.Title, recurringEvent.Status, recurringEvent.Location, recurringEvent.Message, recurringEvent.ContactName, recurringEvent.Date.ToString(), recurringEvent.Period, endDate });
                    listViewI.Tag = recurringEvent;
                    listViewEvent.Items.Add(listViewI);
                }
            }
            else
            {
                List<Event> eventsList = await Task.Run(() => eventRepository.GetEvents(UserInstance.StaticUserAccount.Id));
                listViewEvent.Items.Clear();
                foreach (Event eventObj in eventsList)
                {
                    ListViewItem listViewI = new ListViewItem(new string[] { eventObj.Title, eventObj.Status, eventObj.Location, eventObj.Message, eventObj.ContactName, eventObj.Date.ToString() });
                    listViewI.Tag = eventObj;
                    listViewEvent.Items.Add(listViewI);
                }
            }
        }

        #region ADD - EDIT - DELETE
        // Add events
        private void addBtn_Click(object sender, EventArgs e)
        {
            EventAddEdit eventAddEdit = new EventAddEdit();
            eventAddEdit.Activate();
            eventAddEdit.Show();
        }
        // Edit events
        private void editBtn_Click(object sender, EventArgs e)
        {

            if (listViewEvent.SelectedItems.Count > 0)
            {
                if (isRepeating)
                {
                    EventRecurring eventRepeat = (EventRecurring)listViewEvent.SelectedItems[0].Tag;
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
        // Delete events
        private async void deleteBtn_Click(object sender, EventArgs e)
        {
            if (isRepeating)
            {
                EventRecurring eventRepeat = (EventRecurring)listViewEvent.SelectedItems[0].Tag;

                DialogResult dialogResult = MessageBox.Show("Do you want do delete the event?", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    bool x = await Task.Run(() => eventRecurringRepository.deleteEvent(eventRepeat));
                    if (x)
                        MessageBox.Show("Event deleted");
                    else
                        MessageBox.Show("Event not deleted");
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
                        MessageBox.Show("Event deleted");
                    else
                        MessageBox.Show("Event not deleted");
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

        private void singleEventBtn_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm();
            eventForm.Activate();
            eventForm.Show();
            Close();
        }

        private void singleTransactionBtn_Click(object sender, EventArgs e)
        {
            TransactionForm transactionForm = new TransactionForm();
            transactionForm.Activate();
            transactionForm.Show();
            Close();
        }

        private void recurringTransactionBtn_Click(object sender, EventArgs e)
        {
            TransactionForm transactionForm = new TransactionForm(true);
            transactionForm.Activate();
            transactionForm.Show();
            Close();
        }

        private void summaryBtn_Click(object sender, EventArgs e)
        {
            SummaryForm summaryForm = new SummaryForm();
            summaryForm.Activate();
            summaryForm.Show();
            Close();
        }

        private void contactBtn_Click(object sender, EventArgs e)
        {
            ContactsForm contactsForm = new ContactsForm();
            contactsForm.Activate();
            contactsForm.Show();
            Close();
        }
        #endregion
        
        #region  HOVER ANIMATION
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

        private void closeBtn_MouseEnter(object sender, EventArgs e)
        {
            this.closeBtn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.closeHover));
        }

        private void closeBtn_MouseLeave(object sender, EventArgs e)
        {
            this.closeBtn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.close));
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
                eventTooglePanel.Width += 20;
                if (eventTooglePanel.Size == eventTooglePanel.MaximumSize)
                {
                    timer2.Stop();
                    isCollapsed2 = false;
                }
            }
            else
            {
                eventTooglePanel.Width -= 20;
                if (eventTooglePanel.Size == eventTooglePanel.MinimumSize)
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
                transactionTooglePanel.Width += 20;
                if (transactionTooglePanel.Size == transactionTooglePanel.MaximumSize)
                {
                    timer.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                transactionTooglePanel.Width -= 20;
                if (transactionTooglePanel.Size == transactionTooglePanel.MinimumSize)
                {
                    timer.Stop();
                    isCollapsed = true;
                }
            }
        }
        #endregion

        #region LIST VIEW COLUMN WIDTH BASED ON PANEL SIZE
        //private void SetListViewColumns()
        //{
        //    int total = listViewEvent.Width - 18;
        //    int count = listViewEvent.Columns.Count;
        //    int size = total / count;
        //    int last = total - (size * (count - 2));
        //    for (int i = 0; i < count; i++)
        //    {
        //        if (i == count - 1)
        //            listViewEvent.Columns[i].Width = last;
        //        else if (i == 0)
        //            listViewEvent.Columns[i].Width = last;
        //        else
        //            listViewEvent.Columns[i].Width = (int)(1.5 * size);
        //    }
        //}
       
        //private void listViewEvent_SizeChanged(object sender, EventArgs e)
        //{
        //    SetListViewColumns();
        //}
        #endregion

        private void EventForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            UserInstance.MainForm.Activate();
            UserInstance.MainForm.Show();
            Dispose();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            UserInstance.MainForm.Dispose();
        }
       
    }
}
