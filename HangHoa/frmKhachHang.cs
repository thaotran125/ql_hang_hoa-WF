using System;
using System.Data;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using DevExpress.XtraEditors;

namespace HangHoa
{
    public partial class frmKhachHang : DevExpress.XtraEditors.XtraForm
    {
        Ckh kh = new Ckh();
        CxuatNhap xn = new CxuatNhap();
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            gckh.DataSource = kh.selectKH();
            format();
        }

        private void gvkh_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtid.Text = gvkh.GetRowCellValue(e.FocusedRowHandle, "MAKH").ToString();
            txtten.Text = gvkh.GetRowCellValue(e.FocusedRowHandle, "TENKH").ToString();
            txtdt.Text = gvkh.GetRowCellValue(e.FocusedRowHandle, "DIENTHOAI").ToString();
            txtdc.Text = gvkh.GetRowCellValue(e.FocusedRowHandle, "DIACHI").ToString();
        }

        private void gckh_Click_1(object sender, EventArgs e)
        {
            setbtUp();
            settext(true);
            txtid.Enabled = false;
        }

        private void btondelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                System.Data.DataTable dt = xn.selectXoaKH(txtid.Text);
                DialogResult dialog =
                    XtraMessageBox.Show("bạn muốn xóa", "the question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    if (dt.Rows.Count==1)
                    {
                        XtraMessageBox.Show("khách hàng này có phiếu xuất", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        kh.deleteKH(txtid.Text);
                        
                        XtraMessageBox.Show("đã xóa khách hàng " + txtten.Text, "information", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                        gckh.DataSource = kh.selectKH();
                        format();
                    }
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btadd_Click_1(object sender, EventArgs e)
        {
            settext(true);
            reserttext();
            setbtAdd();
        }

        private void btin_Click(object sender, EventArgs e)
        {
            //DataTable dt = new DataTable();
            //ReportKH rp = new ReportKH();
            //dt = kh.reportkh();
            //rp.DataSource = dt;
            frmchuarpKH frm = new frmchuarpKH();

            //rp.CreateDocument();

            frm.Show();
        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            format();
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog =
                XtraMessageBox.Show("bạn muốn thêm", "the question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    if (txtid.Text == null || txtten.Text == null || txtdc.Text == null || txtdt.Text == null)
                    {
                        XtraMessageBox.Show("vui lòng nhập đủ thông tin", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (checkequal(txtid.Text) == true)
                        {
                            kh.insertKH(txtid.Text, txtten.Text, txtdc.Text, txtdt.Text);
                            XtraMessageBox.Show("thêm thành công", "ìnorrnation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            gckh.DataSource = kh.selectKH();
                            format();
                        }
                        else
                            XtraMessageBox.Show("mã khách hàng này đã tồn tại", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            if (txtten.Text == "")
                XtraMessageBox.Show("vui lòng chọn dồng để sửa", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                setbtUp();
                settext(true);
                txtid.Enabled = false;
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
                    txtid.Enabled = false;
                    kh.updateKH(txtid.Text, txtten.Text, txtdc.Text, txtdt.Text);
                    XtraMessageBox.Show("cập nhạt thành công", "infornation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gckh.DataSource = kh.selectKH();
                    format();
                }
            }
             catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool checkequal(string a)
        {
            System.Data.DataTable dt = kh.selectKH();
            foreach (DataRow dr in dt.Rows)
            {
                string ma = dr["MAKH"].ToString();
                if (a == ma)
                    return false;
            }
            return true;
        }

        public void format()
        {
            btadd.Focus();
            settext(false);
            setbtLoad();
        }

        public void reserttext()
        {
            txtid.Clear();
            txtten.Clear();
            txtdt.Clear();
            txtdc.Clear();
        }

        public void settext(bool f)
        {
            txtid.Enabled = f;
            txtten.Enabled = f;
            txtdc.Enabled = f;
            txtdt.Enabled = f;
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

        private void btExcel_Click(object sender, EventArgs e)
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            dt = kh.selectexcel();
            Export(dt, "Ds_Khach_Hang", "DANH SÁCH KHÁCH HÀNG");
        }

        public void Export(System.Data.DataTable dt, string sheetName, string title)
        {
            try
            {
                Excel.Workbook xlWorkBook;
                xlWorkBook = new Excel.Application().Workbooks.Add(true);
                Excel.Worksheet xlWorkSheet;
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.ActiveSheet;
                xlWorkBook.Application.Visible = true;
                xlWorkSheet.Name = sheetName;
                //tạo phần tiêu đề
                Excel.Range head = xlWorkSheet.Range["A1", "F1"];
                head.MergeCells = true;
                head.Value2 = title;
                head.Font.Bold = true;
                head.Font.Name = "Tahoma";
                head.Font.Size = "18";
                head.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                //tạo tiêu đề cột
                Excel.Range cl0;
                cl0 = xlWorkSheet.Range["A3", "A3"];
                cl0.Value2 = "So TT";
                cl0.ColumnWidth = 10;
                Excel.Range cl1;

                cl1 = xlWorkSheet.Range["B3", "B3"];
                cl1.Value2 = "Mã Khách Hàng";
                cl1.ColumnWidth = 15;

                Excel.Range cl2;
                cl2 = xlWorkSheet.Range["C3", "C3"];
                cl2.Value2 = "Tên Khách Hàng";
                cl2.ColumnWidth = 30;
                Excel.Range cl3;

                cl3 = xlWorkSheet.Range["D3", "D3"];
                cl3.Value2 = "SĐT";
                cl3.ColumnWidth = 20;

                cl3 = xlWorkSheet.Range["E3", "E3"];
                cl3.Value2 = "Địa chỉ";
                cl3.ColumnWidth = 50;

                Excel.Range rowHead;
                rowHead = xlWorkSheet.Range["A3", "E3"];
                rowHead.Font.Bold = true;
                //ke vien
                rowHead.Borders.LineStyle = Excel.Constants.xlSolid;
                //mau nen
                rowHead.Interior.ColorIndex = 15;
                rowHead.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                int numRow = 0;
                for (int jRow = 0; jRow < dt.Rows.Count; jRow++)
                {
                    numRow++;

                    xlWorkSheet.Cells[jRow + 4, 1] = numRow;
                    for (int jCol = 0; jCol < dt.Columns.Count; jCol++)

                    {
                        xlWorkSheet.Cells[jRow + 4, jCol + 2] =
                        dt.Rows[jRow][jCol].ToString();
                    }
                }
                numRow += 3;
                Excel.Range rowData;
                rowData = xlWorkSheet.Range["A" + 4, "E" + numRow];
                //ke vien
                rowData.Borders.LineStyle = Excel.Constants.xlSolid;
            }
            catch (Exception e)
            {
                MessageBox.Show(" error: " + e);
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("bạn muốn thoat", "the question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                this.Close();
        }
    }
}