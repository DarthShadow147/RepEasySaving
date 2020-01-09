using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.SQLServer;

namespace Domain
{
    public class StationeryModel
    {
        private StationeryDao stationery = new StationeryDao();

        public DataTable ShowMembers()
        {
            DataTable tableMembers = new DataTable();
            tableMembers = stationery.ShowMembers();
            return tableMembers;
        }

        public DataTable ShowVault(string InitialDate, string FinalDate)
        {
            DataTable tableVault = new DataTable();
            tableVault = stationery.ShowVault(Convert.ToDateTime(InitialDate), Convert.ToDateTime(FinalDate));
            return tableVault;
        }
        

        public void TransferVault(string MemberId, string Document, string AccountId)
        {
            stationery.TransferVault(Convert.ToInt32(MemberId), Document, Convert.ToInt32(AccountId));
        }
    }
}
