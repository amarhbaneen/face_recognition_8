using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MultiFaceRec
{
    public partial class patient_main_page : Form
    {
        public patient_main_page()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmPrincipal x = new FrmPrincipal();
            x.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            How_to_use_this_app_page x = new How_to_use_this_app_page();
            x.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
