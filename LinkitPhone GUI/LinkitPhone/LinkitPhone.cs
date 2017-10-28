using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace LinkitPhone
{
    public partial class LinkitPhone : MetroFramework.Forms.MetroForm
    {
        CallControl callControl = new CallControl();
        MessageControl messageControl = new MessageControl();
        int status = 0;
        public static Int32 baud;
        public static string comPort;

        public SerialPort serialPort = new SerialPort("COM1", 115200, Parity.None, 8, StopBits.One);


        public LinkitPhone()
        {
            InitializeComponent();
            getPorts();
        }

        public void getPorts()
        {
            String[] ports = SerialPort.GetPortNames();
            comPort_cBox.Items.AddRange(ports);
        }

        private void phone_btn_Click(object sender, EventArgs e)
        {
            try
            {
                panel.Visible = true;
                this.Height = 480;
                panel.Height = 400;
                panel.Controls.Add(callControl);
                callControl.Dock = DockStyle.Fill;
                callControl.BringToFront();
            }
            catch (Exception Ex)
            { }

        }

        private void message_btn_Click(object sender, EventArgs e)
        {
            try
            {
                panel.Visible = true;
                this.Height = 440;
                panel.Height = 318;
                panel.Controls.Add(messageControl);
                messageControl.Dock = DockStyle.Fill;
                messageControl.BringToFront();
            }
            catch (Exception Ex)
            { }

        }

        private void open_btn_Click(object sender, EventArgs e)
        {
            try
            {
                comPort = comPort_cBox.Text;
                baud = Convert.ToInt32(9600);
                phone_btn.Enabled = true;
                message_btn.Enabled = true;

                //if(comPort_cBox.Text != "")
                //{
                //    if (status == 0)
                //    {
                //        serialPort.PortName = comPort_cBox.Text;
                //        serialPort.BaudRate = Convert.ToInt32(115200);
                //        serialPort.Open();
                //        phone_btn.Enabled = true;
                //        message_btn.Enabled = true;
                //        status = 1;
                //        open_btn.Text = "Close Port";
                //    }
                //    else if (status == 1)
                //    {
                //        phone_btn.Enabled = false;
                //        message_btn.Enabled = false;
                //        open_btn.Text = "Open Port";
                //        serialPort.Close();
                //        status = 0;
                //    }

                //}
            }
            catch (Exception Ex)
            { }
        }

        private void back_pBox_Click(object sender, EventArgs e)
        {
            try
            {
                panel.Visible = false;
                panel.Height = 318;
                this.Height = 318;
            }
            catch (Exception Ex)
            { }
        }
    }
}
