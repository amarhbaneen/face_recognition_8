using System;
using System.Windows.Forms;

namespace mlava
{
    public partial class help : Form
    {
        public help()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.SendToBack();
        }
    }
}
