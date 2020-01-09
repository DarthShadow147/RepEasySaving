using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ReportSettlementEvent
    {
        //Id,EventId,Document,Name,LastName,AccountId,Profits
        public int Id { get; set; }
        public int EventId { get; set; }
        public string Document { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int AccountId { get; set; }
        public decimal Profits { get; set; }
    }
}