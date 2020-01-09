using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ReportSetlementVault
    {
        //Document,Name,LastName,AccountId,LimSaving,Amount,CurrentSaving
        public string Document { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int AccountId { get; set; }
        public decimal LimSaving { get; set; }
        public decimal Amount { get; set; }
        public decimal CurrentSaving { get; set; }
    }
}