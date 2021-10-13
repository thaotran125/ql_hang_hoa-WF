using System.Data;

namespace HangHoa
{
    class CxuatNhap
    {
        Cdatabase db;

        public CxuatNhap()
        {
            db = new Cdatabase();
        }
        public DataTable selectXN()
        {
            string sql = "select ROW_NUMBER() over(order by  XUATNHAP.SOPHIEU asc) AS STT, XUATNHAP.SOPHIEU, TENKH, LOAI, NGAY from XUATNHAP, KHACHHANG WHERE " +
            " XUATNHAP.MAKH=KHACHHANG.MAKH ORDER BY SOPHIEU DESC";
            //string sql = "exec selectXN";
            return db.Execute(sql);
        }

        public DataTable selectlkXN()
        {
            string sql = "select SOPHIEU from XUATNHAP";
            return db.Execute(sql);
        }

        public DataTable selectXoaKH(string idkh)
        {
            string sql = "select MAKH from XUATNHAP where MAKH='"+idkh+"' group by MAKH";
            return db.Execute(sql);
        }

        public void insertXN(string idsp, string idkh, string loai, string ngay)
        {
            //string sql = string.Format("exec insertXN '{0}','{1}','{2}','{3}'", idsp, loai, ngay, idkh);
            string sql = string.Format("insert into XUATNHAP values('{0}','{1}','{2}','{3}')", idsp, loai, ngay, idkh);
            db.ExecuteNonQuery(sql);
        }

        public void updateXN(string idsp, string idkh, string loai, string ngay)
        {
            string sql = string.Format("exec updateXN '{0}', '{1}', '{2}', '{3}'", idsp, loai, ngay, idkh);
            db.ExecuteNonQuery(sql);
        }

        public void deleteXN(string idsp)
        {
            string sql = string.Format("exec deleteXN '{0}'", idsp);
            db.ExecuteNonQuery(sql);
        }
    }
}
