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
using System.IO;

namespace Serialport
{
    public partial class FormPort : Form
    {
        public FormPort()
        {
            InitializeComponent();
        }

        private void FormPort_Load(object sender, EventArgs e)
        {
            //string[] portlar = SerialPort.GetPortNames();
            //foreach (string port in portlar)
            //comboBox1.Items.Add(portlar);

            comboBox1.DataSource = SerialPort.GetPortNames();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBox1.SelectedItem.ToString();
            //serialPort1.Open();
        }

       

        private void logic1_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                serialPort1.Write("1");
                logic1.BackColor = Color.Green;
                Logic0.BackColor = Color.Gray;
            }
                  
        }

        private void Logic0_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                serialPort1.Write("0");
                Logic0.BackColor = Color.Green;
                logic1.BackColor = Color.Gray;

            }
           
        }

        private void kapat_Click(object sender, EventArgs e)
        {

            if (serialPort1.IsOpen) serialPort1.Close();
        }

        private void Baglan_Click(object sender, EventArgs e)
        {
           
            if (serialPort1.PortName == comboBox1.SelectedItem.ToString())
            {
                serialPort1.Open();

                serialPort1.BaudRate = 9600;
            }
       
        }

        int pwm;
        private void pwmScrol_Scroll(object sender, EventArgs e)
        {
            pwm = pwmScrol.Value;
            label1.Text = " " + pwm;

            if(serialPort1.IsOpen)
            {
                byte[] b = BitConverter.GetBytes(pwm);
                serialPort1.Write(b, 0, 4); //b dizisinin 0.elemanından 4 eleman olarak gönder
            }
        }

       
    }
}
