using enterpriseDevelopment.Models;
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

        private Event e;

        public EventAddEdit()
        {
            InitializeComponent();
            actionBtn.Text = "Add";
            Text = "Add event";
            e = new Event { userFK = Instance.StaticUserAccount.UserId };

        }

        public EventAddEdit(Event eventObj)
        {
            InitializeComponent();
            actionBtn.Text = "Edit";
            Text = "Edit event";
            titleTxt.Text = eventObj.title;
            messageRichTxt.Text = eventObj.message;

        }

       

    }
}
