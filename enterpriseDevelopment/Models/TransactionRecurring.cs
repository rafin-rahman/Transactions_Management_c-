using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enterpriseDevelopment.Models
{
  public class TransactionRecurring : Transaction  
    {
        public string Period { get; set; }
        public DateTime EndTime { get; set; } 
    }
}
