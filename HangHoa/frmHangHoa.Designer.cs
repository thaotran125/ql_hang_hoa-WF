namespace HangHoa
{
    partial class frmHangHoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHangHoa));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btluuUp = new HangHoa.buttonX(this.components);
            this.btExcel = new HangHoa.buttonX(this.components);
            this.btadd = new HangHoa.buttonX(this.components);
            this.btsua = new HangHoa.buttonX(this.components);
            this.btluu = new HangHoa.buttonX(this.components);
            this.bthuy = new HangHoa.buttonX(this.components);
            this.gchh = new DevExpress.XtraGrid.GridControl();
            this.gvhh = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btxoa = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.cbdvt = new DevExpress.XtraEditors.LookUpEdit();
            this.txtid = new HangHoa.textBboxX(this.components);
            this.txtten = new HangHoa.textBboxX(this.components);
            this.txtdg = new HangHoa.textBboxX(this.components);
            this.btThoat = new HangHoa.buttonX(this.components);
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gchh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvhh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btxoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbdvt.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(412, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH MỤC HÀNG HÓA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã hàng hóa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(536, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "đơn vị tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(825, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "đơn giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "tên hàng hóa";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btluuUp);
            this.groupBox3.Controls.Add(this.btExcel);
            this.groupBox3.Controls.Add(this.btadd);
            this.groupBox3.Controls.Add(this.btsua);
            this.groupBox3.Controls.Add(this.btluu);
            this.groupBox3.Controls.Add(this.bthuy);
            this.groupBox3.Location = new System.Drawing.Point(248, 121);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(667, 90);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            // 
            // btluuUp
            // 
            this.btluuUp.Image = global::HangHoa.Properties.Resources.save_48;
            this.btluuUp.Location = new System.Drawing.Point(209, 19);
            this.btluuUp.Name = "btluuUp";
            this.btluuUp.Size = new System.Drawing.Size(159, 50);
            this.btluuUp.TabIndex = 25;
            this.btluuUp.Text = "lưu";
            this.btluuUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btluuUp.UseVisualStyleBackColor = true;
            this.btluuUp.Click += new System.EventHandler(this.btluuUp_Click);
            // 
            // btExcel
            // 
            this.btExcel.Image = global::HangHoa.Properties.Resources.excel_48;
            this.btExcel.Location = new System.Drawing.Point(399, 22);
            this.btExcel.Name = "btExcel";
            this.btExcel.Size = new System.Drawing.Size(112, 50);
            this.btExcel.TabIndex = 24;
            this.btExcel.Text = "xuất Excel";
            this.btExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btExcel.UseVisualStyleBackColor = true;
            this.btExcel.Click += new System.EventHandler(this.btExcel_Click);
            // 
            // btadd
            // 
            this.btadd.Image = global::HangHoa.Properties.Resources.add48;
            this.btadd.Location = new System.Drawing.Point(7, 17);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(158, 57);
            this.btadd.TabIndex = 20;
            this.btadd.Text = "thêm";
            this.btadd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btadd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // btsua
            // 
            this.btsua.Image = global::HangHoa.Properties.Resources.updates_48;
            this.btsua.Location = new System.Drawing.Point(209, 22);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(153, 50);
            this.btsua.TabIndex = 23;
            this.btsua.Text = "Sửa";
            this.btsua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // btluu
            // 
            this.btluu.Image = global::HangHoa.Properties.Resources.save_48;
            this.btluu.Location = new System.Drawing.Point(194, 24);
            this.btluu.Name = "btluu";
            this.btluu.Size = new System.Drawing.Size(159, 50);
            this.btluu.TabIndex = 21;
            this.btluu.Text = "lưu";
            this.btluu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btluu.UseVisualStyleBackColor = true;
            this.btluu.Click += new System.EventHandler(this.btluu_Click);
            // 
            // bthuy
            // 
            this.bthuy.Location = new System.Drawing.Point(548, 27);
            this.bthuy.Name = "bthuy";
            this.bthuy.Size = new System.Drawing.Size(112, 45);
            this.bthuy.TabIndex = 22;
            this.bthuy.Text = "Refresh";
            this.bthuy.UseVisualStyleBackColor = true;
            this.bthuy.Click += new System.EventHandler(this.bthuy_Click);
            // 
            // gchh
            // 
            this.gchh.Location = new System.Drawing.Point(12, 218);
            this.gchh.MainView = this.gvhh;
            this.gchh.Name = "gchh";
            this.gchh.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btxoa});
            this.gchh.Size = new System.Drawing.Size(1143, 509);
            this.gchh.TabIndex = 15;
            this.gchh.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvhh});
            this.gchh.Click += new System.EventHandler(this.gchh_Click);
            // 
            // gvhh
            // 
            this.gvhh.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gvhh.GridControl = this.gchh;
            this.gvhh.Name = "gvhh";
            this.gvhh.OptionsFind.AlwaysVisible = true;
            this.gvhh.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvhh_FocusedRowChanged);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "STT";
            this.gridColumn1.FieldName = "STT";
            this.gridColumn1.MinWidth = 30;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 45;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Mã HH";
            this.gridColumn2.FieldName = "MAHH";
            this.gridColumn2.MinWidth = 30;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 90;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Tên HH";
            this.gridColumn3.FieldName = "TENHH";
            this.gridColumn3.MinWidth = 30;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 350;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "ĐVT";
            this.gridColumn4.FieldName = "dvt";
            this.gridColumn4.MinWidth = 30;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 205;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Đơn Giá";
            this.gridColumn5.FieldName = "DONGIA";
            this.gridColumn5.MinWidth = 30;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 313;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "delete";
            this.gridColumn6.ColumnEdit = this.btxoa;
            this.gridColumn6.MinWidth = 30;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 112;
            // 
            // btxoa
            // 
            this.btxoa.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btxoa.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btxoa.Name = "btxoa";
            this.btxoa.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btxoa.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btxoa_ButtonClick);
            // 
            // cbdvt
            // 
            this.cbdvt.Location = new System.Drawing.Point(540, 88);
            this.cbdvt.Name = "cbdvt";
            this.cbdvt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cbdvt.Properties.Appearance.Options.UseFont = true;
            this.cbdvt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbdvt.Properties.NullText = "--đơn vị tính--";
            this.cbdvt.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.StartsWith;
            this.cbdvt.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbdvt.Size = new System.Drawing.Size(204, 30);
            this.cbdvt.TabIndex = 16;
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtid.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtid.Location = new System.Drawing.Point(40, 84);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(128, 32);
            this.txtid.TabIndex = 17;
            // 
            // txtten
            // 
            this.txtten.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtten.Location = new System.Drawing.Point(248, 87);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(236, 32);
            this.txtten.TabIndex = 18;
            // 
            // txtdg
            // 
            this.txtdg.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtdg.Location = new System.Drawing.Point(829, 88);
            this.txtdg.Name = "txtdg";
            this.txtdg.Size = new System.Drawing.Size(188, 32);
            this.txtdg.TabIndex = 19;
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btThoat.Image = global::HangHoa.Properties.Resources.thoat_32;
            this.btThoat.Location = new System.Drawing.Point(-1, -2);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(48, 45);
            this.btThoat.TabIndex = 26;
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // frmHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 739);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.txtdg);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.cbdvt);
            this.Controls.Add(this.gchh);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmHangHoa";
            this.Text = "frmHangHoa";
            this.Load += new System.EventHandler(this.frmHangHoa_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gchh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvhh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btxoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbdvt.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraGrid.GridControl gchh;
        private DevExpress.XtraGrid.Views.Grid.GridView gvhh;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.LookUpEdit cbdvt;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btxoa;
        private textBboxX txtid;
        private textBboxX txtten;
        private textBboxX txtdg;
        private buttonX btadd;
        private buttonX btluu;
        private buttonX bthuy;
        private buttonX btsua;
        private buttonX btExcel;
        private buttonX btluuUp;
        private buttonX btThoat;
    }
}