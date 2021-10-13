using System;
using System.Data;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using DevExpress.XtraEditors;

namespace HangHoa
{
    public partial class frmHangHoa : DevExpress.XtraEditors.XtraForm
    {
        Chhoa hh = new Chhoa();
        public frmHangHoa()
        {
            InitializeComponent();
        }

        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            format();
            gchh.DataSource = hh.selecthh();
            //cbdvt.SelectedIndex = 0;
            laoddvt();
        }

        private void gchh_Click(object sender, EventArgs e)
        {
            //setbutton(true);
            setbtUp();
           // btadd.Enabled = false;
            settext(true);
            txtid.Enabled = false;
        }

        public bool checkequal(string a)
        {
            System.Data.DataTable dt = hh.selecthh();
            foreach (DataRow dr in dt.Rows)
            {
                string ma = dr["MAHH"].ToString();
                if (a == ma)
                    return false;
            }
            return true;
        }

        private void btxoa_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DialogResult dialog = XtraMessageBox.Show("bạn muốn xóa", "the question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                //int row = gvhh.FocusedRowHandle;
                hh.deletehh(gvhh.GetRowCellValue(gvhh.FocusedRowHandle, "MAHH").ToString());
                XtraMessageBox.Show("xóa thành công","thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                reserttext();
                gchh.DataSource = hh.selecthh();
            }
            format();
        }

        private void gvhh_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtid.Text = gvhh.GetRowCellValue(e.FocusedRowHandle, "MAHH").ToString();
            txtten.Text = gvhh.GetRowCellValue(e.FocusedRowHandle, "TENHH").ToString();
            cbdvt.Text = gvhh.GetRowCellValue(e.FocusedRowHandle, "dvt").ToString();
            txtdg.Text = gvhh.GetRowCellValue(e.FocusedRowHandle, "DONGIA").ToString();
        }

        public void laoddvt()
        {
            cbdvt.Properties.DataSource = hh.donvitinh();
            cbdvt.Properties.DisplayMember = "dvt";
            cbdvt.Properties.ValueMember = "dvt";

        }

        private void btluu_Click(object sender, EventArgs e)
        {
                try
                {
                    if (txtid.Text=="" || txtten.Text=="" ||txtdg.Text=="" || cbdvt.Text== "--đơn vị tính--")
                    {
                    XtraMessageBox.Show("vui lòng nhập đủ dữ liệu", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (checkequal(txtid.Text) == true)
                        {
                            DialogResult dialod = MessageBox.Show("bạn muốn thêm", "the question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (dialod == DialogResult.Yes)
                            {
                                hh.inserthh(txtid.Text, txtten.Text, cbdvt.Text, txtdg.Text);
                            XtraMessageBox.Show("thêm thành công","information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                gchh.DataSource = hh.selecthh();
                                format();
                        }
                        }
                        else
                            MessageBox.Show("mã hàng hóa không đucợc trùng");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void btluuUp_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = XtraMessageBox.Show("bạn muốn lưu thay đỏi", "The question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    hh.updatehh(txtid.Text, txtten.Text, cbdvt.Text, txtdg.Text);
                    gchh.DataSource = hh.selecthh();
                    format();
                    XtraMessageBox.Show("cập nhật thành công", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btadd_Click(object sender, EventArgs e)
        {
            settext(true);
            reserttext();
            setbtAdd();
            
            //setbutton(false);
            //DataRow dr;
            //for (int i = 0; i < gvhh.RowCount; i++)
            //{
            //    dr = gvhh.GeDataRow(i);
            //    if (dr.RowState == DataRowState.Added)
            //    {
            //        hh.inserthh(gvhh.GetRowCellValue(gvhh.FocusedRowHandle, "MAHH").ToString(), gvhh.GetRowCellValue(gvhh.FocusedRowHandle, "TENHH").ToString(), gvhh.GetRowCellValue(gvhh.FocusedRowHandle, "dvt").ToString(), gvhh.GetRowCellValue(gvhh.FocusedRowHandle, "DONGIA").ToString());
            //        MessageBox.Show("thêm thành công");
            //    }
            //    else if (dr.RowState == DataRowState.Modified)
            //    {
            //        hh.updatehh(gvhh.GetRowCellValue(gvhh.FocusedRowHandle, "MAHH").ToString(), gvhh.GetRowCellValue(gvhh.FocusedRowHandle, "TENHH").ToString(), gvhh.GetRowCellValue(gvhh.FocusedRowHandle, "dvt").ToString(), gvhh.GetRowCellValue(gvhh.FocusedRowHandle, "DONGIA").ToString());
            //    }
            //}
        }

        private void btsua_Click(object sender, EventArgs e)
        {
           if(txtid.Text=="")
                XtraMessageBox.Show("vui lòng chọn dồng để sửa", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                setbtUp();
                //btadd.Enabled = false;
                settext(true);
                txtid.Enabled = false; setbtUp();
                //btadd.Enabled = false;
                settext(true);
                txtid.Enabled = false;
            }
        }
        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialog = XtraMessageBox.Show("bạn muốn thoat", "the question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                this.Close();
        }

        public void reserttext()
        {
            txtid.Clear();
            txtdg.Clear();
            txtten.Clear();
            cbdvt.Text = "";
        }

        public void settext(bool f)
        {
            txtid.Enabled = f;
            txtten.Enabled = f;
            txtdg.Enabled = f;
            cbdvt.Enabled = f;
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
            //reserttext();
            settext(false);
            setbtLoad();
            laoddvt();


        }

        private void btExcel_Click(object sender, EventArgs e)
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            dt = hh.selectexcel();
            Export(dt, "Ds_hang-hoa", "DANH SÁCH HÀNG HÓA");
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
                cl0.Value2 = "So TT";
                cl0.ColumnWidth = 10;
                Excel.Range cl1;

                cl1 = xlWorkSheet.Range["B3", "B3"];
                cl1.Value2 = "Mã hàng hóa";
                cl1.ColumnWidth = 15;

                Excel.Range cl2;
                cl2 = xlWorkSheet.Range["C3", "C3"];
                cl2.Value2 = "Tên hàng hóa";
                cl2.ColumnWidth = 30;
                Excel.Range cl3;

                cl3 = xlWorkSheet.Range["D3", "D3"];
                cl3.Value2 = "đơn vị tính";
                cl3.ColumnWidth = 20;

                cl3 = xlWorkSheet.Range["E3", "E3"];
                cl3.Value2 = "đơn giá";
                cl3.ColumnWidth = 20;

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

        //private ButtonHelper _buttonHelper;
        //private void LookUpEdit_OnStyleChanged(object sender, EventArgs eventArgs)
        //{
        //    _styleChangedStandalone = true;
        //}

        //private bool _firstTimeStandalone = true;
        //private bool _styleChangedStandalone;
        //private void LookUpEditOnPopup(object sender, EventArgs eventArgs)
        //{
        //    Control popupWindow = ((IPopupControl)sender).PopupWindow;
        //    if (_firstTimeStandalone || _styleChangedStandalone)
        //    {
        //        _buttonHelper.AddButtons(popupWindow,
        //            new Control[] { new SimpleButton { Name = "simpleButton1", Text = @"YourButton" } });
        //        _firstTimeStandalone = false;
        //        _styleChangedStandalone = false;
        //        return;
        //    }
        //    _buttonHelper.UpdateButtonsSizeAndLocation(popupWindow);
        //}
    }
}