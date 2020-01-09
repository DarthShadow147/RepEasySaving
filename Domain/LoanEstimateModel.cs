using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAccess.SQLServer;

namespace Domain
{
    public class LoanEstimateModel
    {
        private LoanEstimateDao Estimate = new LoanEstimateDao();

        public DataTable ShowEstimate()
        {
            DataTable tableRequest = new DataTable();
            tableRequest = Estimate.MostrarSolicitud();
            return tableRequest;
        }

        public DataTable ShowDues(string Document)
        {
            DataTable tableDues = new DataTable();
            tableDues = Estimate.MostrarCuotas(Document);
            return tableDues;
        }

        public void InsertEstimate(string Document, string NumDues, string Date, string InterestRate, string AmountRequest)
        {
            Estimate.InsertEstimate(Document, Convert.ToInt32(NumDues),Convert.ToDateTime(Date), Convert.ToInt32(InterestRate), Convert.ToDecimal(AmountRequest));
        }

        public void InsertDues(string Document, string AmountRequest, string InterestRate, string Date)
        {
            Estimate.InsertDues(Document,Convert.ToDecimal(AmountRequest),Convert.ToInt32(InterestRate),Convert.ToDateTime(Date));
        }
    }
}
