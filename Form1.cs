using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Charlie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 F2 = new Form2();
            if (F2.ShowDialog() ==DialogResult.OK)
            {
                if (F2.radioButton1.Checked == true)
                    button2.Text = F2.radioButton1.Text;
                else if (F2.radioButton2.Checked == true)
                    button2.Text = F2.radioButton2.Text;
                else if (F2.radioButton3.Checked == true)
                    button2.Text = F2.radioButton3.Text;
                else if (F2.radioButton4.Checked == true)
                    button2.Text = F2.radioButton4.Text;


            }
        }
    }
}
