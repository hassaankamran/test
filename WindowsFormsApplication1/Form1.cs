﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("original text");

            MessageBox.Show("Dev 1 => message 1");
            MessageBox.Show("Dev 1 => message 2");
            MessageBox.Show("Dev 1 => message 3");


            MessageBox.Show("Dev2 message => 1");
            MessageBox.Show("Dev2 message => 2");
            MessageBox.Show("Dev2 message => 3");

	    }
    }
}
