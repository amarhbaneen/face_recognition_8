using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using System.Data.SqlClient;

namespace mlava
{
    public partial class My_partner_details : Form
    {
        public My_partner_details()
        {
            InitializeComponent();
        }

        private void My_partner_details_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\amara\Desktop\master\Data.mdf; Integrated Security = True");
            SqlDataAdapter sda = new SqlDataAdapter("Select * From [Table] ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Singleton user = Singleton.Instance;
            string nameuser = user.getuser();
            MessageBox.Show(nameuser);
            foreach (DataRow row in dt.Rows ) 
            {
                
                string nameu = row["username"].ToString();
                if (nameu == nameuser && row["kind"].ToString() == "sick")
                {
                    string name = row["work"].ToString();
                
                    listBox1.Items.Add(name);

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.SendToBack();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
