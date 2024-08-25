using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox_Deneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //comboBox1.TabIndex = 0;
            //button1.TabIndex = 1;
            //label1.TabIndex = 2;
            //button2.TabIndex = 3;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Ali");
            comboBox1.Items.Add("veli");
            comboBox1.Items.Add("demir");

            comboBox1.TabIndex = 2;
            button1.TabIndex = 1;
            label1.TabIndex = 0;
            button2.TabIndex = 3;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (comboBox1.SelectedIndex < 0)
            //{
            //    label1.Text = comboBox1.SelectedIndex.ToString();
            //}
            //else
            //{
            //    label1.Text = "OK";
            //}

            //comboBox1.DropDownHeight = 320;
            //comboBox1.DropDownWidth = 200;
            //label1.Text = comboBox1.Bottom.ToString();
            //label1.Text = comboBox1.Top.ToString();
            //comboBox1.Width = 130;
            //button2.Enabled = false;
            //comboBox1.Height = 100;
            //label1.Text = comboBox1.Text;
            //string name= comboBox1.Text;
            //comboBox1.Items.Add(name);
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int w = comboBox1.Width;
            //label1.Text = w.ToString();
            button2.Text = comboBox1.Text;
            comboBox1.Height = 100;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "button2";
        }
    }
}
