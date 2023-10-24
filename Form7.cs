using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kiosk_project
{
    public partial class Form7 : Form
    {
        public DialogResult dialog;
        public string s;

        public Form7(string s)
        {
            InitializeComponent();
            this.s = s;
        }

        private void btnbuy_Click(object sender, EventArgs e)
        {
            AK47Black aK47Black = new AK47Black();
            dialog = aK47Black.ShowDialog();
            s = textBox3.Text;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            textBox2.Text = form3.textBox1.Text;
            textBox2.Text = s; //textbox2=보유금액
            textBox1.Text = "1400";
            textBox3.Text = (int.Parse(s) - int.Parse(textBox1.Text)).ToString();
       
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            textBox2.Text = form3.textBox1.Text;
            textBox2.Text = s; //textbox2=보유금액
            textBox1.Text = "7000";
            textBox3.Text = (int.Parse(s) - int.Parse(textBox1.Text)).ToString();
        
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            textBox2.Text = form3.textBox1.Text;
            textBox2.Text = s; //textbox2=보유금액
            textBox1.Text = "28000";
            textBox3.Text = (int.Parse(s) - int.Parse(textBox1.Text)).ToString();
           
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            textBox2.Text = form3.textBox1.Text;
            textBox2.Text = s; //textbox2=보유금액
            textBox1.Text = "70000";
            textBox3.Text = (int.Parse(s) - int.Parse(textBox1.Text)).ToString();
            
        }
    }
}
