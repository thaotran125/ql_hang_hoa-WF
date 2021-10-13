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
    public partial class frmlogUp : DevExpress.XtraEditors.XtraForm
    {
        CAccount ac = new CAccount();
        public frmlogUp()
        {
            InitializeComponent();
        }

        public bool check(string id)
        {
            DataTable dt = new DataTable();
            dt = ac.selectfull();
            foreach (DataRow dr in dt.Rows)
            {
                string ma = dr["tenlogin"].ToString();
                if (ma.Equals(id) == true)
                {
                    return false;
                }
            }
            return true;
        }

        private void btDK_Click(object sender, EventArgs e)
        {
            if (txtten.Text == null || txtname.Text == null || txtpass.Text == null || txtconfỉm.Text == null || cbquyen.Text=="") 
            {
                XtraMessageBox.Show("vui lòng nhập đủ thông tin", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtpass.Text != txtconfỉm.Text)
                    XtraMessageBox.Show("mật khẩu không đúng", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else if (check(txtname.Text) == false)
                    XtraMessageBox.Show("tài khoản đã tồn tại", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    ac.insertACC(txtten.Text, txtname.Text, txtpass.Text, txtconfỉm.Text, cbquyen.Text);

                    XtraMessageBox.Show("tạo tài khoản thành công", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btcancel_Click(object sender, EventArgs e)
        {
            txtconfỉm.Clear();
            txtname.Clear();
            txtpass.Clear();
            txtten.Clear();
            cbquyen.Text = "";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
      
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cbquyen.Text);
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialog = XtraMessageBox.Show("bạn muốn thoat", "the question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                this.Close();
        }
    }
}