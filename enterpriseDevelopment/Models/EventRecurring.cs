using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enterpriseDevelopment.Models
{
    public class EventRecurring : Event
    {
        // Period = Daily , Monthly, Early
        public string Period { get; set; }
        public DateTime EndDate { get; set; }
    }
}
