using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.SQLServer;

namespace Domain
{
    public class EventsModel
    {
        private EventsDao events = new EventsDao();

        public DataTable ShowEvents()
        {
            DataTable tableEvents = new DataTable();
            tableEvents = events.ShowEvents();
            return tableEvents;
        }

        public DataTable ShowBinacle(string EventId)
        {
            DataTable tableSummary = new DataTable();
            tableSummary = events.ShowSummary(EventId);
            return tableSummary;
        }

        public void InsertEvents(string EventName, string Inversion, string Participants)
        {
            events.InsertEvent(EventName, Convert.ToDecimal(Inversion), Convert.ToInt32(Participants));
        }

        public void InsertBinnacle(string EventId, string Description, string Spending, string Amount)
        {
            events.InsertBinnacle(Convert.ToInt32(EventId), Description, Convert.ToBoolean(Spending), Convert.ToDecimal(Amount));
        }

        public void SettlementEvent(string EventId)
        {
            events.SettlementEvent(Convert.ToInt32(EventId));
        }

        //Atributos Reporte
        public List<ReportSettlementEvent> ReportSettlementEvent { get; private set; }
        public List<ReportBinnacleEvent> ReportBinnacleEvent { get; private set; }
        public List<ReportTotalEvents> ReportTotalEvents { get; private set; }

        //Metodos Reporte
        public void ShowReport(string EventId)
        {
            var report = new EventsDao();
            var result = report.ShowReport(Convert.ToInt32(EventId));

            ReportSettlementEvent = new List<ReportSettlementEvent>();

            foreach (System.Data.DataRow rows in result.Rows)
            {
                var ReportSettlement = new ReportSettlementEvent()
                {
                    //Id,EventId,Document,Name,LastName,AccountId,Profits
                    Id = Convert.ToInt32(rows[0]),
                    EventId = Convert.ToInt32(rows[1]),
                    Document = Convert.ToString(rows[2]),
                    Name = Convert.ToString(rows[3]),
                    LastName = Convert.ToString(rows[4]),
                    AccountId = Convert.ToInt32(rows[5]),
                    Profits = Convert.ToDecimal(rows[6])
                };
                ReportSettlementEvent.Add(ReportSettlement);
            }
        }

        public void ShowBinnacle(string EventId)
        {
            var report = new EventsDao();
            var result = report.ShowBinnacle(Convert.ToInt32(EventId));

            ReportBinnacleEvent = new List<ReportBinnacleEvent>();

            foreach (System.Data.DataRow rows in result.Rows)
            {
                var SummaryBinnacle = new ReportBinnacleEvent()
                {
                    //Id,EventId,Description,DateBinnacle,Spending,AmountEvent
                    Id = Convert.ToInt32(rows[0]),
                    EventId = Convert.ToInt32(rows[1]),
                    Description = Convert.ToString(rows[2]),
                    DateBinnacle = Convert.ToDateTime(rows[3]),
                    Spending = Convert.ToString(rows[4]),
                    AmountEvent = Convert.ToDecimal(rows[5])
                };
                ReportBinnacleEvent.Add(SummaryBinnacle);
            }
        }

        public void ShowTotalEvent(String EventId)
        {
            var report = new EventsDao();
            var result = report.ShowTotal(Convert.ToInt32(EventId));

            ReportTotalEvents = new List<ReportTotalEvents>();

            foreach (System.Data.DataRow rows in result.Rows)
            {
                var ReportTotal = new ReportTotalEvents()
                {
                    Total = Convert.ToDecimal(rows[0])
                };
                ReportTotalEvents.Add(ReportTotal);
            }
        }
    }
}
