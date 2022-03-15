using Serialport.Forms;
using System;
using System.Windows.Forms;

namespace Serialport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();


        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();

            FormHome if1 = new FormHome();
            if1.TopLevel = false;

            panel3.Controls.Add(if1);
            if1.Show();

            if1.Dock = DockStyle.Fill;
            if1.BringToFront();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            FormPort if1 = new FormPort();
            if1.TopLevel = false;
            panel3.Controls.Add(if1);
            if1.Show();
            if1.Dock = DockStyle.Fill;
            if1.BringToFront();

            //



        }

        private void Cıkıs_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void kucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            saat.Text = DateTime.Now.ToLongTimeString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            FormGraph if1 = new FormGraph();
            if1.TopLevel = false;
            panel3.Controls.Add(if1);
            if1.Show();
            if1.Dock = DockStyle.Fill;
            if1.BringToFront();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            FormGPIO if1 = new FormGPIO();
            if1.TopLevel = false;
            panel3.Controls.Add(if1);
            if1.Show();
            if1.Dock = DockStyle.Fill;
            if1.BringToFront();



        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            FormDoc if1 = new FormDoc();
            if1.TopLevel = false;
            panel3.Controls.Add(if1);
            if1.Show();
            if1.Dock = DockStyle.Fill;
            if1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            plcForm if1 = new plcForm();
            if1.TopLevel = false;
            panel3.Controls.Add(if1);
            if1.Show();
            if1.Dock = DockStyle.Fill;
            if1.BringToFront();
        }

        
    }
}
