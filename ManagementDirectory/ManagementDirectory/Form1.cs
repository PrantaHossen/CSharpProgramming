using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementDirectory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are You confirm to close","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
           if(checkBoxShowPass.Checked)
            {
                txtpassWord.PasswordChar = '\0';
            }
            else
            {
                txtpassWord.PasswordChar = '*';
            }
        }
    }
}
