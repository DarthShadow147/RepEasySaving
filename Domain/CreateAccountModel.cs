using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.SQLServer;
using System.Data;

namespace Domain
{
    public class CreateAccountModel
    {
        private CreateAccountDao Account = new CreateAccountDao();

        public DataTable ShowMembers()
        {
            DataTable TableMembers = new DataTable();
            TableMembers = Account.ShowMembers();
            return TableMembers;
        }

        public void InsertAccount(string Document)
        {
            Account.InsertAccount(Document);
        }
    }
}
