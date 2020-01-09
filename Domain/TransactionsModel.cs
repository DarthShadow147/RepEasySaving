using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.SQLServer;

namespace Domain
{
    public class TransactionsModel
    {
        private TransactionsDao transactions = new TransactionsDao();

        public DataTable ShowPerson(string Document)
        {
            DataTable tablePersons = new DataTable();
            tablePersons = transactions.ShowPersons(Document);
            return tablePersons;
        }

        public void InsertTransaction(string Document, string OperationId, string Amount)
        {
            transactions.InsertTransaction(Document,Convert.ToInt32(OperationId),Convert.ToDecimal(Amount));
        }

        public DataTable ShowSummary(string Document)
        {
            DataTable tableSummary = new DataTable();
            tableSummary = transactions.ShowSummaryTran(Document);
            return tableSummary;
        }

        //Atributos Reporte
        public List<ReportTransactions> ReportTransactions { get; private set; }
        public List<ReportTransactionsDetail> ReportTransactionsDetail { get; private set; }

        //Metodos Reporte
        public void ShowReportTransactions(string Document)
        {
            var report = new TransactionsDao();
            var result = report.ReportTransaction(Document);

            ReportTransactions = new List<ReportTransactions>();

            foreach (System.Data.DataRow rows in result.Rows)
            {
                var ReportTransaction = new ReportTransactions()
                {
                    //Document,AccountNumber,Name,LastName,Amount,Operation,AmountTransaction,TransactionDate
                    Document = Convert.ToString(rows[0]),
                    AccountNumber = Convert.ToInt32(rows[1]),
                    Name = Convert.ToString(rows[2]),
                    LastName = Convert.ToString(rows[3]),
                    Amount = Convert.ToDecimal(rows[4]),
                };
                ReportTransactions.Add(ReportTransaction);
            }
        }

        public void ShowReportDetail(string Document)
        {
            var report = new TransactionsDao();
            var result = report.ReportTransactionDetail(Document);

            ReportTransactionsDetail = new List<ReportTransactionsDetail>();

            foreach (System.Data.DataRow rows in result.Rows)
            {
                var ReportDetail = new ReportTransactionsDetail()
                {
                    //Operation,AmountTransaction,TransactionDate
                    Operation = Convert.ToString(rows[0]),
                    AmountTransaction = Convert.ToDecimal(rows[1]),
                    TransactionDate = Convert.ToDateTime(rows[2])
                };
                ReportTransactionsDetail.Add(ReportDetail);
            }
        }
    }
}
