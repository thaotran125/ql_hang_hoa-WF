using System.Data;

namespace HangHoa
{
    class Ckh
    {
        Cdatabase db;
        public Ckh()
        {
            db = new Cdatabase();
        }

        public DataTable selectKH()
        {
            string sql = "select ROW_NUMBER() over(order by MAKH DESC) AS STT, MAKH, TENKH, DIENTHOAI, DIACHI from KHACHHANG order by MAKH desc";
            return db.Execute(sql);
        }

        public DataTable selectexcel()
        {
            string sql= "select MAKH, TENKH, DIENTHOAI, DIACHI from KHACHHANG order by MAKH desc";
            return db.Execute(sql);
        }

        public void insertKH(string id, string ten, string dc, string dt)
        {
            //string sql = string.Format("exec insertKH '{0}', N'{1}', N'{2}', '{3}'", id, ten, dc, dt);
            string sql = string.Format("insert into KHACHHANG values('{0}',N'{1}',N'{2}','{3}')", id, ten, dc, dt);
            db.ExecuteNonQuery(sql);
        }

        public void updateKH(string id, string ten, string dc, string dt)
        {
            string sql = string.Format("update KHACHHANG " +
            " set TENKH = N'{0}', DIACHI = N'{1}', DIENTHOAI = '{2}' " +
            " where MAKH = '{3}'", ten, dc, dt, id);
            db.ExecuteNonQuery(sql);
        }

        public void deleteKH(string id)
        {
            string sql = string.Format("delete KHACHHANG where MAKH='" + id + "'");
            db.ExecuteNonQuery(sql);
        }

        public DataTable datatableKH()
        {
            string sql = "select MAKH, TENKH from KHACHHANG";
            return db.Execute(sql);
        }
        public DataTable selectMAKH()
        {
            string sql = "select MAKH, TENKH from KHACHHANG";
            return db.Execute(sql);
        }

    }
}
