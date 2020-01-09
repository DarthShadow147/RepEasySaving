using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.SQLServer;
using System.Data;

namespace Domain
{
    public class PaymentsModel
    {
        private PaymentsDao payments = new PaymentsDao();

        public DataTable ShowDuesInfo(string Document)
        {
            DataTable tableDuesInfo = new DataTable();
            tableDuesInfo = payments.ShowDuesInfo(Document);
            return tableDuesInfo;
        }

        public void InsertPayment(string Document, string DueId, string LoanId, string DueValue)
        {
            payments.InsertPayment(Document,Convert.ToInt32(DueId),Convert.ToInt32(LoanId),Convert.ToDecimal(DueValue));
        }
    }
}
