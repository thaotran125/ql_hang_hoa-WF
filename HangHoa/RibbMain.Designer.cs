namespace HangHoa
{
    partial class RibbMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RibbMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barbtHH = new DevExpress.XtraBars.BarButtonItem();
            this.barbtXN = new DevExpress.XtraBars.BarButtonItem();
            this.barBtCTPX = new DevExpress.XtraBars.BarButtonItem();
            this.skinDropDownButtonItem1 = new DevExpress.XtraBars.SkinDropDownButtonItem();
            this.barbtKH = new DevExpress.XtraBars.BarButtonItem();
            this.barbtTKHH = new DevExpress.XtraBars.BarButtonItem();
            this.barbtTKKH = new DevExpress.XtraBars.BarButtonItem();
            this.barbtAccAdd = new DevExpress.XtraBars.BarButtonItem();
            this.barbtAccdelete = new DevExpress.XtraBars.BarButtonItem();
            this.barbtAccdangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.barngay = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup10 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.barbtHH,
            this.barbtXN,
            this.barBtCTPX,
            this.skinDropDownButtonItem1,
            this.barbtKH,
            this.barbtTKHH,
            this.barbtTKKH,
            this.barbtAccAdd,
            this.barbtAccdelete,
            this.barbtAccdangXuat,
            this.barngay});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 12;
            this.ribbon.Name = "ribbon";
            this.ribbon.PageHeaderItemLinks.Add(this.barngay);
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3,
            this.ribbonPage4});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1});
            this.ribbon.Size = new System.Drawing.Size(1230, 197);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barbtHH
            // 
            this.barbtHH.Caption = "Thêm hàng hóa";
            this.barbtHH.Id = 1;
            this.barbtHH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barbtHH.ImageOptions.Image")));
            this.barbtHH.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barbtHH.ImageOptions.LargeImage")));
            this.barbtHH.Name = "barbtHH";
            this.barbtHH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtHH_ItemClick);
            // 
            // barbtXN
            // 
            this.barbtXN.Caption = "Xuất Nhập";
            this.barbtXN.Id = 2;
            this.barbtXN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barbtXN.ImageOptions.Image")));
            this.barbtXN.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barbtXN.ImageOptions.LargeImage")));
            this.barbtXN.Name = "barbtXN";
            this.barbtXN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtXN_ItemClick);
            // 
            // barBtCTPX
            // 
            this.barBtCTPX.Caption = "Chi tiết phiếu xuất";
            this.barBtCTPX.Id = 3;
            this.barBtCTPX.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtCTPX.ImageOptions.SvgImage")));
            this.barBtCTPX.Name = "barBtCTPX";
            this.barBtCTPX.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtCTPX_ItemClick);
            // 
            // skinDropDownButtonItem1
            // 
            this.skinDropDownButtonItem1.Id = 4;
            this.skinDropDownButtonItem1.Name = "skinDropDownButtonItem1";
            // 
            // barbtKH
            // 
            this.barbtKH.Caption = "ql Khách hàng";
            this.barbtKH.Id = 5;
            this.barbtKH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barbtKH.ImageOptions.Image")));
            this.barbtKH.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barbtKH.ImageOptions.LargeImage")));
            this.barbtKH.Name = "barbtKH";
            this.barbtKH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtKH_ItemClick);
            // 
            // barbtTKHH
            // 
            this.barbtTKHH.Caption = "Hàng Hóa";
            this.barbtTKHH.Id = 6;
            this.barbtTKHH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barbtTKHH.ImageOptions.Image")));
            this.barbtTKHH.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barbtTKHH.ImageOptions.LargeImage")));
            this.barbtTKHH.Name = "barbtTKHH";
            this.barbtTKHH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtTKHH_ItemClick);
            // 
            // barbtTKKH
            // 
            this.barbtTKKH.Caption = "Khách Hàng";
            this.barbtTKKH.Id = 7;
            this.barbtTKKH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barbtTKKH.ImageOptions.Image")));
            this.barbtTKKH.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barbtTKKH.ImageOptions.LargeImage")));
            this.barbtTKKH.Name = "barbtTKKH";
            this.barbtTKKH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtTKKH_ItemClick);
            // 
            // barbtAccAdd
            // 
            this.barbtAccAdd.Caption = "Tạo Account";
            this.barbtAccAdd.Id = 8;
            this.barbtAccAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barbtAccAdd.ImageOptions.Image")));
            this.barbtAccAdd.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barbtAccAdd.ImageOptions.LargeImage")));
            this.barbtAccAdd.Name = "barbtAccAdd";
            this.barbtAccAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtAccAdd_ItemClick);
            // 
            // barbtAccdelete
            // 
            this.barbtAccdelete.Caption = "Xóa Account";
            this.barbtAccdelete.Id = 9;
            this.barbtAccdelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barbtAccdelete.ImageOptions.Image")));
            this.barbtAccdelete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barbtAccdelete.ImageOptions.LargeImage")));
            this.barbtAccdelete.Name = "barbtAccdelete";
            this.barbtAccdelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtAccdelete_ItemClick);
            // 
            // barbtAccdangXuat
            // 
            this.barbtAccdangXuat.Caption = "Đăng Xuất";
            this.barbtAccdangXuat.Id = 10;
            this.barbtAccdangXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barbtAccdangXuat.ImageOptions.Image")));
            this.barbtAccdangXuat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barbtAccdangXuat.ImageOptions.LargeImage")));
            this.barbtAccdangXuat.Name = "barbtAccdangXuat";
            this.barbtAccdangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtAccdangXuat_ItemClick);
            // 
            // barngay
            // 
            this.barngay.Caption = "ngày";
            this.barngay.Edit = this.repositoryItemDateEdit1;
            this.barngay.EditValue = new System.DateTime(2020, 12, 14, 8, 10, 2, 0);
            this.barngay.EditWidth = 100;
            this.barngay.Id = 11;
            this.barngay.Name = "barngay";
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Hàng Hóa";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barbtHH);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barbtXN);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barBtCTPX);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.skinDropDownButtonItem1);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Theme";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Khách Hàng";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.barbtKH);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6,
            this.ribbonPageGroup7});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Thống Kê";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.barbtTKHH);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.barbtTKKH);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup8,
            this.ribbonPageGroup9,
            this.ribbonPageGroup10});
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Hệ Thống";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.barbtAccAdd);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.ItemLinks.Add(this.barbtAccdelete);
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            // 
            // ribbonPageGroup10
            // 
            this.ribbonPageGroup10.ItemLinks.Add(this.barbtAccdangXuat);
            this.ribbonPageGroup10.Name = "ribbonPageGroup10";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 676);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1230, 30);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // RibbMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 706);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "RibbMain";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "QUẢN LÝ HÀNG HÓA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RibbMain_FormClosed);
            this.Load += new System.EventHandler(this.RibbMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barbtHH;
        private DevExpress.XtraBars.BarButtonItem barbtXN;
        private DevExpress.XtraBars.BarButtonItem barBtCTPX;
        private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barbtKH;
        private DevExpress.XtraBars.BarButtonItem barbtTKHH;
        private DevExpress.XtraBars.BarButtonItem barbtTKKH;
        private DevExpress.XtraBars.BarButtonItem barbtAccAdd;
        private DevExpress.XtraBars.BarButtonItem barbtAccdelete;
        private DevExpress.XtraBars.BarButtonItem barbtAccdangXuat;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup10;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarEditItem barngay;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
    }
}