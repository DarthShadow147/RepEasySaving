using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ReportBuyStationery
    {
        //OperationId,Description,DateTransaction,Amount
        public string OperationId { get; set; }
        public string Description { get; set; }
        public DateTime DateTransaction { get; set; }
        public decimal Amount { get; set; }
    }
}