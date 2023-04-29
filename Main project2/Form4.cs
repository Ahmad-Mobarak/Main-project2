using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Main_project2
{
    public partial class Form4 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ahmad_bqh2ijo\source\repos\Main project2\Main project2\Database2.mdf"";Integrated Security=True");
        public Form4()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dau = new SqlDataAdapter("SELECT count(*) FROM loginstd WHERE id = '" + textBox1.Text + "' AND password ='" + textBox2.Text + "'", conn);
            DataTable dtu = new DataTable();
            dau.Fill(dtu);
            if (dtu.Rows[0][0].ToString() == "1")
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from loginstd ", conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    textBox2.Text = rdr.GetValue(1).ToString();
                    textBox3.Text = rdr.GetValue(2).ToString();
                    textBox6.Text = rdr.GetValue(3).ToString();
                    textBox5.Text = rdr.GetValue(4).ToString();
                    textBox4.Text = rdr.GetValue(5).ToString();
                }
                conn.Close();
            }
            else
            {
                MessageBox.Show("Check ID and password");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            string password = textBox2.Text.ToString();
            SqlCommand sq = new SqlCommand("update loginstd set password = '" + password + "' where id = " + textBox1.Text + "", conn);
            sq.ExecuteNonQuery();
            conn.Close();
        }
        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 ss = new Form1();
            ss.Show();
        }
    }
}
