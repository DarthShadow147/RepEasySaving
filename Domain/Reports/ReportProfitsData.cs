using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Reports
{
    public class ReportProfitsData
    {
        //ProfitId,LoanId,EventId,Description,EventDate,Amount
        public int ProfitId { get; set; }
        public int LoanId { get; set; }
        public int EventId { get; set; }
        public string Description { get; set; }
        public DateTime EventDate { get; set; }
        public decimal Amount { get; set; }
    }
}