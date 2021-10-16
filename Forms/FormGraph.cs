using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            if(gosterge.Value<30)
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

       

        
    }
}
