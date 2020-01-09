using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ReportLoansQueryModel
    {
        //Name, LastName, RequestedAmount, InterestRate, NumDues, FinalAmount, InitialPayDate, FinalPayDate, CurrentDeb, SUM(p.AmountPaid) AS AmountPaid
        public string Name { get; set; }
        public string LastName { get; set; }
        public decimal RequestedAmount { get; set; }
        public int InterestRate { get; set; }
        public int NumDues { get; set; }
        public decimal FinalAmount { get; set; }
        public DateTime InitialPayDate { get; set; }
        public DateTime FinalPayDate { get; set; }
        public decimal CurrentDeb { get; set; }
        public decimal AmountPaid { get; set; }
    }
}
