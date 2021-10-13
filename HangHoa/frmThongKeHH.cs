using System;

namespace HangHoa
{
    public partial class frmThongKeHH : DevExpress.XtraEditors.XtraForm
    {
        CThongKe thongKe = new CThongKe();
        public frmThongKeHH()
        {
            InitializeComponent();
        }

        private void btin_Click(object sender, EventArgs e)
        {
            string dbt = datengaybd.Value.ToString();
            string dkt = datengaykt.Value.ToString();
            frmChuareport_HH frm = new frmChuareport_HH(dbt, dkt);
            frm.ShowDialog();
            this.Close();
        }

        private void frmThongKeHH_Load(object sender, EventArgs e)
        {
            gcthongKe.DataSource = thongKe.selectThongKeHH(datengaybd.Value.ToString(),datengaykt.Value.ToString());
        }

        private void datengaykt_ValueChanged(object sender, EventArgs e)
        {
            gcthongKe.DataSource = thongKe.selectThongKeHH(datengaybd.Value.ToString(), datengaykt.Value.ToString());

        }
    }
}