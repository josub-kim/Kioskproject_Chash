using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kiosk_project
{
    public partial class Form5 : Form
    {
        public string s;
        public DialogResult dialog;

        public Form5(string s)
        {
            InitializeComponent();
            radioButton2.BackColor = Color.Black;
            this.s = s;
        }

        private void btnbuy_Click(object sender, EventArgs e)
        {

            Form1 form1 = new Form1();
            dialog = form1.ShowDialog();
            s = textBox3.Text;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            textBox2.Text = form3.textBox1.Text;
            textBox2.Text = s; //textbox2=보유금액
            textBox1.Text = "2000";
            textBox3.Text = (int.Parse(s) - int.Parse(textBox1.Text)).ToString();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.FlatAppearance.MouseDownBackColor = Color.Red;
            Form3 form3 = new Form3();
            textBox2.Text = form3.textBox1.Text;
            textBox1.Text = "10000";

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.FlatAppearance.MouseDownBackColor = Color.Red;
            Form3 form3 = new Form3();
            textBox2.Text = form3.textBox1.Text;
            textBox1.Text = "40000";

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.FlatAppearance.MouseDownBackColor = Color.Red;
            Form3 form3 = new Form3();
            textBox2.Text = form3.textBox1.Text;
            textBox1.Text = "100000";

        }
    }
}
