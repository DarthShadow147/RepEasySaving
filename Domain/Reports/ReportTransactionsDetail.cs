using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Domain
{
    public class ReportTransactionsDetail
    {
        //Operation,AmountTransaction,TransactionDate
        public string Operation { get; set; }
        public decimal AmountTransaction { get; set; }
        public DateTime TransactionDate { get; set; }
    }
}