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
    public partial class Form13 : Form
    {
        public DialogResult dialog;
        public string s;

        public Form13(string s)
        {
            InitializeComponent();
            this.s = s;
        }

        private void btnbuy_Click(object sender, EventArgs e)
        {
            Mp5 mp5 = new Mp5();
            dialog = mp5.ShowDialog();
            s = textBox3.Text;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            textBox2.Text = form3.textBox1.Text;
            textBox2.Text = s; //textbox2=보유금액
            textBox1.Text = "800";
            textBox3.Text = (int.Parse(s) - int.Parse(textBox1.Text)).ToString();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            textBox2.Text = form3.textBox1.Text;
            textBox2.Text = s; //textbox2=보유금액
            textBox1.Text = "4000";
            textBox3.Text = (int.Parse(s) - int.Parse(textBox1.Text)).ToString();

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            textBox2.Text = form3.textBox1.Text;
            textBox2.Text = s; //textbox2=보유금액
            textBox1.Text = "16000";
            textBox3.Text = (int.Parse(s) - int.Parse(textBox1.Text)).ToString();

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            textBox2.Text = form3.textBox1.Text;
            textBox2.Text = s; //textbox2=보유금액
            textBox1.Text = "40000";
            textBox3.Text = (int.Parse(s) - int.Parse(textBox1.Text)).ToString();

        }
    }
}
