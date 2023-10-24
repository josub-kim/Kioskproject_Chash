using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosk_project
{
    public partial class Form8 : Form
    {
        public DialogResult dialog;
        public string s;
        public Form8(string s)
        {
            InitializeComponent();
            this.s = s;
        }

        private void btnbuy_Click(object sender, EventArgs e)
        {
            Minigun minigun = new Minigun();
            dialog = minigun.ShowDialog();
            s = textBox3.Text;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            textBox2.Text = form3.textBox1.Text;
            textBox2.Text = s; //textbox2=보유금액
            textBox1.Text = "1600";
            textBox3.Text = (int.Parse(s) - int.Parse(textBox1.Text)).ToString();
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            textBox2.Text = form3.textBox1.Text;
            textBox2.Text = s; //textbox2=보유금액
            textBox1.Text = "8000";
            textBox3.Text = (int.Parse(s) - int.Parse(textBox1.Text)).ToString();
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            textBox2.Text = form3.textBox1.Text;
            textBox2.Text = s; //textbox2=보유금액
            textBox1.Text = "32000";
            textBox3.Text = (int.Parse(s) - int.Parse(textBox1.Text)).ToString();
          
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            textBox2.Text = form3.textBox1.Text;
            textBox2.Text = s; //textbox2=보유금액
            textBox1.Text = "80000";
            textBox3.Text = (int.Parse(s) - int.Parse(textBox1.Text)).ToString();
           
        }
    }
}
