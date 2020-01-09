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
    public class MemberModel
    {
        private MembersDao Members = new MembersDao();

        public DataTable ShowMembers()
        {
            DataTable table = new DataTable();
            table = Members.Mostrar();
            return table;
        }
        public void InsertMember (string Document, string name, string lastname, string phone, string limsaving, string limloan, string member)
        {
            Members.Insert(Document,name,lastname,phone,Convert.ToDouble(limsaving),Convert.ToDouble(limloan),Convert.ToBoolean(member));
        }
        public void EditMember(string Document, string name, string lastname, string phone, string limsaving,string limloan, string member)
        {
            Members.Edit(Document,name,lastname,phone,Convert.ToDouble(limsaving),Convert.ToDouble(limloan),Convert.ToBoolean(member));
        }
        public void DeleteMember (string memberid)
        {
            Members.Delete(Convert.ToInt32(memberid));
        }
    }
}
