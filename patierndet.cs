using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using mlava;


namespace MultiFaceRec
{
    public partial class patierndet : Form
    {
        public patierndet()
        {
            InitializeComponent();
        }

        private void patierndet_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\amara\Desktop\master\Data.mdf; Integrated Security = True");
            SqlDataAdapter sda = new SqlDataAdapter("Select * From [Table] ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Singleton user = Singleton.Instance;
            string nameuser = user.getuser();
            SqlDataAdapter sda21 = new SqlDataAdapter("Select * From [Table] WHERE username = '" + nameuser + "'", con);
            DataTable dt21 = new DataTable();
            sda21.Fill(dt21);
            plname.Text = dt21.Rows[0][4].ToString();
            pfname.Text = nameuser;


            foreach (DataRow row in dt.Rows)
            {

                string nameu = row["username"].ToString();
                if (nameu == nameuser && row["kind"].ToString() == "sick")
                {
                    string name = row["work"].ToString();

                    prfname.Text = name;
                    SqlDataAdapter sda2 = new SqlDataAdapter("Select * From [Table] WHERE username = '" + name + "'", con);
                    DataTable dt2 = new DataTable();
                    sda2.Fill(dt2);
                    string lname = dt2.Rows[0][4].ToString();
                    string pnum = dt2.Rows[0][5].ToString();
                    prnnum.Text = pnum;
                    prlname.Text = lname;

                    //listBox1.Items.Add(name);

                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }
    }
}
