using System.Data;

namespace HangHoa
{
    class CThongKe
    {
        Cdatabase db = new Cdatabase();

        public DataTable selectThongKeHH(string ngaybd, string ngaykt)
        {
            string sql = "exec selectThongKE '" + ngaybd + "', '" + ngaykt + "'";
            return db.Execute(sql);
        }

        public DataTable reportkh()
        {
            string sql = "exec reportKH";
            return db.Execute(sql);
        }
    }
}
