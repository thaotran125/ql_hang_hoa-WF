using System;
using System.Windows.Forms;

namespace HangHoa
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmmainview());
            //Application.Run(new frmHangHoa());
            //Application.Run(new frmKhachHang());
            //Application.Run(new frmXuatNhap());
            //Application.Run(new frmCTPX());
            //Application.Run(new frmThongKeHH());
            Application.Run(new frmAccount());
            //Application.Run(new RibbMain());
        }
    }
}
