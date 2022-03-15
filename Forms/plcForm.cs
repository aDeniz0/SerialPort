using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using S7.Net;

namespace Serialport.Forms
{
    public partial class plcForm : Form
    {
        Plc myPlc;

        public plcForm()
        {
            InitializeComponent();
            
        }

        private void Baglan_Click(object sender, EventArgs e)
        {
           
                CpuType cpu = new CpuType();
                string ipadres = ipAdr.Text;
                string comboboxsecim = plctipi.SelectedItem.ToString();
                short rack = Convert.ToInt16(comboRack.SelectedItem);
                short slot = Convert.ToInt16(comboSlot.SelectedItem);

                ipadres = "127.0.0.1";

                if (comboboxsecim.Equals("s71500")) 
                {
                    cpu = CpuType.S71500;

                }
                else if (comboboxsecim.Equals("S71200"))
                {
                    cpu = CpuType.S71200;
                }

                myPlc = new Plc(cpu, ipadres, rack, slot);

                myPlc.Open();

                if (myPlc.IsConnected)
                {
                    durum.Text = "PLC'ye bağlantı başarılı";
                    durum.ForeColor = Color.Green;

                }
            
            
        }
            
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Baglantıkes_Click(object sender, EventArgs e)
        {
            if (myPlc.IsConnected)
            {
                myPlc.Close();
                durum.Text = "PLC'ye Bağlantılı değil!";
                durum.ForeColor = Color.Red;

                
            }
        }

        private void ButtonRead_Click(object sender, EventArgs e)
        {


            //texboxRead1.Text = (myPlc.Read(DataType.DataBlock,3,0,VarType.Bit,1,0)).ToString();

            //texboxRead1.Text = (myPlc.Read(DataType.DataBlock,2,1,VarType.Bit,1,0)).ToString();

            //texboxRead1.Text = myPlc.Read("DB3.DBX0.0").ToString();

            //texboxRead1.Text = myPlc.Read("DB3.DBX4.0").ToString();

            //texboxRead1.Text = myPlc.ReadBytes(DataType.DataBlock,3,0,1).ToString();

            //texboxRead1.Text = myPlc.Read("DB3.DBX0.0").ToString();

            //texboxRead1.Text = myPlc.Read("DB3.DBS2.0").ToString();

            texboxRead1.Text = myPlc.Read(DataType.DataBlock, 3, 4, VarType.String, 5).ToString();


        }

        private void buttonWrite_Click(object sender, EventArgs e)
        {
            //byte[] t = new byte[0];


            bool value = true;
            string adress = "DB3.DBX0.0".ToString();

            myPlc.Write(adress,value);

            writeTxt.Text = myPlc.Read("DB3.DBX0.0").ToString();
        }
    }
}
