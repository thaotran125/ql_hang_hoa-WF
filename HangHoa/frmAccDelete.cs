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
    public partial class frmAccDelete : DevExpress.XtraEditors.XtraForm
    {
        CAccount ac = new CAccount();
        string tenlogin, mk;
        public frmAccDelete()
        {
            InitializeComponent();
        }

        public frmAccDelete(string name,string pass)
        {
            InitializeComponent();
            tenlogin = name;
            mk = pass;
        }


        private void btxoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog =
                XtraMessageBox.Show("bạn muốn xóa", "question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                
                if(txtpass.Text.Equals(mk)==false)
                {
                    XtraMessageBox.Show("nhập password admin", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ac.deleteAcc(lkten.EditValue.ToString());
                    XtraMessageBox.Show("đã xóa tài khoản", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lkten.Text = "";
                    txtpass.Text = "";
                    loadLK();
                }
                
            }
        }

        private void btcancel_Click(object sender, EventArgs e)
        {
            lkten.Text = "--tên user";
            txtpass.Clear();
        }
        
        public void loadLK()
        {
            lkten.Properties.DataSource = ac.selectLK();
            lkten.Properties.ValueMember = "tenlogin";
            lkten.Properties.DisplayMember = "tenuser";
            

        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialog = XtraMessageBox.Show("bạn muốn thoat", "the question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                this.Close();
        }

        private void lkten_DoubleClick(object sender, EventArgs e)
        {
            loadLK();
        }

        private void frmAccDelete_Load(object sender, EventArgs e)
        {
            loadLK();
        }
    }
}