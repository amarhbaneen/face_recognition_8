using MultiFaceRec;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace mlava
{
    public partial class Sick : Form
    {
        public Sick()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Sick_Load(object sender, EventArgs e)
        {
            this.Hide();
            

        }
    }
}
