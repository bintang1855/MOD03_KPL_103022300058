using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOD03_KPL_103022300058
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int angka = 0;
        int temp = 0;


        private void buttonSamaDengan_Click(object sender, EventArgs e)
        {
            angka = angka + temp;
            labelOutput.Text = angka.ToString();
            temp = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            temp = temp * 10 + 1;
            labelOutput.Text = temp.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            temp = temp * 10 + 2;
            labelOutput.Text = temp.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            temp = temp * 10 + 3;
            labelOutput.Text = temp.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            temp = temp * 10 + 4;
            labelOutput.Text = temp.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            temp = temp * 10 + 5;
            labelOutput.Text = temp.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            temp = temp * 10 + 6;
            labelOutput.Text = temp.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            temp = temp * 10 + 7;
            labelOutput.Text = temp.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            temp = temp * 10 + 8;
            labelOutput.Text = temp.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            temp = temp * 10 + 9;
            labelOutput.Text = temp.ToString();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            angka = angka + temp;
            labelOutput.Text = angka.ToString();
            temp = 0;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            temp = temp * 10 + 0;
            labelOutput.Text = temp.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
