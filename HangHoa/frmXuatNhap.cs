using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Windows.Forms;

namespace HangHoa
{
    public partial class frmXuatNhap : DevExpress.XtraEditors.XtraForm
    {
        CxuatNhap xn = new CxuatNhap();
        Ckh kh = new Ckh();
        public frmXuatNhap()
        {
            InitializeComponent();
        }

        private void frmXuatNhap_Load(object sender, EventArgs e)
        {
            loadlkKH();
            format();
            gcXN.DataSource = xn.selectXN();
        }

        private void gvXN_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtsophieu.Text = gvXN.GetRowCellValue(e.FocusedRowHandle, "SOPHIEU").ToString();
            lkkh.Text = gvXN.GetRowCellValue(e.FocusedRowHandle, "TENKH").ToString();
            cbloai.Text = gvXN.GetRowCellValue(e.FocusedRowHandle, "LOAI").ToString();
            dttime.Text = gvXN.GetRowCellValue(e.FocusedRowHandle, "NGAY").ToString();
        }

        private void gcXN_Click(object sender, EventArgs e)
        {
            setbtUp();
            settext(true);
            txtsophieu.Enabled = false;
        }

        private void btondelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                string sp;
                DialogResult dialog =
                    XtraMessageBox.Show("bạn muốn xóa", "the question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    int sd = 0;
                    int[] nbrow = gvXN.GetSelectedRows();
                    foreach (int row in nbrow)
                    {
                        sp = gvXN.GetRowCellValue(row, "SOPHIEU").ToString();
                        xn.deleteXN(sp);
                        sd++;
                    }
                    
                    XtraMessageBox.Show("đã xóa phiếu xuất "+txtsophieu.Text, "information", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    gcXN.DataSource = xn.selectXN();
                    format();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lkkh_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (string.Equals(e.Button.Tag, "tag")==true)
            {
                frmKhachHang frm = new frmKhachHang();
                frm.Show();
                loadlkKH();
            }

        }

        private void btluu_Click(object sender, EventArgs e)
        {
             try
            {
                DialogResult dialog =
                    XtraMessageBox.Show("bạn muốn thêm", "the question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    if (txtsophieu.Text == null)
                    {
                        XtraMessageBox.Show("vui lòng nhập đủ thông tin", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (checkequal(txtsophieu.Text) == true)
                        {
                            string ngay = string.Format("{0:MM/dd/yyyy}", dttime.Value);
                            xn.insertXN(txtsophieu.Text, lkkh.EditValue.ToString(), cbloai.Text, ngay);
                            XtraMessageBox.Show("thêm thành công", "ìnorrnation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            gcXN.DataSource = xn.selectXN();
                            format();
                        }
                        else
                            XtraMessageBox.Show("số phiếu không được trùng", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            format();
        }

        private void btCTPX_Click_1(object sender, EventArgs e)
        {
            frmCTPX frm = new frmCTPX(txtsophieu.Text);
            //frmCTPX frm = new frmCTPX();
            frm.Show();
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            if (txtsophieu.Text == "")
                XtraMessageBox.Show("vui lòng chọn dồng để sửa", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                setbtUp();
                settext(true);
                txtsophieu.Enabled = false;
            }
        }

        private void btluuUp_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog =
                   XtraMessageBox.Show("bạn muốn thay đổi", "the question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    string ngay = string.Format("{0:MM/dd/yyyy}", dttime.Value);
                    xn.updateXN(txtsophieu.Text, lkkh.EditValue.ToString(), cbloai.Text, ngay);
                    XtraMessageBox.Show("success", "infofrnation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gcXN.DataSource = xn.selectXN();
                    format();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool checkequal(string a)
        {
            DataTable dt = xn.selectXN();
            foreach (DataRow dr in dt.Rows)
            {
                string ma = dr["SOPHIEU"].ToString();
                if (a == ma)
                    return false;
            }
            return true;
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

        public void loadlkKH()
        {
            lkkh.Properties.DataSource = kh.selectMAKH();
            lkkh.Properties.DisplayMember = "TENKH";
            lkkh.Properties.ValueMember = "MAKH";

        }

        public void reserttext()
        {
            txtsophieu.Clear();
            lkkh.Text = "";
            cbloai.Text = "";

        }

        public void settext(bool f)
        {
            txtsophieu.Enabled = f;
            lkkh.Enabled = f;
            cbloai.Enabled = f;
            dttime.Enabled = f;
        }

        public void setbtAdd()
        {
            btadd.Visible = false;
            btsua.Visible = false;
            btluu.Visible = true;
            btluuUp.Visible = false;
            btluu.Focus();
        }

        public void setbtUp()
        {
            btadd.Visible = false;
            btsua.Visible = false;
            btluu.Visible = false;
            btluuUp.Visible = true;
            btluuUp.Focus();
        }

        public void setbtLoad()
        {
            btadd.Visible = true;
            btsua.Visible = true;
            btluu.Visible = false;
            btluuUp.Visible = false;
        }

        public void format()
        {
            btadd.Focus();
            settext(false);
            setbtLoad();
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            settext(true);
            setbtAdd();
            reserttext();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("bạn muốn thoat", "the question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                this.Close();
        }

        private void lkkh_DoubleClick(object sender, EventArgs e)
        {
            loadlkKH();
        }
    }
}