using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;
using Serialport;

namespace Serialport
{
    public partial class FormGraph : Form
    {
        public FormGraph()
        {

            InitializeComponent();
           
            
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
        
            serialPort1.Write("1");
            int receiveddata = Convert.ToInt16(serialPort1.ReadExisting());
            receiveddata = ((receiveddata * 5000) / 1023) / 10;
            gosterge.Value = receiveddata;
            sicaklik.Text = receiveddata.ToString() + "*C";
            System.Threading.Thread.Sleep(100);

            if (gosterge.Value < 30)
            {
                gosterge.ForeColor = Color.BlueViolet;

            }
            if (gosterge.Value > 30 && gosterge.Value < 50)
            {
                gosterge.ForeColor = Color.OrangeRed;

            }
            if (gosterge.Value > 50)
            {
                gosterge.ForeColor = Color.DarkRed;

            }

        }

        private void FormGraph_Load(object sender, EventArgs e)
        {
            //circularProgressBar1.Value = 30;
            //circularProgressBar2.Value = 80;

            //comboBox1.DataSource = SerialPort.GetPortNames();

            //if (serialPort1.PortName == comboBox1.SelectedItem.ToString())
            //{
            //    serialPort1.Open();

            //    serialPort1.BaudRate = 9600;


            //}


            //if (serialPort1.IsOpen)
            //{
            //    // timer1.Start();
            //    timer2.Start();

            //}

        }

        private void round_reset_Click(object sender, EventArgs e)
        {
            circularProgressBar1.Value = 0;
            circularProgressBar2.Value = 0;
            
        }
        string sonuc;
        int max = 30;
        int min = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                sonuc = serialPort1.ReadLine();
            }
            catch
            {
                MessageBox.Show("Port Bağlanmadı!");
            }
            
                if (sonuc != null)
                {
                    graphLab.Text = sonuc + "";

                    this.chart1.Series[0].Points.AddXY(min + max / 2, sonuc);
                    max++;
                    min++;
                }
            


            chart1.ChartAreas[0].AxisX.Minimum = min;
            chart1.ChartAreas[0].AxisX.Maximum = max;

            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum = 1000;

            chart1.ChartAreas[0].AxisX.ScaleView.Zoom(min, max);

        }

      
    }
}
