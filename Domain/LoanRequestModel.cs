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
    public class LoanRequestModel
    {
        private LoanRequestDao Request = new LoanRequestDao();

        public DataTable ShowMembers()
        {
            DataTable table = new DataTable();
            table = Request.MostrarMiembrosLoan();
            return table;
        }

        public DataTable ShowRequest()
        {
            DataTable tableRequest = new DataTable();
            tableRequest = Request.MostrarSolicitud();
            return tableRequest;
        }

        public DataTable ShowVault()
        {
            DataTable tableVault = new DataTable();
            tableVault = Request.MostrarFondos();
            return tableVault;
        }

        public void InsertRequest(string Document, string name, string lastname, string requestamount, string interestrate, string observations)
        {
            Request.InsertRequest(Document,name,lastname,Convert.ToDouble(requestamount),Convert.ToInt32(interestrate),observations);
        }

        public void DeleteRequets(string loanId)
        {
            Request.DeleteRequest(Convert.ToInt32(loanId));
        }
    }
}
