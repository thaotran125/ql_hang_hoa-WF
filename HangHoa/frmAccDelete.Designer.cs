namespace HangHoa
{
    partial class frmAccDelete
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
            this.txtpass = new HangHoa.textBboxX(this.components);
            this.btxoa = new HangHoa.buttonX(this.components);
            this.btcancel = new HangHoa.buttonX(this.components);
            this.lkten = new DevExpress.XtraEditors.LookUpEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btThoat = new HangHoa.buttonX(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.lkten.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.txtpass.Location = new System.Drawing.Point(212, 173);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(235, 32);
            this.txtpass.TabIndex = 1;
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(85, 260);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(109, 43);
            this.btxoa.TabIndex = 2;
            this.btxoa.Text = "Delete";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btcancel
            // 
            this.btcancel.Location = new System.Drawing.Point(313, 260);
            this.btcancel.Name = "btcancel";
            this.btcancel.Size = new System.Drawing.Size(109, 43);
            this.btcancel.TabIndex = 3;
            this.btcancel.Text = "Cancel";
            this.btcancel.UseVisualStyleBackColor = true;
            this.btcancel.Click += new System.EventHandler(this.btcancel_Click);
            // 
            // lkten
            // 
            this.lkten.Location = new System.Drawing.Point(212, 86);
            this.lkten.Name = "lkten";
            this.lkten.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lkten.Properties.Appearance.Options.UseFont = true;
            this.lkten.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkten.Properties.NullText = "--tên user--";
            this.lkten.Size = new System.Drawing.Size(235, 30);
            this.lkten.TabIndex = 0;
            this.lkten.DoubleClick += new System.EventHandler(this.lkten_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(249, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "Xóa Tài Khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(24, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "tên user";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(24, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "password admin";
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btThoat.Image = global::HangHoa.Properties.Resources.thoat_32;
            this.btThoat.Location = new System.Drawing.Point(-2, 2);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(48, 45);
            this.btThoat.TabIndex = 38;
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // frmAccDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 588);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lkten);
            this.Controls.Add(this.btcancel);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.txtpass);
            this.Name = "frmAccDelete";
            this.Text = "frmAccDelete";
            this.Load += new System.EventHandler(this.frmAccDelete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lkten.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private textBboxX txtpass;
        private buttonX btxoa;
        private buttonX btcancel;
        private DevExpress.XtraEditors.LookUpEdit lkten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private buttonX btThoat;
    }
}