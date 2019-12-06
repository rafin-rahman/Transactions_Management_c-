using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enterpriseDevelopment.Models
{
     public class Transaction
    {

        public int transactionId { get; set; }
        public string transactionCategory { get; set; }
        public decimal transactionAmount { get; set; }
        public string transactionMessage { get; set; }
        public bool incomeExpense { get; set; }
        public string typeValue { get; set; }
        public DateTime dateTime { get; set; }
        public string contactName { get; set; }
        public int userIdFk { get; set; }
        public int contactIdFk { get; set; }

    }
}
