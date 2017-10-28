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
    public partial class MessageControl : UserControl
    {
        SerialPort serialPort = new SerialPort();
        String port;
        int baudRate;


        public MessageControl()
        {
            InitializeComponent();
        }

        public void serialport_connect(String port, int baudrate)
        {
            serialPort = new SerialPort(port, baudrate);
            try { serialPort.Open(); }
            catch (Exception ex) { MessageBox.Show(ex.ToString(), "Error"); }
        }

        private void send_btn_Click(object sender, EventArgs e)
        {
            try
            {
                port = LinkitPhone.comPort;
                baudRate = LinkitPhone.baud;
                serialport_connect(port, baudRate);
                serialPort.Write("M" + number_tBox.Text + "A" + message_tbox.Text);
                MessageBox.Show("Message send");
                message_tbox.Text = "";
                number_tBox.Text = "";
                serialPort.Close();
            }
            catch (Exception Ex)
            {

                throw;
            }
        }
    }
}
