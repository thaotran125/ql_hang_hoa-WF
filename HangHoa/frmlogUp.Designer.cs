namespace HangHoa
{
    partial class frmlogUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlogUp));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbquyen = new HangHoa.ComboBoxX(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.btcancel = new HangHoa.buttonX(this.components);
            this.btDK = new HangHoa.buttonX(this.components);
            this.txtconfỉm = new HangHoa.textBboxX(this.components);
            this.txtpass = new HangHoa.textBboxX(this.components);
            this.txtname = new HangHoa.textBboxX(this.components);
            this.txtten = new HangHoa.textBboxX(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btThoat = new HangHoa.buttonX(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btThoat);
            this.panel1.Controls.Add(this.cbquyen);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btcancel);
            this.panel1.Controls.Add(this.btDK);
            this.panel1.Controls.Add(this.txtconfỉm);
            this.panel1.Controls.Add(this.txtpass);
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Controls.Add(this.txtten);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 480);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cbquyen
            // 
            this.cbquyen.FormattingEnabled = true;
            this.cbquyen.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.cbquyen.Items.AddRange(new object[] {
            "user",
            "admin"});
            this.cbquyen.Location = new System.Drawing.Point(201, 331);
            this.cbquyen.Name = "cbquyen";
            this.cbquyen.Size = new System.Drawing.Size(121, 27);
            this.cbquyen.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(17, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "Quyền truy cập";
            // 
            // btcancel
            // 
            this.btcancel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btcancel.Location = new System.Drawing.Point(373, 379);
            this.btcancel.Name = "btcancel";
            this.btcancel.Size = new System.Drawing.Size(98, 44);
            this.btcancel.TabIndex = 12;
            this.btcancel.Text = "cancel";
            this.btcancel.UseVisualStyleBackColor = true;
            this.btcancel.Click += new System.EventHandler(this.btcancel_Click);
            // 
            // btDK
            // 
            this.btDK.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btDK.Location = new System.Drawing.Point(166, 379);
            this.btDK.Name = "btDK";
            this.btDK.Size = new System.Drawing.Size(98, 44);
            this.btDK.TabIndex = 11;
            this.btDK.Text = "Đăng ký";
            this.btDK.UseVisualStyleBackColor = true;
            this.btDK.Click += new System.EventHandler(this.btDK_Click);
            // 
            // txtconfỉm
            // 
            this.txtconfỉm.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.txtconfỉm.Location = new System.Drawing.Point(201, 273);
            this.txtconfỉm.Name = "txtconfỉm";
            this.txtconfỉm.PasswordChar = '*';
            this.txtconfỉm.Size = new System.Drawing.Size(270, 27);
            this.txtconfỉm.TabIndex = 3;
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.txtpass.Location = new System.Drawing.Point(201, 210);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(270, 27);
            this.txtpass.TabIndex = 2;
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.txtname.Location = new System.Drawing.Point(201, 154);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(270, 27);
            this.txtname.TabIndex = 1;
            // 
            // txtten
            // 
            this.txtten.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.txtten.Location = new System.Drawing.Point(201, 88);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(270, 27);
            this.txtten.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(17, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nhập lại password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(17, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(17, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label2.Location = new System.Drawing.Point(188, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 34);
            this.label2.TabIndex = 7;
            this.label2.Text = "ĐĂNG KÝ TÀI KHOẢNG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(17, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tên người dùng";
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btThoat.Image = global::HangHoa.Properties.Resources.thoat_32;
            this.btThoat.Location = new System.Drawing.Point(613, 0);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(48, 45);
            this.btThoat.TabIndex = 38;
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // frmlogUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 496);
            this.Controls.Add(this.panel1);
            this.Name = "frmlogUp";
            this.Text = "frmlogUp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private buttonX btcancel;
        private buttonX btDK;
        private textBboxX txtconfỉm;
        private textBboxX txtpass;
        private textBboxX txtname;
        private textBboxX txtten;
        private System.Windows.Forms.Label label6;
        private ComboBoxX cbquyen;
        private buttonX btThoat;
    }
}