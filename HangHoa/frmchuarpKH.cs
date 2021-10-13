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
    public partial class frmchuarpKH : DevExpress.XtraEditors.XtraForm
    {
        public frmchuarpKH()
        {
            InitializeComponent();
        }

        private void frmchuarpKH_Load(object sender, EventArgs e)
        {
            ReportKH rep = new ReportKH();
            documentViewer1.DocumentSource = rep;
            rep.CreateDocument();
        }
    }
}