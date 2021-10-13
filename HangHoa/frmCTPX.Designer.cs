namespace HangHoa
{
    partial class frmCTPX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCTPX));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lkhh = new DevExpress.XtraEditors.LookUpEdit();
            this.gcCTPX = new DevExpress.XtraGrid.GridControl();
            this.gvCTPX = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btondelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.lkupsophieu = new DevExpress.XtraEditors.LookUpEdit();
            this.txtSL = new HangHoa.textBboxX(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btExcel = new HangHoa.buttonX(this.components);
            this.btsua = new HangHoa.buttonX(this.components);
            this.btadd = new HangHoa.buttonX(this.components);
            this.btluuUp = new HangHoa.buttonX(this.components);
            this.btluu = new HangHoa.buttonX(this.components);
            this.bthuy = new HangHoa.buttonX(this.components);
            this.comboBoxX1 = new HangHoa.ComboBoxX(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.btThoat = new HangHoa.buttonX(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.lkhh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btondelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkupsophieu.Properties)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(472, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "CHI TIẾT PHIẾU XUẤT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số Phiếu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên hàng hóa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(734, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "số lượng";
            // 
            // lkhh
            // 
            this.lkhh.Location = new System.Drawing.Point(297, 86);
            this.lkhh.Name = "lkhh";
            this.lkhh.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lkhh.Properties.Appearance.Options.UseFont = true;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.lkhh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", "tag", null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.lkhh.Properties.NullText = "--tên hàng hóa--";
            this.lkhh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lkhh.Size = new System.Drawing.Size(394, 36);
            this.lkhh.TabIndex = 2;
            this.lkhh.DoubleClick += new System.EventHandler(this.lkhh_DoubleClick);
            // 
            // gcCTPX
            // 
            this.gcCTPX.Location = new System.Drawing.Point(20, 223);
            this.gcCTPX.MainView = this.gvCTPX;
            this.gcCTPX.Name = "gcCTPX";
            this.gcCTPX.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btondelete});
            this.gcCTPX.Size = new System.Drawing.Size(1174, 492);
            this.gcCTPX.TabIndex = 29;
            this.gcCTPX.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCTPX});
            // 
            // gvCTPX
            // 
            this.gvCTPX.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gvCTPX.GridControl = this.gcCTPX;
            this.gvCTPX.Name = "gvCTPX";
            this.gvCTPX.OptionsFind.AlwaysVisible = true;
            this.gvCTPX.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvCTPX_FocusedRowChanged);
            this.gvCTPX.Click += new System.EventHandler(this.gvCTPX_Click);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "STT";
            this.gridColumn1.FieldName = "STT";
            this.gridColumn1.MinWidth = 30;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 80;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên hàng hóa";
            this.gridColumn2.FieldName = "TENHH";
            this.gridColumn2.MinWidth = 30;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 448;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Số lượng";
            this.gridColumn3.FieldName = "SL";
            this.gridColumn3.MinWidth = 30;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 448;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "delete";
            this.gridColumn4.ColumnEdit = this.btondelete;
            this.gridColumn4.MinWidth = 30;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 162;
            // 
            // btondelete
            // 
            this.btondelete.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.btondelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btondelete.Name = "btondelete";
            this.btondelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btondelete.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btondelete_ButtonClick);
            // 
            // lkupsophieu
            // 
            this.lkupsophieu.Location = new System.Drawing.Point(59, 92);
            this.lkupsophieu.Name = "lkupsophieu";
            this.lkupsophieu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lkupsophieu.Properties.Appearance.Options.UseFont = true;
            this.lkupsophieu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkupsophieu.Properties.NullText = "--số phiếu--";
            this.lkupsophieu.Size = new System.Drawing.Size(170, 30);
            this.lkupsophieu.TabIndex = 1;
            this.lkupsophieu.EditValueChanged += new System.EventHandler(this.lkSophieu_EditValueChanged);
            // 
            // txtSL
            // 
            this.txtSL.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtSL.Location = new System.Drawing.Point(738, 95);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(160, 32);
            this.txtSL.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btExcel);
            this.groupBox3.Controls.Add(this.btsua);
            this.groupBox3.Controls.Add(this.btadd);
            this.groupBox3.Controls.Add(this.btluuUp);
            this.groupBox3.Controls.Add(this.btluu);
            this.groupBox3.Controls.Add(this.bthuy);
            this.groupBox3.Location = new System.Drawing.Point(351, 131);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(703, 85);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            // 
            // btExcel
            // 
            this.btExcel.Image = global::HangHoa.Properties.Resources.excel_48;
            this.btExcel.Location = new System.Drawing.Point(582, 15);
            this.btExcel.Name = "btExcel";
            this.btExcel.Size = new System.Drawing.Size(112, 50);
            this.btExcel.TabIndex = 35;
            this.btExcel.Text = "xuất Excel";
            this.btExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btExcel.UseVisualStyleBackColor = true;
            this.btExcel.Click += new System.EventHandler(this.btExcel_Click);
            // 
            // btsua
            // 
            this.btsua.Image = global::HangHoa.Properties.Resources.updates_48;
            this.btsua.Location = new System.Drawing.Point(262, 9);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(112, 63);
            this.btsua.TabIndex = 7;
            this.btsua.Text = "sửa";
            this.btsua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // btadd
            // 
            this.btadd.Image = global::HangHoa.Properties.Resources.add48;
            this.btadd.Location = new System.Drawing.Point(7, 9);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(112, 63);
            this.btadd.TabIndex = 0;
            this.btadd.Text = "thêm";
            this.btadd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // btluuUp
            // 
            this.btluuUp.Image = global::HangHoa.Properties.Resources.save_48;
            this.btluuUp.Location = new System.Drawing.Point(99, 15);
            this.btluuUp.Name = "btluuUp";
            this.btluuUp.Size = new System.Drawing.Size(118, 50);
            this.btluuUp.TabIndex = 34;
            this.btluuUp.Text = "lưu";
            this.btluuUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btluuUp.UseVisualStyleBackColor = true;
            this.btluuUp.Click += new System.EventHandler(this.btluuUp_Click);
            // 
            // btluu
            // 
            this.btluu.Image = global::HangHoa.Properties.Resources.save_48;
            this.btluu.Location = new System.Drawing.Point(99, 9);
            this.btluu.Name = "btluu";
            this.btluu.Size = new System.Drawing.Size(118, 63);
            this.btluu.TabIndex = 4;
            this.btluu.Text = "lưu";
            this.btluu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btluu.UseVisualStyleBackColor = true;
            this.btluu.Click += new System.EventHandler(this.btluu_Click);
            // 
            // bthuy
            // 
            this.bthuy.Location = new System.Drawing.Point(420, 23);
            this.bthuy.Name = "bthuy";
            this.bthuy.Size = new System.Drawing.Size(112, 42);
            this.bthuy.TabIndex = 6;
            this.bthuy.Text = "Refresh";
            this.bthuy.UseVisualStyleBackColor = true;
            this.bthuy.Click += new System.EventHandler(this.bthuy_Click_1);
            // 
            // comboBoxX1
            // 
            this.comboBoxX1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.comboBoxX1.FormattingEnabled = true;
            this.comboBoxX1.Items.AddRange(new object[] {
            "toàn bộ",
            "theo số phiếu"});
            this.comboBoxX1.Location = new System.Drawing.Point(933, 97);
            this.comboBoxX1.Name = "comboBoxX1";
            this.comboBoxX1.Size = new System.Drawing.Size(121, 32);
            this.comboBoxX1.TabIndex = 35;
            this.comboBoxX1.SelectedIndexChanged += new System.EventHandler(this.comboBoxX1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(938, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 19);
            this.label5.TabIndex = 36;
            this.label5.Text = "xuất excel";
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btThoat.Image = global::HangHoa.Properties.Resources.thoat_32;
            this.btThoat.Location = new System.Drawing.Point(1335, 1);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(48, 45);
            this.btThoat.TabIndex = 37;
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // frmCTPX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 739);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxX1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.lkupsophieu);
            this.Controls.Add(this.gcCTPX);
            this.Controls.Add(this.lkhh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCTPX";
            this.Text = "frmCTPX";
            this.Load += new System.EventHandler(this.frmCTPX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lkhh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btondelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkupsophieu.Properties)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.LookUpEdit lkhh;
        private DevExpress.XtraGrid.GridControl gcCTPX;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCTPX;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btondelete;
        private DevExpress.XtraEditors.LookUpEdit lkupsophieu;
        private textBboxX txtSL;
        private System.Windows.Forms.GroupBox groupBox3;
        private buttonX btadd;
        private buttonX btluu;
        private buttonX bthuy;
        private buttonX btsua;
        private buttonX btluuUp;
        private buttonX btExcel;
        private ComboBoxX comboBoxX1;
        private System.Windows.Forms.Label label5;
        private buttonX btThoat;
    }
}