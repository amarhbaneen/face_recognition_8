using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FRZ_rec
{
    public partial class add_new_person : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\PROJECT\\FRZ_rec_Final\\FRZ_rec\\homo.mdf;Integrated Security=True");
        string filename;
        

        public add_new_person()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void add_new_person_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog { Filter = "JPG | *.jpg", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    filename = ofd.FileName;
                    pictureBox1.Image = Image.FromFile(filename);

                }
            }
        }

       

        private  void sv_btn_Click(object sender, EventArgs e)
        { 

                string ins = "Insert into [People](firstname ,lastname,idphoto)values(' " + textBox2.Text + " ',' " + textBox1.Text + " ' , '" + pictureBox1.Image + "')";
                SqlCommand com = new SqlCommand(ins, con);
                con.Open();
                com.ExecuteNonQuery();
                MessageBox.Show("You have been successfully  saved the person to the data ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
               
               

            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
