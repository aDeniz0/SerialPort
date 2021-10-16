﻿using System;
using System.Drawing;
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
            circularProgressBar1.Value = 30;
            circularProgressBar2.Value = 80;
            circularProgressBar3.Value = 50;
        }

        private void round_reset_Click(object sender, EventArgs e)
        {
            circularProgressBar1.Value = 0;
            circularProgressBar2.Value = 0;
            circularProgressBar3.Value = 0;
        }

        
    }
}
