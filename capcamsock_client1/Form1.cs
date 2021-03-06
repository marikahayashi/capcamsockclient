﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace capcamsock_client1
{
    public partial class Form1 : Form
    {
        public int curCamNum = -1;
        private String[] tcpAddr;
        private int[] tcpPort;

        System.Net.Sockets.TcpClient[] tcpClient;

        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Timer timer2;
        public System.Windows.Forms.Timer timer3;
        public System.Windows.Forms.Timer timer4;

        [DllImport("KERNEL32.DLL")]
        public static extern uint GetPrivateProfileString(
            string lpAppName, string lpKeyName, string lpDefault,
            StringBuilder lpReturnedString, uint nSize,
            string lpFileName);

        public Form1()
        {
            InitializeComponent();
            tcpAddr = new String[4];
            tcpPort = new int[4];
            tcpClient = new System.Net.Sockets.TcpClient[4];
            string iniFileName = AppDomain.CurrentDomain.BaseDirectory
                + "capcamsock_client.ini";
            StringBuilder stringbuilder = new StringBuilder(1024);
            for (int i=0; i<4; i++)
            {
                String camname = "cam" + (i + 1).ToString();
                GetPrivateProfileString(camname, "addr", "no such item",
                    stringbuilder, Convert.ToUInt32(stringbuilder.Capacity),
                    iniFileName);
                this.tcpAddr[i] = stringbuilder.ToString();
                GetPrivateProfileString(camname, "port", "no such item",
                    stringbuilder, Convert.ToUInt32(stringbuilder.Capacity),
                    iniFileName);
                this.tcpPort[i] = Int16.Parse(stringbuilder.ToString());
                
            }
            
            GetPrivateProfileString("main", "interval", "no such item",
                stringbuilder, Convert.ToUInt32(stringbuilder.Capacity),
                iniFileName);
            this.timer1.Interval = Int16.Parse(stringbuilder.ToString());
            this.timer2.Interval = Int16.Parse(stringbuilder.ToString());
            this.timer3.Interval = Int16.Parse(stringbuilder.ToString());
            this.timer4.Interval = Int16.Parse(stringbuilder.ToString());
        }


        ~Form1()
        {
            for (int i = 0; i < 4; i++)
            {
                this.tcpClient[i].Close();
            }
        }

        public Image get_image(int windowNum)
        {

            System.Net.Sockets.NetworkStream networkStream;
            byte[] resBytes = new byte[1024 * 200];
            int resSize = 0;
            Image img = null;
            System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
            ImageConverter imgconv = new ImageConverter();

            if (tcpClient[windowNum] == null || tcpClient[windowNum].Connected == false)
            {
                try
                {
                    tcpClient[windowNum] = Connect(tcpAddr[windowNum], tcpPort[windowNum]);
                }
                catch (Exception exception)
                {
                    Console.WriteLine("Exception at Connect(): {0}", exception);
                    return null;
                }
            }
            tcpClient[windowNum].ReceiveBufferSize = 1024 * 400; //default 65536
            try
            {
                networkStream = tcpClient[windowNum].GetStream();
            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception at GetStream(): {0}", exception);
                return null;
            }
            
            //networkStream.ReadTimeout = System.Threading.Timeout.Infinite;
            networkStream.ReadTimeout = 500;
            do
            {
                try
                {
                    resSize = networkStream.Read(resBytes, 0, resBytes.Length);
                }
                catch (Exception exception)
                {
                    Console.WriteLine("Exception at Read():{0}", exception);
                    return null;
                }
                
                if (resSize != 0)
                {
                    memoryStream.Write(resBytes, 0, resSize);
                }
                //Console.WriteLine("ressize {0}", resSize);
                System.Threading.Thread.Sleep(20);
            } while (networkStream.DataAvailable);
            Console.WriteLine("");
            if (memoryStream.Length != 0)
            {
                img = (Image)imgconv.ConvertFrom(memoryStream.GetBuffer());
                //this.pictureBox_cam1.Image = img;
            }
            networkStream.Close();
            memoryStream.Dispose();

            return img;
        }

        private Bitmap resize_image(Image inputImg)
        {
            Bitmap resizedImg = new Bitmap(this.pictureBox_cam1.Width, this.pictureBox_cam1.Height);
            if (inputImg == null)
            {
                return resizedImg;
            }
            Graphics g = Graphics.FromImage(resizedImg);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            g.DrawImage(inputImg, 0, 0, this.pictureBox_cam1.Width, this.pictureBox_cam1.Height);
            g.Dispose();
            inputImg.Dispose();
            return resizedImg;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            Image img = this.get_image(0);
            if (img == null) {
                return;
            }
            Bitmap bitmapImage = this.resize_image(img);
            this.pictureBox_cam1.Image = bitmapImage;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            Image img = this.get_image(1);
            if (img == null)
            {
                return;
            }
            Bitmap bitmapImage = this.resize_image(img);
            this.pictureBox_cam2.Image = bitmapImage;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            Image img = this.get_image(2);
            if (img == null)
            {
                return;
            }
            Bitmap bitmapImage = this.resize_image(img);
            this.pictureBox_cam3.Image = bitmapImage;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            Image img = this.get_image(3);
            if (img == null)
            {
                return;
            }
            Bitmap bitmapImage = this.resize_image(img);
            this.pictureBox_cam4.Image = bitmapImage;
        }

        private void pictureBox_cam1_MouseClick(object sender, MouseEventArgs e)
        {
            this.timer1.Enabled = false;
            Form2 form2 = new capcamsock_client1.Form2();
            this.curCamNum = 0;
            form2.ShowDialog(this);
        }

        private void pictureBox_cam2_MouseClick(object sender, MouseEventArgs e)
        {
            this.timer2.Enabled = false;
            Form2 form2 = new capcamsock_client1.Form2();
            this.curCamNum = 1;
            form2.ShowDialog(this);
        }

        private void pictureBox_cam3_MouseClick(object sender, MouseEventArgs e)
        {
            this.timer3.Enabled = false;
            Form2 form2 = new capcamsock_client1.Form2();
            this.curCamNum = 2;
            form2.ShowDialog(this);
        }

        private void pictureBox_cam4_MouseClick(object sender, MouseEventArgs e)
        {
            this.timer4.Enabled = false;
            Form2 form2 = new capcamsock_client1.Form2();
            this.curCamNum = 3;
            form2.ShowDialog(this);
        }

        private void timer_clock_Tick(object sender, EventArgs e)
        {
            this.label_clock.Text = DateTime.Now.ToString();
        }

        private static bool IsConnectionSuccessful = false;
        private static Exception socketexception;
        private static System.Threading.ManualResetEvent TimeoutObject
            = new System.Threading.ManualResetEvent(false);

        private static System.Net.Sockets.TcpClient Connect(string addr, int port)
        {
            TimeoutObject.Reset();
            socketexception = null;

            System.Net.Sockets.TcpClient tcpclient = new System.Net.Sockets.TcpClient();

            tcpclient.BeginConnect(addr, port,
                new AsyncCallback(ConnectCallback), tcpclient);

            if (TimeoutObject.WaitOne(TimeSpan.FromMilliseconds(200), false))
            {
                if (IsConnectionSuccessful)
                {
                    return tcpclient;
                }
                else
                {
                    throw socketexception;
                }
            }
            else
            {
                tcpclient.Close();
                throw new TimeoutException("Timeout Exception");
            }
        }
        private static void ConnectCallback(IAsyncResult asyncresult)
        {
            try
            {
                IsConnectionSuccessful = false;
                System.Net.Sockets.TcpClient tcpclient
                    = asyncresult.AsyncState as System.Net.Sockets.TcpClient;

                if (tcpclient.Client != null)
                {
                    tcpclient.EndConnect(asyncresult);
                    IsConnectionSuccessful = true;
                }
            }
            catch (Exception ex)
            {
                IsConnectionSuccessful = false;
                socketexception = ex;
            }
            finally
            {
                TimeoutObject.Set();
            }
        }


    }
}
