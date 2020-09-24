using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastighed_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Konvertere Km/t til M/S (Meter I Sekundet)
            double kmh = Convert.ToDouble(textBox2.Text);
            double kmsum = kmh * 0.2778;

            label4.Text = Convert.ToString(kmsum +" M/S");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Konvertere M/S til Km/t
            double ms = Convert.ToDouble(textBox1.Text);
            double mssum = ms * 3.6;

            label3.Text = Convert.ToString(mssum +" Km/h");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //lukker programmet
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
