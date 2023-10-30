using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosk_project
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            textBox1.Text = "10000000";

        }



        int count = 0;


        public PictureBox PictureBox3 // 프로퍼티를 추가하여 pictureBox3에 접근 가능하도록 함
        {
            get { return pictureBox3; }
            set { pictureBox3 = value; }


        }
        public PictureBox PictureBox4 // 프로퍼티를 추가하여 pictureBox3에 접근 가능하도록 함
        {
            get { return pictureBox4; }
            set { pictureBox4 = value; }
        }
        public PictureBox PictureBox5 // 프로퍼티를 추가하여 pictureBox3에 접근 가능하도록 함
        {
            get { return pictureBox5; }
            set { pictureBox5 = value; }
        }
        public PictureBox PictureBox6 // 프로퍼티를 추가하여 pictureBox3에 접근 가능하도록 함
        {
            get { return pictureBox6; }
            set { pictureBox6 = value; }
        }
        public PictureBox PictureBox7 // 프로퍼티를 추가하여 pictureBox3에 접근 가능하도록 함
        {
            get { return pictureBox7; }
            set { pictureBox7 = value; }
        }
        public PictureBox PictureBox8 // 프로퍼티를 추가하여 pictureBox3에 접근 가능하도록 함
        {
            get { return pictureBox8; }
            set { pictureBox8 = value; }
        }
        public PictureBox PictureBox9 // 프로퍼티를 추가하여 pictureBox3에 접근 가능하도록 함
        {
            get { return pictureBox9; }
            set { pictureBox9 = value; }

        }
        public PictureBox PictureBox10 // 프로퍼티를 추가하여 pictureBox3에 접근 가능하도록 함
        {
            get { return pictureBox10; }
            set { pictureBox10 = value; }
        }
        public PictureBox PictureBox11 // 프로퍼티를 추가하여 pictureBox3에 접근 가능하도록 함
        {
            get { return pictureBox11; }
            set { pictureBox11 = value; }
        }


        public ImageList imagelist
        {
            get { return imageList1; }
            set { imageList1 = value; }
        }
        public ImageList imagelist4
        {
            get { return imageList4; }
            set { imageList4 = value; }
        }

        private void btnAk47_Click(object sender, EventArgs e)
        {
            Ak47.Checked = true;
            btnAk47.Image = imageList2.Images[0];
            if (AK47BLACK.Checked == false)
                btnAkBlack.Image = imageList3.Images[3];
            if (M4A1.Checked == false)
                btnM4A1.Image = imageList3.Images[2];
            if (Minigun.Checked == false)
                btnMinigun.Image = imageList3.Images[4];
            if (Dragunov.Checked == false)
                button7.Image = imageList3.Images[5];
            if (UAR.Checked == false)
                btnUar.Image = imageList3.Images[6];
            if (CM901.Checked == false)
                btnCm.Image = imageList3.Images[7];
            if (MP5.Checked == false)
                btnMp5.Image = imageList3.Images[8];
            if (TRG.Checked == false)
                btnTrg.Image = imageList3.Images[1];

        }

        private void btnTrg_Click(object sender, EventArgs e)
        {
            TRG.Checked = true;
            btnTrg.Image = imageList2.Images[1];
            if (Ak47.Checked == false)
                btnAk47.Image = imageList3.Images[0];
            if (AK47BLACK.Checked == false)
                btnAkBlack.Image = imageList3.Images[3];
            if (M4A1.Checked == false)
                btnM4A1.Image = imageList3.Images[2];
            if (Minigun.Checked == false)
                btnMinigun.Image = imageList3.Images[4];
            if (Dragunov.Checked == false)
                button7.Image = imageList3.Images[5];
            if (UAR.Checked == false)
                btnUar.Image = imageList3.Images[6];
            if (CM901.Checked == false)
                btnCm.Image = imageList3.Images[7];
            if (MP5.Checked == false)
                btnMp5.Image = imageList3.Images[8];
        }

        private void btnM4A1_Click(object sender, EventArgs e)
        {
            M4A1.Checked = true;
            btnM4A1.Image = imageList2.Images[2];
            if (Ak47.Checked == false)
                btnAk47.Image = imageList3.Images[0];
            if (AK47BLACK.Checked == false)
                btnAkBlack.Image = imageList3.Images[3];
            if (Minigun.Checked == false)
                btnMinigun.Image = imageList3.Images[4];
            if (Dragunov.Checked == false)
                button7.Image = imageList3.Images[5];
            if (UAR.Checked == false)
                btnUar.Image = imageList3.Images[6];
            if (CM901.Checked == false)
                btnCm.Image = imageList3.Images[7];
            if (MP5.Checked == false)
                btnMp5.Image = imageList3.Images[8];
            if (TRG.Checked == false)
                btnTrg.Image = imageList3.Images[1];

        }

        private void btnAkBlack_Click(object sender, EventArgs e)
        {
            AK47BLACK.Checked = true;
            btnAkBlack.Image = imageList2.Images[3];
            if (Ak47.Checked == false)
                btnAk47.Image = imageList3.Images[0];
            if (M4A1.Checked == false)
                btnM4A1.Image = imageList3.Images[2];
            if (Minigun.Checked == false)
                btnMinigun.Image = imageList3.Images[4];
            if (Dragunov.Checked == false)
                button7.Image = imageList3.Images[5];
            if (UAR.Checked == false)
                btnUar.Image = imageList3.Images[6];
            if (CM901.Checked == false)
                btnCm.Image = imageList3.Images[7];
            if (MP5.Checked == false)
                btnMp5.Image = imageList3.Images[8];
            if (TRG.Checked == false)
                btnTrg.Image = imageList3.Images[1];
        }

        private void btnMinigun_Click(object sender, EventArgs e)
        {
            Minigun.Checked = true;
            btnMinigun.Image = imageList2.Images[4];
            if (Ak47.Checked == false)
                btnAk47.Image = imageList3.Images[0];
            if (AK47BLACK.Checked == false)
                btnAkBlack.Image = imageList3.Images[3];
            if (M4A1.Checked == false)
                btnM4A1.Image = imageList3.Images[2];
            if (Dragunov.Checked == false)
                button7.Image = imageList3.Images[5];
            if (UAR.Checked == false)
                btnUar.Image = imageList3.Images[6];
            if (CM901.Checked == false)
                btnCm.Image = imageList3.Images[7];
            if (MP5.Checked == false)
                btnMp5.Image = imageList3.Images[8];
            if (TRG.Checked == false)
                btnTrg.Image = imageList3.Images[1];
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Dragunov.Checked = true;
            button7.Image = imageList2.Images[5];
            if (Ak47.Checked == false)
                btnAk47.Image = imageList3.Images[0];
            if (AK47BLACK.Checked == false)
                btnAkBlack.Image = imageList3.Images[3];
            if (M4A1.Checked == false)
                btnM4A1.Image = imageList3.Images[2];
            if (Minigun.Checked == false)
                btnMinigun.Image = imageList3.Images[4];

            if (UAR.Checked == false)
                btnUar.Image = imageList3.Images[6];
            if (CM901.Checked == false)
                btnCm.Image = imageList3.Images[7];
            if (MP5.Checked == false)
                btnMp5.Image = imageList3.Images[8];
            if (TRG.Checked == false)
                btnTrg.Image = imageList3.Images[1];
        }

        private void btnUar_Click(object sender, EventArgs e)
        {
            UAR.Checked = true;
            btnUar.Image = imageList2.Images[6];
            if (Ak47.Checked == false)
                btnAk47.Image = imageList3.Images[0];
            if (AK47BLACK.Checked == false)
                btnAkBlack.Image = imageList3.Images[3];
            if (M4A1.Checked == false)
                btnM4A1.Image = imageList3.Images[2];
            if (Minigun.Checked == false)
                btnMinigun.Image = imageList3.Images[4];
            if (Dragunov.Checked == false)
                button7.Image = imageList3.Images[5];

            if (CM901.Checked == false)
                btnCm.Image = imageList3.Images[7];
            if (MP5.Checked == false)
                btnMp5.Image = imageList3.Images[8];
            if (TRG.Checked == false)
                btnTrg.Image = imageList3.Images[1];
        }

        private void btnCm_Click(object sender, EventArgs e)
        {
            CM901.Checked = true;
            btnCm.Image = imageList2.Images[7];
            if (Ak47.Checked == false)
                btnAk47.Image = imageList3.Images[0];
            if (AK47BLACK.Checked == false)
                btnAkBlack.Image = imageList3.Images[3];
            if (M4A1.Checked == false)
                btnM4A1.Image = imageList3.Images[2];
            if (Minigun.Checked == false)
                btnMinigun.Image = imageList3.Images[4];
            if (Dragunov.Checked == false)
                button7.Image = imageList3.Images[5];
            if (UAR.Checked == false)
                btnUar.Image = imageList3.Images[6];

            if (MP5.Checked == false)
                btnMp5.Image = imageList3.Images[8];
            if (TRG.Checked == false)
                btnTrg.Image = imageList3.Images[1];
        }

        private void btnMp5_Click(object sender, EventArgs e)
        {
            MP5.Checked = true;
            btnMp5.Image = imageList2.Images[8];
            if (Ak47.Checked == false)
                btnAk47.Image = imageList3.Images[0];
            if (AK47BLACK.Checked == false)
                btnAkBlack.Image = imageList3.Images[3];
            if (M4A1.Checked == false)
                btnM4A1.Image = imageList3.Images[2];
            if (Minigun.Checked == false)
                btnMinigun.Image = imageList3.Images[4];
            if (Dragunov.Checked == false)
                button7.Image = imageList3.Images[5];
            if (UAR.Checked == false)
                btnUar.Image = imageList3.Images[6];
            if (CM901.Checked == false)
                btnCm.Image = imageList3.Images[7];
            if (TRG.Checked == false)
                btnTrg.Image = imageList3.Images[1];

        }

        private void button3_Click(object sender, EventArgs e)//결제 확인창 구입하기 버튼
        {
            //결제 확인창 폼들
            Form4 form4 = new Form4(textBox1.Text);
            Form5 form5 = new Form5(textBox1.Text);
            Form6 form6 = new Form6(textBox1.Text);
            Form7 form7 = new Form7(textBox1.Text);
            Form8 form8 = new Form8(textBox1.Text);
            Form9 form9 = new Form9(textBox1.Text);
            Form2 form2 = new Form2(textBox1.Text);
            Form12 form12 = new Form12(textBox1.Text);
            Form13 form13 = new Form13(textBox1.Text);

            if (Ak47.Checked)
            {
                form4.ShowDialog();
            }
            else if (TRG.Checked)
            {

                form5.ShowDialog();

            }
            else if (M4A1.Checked)
            {
                form6.ShowDialog();

            }
            else if (AK47BLACK.Checked)
            {
                form7.ShowDialog();
            }
            else if (Minigun.Checked)
            {
                form8.ShowDialog();
            }
            else if (Dragunov.Checked)
            {
                form2.ShowDialog();
            }
            else if (UAR.Checked)
            {
                form9.ShowDialog();
            }
            else if (CM901.Checked)
            {
                form12.ShowDialog();
            }
            else
            {
                form13.ShowDialog();
            }




            Ak47 ak47 = new Ak47();//ak-47 결제확인 버튼
            ak47.dialog = form4.dialog;//결제창에서 ok을 누르면 ak47 결제 확인창 ok로 감

            if (ak47.dialog == DialogResult.OK)//ak47 결제확인창 ok 가 되면 ..
            {
                count++;
                if (count == 1)
                {
                    pictureBox3.Image = imagelist.Images[1];
                }
                if (count == 2)
                {
                    pictureBox4.Image = imagelist.Images[1];
                }
                if (count == 3)
                {
                    pictureBox5.Image = imagelist.Images[1];
                }
                if (count == 4)
                {
                    pictureBox6.Image = imagelist.Images[1];

                }
                if (count == 5)
                {
                    pictureBox7.Image = imagelist.Images[1];
                }
                if (count == 6)
                {
                    pictureBox8.Image = imagelist.Images[1];
                }
                if (count == 7)
                {
                    pictureBox9.Image = imagelist.Images[1];
                }
                if (count == 8)
                {
                    pictureBox10.Image = imagelist.Images[1];
                }
                if (count == 9)
                {
                    pictureBox11.Image = imagelist.Images[1];
                }
                if (count > 10)
                {
                    MessageBox.Show("총이 다 찼습니다 ㅋㅋ");
                }
                textBox1.Text = form4.s;// 결제완료되면 
            }


            Form1 form1 = new Form1(); //Trg 결제창
            form1.dialog1 = form5.dialog; //trg..

            if (form1.dialog1 == DialogResult.OK)//ak
            {
                count++;
                if (count == 1)
                {
                    pictureBox3.Image = imagelist.Images[2];
                }
                if (count == 2)
                {
                    pictureBox4.Image = imagelist.Images[2];
                }
                if (count == 3)
                {
                    pictureBox5.Image = imagelist.Images[2];
                }
                if (count == 4)
                {
                    pictureBox6.Image = imagelist.Images[2];

                }
                if (count == 5)
                {
                    pictureBox7.Image = imagelist.Images[2];
                }
                if (count == 6)
                {
                    pictureBox8.Image = imagelist.Images[2];
                }
                if (count == 7)
                {
                    pictureBox9.Image = imagelist.Images[2];
                }
                if (count == 8)
                {
                    pictureBox10.Image = imagelist.Images[2];
                }
                if (count == 9)
                {
                    pictureBox11.Image = imagelist.Images[2];
                }
                if (count > 10)
                {
                    MessageBox.Show("총이 다 찼습니다 ㅋㅋ");
                }
                textBox1.Text = form5.s;

            }


            M4 m4 = new M4();//m4 결제창
            m4.dialog2 = form6.dialog; //m4..
            if (m4.dialog2 == DialogResult.OK)//
            {
                count++;
                if (count == 1)
                {
                    pictureBox3.Image = imagelist.Images[3];
                }
                if (count == 2)
                {
                    pictureBox4.Image = imagelist.Images[3];
                }
                if (count == 3)
                {
                    pictureBox5.Image = imagelist.Images[3];
                }
                if (count == 4)
                {
                    pictureBox6.Image = imagelist.Images[3];

                }
                if (count == 5)
                {
                    pictureBox7.Image = imagelist.Images[3];
                }
                if (count == 6)
                {
                    pictureBox8.Image = imagelist.Images[3];
                }
                if (count == 7)
                {
                    pictureBox9.Image = imagelist.Images[3];
                }
                if (count == 8)
                {
                    pictureBox10.Image = imagelist.Images[3];
                }
                if (count == 9)
                {
                    pictureBox11.Image = imagelist.Images[3];
                }
                if (count > 10)
                {
                    MessageBox.Show("총이 다 찼습니다 ㅋㅋ");
                }


                textBox1.Text = form6.s;
            }

            AK47Black aK47BLACK = new AK47Black();

            aK47BLACK.dialog = form7.dialog;
            if (aK47BLACK.dialog == DialogResult.OK)//ok
            {
                count++;
                if (count == 1)
                {
                    pictureBox3.Image = imagelist.Images[4];
                }
                if (count == 2)
                {
                    pictureBox4.Image = imagelist.Images[4];
                }
                if (count == 3)
                {
                    pictureBox5.Image = imagelist.Images[4];
                }
                if (count == 4)
                {
                    pictureBox6.Image = imagelist.Images[4];

                }
                if (count == 5)
                {
                    pictureBox7.Image = imagelist.Images[4];
                }
                if (count == 6)
                {
                    pictureBox8.Image = imagelist.Images[4];
                }
                if (count == 7)
                {
                    pictureBox9.Image = imagelist.Images[4];
                }
                if (count == 8)
                {
                    pictureBox10.Image = imagelist.Images[4];
                }
                if (count == 9)
                {
                    pictureBox11.Image = imagelist.Images[4];
                }
                if (count > 10)
                {
                    MessageBox.Show("총이 다 찼습니다 ㅋㅋ");
                }
                textBox1.Text = form7.s;
            }

            Minigun minigun = new Minigun();
            minigun.dialog = form8.dialog;
            if (minigun.dialog == DialogResult.OK)//ok
            {
                count++;
                if (count == 1)
                {
                    pictureBox3.Image = imagelist.Images[5];
                }
                if (count == 2)
                {
                    pictureBox4.Image = imagelist.Images[5];
                }
                if (count == 3)
                {
                    pictureBox5.Image = imagelist.Images[5];
                }
                if (count == 4)
                {
                    pictureBox6.Image = imagelist.Images[5];

                }
                if (count == 5)
                {
                    pictureBox7.Image = imagelist.Images[5];
                }
                if (count == 6)
                {
                    pictureBox8.Image = imagelist.Images[5];
                }
                if (count == 7)
                {
                    pictureBox9.Image = imagelist.Images[5];
                }
                if (count == 8)
                {
                    pictureBox10.Image = imagelist.Images[5];
                }
                if (count == 9)
                {
                    pictureBox11.Image = imagelist.Images[5];
                }
                if (count > 10)
                {
                    MessageBox.Show("총이 다 찼습니다 ㅋㅋ");
                }
                textBox1.Text = form8.s;
            }

            Uar uar = new Uar();
            uar.dialog = form9.dialog;

            if (uar.dialog == DialogResult.OK)//ok
            {
                count++;
                if (count == 1)
                {
                    pictureBox3.Image = imagelist.Images[7];
                }
                if (count == 2)
                {
                    pictureBox4.Image = imagelist.Images[7];
                }
                if (count == 3)
                {
                    pictureBox5.Image = imagelist.Images[7];
                }
                if (count == 4)
                {
                    pictureBox6.Image = imagelist.Images[7];

                }
                if (count == 5)
                {
                    pictureBox7.Image = imagelist.Images[7];
                }
                if (count == 6)
                {
                    pictureBox8.Image = imagelist.Images[7];
                }
                if (count == 7)
                {
                    pictureBox9.Image = imagelist.Images[7];
                }
                if (count == 8)
                {
                    pictureBox10.Image = imagelist.Images[7];
                }
                if (count == 9)
                {
                    pictureBox11.Image = imagelist.Images[7];
                }
                if (count > 10)
                {
                    MessageBox.Show("총이 다 찼습니다 ㅋㅋ");
                }
                textBox1.Text = form9.s;


            }

            Dragunov dragunov = new Dragunov();
            dragunov.dialog = form2.dialog;
            if (dragunov.dialog == DialogResult.OK)//ok
            {
                count++;
                if (count == 1)
                {
                    pictureBox3.Image = imagelist.Images[6];
                }
                if (count == 2)
                {
                    pictureBox4.Image = imagelist.Images[6];
                }
                if (count == 3)
                {
                    pictureBox5.Image = imagelist.Images[6];
                }
                if (count == 4)
                {
                    pictureBox6.Image = imagelist.Images[6];

                }
                if (count == 5)
                {
                    pictureBox7.Image = imagelist.Images[6];
                }
                if (count == 6)
                {
                    pictureBox8.Image = imagelist.Images[6];
                }
                if (count == 7)
                {
                    pictureBox9.Image = imagelist.Images[6];
                }
                if (count == 8)
                {
                    pictureBox10.Image = imagelist.Images[6];
                }
                if (count == 9)
                {
                    pictureBox11.Image = imagelist.Images[6];
                }
                if (count > 10)
                {
                    MessageBox.Show("총이 다 찼습니다 ㅋㅋ");
                }
                textBox1.Text = form2.s;
            }

            Cm901 cm901 = new Cm901();
            cm901.dialog = form12.dialog;
            if (cm901.dialog == DialogResult.OK)//ok
            {
                count++;
                if (count == 1)
                {
                    pictureBox3.Image = imagelist.Images[8];
                }
                if (count == 2)
                {
                    pictureBox4.Image = imagelist.Images[8];
                }
                if (count == 3)
                {
                    pictureBox5.Image = imagelist.Images[8];
                }
                if (count == 4)
                {
                    pictureBox6.Image = imagelist.Images[8];

                }
                if (count == 5)
                {
                    pictureBox7.Image = imagelist.Images[8];
                }
                if (count == 6)
                {
                    pictureBox8.Image = imagelist.Images[8];
                }
                if (count == 7)
                {
                    pictureBox9.Image = imagelist.Images[8];
                }
                if (count == 8)
                {
                    pictureBox10.Image = imagelist.Images[8];
                }
                if (count == 9)
                {
                    pictureBox11.Image = imagelist.Images[8];
                }
                if (count > 10)
                {
                    MessageBox.Show("총이 다 찼습니다 ㅋㅋ");
                }
                textBox1.Text = form12.s;
            }
            Mp5 mp5 = new Mp5();
            mp5.dialog = form13.dialog;
            if (mp5.dialog == DialogResult.OK)//ok
            {
                count++;
                if (count == 1)
                {
                    pictureBox3.Image = imagelist.Images[9];

                }
                if (count == 2)
                {
                    pictureBox4.Image = imagelist.Images[9];
                }
                if (count == 3)
                {
                    pictureBox5.Image = imagelist.Images[9];
                }
                if (count == 4)
                {
                    pictureBox6.Image = imagelist.Images[9];

                }
                if (count == 5)
                {
                    pictureBox7.Image = imagelist.Images[9];
                }
                if (count == 6)
                {
                    pictureBox8.Image = imagelist.Images[9];
                }
                if (count == 7)
                {
                    pictureBox9.Image = imagelist.Images[9];
                }
                if (count == 8)
                {
                    pictureBox10.Image = imagelist.Images[9];
                }
                if (count == 9)
                {
                    pictureBox11.Image = imagelist.Images[9];
                }
                if (count > 10)
                {
                    MessageBox.Show("총이 다 찼습니다 ㅋㅋ");
                }

                textBox1.Text = form13.s;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<PictureBox> mix = new List<PictureBox>(); //리스트 클래스

            mix.Add(pictureBox3);//리크스클래스 에 픽쳐박스 추가.
            mix.Add(pictureBox4);
            mix.Add(pictureBox5);
            mix.Add(pictureBox6);
            mix.Add(pictureBox7);
            mix.Add(pictureBox8);
            mix.Add(pictureBox9);
            mix.Add(pictureBox10);
            mix.Add(pictureBox11);



            Itemmix itemmix = new Itemmix(mix, this);
            this.Hide();
            itemmix.Show();//모달리스




        }
    }
}
