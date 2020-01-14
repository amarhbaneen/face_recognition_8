using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using mlava;

namespace MultiFaceRec
{
    public partial class inforamtion_manger : Form
    {
        public inforamtion_manger()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.SendToBack();
        }

        private void inforamtion_manger_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\amara\Desktop\master\Data.mdf;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select * From [Table] ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            
            foreach (DataRow row in dt.Rows)
            {
                if (row["kind"].ToString() == "manger" )
                {
                    listBox1.Items.Add(string.Format(" name : {0} {1} | phone number  : {2} |",row["username"],row["lastname"],row["phonenumber"]));
                }

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
