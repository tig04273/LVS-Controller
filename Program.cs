using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//시리얼통신관련 네임스페이스 
using System.IO.Ports;

//스레드네임스페이스
using System.Threading;


namespace LVSController
{
    internal static class Program
    {
        static SerialPort _serialPort;
        static bool _continue = true;
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }







        
    }
}
