using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ReportShowDues
    {
        //DueDate,LoanAmount,InterestRate,DueNumber,DueValue,Pay,Status
        public DateTime DueDate { get; set; }
        public decimal LoanAmount { get; set; }
        public int InterestRate { get; set; }
        public int DueNumber { get; set; }
        public decimal DueValue { get; set; }
        public string Pay { get; set; }
        public string Status { get; set; }
    }
}