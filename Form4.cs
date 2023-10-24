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
using static System.Windows.Forms.DataFormats;

namespace Kiosk_project
{


    public partial class Form4 : Form
    {

        public DialogResult dialog;
        public string s;
        public int count = 0;
        public Form4(string s)
        {
            InitializeComponent();
            radioButton1.BackColor = Color.Black;
            this.s = s;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {


            Form3 form3 = new Form3();
            textBox2.Text = form3.textBox1.Text;//총 금액.(FORM 4에서)
            textBox2.Text = s; //FORM3의 총금액을 TEXTBOX2에 넘김.
            textBox1.Text = "1400"; //Ak의 가격
            textBox3.Text = (int.Parse(s) - int.Parse(textBox1.Text)).ToString();//보유잔액
        }

        private void btnbuy_Click(object sender, EventArgs e) //결제창 구매버튼
        {
            Ak47 ak47 = new Ak47();
            dialog = ak47.ShowDialog();
            s = textBox3.Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            textBox2.Text = form3.textBox1.Text;
            textBox2.Text = s;
            textBox1.Text = "7000";
            textBox3.Text = (int.Parse(s) - int.Parse(textBox1.Text)).ToString();

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            textBox2.Text = form3.textBox1.Text;
            textBox2.Text = s;
            textBox1.Text = "28000";
            textBox3.Text = (int.Parse(s) - int.Parse(textBox1.Text)).ToString();

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            textBox2.Text = form3.textBox1.Text;
            textBox2.Text = s;
            textBox1.Text = "70000";
            textBox3.Text = (int.Parse(s) - int.Parse(textBox1.Text)).ToString();
        }
    }
}
