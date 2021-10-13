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
using static System.Windows.Forms.ImageList;
using static System.Windows.Forms.ImageList.ImageCollection;

namespace HangHoa
{
    public partial class frmmainview : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        string name, loai, pass;
        public frmmainview()
        {
            InitializeComponent();
        }

        public frmmainview(string tenlogin, string loaiuser, string mk)
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
        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
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

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
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

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
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

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
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

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
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

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
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

        private void taoacc_ItemClick(object sender, ItemClickEventArgs e)
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
        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
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

        private void frmmainview_Load(object sender, EventArgs e)
        {
            if (loai == "admin")
            {
                taoacc.Enabled = true;
                barbtDelete.Enabled = true;
            }
            else if (loai == "user")
            {
                taoacc.Enabled = false;
                barbtDelete.Enabled = false;
            }
        }

        private void barbtDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            Form f = check(typeof(frmAccDelete));
            if (f != null)
                f.Activate();
            else
            {
                frmAccDelete frm = new frmAccDelete(name,pass);
                frm.MdiParent = this;
                frm.Show();
            }
        }


        public void Skin()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Xmas (Blue)";
            //defaultLookAndFeel1.LookAndFeel.SkinName= "Xmas (Blue)";
        }
        
    }
}