using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace LinkitPhone
{
    public partial class CallControl : UserControl
    {
        LinkitPhone linkitPhone ;
        Calling calling = new Calling();
        String ph_number;

        SerialPort serialPort = new SerialPort();
        String port;
        int baudRate;

        public CallControl()
        {
            InitializeComponent();
        }

        private void one_btn_Click(object sender, EventArgs e)
        {
            ph_number += 1;
            number_box.Text = ph_number;
        }

        private void two_btn_Click(object sender, EventArgs e)
        {
            ph_number += 2;
            number_box.Text = ph_number;
        }

        private void three_btn_Click(object sender, EventArgs e)
        {
            ph_number += 3;
            number_box.Text = ph_number;
        }

        private void four_btn_Click(object sender, EventArgs e)
        {
            ph_number += 4;
            number_box.Text = ph_number;
        }

        private void five_btn_Click(object sender, EventArgs e)
        {
            ph_number += 5;
            number_box.Text = ph_number;
        }

        private void six_btn_Click(object sender, EventArgs e)
        {
            ph_number += 6;
            number_box.Text = ph_number;
        }

        private void seven_btn_Click(object sender, EventArgs e)
        {
            ph_number += 7;
            number_box.Text = ph_number;
        }

        private void eight_btn_Click(object sender, EventArgs e)
        {
            ph_number += 8;
            number_box.Text = ph_number;
        }

        private void nine_btn_Click(object sender, EventArgs e)
        {
            ph_number += 9;
            number_box.Text = ph_number;
        }

        private void zero_btn_Click(object sender, EventArgs e)
        {
            ph_number += 0;
            number_box.Text = ph_number;
        }


        private void disconnect_btn_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.Close();
            }
            catch (Exception Ex)
            {

            }
        }

        private void call_btn_Click(object sender, EventArgs e)
        {
            try
            {
                port = LinkitPhone.comPort;
                baudRate = LinkitPhone.baud;
                serialport_connect(port, baudRate);
                serialPort.Write("C" + number_box.Text);

            }
            catch (Exception Ex)
            {

               
            }
            calling.ShowDialog();
            serialPort.WriteLine("\n");

        }

        public void serialport_connect(String port, int baudrate)
        {
            serialPort = new SerialPort(port, baudrate);
            try { serialPort.Open(); }
            catch (Exception ex) { MessageBox.Show(ex.ToString(), "Error"); }
        }
    }
}
