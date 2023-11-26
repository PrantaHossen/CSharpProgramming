using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsAppA
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do You want to close.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            {
                if (dr == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        private void txtusername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtusername.Text) == true)
            {
                errorProvider1.Icon = Properties.Resources.error;
                txtusername.Focus();
                errorProvider1.SetError(this.txtusername, "Please Fill The Text Box");
            }

            else
            {
                errorProvider1.Icon= Properties.Resources.check;
                //errorProvider1.Clear();
            }

        }

        private void txtpassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtpassword.Text) == true)
            {
                errorProvider2.Icon = Properties.Resources.error;
                txtpassword.Focus();
                errorProvider2.SetError(this.txtpassword, "Please Fill The Text Box");
            }

            else
            {
                errorProvider2.Icon = Properties.Resources.check;
                //errorProvider1.Clear();
            }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor=Color.Red; 
            button1.ForeColor=Color.Green;
        }
    }
}
