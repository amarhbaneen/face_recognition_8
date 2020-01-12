using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MultiFaceRec
{
    public partial class informationabout_sick : Form
    {
        public informationabout_sick()
        {
            InitializeComponent();
        }

        private void informationabout_sick_Load(object sender, EventArgs e)
        {
            // String source = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\אלטורי\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\amaral3\Desktop\master\Data.mdf;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select * From [Table] ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow row in dt.Rows)
            { 
               // listBox1.Items.Add(row["password"].ToString());
                listBox1.Items.Add(row["mypartner"]);
            }

        }
    }
}
