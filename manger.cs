﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace mlava
{
    public partial class manger : Form
    {
        public manger()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 s = new Form1();
            s.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            viewreportsmanger viewmanger = new viewreportsmanger();
            viewmanger.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MyData ss = new MyData();
            ss.Show();
        }
    }
}
