using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace mlava
{
    public partial class add : Form
    {
        public add()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\wajdial\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
        string imglo = "";
        SqlCommand cmd;
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.SendToBack();
        }

        private void add_Load(object sender, EventArgs e)
        {

        }
        private void add_LABEL(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imglo = dialog.FileName.ToString();
                pictureBox1.ImageLocation = imglo;

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            byte[] images = null;
            FileStream streem = new FileStream(imglo, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(streem);
            images = brs.ReadBytes((int)streem.Length);

            connection.Open();
            string sqlQvery = "Insert into infTable(theid,firstname,LastName,photo)Values('" + textBox3.Text + "','" + textBox1.Text + "','" + textBox2.Text + "',@images)";
            cmd = new SqlCommand(sqlQvery, connection);
            cmd.Parameters.Add(new SqlParameter("@images", images));
            int N = cmd.ExecuteNonQuery();
            MessageBox.Show( "Datas Saved Successfully ");
            connection.Close();

        }
    }
}
