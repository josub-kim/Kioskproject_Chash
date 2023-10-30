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

    public partial class Itemmix : Form
    {

        private Form3 form3;
        List<Button> buttons = new List<Button>(); //버튼이라는 리스트 클래스 생성해서
        int count = 0;
        public Itemmix(List<PictureBox> list, Form3 form3)
        {
            InitializeComponent();
            this.form3 = form3;
            //_form3 = form3;
            //button1.Image = list[0].Image; 원래는 이렇게지만..
            buttons.Add(button1);
            buttons.Add(button2);
            buttons.Add(button3);
            buttons.Add(button4);
            buttons.Add(button5);
            buttons.Add(button6);
            buttons.Add(button7);
            buttons.Add(button8);
            buttons.Add(button9);

            for (int i = 0; i < list.Count; i++)
            {
                buttons[i].Image = list[i].Image;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            if (count == 1)
                button1.Location = new Point(61, 262);
            else if (count == 2)
                button1.Location = new Point(275, 263);
            else if (count == 3)
                button1.Location = new Point(490, 263);
            else if (count == 4)
                button1.Location = new Point(62, 445);
            else if (count == 5)
                button1.Location = new Point(275, 445);
            else if (count == 6)
                button1.Location = new Point(490, 445);


        }


        private void button2_Click_1(object sender, EventArgs e)  //버튼 2 클릭
        {
            count++;
            if (count == 1)
                button2.Location = new Point(61, 262);
            else if (count == 2)
                button2.Location = new Point(275, 263);
            else if (count == 3)
                button2.Location = new Point(490, 263);
            else if (count == 4)
                button2.Location = new Point(62, 445);
            else if (count == 5)
                button2.Location = new Point(275, 445);
            else if (count == 6)
                button2.Location = new Point(490, 445);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            count++;
            if (count == 1)
                button3.Location = new Point(61, 262);
            if (count == 2)
                button3.Location = new Point(275, 263);
            if (count == 3)
                button3.Location = new Point(490, 263);
            if (count == 4)
                button3.Location = new Point(62, 445);
            if (count == 5)
                button3.Location = new Point(275, 445);
            if (count == 6)
                button3.Location = new Point(490, 445);

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            count++;
            if (count == 1)
                button4.Location = new Point(61, 262);
            if (count == 2)
                button4.Location = new Point(275, 263);
            if (count == 3)
                button4.Location = new Point(490, 263);
            if (count == 4)
                button4.Location = new Point(62, 445);
            if (count == 5)
                button4.Location = new Point(275, 445);
            if (count == 6)
                button4.Location = new Point(490, 445);

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            count++;
            if (count == 1)
                button5.Location = new Point(61, 262);
            if (count == 2)
                button5.Location = new Point(275, 263);
            if (count == 3)
                button5.Location = new Point(490, 263);
            if (count == 4)
                button5.Location = new Point(62, 445);
            if (count == 5)
                button5.Location = new Point(275, 445);
            if (count == 6)
                button5.Location = new Point(490, 445);
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            count++;
            if (count == 1)
                button6.Location = new Point(61, 262);
            if (count == 2)
                button6.Location = new Point(275, 263);
            if (count == 3)
                button6.Location = new Point(490, 263);
            if (count == 4)
                button6.Location = new Point(62, 445);
            if (count == 5)
                button6.Location = new Point(275, 445);
            if (count == 6)
                button6.Location = new Point(490, 445);
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            count++;
            if (count == 1)
                button7.Location = new Point(61, 262);
            if (count == 2)
                button7.Location = new Point(275, 263);
            if (count == 3)
                button7.Location = new Point(490, 263);
            if (count == 4)
                button7.Location = new Point(62, 445);
            if (count == 5)
                button7.Location = new Point(275, 445);
            if (count == 6)
                button7.Location = new Point(490, 445);
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            count++;
            if (count == 1)
                button8.Location = new Point(61, 262);
            if (count == 2)
                button8.Location = new Point(275, 263);
            if (count == 3)
                button8.Location = new Point(490, 263);
            if (count == 4)
                button8.Location = new Point(62, 445);
            if (count == 5)
                button8.Location = new Point(275, 445);
            if (count == 6)
                button8.Location = new Point(490, 445);

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            count++;
            if (count == 1)
                button9.Location = new Point(61, 262);
            if (count == 2)
                button9.Location = new Point(275, 263);
            if (count == 3)
                button9.Location = new Point(490, 263);
            if (count == 4)
                button9.Location = new Point(62, 445);
            if (count == 5)
                button9.Location = new Point(275, 445);
            if (count == 6)
                button9.Location = new Point(490, 445);
        }

        private void button10_Click(object sender, EventArgs e) // 아이템 믹스 클릭
        {
            //form3.pictureBox3.Image = null;
            Random random = new Random();
            Dictionary<string, double> probabilities = new Dictionary<string, double>
                {
                    { "AWP", 0.9 },
                    { "TRG", 0.01 },
                    { "Gurkha", 0.01 },
                    { "G600", 0.01},
                    { "CM901", 0.01 },
                    { "KRISS ", 0.06 },
                };

            if (count < 3)
                MessageBox.Show("재료가 부족합니다.");
            else
            {
                double randomValue = random.NextDouble();
                double cumulativeProbability = 0.0;
                string selectedItem = null;
                foreach (var kvp in probabilities)
                {
                    cumulativeProbability += kvp.Value;

                    if (randomValue < cumulativeProbability)
                    {
                        selectedItem = kvp.Key;
                        break;
                    }
                }

                if (selectedItem != null)
                {
                    if (selectedItem == "AWP")
                    {
                        form3.PictureBox3.Image = imageList1.Images[0];
                        form3.PictureBox4.Image = null;
                        form3.PictureBox5.Image = null;
                        form3.Show(this);
                    }
                    else if (selectedItem == "TRG")
                    {
                        form3.PictureBox3.Image = imageList1.Images[1];
                        form3.PictureBox4.Image = null;
                        form3.PictureBox5.Image = null;
                        form3.Show(this);
                    }
                    else if (selectedItem == "Gurkha")
                    {
                        form3.PictureBox3.Image = imageList1.Images[2];
                        form3.PictureBox4.Image = null;
                        form3.PictureBox5.Image = null;
                        form3.Show(this);
                    }
                    else if (selectedItem == "G600")
                    {
                        form3.PictureBox3.Image = imageList1.Images[3];
                        form3.PictureBox4.Image = null;
                        form3.PictureBox5.Image = null;
                        form3.Show(this);
                    }
                    else if (selectedItem == "CM901")
                    {
                        form3.PictureBox3.Image = imageList1.Images[4];
                        form3.PictureBox4.Image = null;
                        form3.PictureBox5.Image = null;
                        form3.Show(this);
                    }
                    else if (selectedItem == "KRISS")
                    {
                        form3.PictureBox3.Image = imageList1.Images[5];
                        form3.PictureBox4.Image = null;
                        form3.PictureBox5.Image = null;
                        form3.Show(this);
                    }

                    MessageBox.Show($"선택된 아이템: {selectedItem}");
                    // count 변수를 조정하는 코드 또는 다른 작업 수행
                }
                else
                {
                    MessageBox.Show("선택된 아이템이 없습니다. 오류 또는 확률 합이 1보다 작을 수 있습니다.");
                }
            }
        }
    }
}




