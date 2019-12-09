using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enterpriseDevelopment.Models
{
    public class EventRepeat
    {

        public int id { get; set; }
        public string title { get; set; }
        public string status { get; set; }
        public string location { get; set; }
        public string message { get; set; }
        public DateTime date { get; set; }
        public int userFK { get; set; }
        public int contactFk { get; set; }
        public string contactName { get; set; }
        public string period { get; set; }
        public DateTime endDate { get; set; }
    }
}
