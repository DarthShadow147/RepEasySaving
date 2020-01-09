using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.SQLServer;

namespace Domain
{
    public class LoanSavingModel
    {
        //Atributos
        public List<ReportSavingModel> ReportSavingModel { get; private set; }

        //Metodos
        public void ReportSaving(string Document)
        {
            var saving = new LoanSavingDao();
            var result = saving.ShowSaving(Document);

            ReportSavingModel = new List<ReportSavingModel>();

            foreach (System.Data.DataRow rows in result.Rows)
            {
                var LoanSavingModel = new ReportSavingModel()
                {
                    //Name,LastName,LimSaving,CurrentSaving,AccountNumber,RegistrationDate
                    Name = Convert.ToString(rows[0]),
                    LastName = Convert.ToString(rows[1]),
                    LimSaving = Convert.ToDecimal(rows[2]),
                    CurrentSaving = Convert.ToDecimal(rows[3]),
                    AccountNumber = Convert.ToInt32(rows[4]),
                    RegistrationDate = Convert.ToDateTime(rows[5])
                };
                ReportSavingModel.Add(LoanSavingModel);
            }
        }
    }
}
