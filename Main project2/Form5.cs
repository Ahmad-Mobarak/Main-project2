using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Main_project2
{
    public partial class Form5 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ahmad_bqh2ijo\source\repos\Main project2\Main project2\Database2.mdf"";Integrated Security=True");
        public Form5()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from loginstd where id =" + textBox1.Text + " ", conn);
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

        private void button6_Click(object sender, EventArgs e)
        {
            conn.Open();
            int id = Int32.Parse(textBox1.Text.ToString());
            float grade = float.Parse(textBox4.Text.ToString());
            string name = textBox3.Text.ToString();
            string password = textBox2.Text.ToString();
            string faculity = textBox6.Text.ToString();
            string couces = textBox5.Text.ToString();
            SqlCommand sq = new SqlCommand("insert into loginstd values(" + id + ",'" + password + "','" + name + "','" + faculity + "','" + couces + "'," + grade + ")", conn);
            sq.ExecuteNonQuery();
            conn.Close();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            int id = Int32.Parse(textBox1.Text.ToString());
            float grade = float.Parse(textBox4.Text.ToString());
            string name = textBox3.Text.ToString();
            string password = textBox2.Text.ToString();
            string faculity = textBox6.Text.ToString();
            string couces = textBox5.Text.ToString();
            SqlCommand sq = new SqlCommand("update loginstd set password = '" + password + "', name = '" + name + "',faculity ='" + faculity + "',enrolled_cources ='" + couces + "',grade =" + grade + " where id = " + id + "", conn);
            sq.ExecuteNonQuery();
            conn.Close();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 ss = new Form3();
            ss.Show();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
