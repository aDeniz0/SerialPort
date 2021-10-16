using System;
using System.Windows.Forms;

namespace Serialport
{
    public partial class FormOpen : Form
    {
        public FormOpen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Close();

        }


    }
}
