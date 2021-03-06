using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;

namespace HangHoa
{
    public partial class RibbMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        string name, loai, pass;
        public RibbMain()
        {
            InitializeComponent();
        }

        public RibbMain(string tenlogin, string loaiuser, string mk)
        {
            InitializeComponent();
            name = tenlogin;
            loai = loaiuser;
            pass = mk;
        }

        public Form check(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype)
                    return f;
            }
            return null;
        }

        private void barbtHH_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = check(typeof(frmHangHoa));
            if (f != null)
                f.Activate();
            else
            {
                frmHangHoa frm = new frmHangHoa();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void barbtXN_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = check(typeof(frmXuatNhap));
            if (f != null)
                f.Activate();
            else
            {
                frmXuatNhap frm = new frmXuatNhap();
                frm.MdiParent = this;
                frm.Show();
                ;
            }
        }

        private void barBtCTPX_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = check(typeof(frmCTPX));
            if (f != null)
                f.Activate();
            else
            {
                frmCTPX frm = new frmCTPX();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void barbtKH_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = check(typeof(frmKhachHang));
            if (f != null)
                f.Activate();
            else
            {
                frmKhachHang frm = new frmKhachHang();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void barbtTKHH_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = check(typeof(frmChuareport_HH));
            if (f != null)
                f.Activate();
            else
            {
                frmThongKeHH frm = new frmThongKeHH();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void barbtTKKH_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = check(typeof(frmchuarpKH));
            if (f != null)
                f.Activate();
            else
            {
                frmchuarpKH frm = new frmchuarpKH();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void barbtAccAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = check(typeof(frmlogUp));
            if (f != null)
                f.Activate();
            else
            {
                frmlogUp frm = new frmlogUp();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void RibbMain_Load(object sender, EventArgs e)
        {
            //Skin();
            if (loai == "admin")
            {
                barbtAccAdd.Enabled = true;
                barbtAccdelete.Enabled = true;
            }
            else if (loai == "user")
            {
                barbtAccAdd.Enabled = false;
                barbtAccdelete.Enabled = false;
            }
        }

        private void barbtAccdelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = check(typeof(frmAccDelete));
            if (f != null)
                f.Activate();
            else
            {
                frmAccDelete frm = new frmAccDelete(name, pass);
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void RibbMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult dr;
            dr = XtraMessageBox.Show("Bạn thật sự muốn thoát ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void barbtAccdangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dialog =
              MessageBox.Show("bạn muốn đăng xuất", "question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.Hide();
                frmAccount frm = new frmAccount();
                frm.ShowDialog();
                this.Close();
            }
        }

        public void Skin()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Xmas (Blue)";
            //defaultLookAndFeel1.LookAndFeel.SkinName = "Xmas (Blue)";
        }
    }
}