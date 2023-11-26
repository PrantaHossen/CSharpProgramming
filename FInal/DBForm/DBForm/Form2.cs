using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBForm
{
    public partial class Form2 : Form
    {
        private Form1 f1{ get; set; }

        public Form2(Form1 frm1) : this()
        {
            //InitializeComponent();
           // this.lblInfo.Text = info;
            this.f1= frm1;
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.f1.Visible = true;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            this.f1.Visible = true;
        }

        

        private void button1_MouseHover(object sender, EventArgs e)
        {
            this.BackColor=Color.AliceBlue; this.ForeColor=Color.Green;
        }

     
    }
}
