using System;
using System.Windows.Forms;

namespace mlava
{
    public partial class mal : Form
    {
        public mal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            Application.Exit();
 
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            add ss = new add();
            ss.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            viewreports ss1 = new viewreports();
            ss1.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            help ss2 = new help();
            ss2.Show();
        }
    }
}
