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

namespace UHFReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Device_2 device1 = new Device_2();
            if (comboBox2.SelectedItem == "device 1")
            {
                device1.Show();
                this.Hide();
            }
            else if (comboBox2.SelectedItem == "device 2")
            {
                device1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("please select device");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            comboBox1.Items.AddRange(ports);
            //comboBox1.SelectedIndex = 0;

            comboBox2.Items.Add("device 1");
            comboBox2.Items.Add("device 2");
        }

    }
}
