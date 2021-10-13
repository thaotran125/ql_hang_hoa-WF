using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace HangHoa
{
    public partial class frmChuareport_HH : DevExpress.XtraEditors.XtraForm
    {
        string _ngaybd, _ngaykt;
        public frmChuareport_HH()
        {
            InitializeComponent();
        }

        public frmChuareport_HH(string ngaybd, string ngaykt)
        {
            InitializeComponent();
            _ngaybd = ngaybd;
            _ngaykt = ngaykt;
        }

        private void frmChuareport_HH_Load(object sender, EventArgs e)
        {
            //XtraReporHH re = new XtraReporHH();
            XtraReporthh re = new XtraReporthh();
            re.Parameters["pngaybd"].Value = _ngaybd.ToString();
            re.Parameters["pngaykt"].Value = _ngaykt.ToString();
            re.Parameters["pngaybd"].Visible = false;
            re.Parameters["pngaykt"].Visible = false;
            documentViewer1.DocumentSource = re;
            re.CreateDocument();
        }
    }
}