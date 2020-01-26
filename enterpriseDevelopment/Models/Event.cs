using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enterpriseDevelopment.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Status { get; set; }
        public string Location { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public int UserFK { get; set; }
        public int ContactFk { get; set; }
        public string ContactName { get; set; }
    }

}
