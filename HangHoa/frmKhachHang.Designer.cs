namespace HangHoa
{
    partial class frmKhachHang
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gckh = new DevExpress.XtraGrid.GridControl();
            this.gvkh = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btondelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.txtid = new HangHoa.textBboxX(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btExcel = new HangHoa.buttonX(this.components);
            this.btsua = new HangHoa.buttonX(this.components);
            this.btluuUp = new HangHoa.buttonX(this.components);
            this.btin = new HangHoa.buttonX(this.components);
            this.bthuy = new HangHoa.buttonX(this.components);
            this.btadd = new HangHoa.buttonX(this.components);
            this.btluu = new HangHoa.buttonX(this.components);
            this.txtten = new HangHoa.textBboxX(this.components);
            this.txtdt = new HangHoa.textBboxX(this.components);
            this.txtdc = new HangHoa.textBboxX(this.components);
            this.btThoat = new HangHoa.buttonX(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gckh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvkh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btondelete)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(452, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(341, 34);
            this.label5.TabIndex = 29;
            this.label5.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(714, 67);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 28;
            this.label4.Text = "Địa Chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(475, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 27;
            this.label3.Text = "Điện Thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tên KH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 25;
            this.label1.Text = "MÃ kh";
            // 
            // gckh
            // 
            this.gckh.Location = new System.Drawing.Point(30, 250);
            this.gckh.MainView = this.gvkh;
            this.gckh.Name = "gckh";
            this.gckh.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btondelete});
            this.gckh.Size = new System.Drawing.Size(1333, 341);
            this.gckh.TabIndex = 31;
            this.gckh.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvkh});
            this.gckh.Click += new System.EventHandler(this.gckh_Click_1);
            // 
            // gvkh
            // 
            this.gvkh.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gvkh.GridControl = this.gckh;
            this.gvkh.Name = "gvkh";
            this.gvkh.OptionsFind.AlwaysVisible = true;
            this.gvkh.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvkh_FocusedRowChanged);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "STT";
            this.gridColumn1.FieldName = "STT";
            this.gridColumn1.MinWidth = 30;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 50;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Mã kh";
            this.gridColumn2.FieldName = "MAKH";
            this.gridColumn2.MinWidth = 30;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 100;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Tên kh";
            this.gridColumn3.FieldName = "TENKH";
            this.gridColumn3.MinWidth = 30;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 381;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Điện thoại";
            this.gridColumn4.FieldName = "DIENTHOAI";
            this.gridColumn4.MinWidth = 30;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 381;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Địa chỉ";
            this.gridColumn5.FieldName = "DIACHI";
            this.gridColumn5.MinWidth = 30;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 385;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "delete";
            this.gridColumn6.ColumnEdit = this.btondelete;
            this.gridColumn6.MinWidth = 30;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 112;
            // 
            // btondelete
            // 
            this.btondelete.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btondelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btondelete.Name = "btondelete";
            this.btondelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btondelete.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btondelete_ButtonClick);
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtid.Location = new System.Drawing.Point(17, 90);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(127, 32);
            this.txtid.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btExcel);
            this.groupBox3.Controls.Add(this.btsua);
            this.groupBox3.Controls.Add(this.btluuUp);
            this.groupBox3.Controls.Add(this.btin);
            this.groupBox3.Controls.Add(this.bthuy);
            this.groupBox3.Controls.Add(this.btadd);
            this.groupBox3.Controls.Add(this.btluu);
            this.groupBox3.Location = new System.Drawing.Point(372, 143);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(754, 72);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            // 
            // btExcel
            // 
            this.btExcel.Image = global::HangHoa.Properties.Resources.excel_48;
            this.btExcel.Location = new System.Drawing.Point(635, 11);
            this.btExcel.Name = "btExcel";
            this.btExcel.Size = new System.Drawing.Size(112, 50);
            this.btExcel.TabIndex = 9;
            this.btExcel.Text = "xuất Excel";
            this.btExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btExcel.UseVisualStyleBackColor = true;
            this.btExcel.Click += new System.EventHandler(this.btExcel_Click);
            // 
            // btsua
            // 
            this.btsua.Image = global::HangHoa.Properties.Resources.updates_48;
            this.btsua.Location = new System.Drawing.Point(199, 11);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(152, 50);
            this.btsua.TabIndex = 5;
            this.btsua.Text = "sửa";
            this.btsua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // btluuUp
            // 
            this.btluuUp.Image = global::HangHoa.Properties.Resources.save_48;
            this.btluuUp.Location = new System.Drawing.Point(192, 11);
            this.btluuUp.Name = "btluuUp";
            this.btluuUp.Size = new System.Drawing.Size(159, 50);
            this.btluuUp.TabIndex = 6;
            this.btluuUp.Text = "lưu";
            this.btluuUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btluuUp.UseVisualStyleBackColor = true;
            this.btluuUp.Click += new System.EventHandler(this.btluuUp_Click);
            // 
            // btin
            // 
            this.btin.Image = global::HangHoa.Properties.Resources.print_icon;
            this.btin.Location = new System.Drawing.Point(508, 8);
            this.btin.Name = "btin";
            this.btin.Size = new System.Drawing.Size(112, 57);
            this.btin.TabIndex = 8;
            this.btin.Text = "in";
            this.btin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btin.UseVisualStyleBackColor = true;
            this.btin.Click += new System.EventHandler(this.btin_Click);
            // 
            // bthuy
            // 
            this.bthuy.Location = new System.Drawing.Point(370, 19);
            this.bthuy.Name = "bthuy";
            this.bthuy.Size = new System.Drawing.Size(112, 42);
            this.bthuy.TabIndex = 7;
            this.bthuy.Text = "Refresh";
            this.bthuy.UseVisualStyleBackColor = true;
            this.bthuy.Click += new System.EventHandler(this.bthuy_Click);
            // 
            // btadd
            // 
            this.btadd.Image = global::HangHoa.Properties.Resources.add48;
            this.btadd.Location = new System.Drawing.Point(7, 11);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(136, 50);
            this.btadd.TabIndex = 4;
            this.btadd.Text = "thêm";
            this.btadd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click_1);
            // 
            // btluu
            // 
            this.btluu.Image = global::HangHoa.Properties.Resources.save_48;
            this.btluu.Location = new System.Drawing.Point(205, 8);
            this.btluu.Name = "btluu";
            this.btluu.Size = new System.Drawing.Size(146, 57);
            this.btluu.TabIndex = 6;
            this.btluu.Text = "lưu";
            this.btluu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btluu.UseVisualStyleBackColor = true;
            this.btluu.Click += new System.EventHandler(this.btluu_Click);
            // 
            // txtten
            // 
            this.txtten.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtten.Location = new System.Drawing.Point(177, 90);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(264, 32);
            this.txtten.TabIndex = 1;
            // 
            // txtdt
            // 
            this.txtdt.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtdt.Location = new System.Drawing.Point(479, 90);
            this.txtdt.Name = "txtdt";
            this.txtdt.Size = new System.Drawing.Size(178, 32);
            this.txtdt.TabIndex = 2;
            // 
            // txtdc
            // 
            this.txtdc.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtdc.Location = new System.Drawing.Point(717, 90);
            this.txtdc.Name = "txtdc";
            this.txtdc.Size = new System.Drawing.Size(409, 32);
            this.txtdc.TabIndex = 3;
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btThoat.Image = global::HangHoa.Properties.Resources.thoat_32;
            this.btThoat.Location = new System.Drawing.Point(-2, 8);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(48, 45);
            this.btThoat.TabIndex = 34;
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 603);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.txtdc);
            this.Controls.Add(this.txtdt);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.gckh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmKhachHang";
            this.Text = "frmKhachHang";
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gckh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvkh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btondelete)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gckh;
        private DevExpress.XtraGrid.Views.Grid.GridView gvkh;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btondelete;
        private textBboxX txtid;
        private System.Windows.Forms.GroupBox groupBox3;
        private buttonX btadd;
        private buttonX btluu;
        private buttonX bthuy;
        private textBboxX txtten;
        private textBboxX txtdt;
        private textBboxX txtdc;
        private buttonX btin;
        private buttonX btsua;
        private buttonX btluuUp;
        private buttonX btExcel;
        private buttonX btThoat;
    }
}