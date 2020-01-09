using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.SQLServer;

namespace Domain
{
    public class SettlementModel
    {
        private SettlementDao settlement = new SettlementDao();

        public DataTable ShowMembers()
        {
            DataTable table = new DataTable();
            table = settlement.ShowMembers();
            return table;
        }

        public DataTable ShowSettlement()
        {
            DataTable table = new DataTable();
            table = settlement.ShowSettlement();
            return table;
        }

        public void InsertSettlement()
        {
            settlement.InsertSettlement();
        }

        //Atributos del reporte
        public List<ReportSetlementVault> reportSetlementVault { get; private set; }
        public List<ReportSetlementVTotal> reportSetlementVTotal { get; private set; }
        public List<ReportSetlementPTotal> reportSetlementPTotal { get; private set; }

        //Metodos del reporte
        public void ShowReport()
        {
            var report = new SettlementDao();
            var result = report.ShowReport();

            reportSetlementVault = new List<ReportSetlementVault>();

            foreach (System.Data.DataRow rows in result.Rows)
            {
                var SettlementSummary = new ReportSetlementVault()
                {
                    //Document,Name,LastName,AccountId,LimSaving,Amount,CurrentSaving
                    Document = Convert.ToString(rows[0]),
                    Name = Convert.ToString(rows[1]),
                    LastName = Convert.ToString(rows[2]),
                    AccountId = Convert.ToInt32(rows[3]),
                    LimSaving = Convert.ToDecimal(rows[4]),
                    Amount = Convert.ToDecimal(rows[5]),
                    CurrentSaving = Convert.ToDecimal(rows[6])
                };
                reportSetlementVault.Add(SettlementSummary);
            }
        }

        public void ShowTotalVault()
        {
            var report = new SettlementDao();
            var result = report.TotalVault();

            reportSetlementVTotal = new List<ReportSetlementVTotal>();

            foreach (System.Data.DataRow rows in result.Rows)
            {
                var SettlementTotal = new ReportSetlementVTotal()
                {
                    //Vault
                    Vault = Convert.ToDecimal(rows[0])
                };
                reportSetlementVTotal.Add(SettlementTotal);
            }
        }

        public void ShowTotalProfits()
        {
            var report = new SettlementDao();
            var result = report.TotalProfits();

            reportSetlementPTotal = new List<ReportSetlementPTotal>();

            foreach (System.Data.DataRow rows in result.Rows)
            {
                var SettlementPTotal = new ReportSetlementPTotal()
                {
                    //Profits
                    Profits = Convert.ToDecimal(rows[0])
                };
                reportSetlementPTotal.Add(SettlementPTotal);
            }
        }
    }
}
