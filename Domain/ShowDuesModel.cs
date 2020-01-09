using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.SQLServer;

namespace Domain
{
    public class ShowDuesModel
    {
        private ShowDuesDao Dues = new ShowDuesDao();

        public DataTable ShowMembers()
        {
            DataTable tableMembers = new DataTable();
            tableMembers = Dues.MostrarMiembros();
            return tableMembers;
        }

        public DataTable ShowDues(string Document)
        {
            DataTable tableDues = new DataTable();
            tableDues = Dues.ShowDues(Document);
            return tableDues;
        }

        //Atributos Reporte
        public List<ReportShowDues> ReportShowDues { get; private set; }
        public List<ReportShowMember> ReportShowMember { get; private set; }

        //Metodos Reporte
        public void PrintDues(string Document)
        {
            var report = new ShowDuesDao();
            var result = report.PrintDues(Document);

            ReportShowDues = new List<ReportShowDues>();

            foreach (System.Data.DataRow rows in result.Rows)
            {
                var ShowDues = new ReportShowDues()
                {
                    //DueDate,LoanAmount,InterestRate,DueNumber,DueValue,Pay,Status
                    DueDate = Convert.ToDateTime(rows[0]),
                    LoanAmount = Convert.ToDecimal(rows[1]),
                    InterestRate = Convert.ToInt32(rows[2]),
                    DueNumber = Convert.ToInt32(rows[3]),
                    DueValue = Convert.ToDecimal(rows[4]),
                    Pay = Convert.ToString(rows[5]),
                    Status = Convert.ToString(rows[6])
                };
                ReportShowDues.Add(ShowDues);
            }
        }

        public void PrintMember(string Document)
        {
            var report = new ShowDuesDao();
            var result = report.DuesMember(Document);

            ReportShowMember = new List<ReportShowMember>();

            foreach (System.Data.DataRow rows in result.Rows)
            {
                var ShowMember = new ReportShowMember()
                {
                    //Document,Name,LastName
                    Document = Convert.ToString(rows[0]),
                    Name = Convert.ToString(rows[1]),
                    LastName = Convert.ToString(rows[2])
                };
                ReportShowMember.Add(ShowMember);
            }
        }
    }
}
