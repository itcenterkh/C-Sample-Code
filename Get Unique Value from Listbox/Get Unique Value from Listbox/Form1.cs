using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Get_Unique_Value_from_Listbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random rnd = new Random();
            for(int i=1; i <= 100; i++)
            {
                listBox1.Items.Add(rnd.Next(1, 10)+ "");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listBox1.Items.Count>=0)
            {
                //listBox2.Items.Add(listBox1.Items[0].ToString());

                for(int i=0;i<listBox1.Items.Count;i++)
                {
                    int test = 0;
                    for(int j=0; j<listBox2.Items.Count; j++)
                    {
                        if (listBox1.Items[i].ToString().Equals(listBox2.Items[j].ToString()))
                        {
                            test = 1;
                        }
                    }

                    if (test == 0) listBox2.Items.Add(listBox1.Items[i].ToString());
                }
            }
        }
    }
}
