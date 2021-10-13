namespace HangHoa
{
    partial class frmAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccount));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btThoat = new HangHoa.buttonX(this.components);
            this.btHienPass = new HangHoa.buttonX(this.components);
            this.btonAnPass = new HangHoa.buttonX(this.components);
            this.bthuy = new HangHoa.buttonX(this.components);
            this.btnhap = new HangHoa.buttonX(this.components);
            this.txtpass = new HangHoa.textBboxX(this.components);
            this.txtten = new HangHoa.textBboxX(this.components);
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(251, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 104);
            this.label4.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 19);
            this.label3.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(80, 261);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(80, 204);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "tên đăng nhập";
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btThoat.Image = global::HangHoa.Properties.Resources.thoat_32;
            this.btThoat.Location = new System.Drawing.Point(3, 3);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(48, 45);
            this.btThoat.TabIndex = 38;
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btHienPass
            // 
            this.btHienPass.Image = global::HangHoa.Properties.Resources.eyeclose;
            this.btHienPass.Location = new System.Drawing.Point(500, 252);
            this.btHienPass.Name = "btHienPass";
            this.btHienPass.Size = new System.Drawing.Size(37, 27);
            this.btHienPass.TabIndex = 25;
            this.btHienPass.UseVisualStyleBackColor = true;
            this.btHienPass.Click += new System.EventHandler(this.btanPass_Click);
            // 
            // btonAnPass
            // 
            this.btonAnPass.Image = global::HangHoa.Properties.Resources.eye_16px;
            this.btonAnPass.Location = new System.Drawing.Point(500, 252);
            this.btonAnPass.Name = "btonAnPass";
            this.btonAnPass.Size = new System.Drawing.Size(37, 27);
            this.btonAnPass.TabIndex = 24;
            this.btonAnPass.UseVisualStyleBackColor = true;
            this.btonAnPass.Click += new System.EventHandler(this.btHienPass_Click);
            // 
            // bthuy
            // 
            this.bthuy.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.bthuy.Location = new System.Drawing.Point(390, 313);
            this.bthuy.Name = "bthuy";
            this.bthuy.Size = new System.Drawing.Size(135, 68);
            this.bthuy.TabIndex = 22;
            this.bthuy.Text = "cancel";
            this.bthuy.UseVisualStyleBackColor = true;
            this.bthuy.Click += new System.EventHandler(this.bthuy_Click);
            // 
            // btnhap
            // 
            this.btnhap.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnhap.Location = new System.Drawing.Point(134, 313);
            this.btnhap.Name = "btnhap";
            this.btnhap.Size = new System.Drawing.Size(152, 68);
            this.btnhap.TabIndex = 20;
            this.btnhap.Text = "Đăng nhập";
            this.btnhap.UseVisualStyleBackColor = true;
            this.btnhap.Click += new System.EventHandler(this.btnhap_Click_1);
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.txtpass.Location = new System.Drawing.Point(246, 253);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(270, 27);
            this.txtpass.TabIndex = 19;
            // 
            // txtten
            // 
            this.txtten.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.txtten.Location = new System.Drawing.Point(246, 201);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(270, 27);
            this.txtten.TabIndex = 18;
            // 
            // frmAccount
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(596, 489);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btHienPass);
            this.Controls.Add(this.btonAnPass);
            this.Controls.Add(this.bthuy);
            this.Controls.Add(this.btnhap);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAccount";
            this.Text = "TẠO TÀI KHOẢN";
            this.Load += new System.EventHandler(this.frmAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private textBboxX txtten;
        private textBboxX txtpass;
        private buttonX btnhap;
        private buttonX bthuy;
        private buttonX btonAnPass;
        private buttonX btHienPass;
        private buttonX btThoat;
    }
}