using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace FRZ_rec
{
    public partial class login : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\PROJECT\\FRZ_rec_Final\\FRZ_rec\\homo.mdf;Integrated Security=True");
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {/*
            string ins = "Insert into [Users](username , password)values(' " + textBox1.Text + " ',' " + textBox2.Text + " ')";
            SqlCommand com = new SqlCommand(ins, con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();*/
            string check = " SELECT  * from [users] where username = (' " + textBox1.Text + " ') and password = (' " + textBox2.Text +  " ')";
            //SqlCommand com = new SqlCommand(check, con);
            SqlDataAdapter selecter = new SqlDataAdapter(check, con);
            DataTable dtb1 = new DataTable();
            selecter.Fill(dtb1);
            if(dtb1.Rows.Count == 1)
            {
                MessageBox.Show("welcome to the app ");
                this.Hide();
                add_new_person xox = new add_new_person();
                xox.Show();


            }
            else
            {
                MessageBox.Show("hey mother fucker check your accounnt again lol lol");
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
