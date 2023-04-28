using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
//Made by Seol_YoungSeok(in MPS)
namespace LVSController
{
    public partial class Form1 : Form
    {
        static SerialPort _serialPort;
        static bool _continue = true;
        int CH = 1;
        int LValue = 50;



        public Form1()
        {
            InitializeComponent();
            string[] portNames = GetPortNames();
            for (int i = 0; i < portNames.Length; i++)
            {
                Comlist.Items.Add(portNames[i]);
                //("{0}:{1} ", i + 1, portNames[i]);
            }

        }
        //포트리스트가져오기
        static string[] GetPortNames()
        {
            return System.IO.Ports.SerialPort.GetPortNames();
        }

        private void ComlistMouseClick(object sender, MouseEventArgs e)
        {
            // 인덱스를 저장할 변수
            int selectedIndex = -1;

            // 마우스 포인터의 위치
            Point point = e.Location;

            // 리스트 박스의 IndexFromPoint 메서드 호출
            selectedIndex = Comlist.IndexFromPoint(point);

            if (selectedIndex != -1) // 빈 공간이 아닌 곳을 더블클릭 했을 때.
            {
                // 선택된 항목 저장
                string selectedItem = Comlist.Items[selectedIndex] as string;

                // 선택한 항목으로 텍스트 대입
                ComBox.Text = selectedItem;
            }
        }
        //포트 정의
        static void PortSettings(string portName, int baudRate, Parity parity, int dataBits, StopBits stopBits)
        {
            _serialPort.PortName = portName;
            _serialPort.BaudRate = baudRate;
            _serialPort.DataBits = dataBits;
            _serialPort.Parity = parity;
            _serialPort.StopBits = stopBits;
        }
        //포트 연결 시작
        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            StringComparer stringComparer = StringComparer.OrdinalIgnoreCase;
            if (ComBox.Text == "") MessageBox.Show("Select ComPort");
            else
            {
                _serialPort = new SerialPort();
                // Set the read/write timeouts
                _serialPort.ReadTimeout = 500;
                _serialPort.WriteTimeout = 500;
                PortSettings(ComBox.Text, 19200, Parity.None, 8, StopBits.One);

                //2.포트오픈
                if (_serialPort.IsOpen == false)
                {
                    try
                    {
                        _serialPort.Open();
                    }
                    catch (TimeoutException)
                    {
                        Console.WriteLine("FailOpen");
                    }
                }
                if (_serialPort.IsOpen == true)
                {
                    //  수신대기스레드생성
                    Thread readThread = new Thread(Read);
                    readThread.Start();
                    readThread.Interrupt();
                    try
                    {
                        _serialPort.WriteLine("Check");
                        if (_serialPort.ReadChar() == 'S')
                        {
                            try
                            {
                                _serialPort.WriteLine(String.Format("L{0}{1}[CR][LF]", CH, LValue.ToString("D3")));
                                Thread.Sleep(100);
                            }
                            catch (TimeoutException)
                            {
                                Console.WriteLine(_serialPort.NewLine);
                            }

                            Thread.Sleep(100);
                            Console.WriteLine(_serialPort.ReadExisting());
                            ComStatus.Text = "OPEN";
                            ConnectBtn.Enabled = false;
                            DisconnectBtn.Enabled = true;
                            Thread.Sleep(100);
                        }
                        else
                        {
                            readThread.Interrupt();
                            Thread.Sleep(100);
                            readThread.Join();
                            _serialPort.Close();
                            Comlist.Items.Remove(ComBox.Text);
                            ComBox.Clear();
                            ComStatus.Text = "Not Connect";
                        }
                    }
                    catch (TimeoutException)
                    {
                        readThread.Interrupt();
                        Thread.Sleep(100);
                        readThread.Join();
                        _serialPort.Close();
                        Comlist.Items.Remove(ComBox.Text);
                        ComBox.Clear();
                        ComStatus.Text = "Not Connect";
                    }
                }
                Console.WriteLine("Status Start");
                Console.WriteLine(_serialPort.IsOpen);
                Console.WriteLine("Status END");
                string readData = string.Empty;
            }
        }
        //수신 쓰레드 
        private void Read()
        {
            while (_continue)
            {
                try
                {

                    Console.WriteLine("ReadThreadRUN");
                    _continue = false;

                }
                catch (System.TimeoutException)
                {
                    CheckForIllegalCrossThreadCalls = false;
                    _continue = false;
                    _serialPort.Close();
                    Comlist.Items.Remove(ComBox.Text);
                    ComBox.Clear();
                    ComStatus.Text = "Not Connect";
                    Thread.Sleep(10);
                }

            }
        }
        //연결해제 버튼
        private void DisconnectBtn_Click(object sender, EventArgs e)
        {

            if (_serialPort.IsOpen == true)
            {
                _serialPort.Close();
            }
            ConnectBtn.Enabled = true;
            DisconnectBtn.Enabled = false;
            ComStatus.Text = "CLOSE";
        }
        private void OpenException()
        {
            CheckForIllegalCrossThreadCalls = false;
            _continue = false;
            Comlist.Items.Remove(ComBox.Text);
            ComBox.Clear();
            ComStatus.Text = "Not Connect";
            Thread.Sleep(10);
        }
        //시리얼 데이터 전송
        public void Send()
        {
            try
            {
                _serialPort.WriteLine(String.Format("L{0}{1}[CR][LF]", CH, LValue.ToString("D3")));
                Thread.Sleep(100);
            }
            catch (Exception)
            {
                Console.WriteLine("Null");
            }
        }
        //조명 끄기
        public void TurnOff()
        {
            try
            {
                _serialPort.WriteLine(String.Format("E{0}[CR][LF]", CH));
                Thread.Sleep(100);
            }
            catch (Exception)
            {
                Console.WriteLine("Null");
            }
        }
        //포트열림 확인
        private void isOpend_Click(object sender, EventArgs e)
        {
            try
            {
                if (_serialPort.IsOpen == true)
                    Console.WriteLine("Already Opend");
                else
                    Console.WriteLine("Closed");
            }
            catch (Exception)
            {
                Console.WriteLine("Null");
            }

        }
        //조명 채널 설정
        private void CH1Bar_ValueChanged(object sender, EventArgs e)
        {
            CH = 1;
            LValue = CH1Bar.Value;
            CH1Num.Text = Convert.ToString(CH1Bar.Value);
            Send();
        }
        private void CH2Bar_ValueChanged(object sender, EventArgs e)
        {
            CH = 2;
            LValue = CH2Bar.Value;
            CH2Num.Text = Convert.ToString(CH2Bar.Value);
            Send();
        }
        private void CH3Bar_ValueChanged(object sender, EventArgs e)
        {
            CH = 3;
            LValue = CH3Bar.Value;
            CH3Num.Text = Convert.ToString(CH3Bar.Value);
            Send();
        }
        private void CH4Bar_ValueChanged(object sender, EventArgs e)
        {
            CH = 4;
            LValue = CH4Bar.Value;
            CH4Num.Text = Convert.ToString(CH4Bar.Value);
            Send();
        }
        private void CH1Off_Click(object sender, EventArgs e)
        {
            CH = 1;
            TurnOff();
        }
        private void CH2Off_Click(object sender, EventArgs e)
        {
            CH = 2;
            TurnOff();
        }
        private void CH3Off_Click(object sender, EventArgs e)
        {
            CH = 3;
            TurnOff();
        }
        private void CH4Off_Click(object sender, EventArgs e)
        {
            CH = 4;
            TurnOff();
        }
    }
}
