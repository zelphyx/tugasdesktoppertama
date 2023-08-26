using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan2
{
    public partial class Form1 : Form
    {
        private CheckBox lastCheckedBox;
        public Form1()
        {
            InitializeComponent();

        }

       


        private void label8_Click(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            txtnama.Text = "";
            txtalamat.Text = "";
            txtabsen.Text = "";
            txthobby.Text = "";
          

            checkBox1.Checked = false;
            checkBox2.Checked = false;

            if (cbagama.Items.Count > 0)
            {
                cbagama.SelectedIndex = 0;
            }
            if (cbkelas.Items.Count > 0)
            {
                cbkelas.SelectedIndex = 0;
            }





        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void txtabsen_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
            }
        }

        private void cbagama_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
