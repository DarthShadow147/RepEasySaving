using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.SQLServer;

namespace Domain
{
    public class BuyStationeryModel
    {
        private BuyStationeryDao Buy = new BuyStationeryDao();

        public DataTable ShowAmount()
        {
            DataTable table = new DataTable();
            table = Buy.ShowAmount();
            return table;
        }

        public DataTable ShowVault(string InitialDate, string FinalDate)
        {
            DataTable table = new DataTable();
            table = Buy.ShowVault(Convert.ToDateTime(InitialDate), Convert.ToDateTime(FinalDate));
            return table;
        }

        public void InsertBuy(string Description, string Amount)
        {
            Buy.InsertBuy(Description, Convert.ToDecimal(Amount));
        }

        //Atributos reporte
        public List<ReportBuyStationery> ReportBuyStationery { get; private set; }

        //Metodos reporte
        public void ShowReport(string InitialDate, string FinalDate)
        {
            var report = new BuyStationeryDao();
            var result = report.ShowReport(Convert.ToDateTime(InitialDate), Convert.ToDateTime(FinalDate));

            ReportBuyStationery = new List<ReportBuyStationery>();

            foreach (System.Data.DataRow rows in result.Rows)
            {
                var ReportBuy = new ReportBuyStationery()
                {
                    //OperationId,Description,DateTransaction,Amount
                    OperationId = Convert.ToString(rows[0]),
                    Description = Convert.ToString(rows[1]),
                    DateTransaction = Convert.ToDateTime(rows[2]),
                    Amount = Convert.ToDecimal(rows[3])
                };
                ReportBuyStationery.Add(ReportBuy);
            }
        }
    }
}
