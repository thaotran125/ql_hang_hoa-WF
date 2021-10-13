using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangHoa
{
    class CAccount
    {
        Cdatabase db = new Cdatabase();
        public DataTable selectACC(string ten, string pass)
        {
            string sql = "exec acc '" + ten + "','" + pass + "'";
            return db.Execute(sql);
        }

        public DataTable selectfull()
        {
            string sql = "select *from account";
            return db.Execute(sql);
        }

        public void insertACC(string ten, string id, string pass, string confirm, string quyen)
        {
            string sql =string.Format("insert into account values (N'{0}','{1}','{2}','{3}','{4}')",ten,id,pass,confirm,quyen);
            db.ExecuteNonQuery(sql);
        }

        public DataTable selectLK()
        {
            string sql = "select tenuser, tenlogin from account";
            return db.Execute(sql);
        }

        public void deleteAcc(string username)
        {
            string sql = string.Format("delete account where tenlogin='{0}'", username);
            db.ExecuteNonQuery(sql);
        }
    }
}
