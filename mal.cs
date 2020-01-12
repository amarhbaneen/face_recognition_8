using System;
using System.Windows.Forms;
using MultiFaceRec;

namespace MultiFaceRec
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
            this.Close();
            Form1 s = new Form1();
            s.Show();


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            add_by_cam ss = new add_by_cam();
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmPrincipal newfrm = new FrmPrincipal();
            newfrm.Show();
            this.Hide();
        }

        private void mal_Load(object sender, EventArgs e)
        {

        }
    }
}
