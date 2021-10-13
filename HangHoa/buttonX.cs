using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangHoa
{
    public partial class buttonX : System.Windows.Forms.Button
    {
        public buttonX()
        {
            InitializeComponent();
        }

        public buttonX(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        //Ghi đè lại thuộc tính GotFocus để in đậm => Xảy ra khi dùng Tab để di chuyển giữa các control
        protected override void OnGotFocus(EventArgs e)
        {
            if (!DesignMode) //Không phải trạng thái Design Form
            {
                Font = new System.Drawing.Font(Font, System.Drawing.FontStyle.Bold); //In đậm
                BackColor = System.Drawing.Color.Aqua;
            }
            base.OnGotFocus(e);
        }
        //Sự kiện MouseHover cũng tương tự => khi rê chuột vào sẽ in đậm
        protected override void OnMouseHover(EventArgs e)
        {
            if (!DesignMode)
            {
                Font = new System.Drawing.Font(Font, System.Drawing.FontStyle.Bold); //In đậm
                BackColor = System.Drawing.Color.Aqua;
            }
               
                
            base.OnMouseHover(e);
        }
        //Khi lostfocus thì sẽ trả về bình thường
        protected override void OnLostFocus(EventArgs e)
        {
            if (!DesignMode)
            {
                Font = new System.Drawing.Font(Font, System.Drawing.FontStyle.Regular); //Bình thường
                BackColor = System.Drawing.Color.WhiteSmoke;
            }
                
            base.OnLostFocus(e);
        }
        //Khi sự kiện mouseleave cũng tương tự
        protected override void OnMouseLeave(EventArgs e)
        {
            if (!DesignMode)
            {
                Font = new System.Drawing.Font(Font, System.Drawing.FontStyle.Regular);
                BackColor = System.Drawing.Color.WhiteSmoke;
            }
                
            base.OnMouseLeave(e);
        }
    }
}
