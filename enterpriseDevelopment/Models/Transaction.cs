using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enterpriseDevelopment.Models
{
     public class Transaction
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public bool IncomeExpense { get; set; }
        // TransactionType can be Income or Expense
        public string TransactionType { get; set; }
        public DateTime DateTime { get; set; }
        public string ContactName { get; set; }
        public int UserFk { get; set; }
        public int ContactFk { get; set; }
    }
}
