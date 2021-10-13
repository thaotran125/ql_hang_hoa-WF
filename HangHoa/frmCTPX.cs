using System;
using System.Data;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using DevExpress.XtraEditors;

namespace HangHoa
{
    public partial class frmCTPX : DevExpress.XtraEditors.XtraForm
    {
        CCTphieuXuat ctpx = new CCTphieuXuat();
        Chhoa hh = new Chhoa();
        CxuatNhap xn = new CxuatNhap();
        string sophieu;
        public frmCTPX()
        {
            InitializeComponent();
        }

        public frmCTPX(string sp)
        {
            InitializeComponent();
            sophieu = sp;
            comboBoxX1.Enabled = false;
        }

        private void gvCTPX_Click(object sender, EventArgs e)
        {
            setbtUp();
            settext(true);
            lkupsophieu.Enabled = false;
        }

        private void gvCTPX_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            lkhh.Text = gvCTPX.GetRowCellValue(e.FocusedRowHandle, "TENHH").ToString();
            txtSL.Text = gvCTPX.GetRowCellValue(e.FocusedRowHandle, "SL").ToString();
        }

        private void lkSophieu_EditValueChanged(object sender, EventArgs e)
        {
            gcCTPX.DataSource = ctpx.selectWhitidPX(lkupsophieu.EditValue.ToString());
        }

        private void btondelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("bạn muốn xóa", "the question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                ctpx.deleteCTPX(lkhh.EditValue.ToString(), lkupsophieu.EditValue.ToString());
                XtraMessageBox.Show("đã xóa sản phẩm " + lkhh.EditValue.ToString(), "information", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                gcCTPX.DataSource = ctpx.selectWhitidPX(lkupsophieu.EditValue.ToString());
                format();
            }
            
        }

        private void frmCTPX_Load(object sender, EventArgs e)
        {
            comboBoxX1.Enabled = false;
            loadLKhh();
            loadLkSP();
            format();
            lkupsophieu.EditValue = sophieu;
            //gcCTPX.DataSource = ctpx.selectWhitidPX(lkupsophieu.EditValue.ToString());
            gcCTPX.DataSource = ctpx.selectWhitidPX(sophieu);
        }

        public void loadLKhh()
        {
            lkhh.Properties.DataSource = hh.selectLKhh();
            lkhh.Properties.DisplayMember = "TENHH";
            lkhh.Properties.ValueMember = "MAHH";
        }

        public void loadLkSP()
        {
            lkupsophieu.Properties.DataSource = xn.selectlkXN();
            lkupsophieu.Properties.DisplayMember = "SOPHIEU";
            lkupsophieu.Properties.ValueMember = "SOPHIEU";
        }

        private void lkhh_DoubleClick(object sender, EventArgs e)
        {

        }

        private void btadd_Click(object sender, EventArgs e)
        {
            settext(true);
            setbtAdd();
            reserttext();
        }
       

        private void btluu_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog =
                    XtraMessageBox.Show("bạn muốn thêm", "the question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    if (txtSL.Text == null)
                    {
                        XtraMessageBox.Show("vui lòng nhập số lượng", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (checkequal(lkhh.EditValue.ToString()) == true)
                        {
                            ctpx.insertCTPX(lkhh.EditValue.ToString(), lkupsophieu.EditValue.ToString(), txtSL.Text);
                            XtraMessageBox.Show("thêm thành công", "ìnorrnation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            gcCTPX.DataSource = ctpx.selectWhitidPX(lkupsophieu.Text);
                            format();
                        }
                        else
                            XtraMessageBox.Show("hàng hóa đã tồn tại", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //gcCTPX.DataSource = ctpx.selectWhitidPX(lkupsophieu.EditValue.ToString());
            
        }

        private void bthuy_Click_1(object sender, EventArgs e)
        {
            format();
            lkupsophieu.Enabled = true;
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            if (lkupsophieu.Text == "")
                XtraMessageBox.Show("vui lòng chọn dồng để sửa", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                setbtUp();
                settext(true);
                lkupsophieu.Enabled = false;
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
                    ctpx.updatePX(lkhh.EditValue.ToString(), lkupsophieu.EditValue.ToString(), txtSL.Text);
                    gcCTPX.DataSource = ctpx.selectWhitidPX(lkupsophieu.Text);
                    XtraMessageBox.Show("success", "infofrnation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    format();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool checkequal(string a)
        {
            System.Data.DataTable dt = ctpx.selectCheck(lkupsophieu.EditValue.ToString());
            foreach (DataRow dr in dt.Rows)
            {
                string ma = dr["MAHH"].ToString();
                if (a == ma)
                    return false;
            }
            return true;
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

        public void reserttext()
        {
            //lkupsophieu.ItemIndex = 0;
            //lkhh.ItemIndex = 0;
            txtSL.Clear();

        }

        public void settext(bool f)
        {
            lkupsophieu.Enabled = !f;
            lkhh.Enabled = f;
            txtSL.Enabled = f;
            //comboBoxX1.Enabled = f;
        }

        public void format()
        {
            btadd.Focus();
            settext(false);
            setbtLoad();
            comboBoxX1.Enabled = false;
            cexcel = false;
        }

        private void btExcel_Click(object sender, EventArgs e)
        {
            if (cexcel == true)
            {
                if (comboBoxX1.Text== "toàn bộ")
                {
                    System.Data.DataTable dt = new System.Data.DataTable();
                    dt = ctpx.selectCTPX();
                    Export(dt, "Ds_hang-hoa", "DANH SÁCH HÀNG HÓA");
                    cexcel = false;
                }
                else
                {
                    //if(lkupsophieu.Text =="--số phiếu--")
                    
                        System.Data.DataTable dt = new System.Data.DataTable();
                        dt = ctpx.selectExcelid(lkupsophieu.EditValue.ToString());
                        Export1(dt, "Ds_hang-hoa", "DANH SÁCH HÀNG HÓA", lkupsophieu.EditValue.ToString());
                        cexcel = false;
                    
                }
                comboBoxX1.Enabled = false;
            }
            else
            {
                comboBoxX1.Enabled = true;
                comboBoxX1.Focus();
                comboBoxX1.SelectedIndex = 0;
            }
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
                Excel.Range head = xlWorkSheet.Range["A1", "E1"];
                head.MergeCells = true;
                head.Value2 = title;
                head.Font.Bold = true;
                head.Font.Name = "Tahoma";
                head.Font.Size = "18";
                head.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                //tạo tiêu đề cột
                Excel.Range cl0;
                cl0 = xlWorkSheet.Range["A3", "A3"];
                cl0.Value2 = "Số TT";
                cl0.ColumnWidth = 10;

                Excel.Range cl1;
                cl1 = xlWorkSheet.Range["B3", "B3"];
                cl1.Value2 = "Số Phiếu";
                cl1.ColumnWidth = 15;

                Excel.Range cl2;
                cl2 = xlWorkSheet.Range["C3", "C3"];
                cl2.Value2 = "Mã hàng hóa";
                cl2.ColumnWidth = 15;

                Excel.Range cl3;
                cl3 = xlWorkSheet.Range["D3", "D3"];
                cl3.Value2 = "Tên hàng hóa";
                cl3.ColumnWidth = 35;

                Excel.Range cl4;
                cl4 = xlWorkSheet.Range["E3", "E3"];
                cl4.Value2 = "Số lượng";
                cl4.ColumnWidth = 15;

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
        bool cexcel = false;
        private void comboBoxX1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cexcel = true;
        }

        public void Export1(System.Data.DataTable dt, string sheetName, string title, string sophieu)
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
                Excel.Range head = xlWorkSheet.Range["A1", "D1"];
                head.MergeCells = true;
                head.Value2 = title;
                head.Font.Bold = true;
                head.Font.Name = "Tahoma";
                head.Font.Size = "18";
                head.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                //tạo noi hien so phieu
                Excel.Range r0;
                r0 = xlWorkSheet.Range["B2", "B3"];
                r0.Value2 = "Số phiếu";
                r0.ColumnWidth = 10;

                Excel.Range r1;
                r1 = xlWorkSheet.Range["C2", "C3"];
                r1.Value2 = sophieu;
                r1.ColumnWidth = 15;
                
                //tạo tiêu đề cột
                Excel.Range cl0;
                cl0 = xlWorkSheet.Range["A3", "A3"];
                cl0.Value2 = "Số TT";
                cl0.ColumnWidth = 10;

                Excel.Range cl1;
                cl1 = xlWorkSheet.Range["B3", "B3"];
                cl1.Value2 = "Mã hàng hóa";
                cl1.ColumnWidth = 15;

                Excel.Range cl2;
                cl2 = xlWorkSheet.Range["C3", "C3"];
                cl2.Value2 = "Tên hàng hóa";
                cl2.ColumnWidth = 35;

                Excel.Range cl3;
                cl3 = xlWorkSheet.Range["D3", "D3"];
                cl3.Value2 = "Số lượng";
                cl3.ColumnWidth = 15;

                Excel.Range rowHead;
                rowHead = xlWorkSheet.Range["A3", "D3"];
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
                rowData = xlWorkSheet.Range["A" + 4, "D" + numRow];
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