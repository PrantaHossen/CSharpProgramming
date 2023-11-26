using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm.cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Program.connectingString);
            string query = "insert into loginP values(@username,@userpassword)";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", textBox1.Text);
            cmd.Parameters.AddWithValue("@userpassword", textBox2.Text);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Program.connectingString);
            string query = "select * from loginP where username = @username";

            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", textBox1.Text);
            SqlDataReader sd = cmd.ExecuteReader();
            label1.Text = sd["userpassword"].ToString();
            con.Close();
        }
    }
}
