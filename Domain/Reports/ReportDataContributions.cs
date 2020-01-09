using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Reports
{
    public class ReportDataContributions
    {
        //Document,Member,AccountNumber,ahorroTotal,AmountTransaction,TransactionDate
        public string Document { get; set; }
        public string Member { get; set; }
        public int AccountNumber { get; set; }
        public decimal ahorroTotal { get; set; }
        public decimal AmountTransaction { get; set; }
        public DateTime TransactionDate { get; set; }
    }
}