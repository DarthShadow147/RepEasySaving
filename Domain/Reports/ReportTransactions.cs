using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ReportTransactions
    {
        //Document,AccountNumber,Name,LastName,Amount
        public string Document { get; set; }
        public int AccountNumber { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public decimal Amount { get; set; }
    }
}