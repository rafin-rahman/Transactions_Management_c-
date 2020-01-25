using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enterpriseDevelopment.Models
{
  public class TransactionRepeat : Transaction  
    {
        public string subscriptionPeriod { get; set; }
        public DateTime subscriptionEndTime { get; set; }

        
    }
}
