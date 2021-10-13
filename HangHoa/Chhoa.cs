using System.Data;

namespace HangHoa
{
    class Chhoa
    {
        Cdatabase db;
        public Chhoa()
        {
            db = new Cdatabase();
        }
        public DataTable selecthh()
        {
            string sql = "select ROW_NUMBER() over(order by MAHH DESC) AS STT, MAHH ,TENHH, dvt,DONGIA from HANGHOA order by MAHH desc";
            return db.Execute(sql);
        }

        public DataTable selectdvt()
        {
            string SQL = "select dvt from HANGHOA";
            return db.Execute(SQL);
        }

        public DataTable selectLKhh()
        {
            string sql = "select MAHH, TENHH from HANGHOA";
            return db.Execute(sql);
        }

        public DataTable selectexcel()
        {
             string sql = " select MAHH, TENHH, dvt,DONGIA from HANGHOA";
            return db.Execute(sql);
        }

        public void inserthh(string id, string ten, string dvt, string gia)
        {
            string sql = string.Format("INSERT INTO HANGHOA VALUES ('{0}',N'{1}',N'{2}',{3})", id, ten, dvt, gia);
            db.ExecuteNonQuery(sql);
        }

        public void deletehh(string id)
        {
            string sql = string.Format("exec deleteHH '" + id + "'");
            db.ExecuteNonQuery(sql);
        }

        public void updatehh(string id, string ten, string dvt, string gia)
        {
            string sql = string.Format("update HANGHOA set TENHH=N'{0}', DVT=N'{1}', DONGIA={2} where MAHH='{3}'", ten, dvt, gia, id);
            db.ExecuteNonQuery(sql);
        }

        public DataTable donvitinh()
        {
            string sql = "select DVT from HANGHOA group by DVT";
            return db.Execute(sql);
        }

        public void insertdvt(string dvt)
        {
            string sql = string.Format("insert into donvitinh values(N'{0}')", dvt);
            db.ExecuteNonQuery(sql);
        }

        public DataTable selectreport(string ngaybd, string ngaykt)
        {
            string sql = "";
            return db.Execute(sql);
        }
    }
}
