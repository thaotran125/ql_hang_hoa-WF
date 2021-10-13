using System.Data;

namespace HangHoa
{
    class CCTphieuXuat
    {
        Cdatabase db = new Cdatabase();
        public DataTable selectWhitidPX(string sp)
        {
            string sql = "select ROW_NUMBER() over(order by HANGHOA.MAHH desc) as STT, TENHH, SL from CTPHIEUXUAT, HANGHOA where CTPHIEUXUAT.MAHH=HANGHOA.MAHH and SOPHIEU='" + sp + "'";
            return db.Execute(sql);
        }

        public DataTable selectCheck(string sp)
        {
            string sql = "select HANGHOA.MAHH, TENHH, SL from CTPHIEUXUAT, HANGHOA where CTPHIEUXUAT.MAHH=HANGHOA.MAHH and SOPHIEU='" + sp + "'";
            return db.Execute(sql);
        }

        public DataTable selectCTPX()
        {
            string sql = "select SOPHIEU, HANGHOA.MAHH, TENHH, SL from CTPHIEUXUAT, HANGHOA where CTPHIEUXUAT.MAHH=HANGHOA.MAHH order by SOPHIEU asc";
            return db.Execute(sql);
        }

        public DataTable selectExcelid(string sp)
        {
            string sql = "select HANGHOA.MAHH, TENHH, SL from CTPHIEUXUAT, HANGHOA where CTPHIEUXUAT.MAHH=HANGHOA.MAHH and SOPHIEU='" + sp + "'";
            return db.Execute(sql);
        }

        public void insertCTPX(string idhh, string idpx, string sl)
        {
            string sql = string.Format("INSERT INTO CTPHIEUXUAT VALUES('{0}','{1}',{2})", idhh, idpx, sl);
            db.ExecuteNonQuery(sql);
        }

        public void updatePX(string idhh, string idpx , string sl)
        {
            string sql = string.Format("exec updateCTPX '{0}','{1}','{2}' ", idhh, idpx, sl);
            db.ExecuteNonQuery(sql);
        }

        public void deleteCTPX(string idhh, string idpx)
        {
            string sql = string.Format("exec deleteCTPX '{0}','{1}'", idhh, idpx);
            db.ExecuteNonQuery(sql);
        }
    }
}
