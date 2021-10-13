using System.Data;
using System.Data.SqlClient;

namespace HangHoa
{
    class Cdatabase
    {
        SqlConnection sqlcnn;
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        //string svname = "PCLC3-PC04"; THAO-TRAN\\SQLEXPRESS 
        //string dbname = "QLTHUVIEN";
        public Cdatabase()
        {
            string cnnstr = "Data source=THAO-TRAN\\SQLEXPRESS; database=QLHANGHOA;Integrated Security = True";
            sqlcnn = new SqlConnection(cnnstr);
        }

        public DataTable Execute(string str)
        {
            da = new SqlDataAdapter(str, sqlcnn);
            ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }

        public void ExecuteNonQuery(string str)
        {
            SqlCommand sqlcmd = new SqlCommand(str, sqlcnn);
            sqlcnn.Open();
            sqlcmd.ExecuteNonQuery();
            sqlcnn.Close();
        }

        public void Update(string str, DataTable dt)
        {
            da = new SqlDataAdapter(str, sqlcnn);
            SqlCommandBuilder sqlbd = new SqlCommandBuilder(da);
            da.Update(dt);
        }
    }
}
