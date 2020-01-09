using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ReportSavingModel
    {
        //Name,LastName,LimSaving,CurrentSaving,AccountNumber,RegistrationDate
        public string Name { get; set; }
        public string LastName { get; set; }
        public decimal LimSaving { get; set; }
        public decimal CurrentSaving { get; set; }
        public int AccountNumber { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}