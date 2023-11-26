using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DatabaseForm
{
    public partial class Form1 : Form
    {
        //Cs Connection String
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dr1 = MessageBox.Show("Do you want to close", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            {
                if (dr1 == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) == true)
            {
                errorProvider1.Icon = Properties.Resources.error;
                txtUsername.Focus();
                errorProvider1.SetError(this.txtUsername, "Please Fill The Text Box");
            }

            else
            {
                errorProvider1.Icon = Properties.Resources.check;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text) == true)
            {
                errorProvider2.Icon = Properties.Resources.error;
                txtPassword.Focus();
                errorProvider2.SetError(this.txtPassword, "Please Fill The Text Box");
            }

            else
            {
                errorProvider2.Icon = Properties.Resources.check;
            }
        }

        private void cbxShowpass_CheckedChanged(object sender, EventArgs e)
        {
            bool status = cbxShowpass.Checked;
            switch (status)
            {
                case true:
                    txtPassword.UseSystemPasswordChar = false;
                    break;
                case false:
                    txtPassword.UseSystemPasswordChar = true;
                    break;

            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                SqlConnection con = new SqlConnection(cs);

                string query = ("select * from Login_tbl where username = @username and pass=@password");

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    MessageBox.Show("Login SuccessFull", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    /*this.Visible = false;
                    Form2 f2 = new Form2(this);
                    f2.Visible = true;*/
                }
                else
                {
                    MessageBox.Show("Login Failed", "Failed", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Please Insert Both Field!", "Failed", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }

        }
    }
}
