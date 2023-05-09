using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomePage
{
    public partial class _0708_Student_StructForm : Form
    {
        public _0708_Student_StructForm()
        {
            InitializeComponent();
        }

        //結構(struct)型態 宣告，必須宣告在外面，才可以將設定內容值存取起來
        StudentScore Score;

        private void SaveScore_Click(object sender, EventArgs e)
        {
            //設定內容值
            Score.Name = textBoxName.Text;
            Score.Chinese = int.Parse(textBoxChi.Text);
            Score.English = int.Parse(textBoxEng.Text);
            Score.Math = int.Parse(textBoxMath.Text);
        }

        private void ShowScore_Click(object sender, EventArgs e)
        {
            ScoreList.Text = $"姓名：{Score.Name} \n國文：{Score.Chinese} \n英文：{Score.English} \n數學：{Score.Math}";
        }

        private void checkScore_Click(object sender, EventArgs e)
        {

            //宣告一個陣列存放三個科目的成績:
            float[] arrScore = new float[3];

            arrScore[0] = Score.Chinese;//國文
            arrScore[1] = Score.English;//英文
            arrScore[2] = Score.Math;//數學

            //宣告一個陣列存放三個科目的名稱:
            string[] arrSubjects = new string[3];

            arrSubjects[0] = "國文";//國文
            arrSubjects[1] = "英文";//英文
            arrSubjects[2] = "數學";//數學

            //計算總分用: arr.Sum()
            //計算平均用: arr.Average()
            //計算最高分用: arr.Max()
            float max = arrScore.Max(); //計算陣列裡的最高分
            int maxIndex = Array.IndexOf(arrScore, max); //獲取最高分在第幾陣列

            float min = arrScore.Min(); //計算陣列裡的最低分
            int minIndex = Array.IndexOf(arrScore, min); //獲取最低分在第幾陣列

            richTextBox2.Text = "最高科目成績為：" + arrSubjects[maxIndex] + arrScore.Max() + "分\n" + "最低科目成績為：" + arrSubjects[minIndex] + arrScore.Min() + "分";
        }
    }
}
