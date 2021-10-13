namespace HangHoa
{
    partial class frmThongKeHH
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
            this.datengaykt = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gcthongKe = new DevExpress.XtraGrid.GridControl();
            this.gvthongKe = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btin = new HangHoa.buttonX(this.components);
            this.datengaybd = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.gcthongKe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvthongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // datengaykt
            // 
            this.datengaykt.CustomFormat = "04/01/2019";
            this.datengaykt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datengaykt.Location = new System.Drawing.Point(553, 76);
            this.datengaykt.Name = "datengaykt";
            this.datengaykt.Size = new System.Drawing.Size(200, 27);
            this.datengaykt.TabIndex = 1;
            this.datengaykt.ValueChanged += new System.EventHandler(this.datengaykt_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(462, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thống Kê Xuất Hàng Hóa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "ngày bắt đầu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(449, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "ngày kết thúc";
            // 
            // gcthongKe
            // 
            this.gcthongKe.Location = new System.Drawing.Point(37, 272);
            this.gcthongKe.MainView = this.gvthongKe;
            this.gcthongKe.Name = "gcthongKe";
            this.gcthongKe.Size = new System.Drawing.Size(1120, 382);
            this.gcthongKe.TabIndex = 10;
            this.gcthongKe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvthongKe});
            // 
            // gvthongKe
            // 
            this.gvthongKe.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gvthongKe.GridControl = this.gcthongKe;
            this.gvthongKe.Name = "gvthongKe";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "STT";
            this.gridColumn1.FieldName = "STT";
            this.gridColumn1.MinWidth = 30;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 100;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "tên hàng hóa";
            this.gridColumn2.FieldName = "TENHH";
            this.gridColumn2.MinWidth = 30;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 328;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "lượng nhập";
            this.gridColumn3.FieldName = "nhap";
            this.gridColumn3.MinWidth = 30;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 300;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "lượng xuất";
            this.gridColumn4.FieldName = "xuat";
            this.gridColumn4.MinWidth = 30;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 300;
            // 
            // btin
            // 
            this.btin.Location = new System.Drawing.Point(441, 145);
            this.btin.Name = "btin";
            this.btin.Size = new System.Drawing.Size(234, 55);
            this.btin.TabIndex = 21;
            this.btin.Text = "in chi tiết";
            this.btin.UseVisualStyleBackColor = true;
            this.btin.Click += new System.EventHandler(this.btin_Click);
            // 
            // datengaybd
            // 
            this.datengaybd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datengaybd.Location = new System.Drawing.Point(146, 76);
            this.datengaybd.Name = "datengaybd";
            this.datengaybd.Size = new System.Drawing.Size(200, 27);
            this.datengaybd.TabIndex = 22;
            // 
            // frmThongKeHH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 699);
            this.Controls.Add(this.datengaybd);
            this.Controls.Add(this.btin);
            this.Controls.Add(this.gcthongKe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datengaykt);
            this.Name = "frmThongKeHH";
            this.Text = "frmThongKeHH";
            this.Load += new System.EventHandler(this.frmThongKeHH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcthongKe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvthongKe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker datengaykt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.GridControl gcthongKe;
        private DevExpress.XtraGrid.Views.Grid.GridView gvthongKe;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private buttonX btin;
        private System.Windows.Forms.DateTimePicker datengaybd;
    }
}