using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottery
{
    public partial class Form1 : Form
    {

        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text.Equals("Start"))
            {
                button1.Text = "Stop";
                timer1.Enabled = true;
            }
            else
            {
                button1.Text = "Start";
                timer1.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = rnd.Next(0, 99) + "";
        }
    }
}
