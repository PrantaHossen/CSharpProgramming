using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to close","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            {
                if(dr==DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtAddItems.Text != "")
            {
                if (comboBox1.Items.Contains(txtAddItems.Text))
                {
                    MessageBox.Show("Items Already Exit's");
                }
                else
                {
                    comboBox1.Items.Add(txtAddItems.Text);
                    MessageBox.Show("Items Add");
                    txtAddItems.Clear();
                    txtAddItems.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please Input a Item Name", "Error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count = comboBox1.Items.Count;
            MessageBox.Show("Total Items Are : "+count.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Sorted = true;
            MessageBox.Show("Items are Sorted");
        }

        private void btnRemoveItems_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.SelectedItem + " are Removed ");
            comboBox1.Items.Remove(comboBox1.SelectedItem);
           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }
    }
}
