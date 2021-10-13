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
    public partial class frmAccount : DevExpress.XtraEditors.XtraForm
    {
        CAccount ac = new CAccount();
        string tenlogin, loai, pass;
        public frmAccount()
        {
            InitializeComponent();
        }

        private void btHienPass_Click(object sender, EventArgs e)
        {
            txtpass.UseSystemPasswordChar = false;
            btHienPass.Visible = true;
            btonAnPass.Visible = false;
        }

        private void btanPass_Click(object sender, EventArgs e)
        {
            txtpass.UseSystemPasswordChar = true;
            btHienPass.Visible = false;
            btonAnPass.Visible = true;
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {
            txtpass.UseSystemPasswordChar = true;
            btHienPass.Visible = false;
            btonAnPass.Visible = true;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialog = XtraMessageBox.Show("bạn muốn thoat", "the question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                this.Close();
        }

        private void btnhap_Click_1(object sender, EventArgs e)
        {
            DataTable dt = ac.selectACC(txtten.Text, txtpass.Text);
            if (dt.Rows.Count == 0)
            {
                XtraMessageBox.Show("tên đăng nhập hoặc mật khẩu không đúng", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                tenlogin = dt.Rows[0]["tenlogin"].ToString();
                loai = dt.Rows[0]["quyen"].ToString();
                pass= dt.Rows[0]["pass"].ToString();

                this.Hide();
                RibbMain frm = new RibbMain(tenlogin, loai, pass);
                //Ribbmaincs frm = new Ribbmaincs(tenlogin, loai, pass);
                frm.ShowDialog();
                this.Close();
            }
        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            txtten.Clear();
            txtpass.Clear();
        }
    }
}