using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace _01BASIC
{
    public partial class Form1 : Form
    {

        private SerialPort serialPort = new SerialPort();

        public Form1()
        {
            InitializeComponent();
        }

      

        private void PortNumber_SelectedIndexChanged_1(object sender, EventArgs e)
        {
         
        }
        
        private void SerialPort_DataRecv(object sender, SerialDataReceivedEventArgs e)
        {
            String recvData = this.serialPort.ReadExisting();
            Console.Write(recvData);
        }

        private void conn_btn_Click(object sender, EventArgs e)
        {
            
                Console.WriteLine(this.PortNumber.Items[this.PortNumber.SelectedIndex].ToString()+" CONN ");
                this.serialPort.PortName = this.PortNumber.Items[this.PortNumber.SelectedIndex].ToString();              
            
                textBox1.Text = "MESSAGE : \r\n" + this.PortNumber.Items[this.PortNumber.SelectedIndex].ToString()+" CONN ";
        
        }

        private void Led_01_Click(object sender, EventArgs e)
        {
            Console.WriteLine("LED_01 ON CLICKED");
            textBox1.Text = "MESSAGE : \r\n" + "LED_01 ON CLICKED";
        }
        private void Led_02_Click(object sender, EventArgs e)
        {
            Console.WriteLine("LED_01 OFF CLICKED");
            textBox1.Text = "MESSAGE : \r\n" + "LED_01 OFF CLICKED";
        }
        private void Led_03_Click(object sender, EventArgs e)
        {
            Console.WriteLine("LED_02 ON CLICKED");
            textBox1.Text = "MESSAGE : \r\n" + "LED_02 ON CLICKED";
        }
        private void Led_04_Click(object sender, EventArgs e)
        {
            Console.WriteLine("LED_02 OFF CLICKED");
            textBox1.Text = "MESSAGE : \r\n" + "LED_02 OFF CLICKED";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
