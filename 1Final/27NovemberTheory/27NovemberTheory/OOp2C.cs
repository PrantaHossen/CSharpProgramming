using System;
using System.Windows.Forms;

namespace _27NovemberTheory
{
    public partial class OOp2C : Form
    {
        public OOp2C()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do You Want to Close", "ConFirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                this.Close();
            }


        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            this.txtOutputUsername.Text = this.txtUsername.Text;
            this.lblPassword.Text = this.txtPassword.Text;
            this.lblDepartment.Text = this.cmbDepartment.Text;
            this.lblDOB.Text = this.dateTimePicker1.Text;

            if (this.rbBechelor.Checked)
            {
                this.lblProgram.Text = "Bechelor's";
            }
            else if (this.rbMasters.Checked)
            {
                this.lblProgram.Text = "Master's";
            }
            else { }


            this.pnlInformation.Hide();
            MessageBox.Show("Showing Data");
            this.pnlOut.Visible = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtOutputUsername.Text = "";
            this.lblPassword.Text = "";
            this.lblDepartment.Text = "";
            this.lblDOB.Text = "";
            this.lblProgram.Text = "";

            this.txtUsername.Clear();
            this.txtPassword.Clear();
            this.cmbDepartment.SelectedIndex = -1;//ComboBox
            this.dateTimePicker1.Text = "";
            this.rbBechelor.Checked = false;
            this.rbMasters.Checked = false;

            MessageBox.Show("Hiding Data");
            this.pnlOut.Visible = false;
            this.pnlInformation.Show();

        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
