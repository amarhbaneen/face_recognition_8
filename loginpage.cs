using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MultiFaceRec;

namespace mlava
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            String source= @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\amaral3\Desktop\master\Data.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(source);
            con.Open();
            String sqlSelectquery = " Select * From [Table]  where Username ='" + textBox1.Text + "'and Password ='" + textBox2.Text + "'";
            SqlCommand cmd = new SqlCommand(sqlSelectquery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
               String name=dr["username"].ToString();
                MessageBox.Show(name);
                String a = dr["kind"].ToString();
               if (a == "partner") 
                {
                    this.Hide();
                    mal ss = new mal();
                    ss.Show();
                } 
               else if(a == "manger")
                {
                    this.Hide();
                    manger ssm=new manger ();
                    ssm.Show();
                }
               else
                {
                    this.Hide();
                    patient_main_page x = new patient_main_page();
                    x.Show();
                    
                   

                }

 
       
                
            }
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
                MessageBox.Show("please check Your Username and Password");
            }
            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }
    }
}
