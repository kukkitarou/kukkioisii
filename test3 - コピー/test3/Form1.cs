using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test3
{
    public partial class Form1 : Form
    {
        //左右判定用、falseが右から左、tureが左から右
        bool cheage = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //枠を消す
            this.FormBorderStyle = FormBorderStyle.None;

            //ファームを背景色で透明化する
            this.TransparencyKey = BackColor;

            //画面全体
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            timer1.Interval = 100;
            timer1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //スタート
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //停止
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //if (cheage == false)
            //{

            //    image1.Left = image1.Left + -10;
            //    //image1.Top = image1.Top + 10;
            //}
            //else
            //{
            //    image1.Left = image1.Left + 10;

            //}

            Random rnd = new Random();

            int x = rnd.Next(0, 100);

            if (x <= 24)//上
            {
                image1.Top = image1.Top + -10;
                image1.Top = image1.Top + -10;
                image1.Top = image1.Top + -10;
                image1.Top = image1.Top + -10;
                image1.Top = image1.Top + -10;
            }
            else if (x <= 49)//下
            {

                image1.Top = image1.Top + 10;
                image1.Top = image1.Top + 10;
                image1.Top = image1.Top + 10;
                image1.Top = image1.Top + 10;
                image1.Top = image1.Top + 10;
            }
            else if (x <= 74)//左
            {
                image1.Left = image1.Left + -10;
                image1.Left = image1.Left + -10;
                image1.Left = image1.Left + -10;
                image1.Left = image1.Left + -10;
                image1.Left = image1.Left + -10;
            }
            else if (x >= 99)//右
            {
                image1.Left = image1.Left + 10;
                image1.Left = image1.Left + 10;
                image1.Left = image1.Left + 10;
                image1.Left = image1.Left + 10;
                image1.Left = image1.Left + 10;
            }
        }

        private void image1_Click(object sender, EventArgs e)
        {
            //反転
            image1.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            image1.Refresh();


            //左右切り替え
            if (cheage == true)
            {
                cheage = false;
            }
            else
            {
                cheage = true;
            }

        }

    }

    
}
//google
//string target = "https://www.google.co.jp/";
//try
//{
//    System.Diagnostics.Process.Start(target);
//}
//catch (System.ComponentModel.Win32Exception noBrowser)
//{
//    if (noBrowser.ErrorCode == -2147467259)
//        MessageBox.Show(noBrowser.Message);
//}
//catch (System.Exception other)
//{
//    MessageBox.Show(other.Message);
//}
