﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExeDataGridandNavBinding
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

        private void button1_Click(object sender, EventArgs e)
        {
            string Username = textBox1.Text;
            string Password = textBox2.Text;
            if(Username == "Finanda" && Password == "hahaha") 
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Masukkan Username dan Password yang benar");
            }
        }
    }
}
