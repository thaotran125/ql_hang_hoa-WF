using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangHoa
{
    public partial class textBboxX : System.Windows.Forms.TextBox
    {
        public textBboxX()
        {
            InitializeComponent();
        }

        public textBboxX(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        //Override lại 2 sự kiên gotfocus và Leave của control
        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            if (Parent != null) //Nếu có parent mới thực hiện
            {
                Parent.Refresh();
                System.Drawing.Graphics gp = Parent.CreateGraphics(); //Tạo đối tượng Graphics từ Parent 
                Rectangle rec = Bounds; //Tạo hình chữ nhật từ vị trí và kích thước của control hiện tại trên Parent của nó
                rec.Inflate(1, 1); //Tạo bản sao của hình chữ nhật cần vẽ và tăng kích thước theo 2 chiều là 1 pixel
                Pen p = new Pen(Color.Red, 2); //Tạo 1 Pen với màu đỏ vào độ rộng vẽ (cọ) là 2
                gp.DrawRectangle(p, rec);//Vẽ hình chữ nhật với kích thước của Rec và Pen được tạo sẵn
                gp.Dispose(); //Giải phóng biến
            }
        }
        //Override sự kiện Leave
        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            if (Parent != null)
                Parent.Refresh(); //Refresh thôi :D
        }
    }
}
