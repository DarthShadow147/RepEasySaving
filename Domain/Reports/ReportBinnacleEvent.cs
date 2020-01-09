using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ReportBinnacleEvent
    {
        //Id,EventId,Description,DateBinnacle,Spending,AmountEvent
        public int Id { get; set; }
        public int EventId { get; set; }
        public string Description { get; set; }
        public DateTime DateBinnacle { get; set; }
        public string Spending { get; set; }
        public decimal AmountEvent { get; set; }
    }
}