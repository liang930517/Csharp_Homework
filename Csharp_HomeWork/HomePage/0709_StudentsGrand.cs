using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HomePage
{
    public partial class _0709_StudentsGrand : Form
    {
        public _0709_StudentsGrand()
        {
            InitializeComponent();
        }

        string[] arr = new string[8];
        //結構(struct)型態 宣告，必須宣告在外面，才可以將設定內容值存取起來
        StudentScore2 Score;
        private void addScore_Click(object sender, EventArgs e)
        {
            if (Validation())
            { //等於true時
                //設定內容值
                Score.Name = textBoxName.Text;
                Score.Chinese = int.Parse(textBoxChi.Text);
                Score.English = int.Parse(textBoxEng.Text);
                Score.Math = int.Parse(textBoxMath.Text);
                AddScore();
                BtnSubjectCount.Enabled = true;
            }
        }

        private bool Validation()
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("請輸入姓名", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(textBoxChi.Text))
            {
                MessageBox.Show("請輸入國文成績", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(textBoxEng.Text))
            {
                MessageBox.Show("請輸入英文成績", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(textBoxMath.Text))
            {
                MessageBox.Show("請輸入數學成績", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }


        //宣告一個陣列存放三個科目的名稱:
        string[] arrSubjects = new string[3];
        void AddScore()
        {
            //計算總分
            decimal TotalScore;
            TotalScore = int.Parse(textBoxChi.Text) + int.Parse(textBoxEng.Text) + int.Parse(textBoxMath.Text);
            //計算平均
            decimal Average = TotalScore / 3;
            decimal MRAverage = Math.Round(Average, 1); //保留小數點第1位，不四捨五入

            //給陣列指定值
            arr[0] = textBoxName.Text; //姓名
            arr[1] = textBoxChi.Text; //國文成績
            arr[2] = textBoxEng.Text; //英文成績
            arr[3] = textBoxMath.Text; //數學成績
            arr[4] = TotalScore.ToString(); //總分
            arr[5] = MRAverage.ToString(); //平均

            //抓取最高分數跟最低分數
            //建立分數的陣列
            float[] OnlyScore = new float[3]; //這裡要記得是float......不能用int
            OnlyScore[0] = Score.Chinese;
            OnlyScore[1] = Score.English;
            OnlyScore[2] = Score.Math;

            //宣告一個陣列存放三個科目的名稱:
            arrSubjects[0] = "國文";//國文
            arrSubjects[1] = "英文";//英文
            arrSubjects[2] = "數學";//數學


            float MaxScore = OnlyScore.Max(); //最高分
            int maxIndex = Array.IndexOf(OnlyScore, MaxScore); //獲取最高分在第幾陣列

            float MinScore = OnlyScore.Min(); //最低分
            int minIndex = Array.IndexOf(OnlyScore, MinScore); //獲取最低分在第幾陣列

            //丟給arr陣列裡
            arr[6] = arrSubjects[maxIndex] + MaxScore.ToString(); //最高分
            arr[7] = arrSubjects[minIndex] + MinScore.ToString(); //最低分
            //放入listView
            ListViewItem item;
            item = new ListViewItem(arr);
            listView.Items.Add(item);
        }

        string[] row = new string[8]; //建立新的string array
        public decimal CountNum; //array length
        Random myObject1 = new Random(); //產生隨機數字

        private void randomScore_Click(object sender, EventArgs e)
        {
            AppendArray();
            BtnSubjectCount.Enabled = true;
        }

        private void btnRandomTwenty_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                AppendArray();
            }
            BtnSubjectCount.Enabled = true;
        }

        void AppendArray()
        {
            for (int i = 0; i <= listView.Items.Count; i++)
            {
                //抓到目前陣列的數量
                CountNum = listView.Items.Count + 1;
                row[0] = CountNum.ToString();
            }

            //產生隨機數字
            int ranNum1 = myObject1.Next(0, 100);
            row[1] = ranNum1.ToString();

            int ranNum2 = myObject1.Next(0, 100);
            row[2] = ranNum2.ToString();

            int ranNum3 = myObject1.Next(0, 100);
            row[3] = ranNum3.ToString();

            //計算隨機產生的總分
            decimal ranTotalScore;
            ranTotalScore = ranNum1 + ranNum2 + ranNum3;

            row[4] = ranTotalScore.ToString();

            //計算平均
            decimal ranAverage = ranTotalScore / 3;
            decimal ranAverage1 = Math.Round(ranAverage, 1); //保留小數點第1位，不四捨五入
            row[5] = ranAverage1.ToString();

            //抓取最高分數跟最低分數
            //建立分數的陣列
            float[] RanScore = new float[3]; //這裡要記得是float......不能用int
            RanScore[0] = ranNum1;
            RanScore[1] = ranNum2;
            RanScore[2] = ranNum3;

            //宣告一個陣列存放三個科目的名稱:
            arrSubjects[0] = "國文";//國文
            arrSubjects[1] = "英文";//英文
            arrSubjects[2] = "數學";//數學

            float MaxScore = RanScore.Max(); //最高分
            int maxIndex = Array.IndexOf(RanScore, MaxScore); //獲取最高分在第幾陣列

            float MinScore = RanScore.Min(); //最低分
            int minIndex = Array.IndexOf(RanScore, MinScore); //獲取最低分在第幾陣列

            //丟給arr陣列裡
            row[6] = arrSubjects[maxIndex] + MaxScore.ToString(); //最高分
            row[7] = arrSubjects[minIndex] + MinScore.ToString(); //最低分

            //放入listView
            var listViewItem = new ListViewItem(row);
            listView.Items.Add(listViewItem);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            listView.Items.Clear(); //清掉listView的內容
            StatisticlistView.Items.Clear(); //清掉StatisticlistView的內容
            BtnSubjectCount.Enabled = false;  //各科統計按鈕要變回false不能按

            //抓到場上所有的控制項，以其進行true
            foreach (Control item in this.Controls)
            {
                if (item.Name != "BtnSubjectCount")
                {
                    item.Enabled = true;
                }
            }
        }

        //宣告一個陣列存放三個科目的名稱:
        string[] Statistic1 = new string[4];
        string[] Statistic2 = new string[4];
        string[] Statistic3 = new string[4];
        string[] Statistic4 = new string[4];
        int ChiTotalScore = 0; //國文總分
        int EngTotalScore = 0; //英文總分
        int MathTotalScore = 0; //數學總分

        private void BtnSubjectCount_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView.Items.Count; i++)
            {
                //抓到column的國文成績，做加總
                string ChiCloumnValue = listView.Items[i].SubItems[1].Text;
                ChiTotalScore += int.Parse(ChiCloumnValue);
                //抓到column的英文成績，做加總
                string EngCloumnValue = listView.Items[i].SubItems[2].Text;
                EngTotalScore += int.Parse(EngCloumnValue);
                //抓到column的數學成績，做加總
                string MathCloumnValue = listView.Items[i].SubItems[3].Text;
                MathTotalScore += int.Parse(MathCloumnValue);
            }

            //-------------------------------所有科目成績總分區塊
            Statistic1[0] = "總分";
            //總分區塊-國文
            Statistic1[1] = ChiTotalScore.ToString();
            //總分區塊-英文
            Statistic1[2] = EngTotalScore.ToString();
            //總分區塊-數學
            Statistic1[3] = MathTotalScore.ToString();
            //-------------------------------所有科目成績總分區塊


            //-------------------------------所有科目成績平均區塊
            Statistic2[0] = "平均";
            //平均區塊-國文
            decimal AverageChi = ChiTotalScore / CountNum;
            decimal ChiAverage = Math.Round(AverageChi, 1); //保留小數點第1位，不四捨五入
            Statistic2[1] = ChiAverage.ToString();
            //平均區塊-英文
            decimal AverageEng = EngTotalScore / CountNum;
            decimal EngAverage = Math.Round(AverageEng, 1); //保留小數點第1位，不四捨五入
            Statistic2[2] = EngAverage.ToString();
            //平均區塊-數學
            decimal AverageMath = MathTotalScore / CountNum;
            decimal MathAverage = Math.Round(AverageMath, 1); //保留小數點第1位，不四捨五入
            Statistic2[3] = MathAverage.ToString();
            //-------------------------------所有科目成績平均區塊

            //-------------------------------所有科目成績最高分區塊
            Statistic3[0] = "最高分";
            //得到國文最高分->LINQ
            var AllChiScoreMax = listView.Items.Cast<ListViewItem>().Max(x => int.Parse(x.SubItems[1].Text));
            Statistic3[1] = AllChiScoreMax.ToString();

            //得到英文最高分->LINQ
            var AllEngScoreMax = listView.Items.Cast<ListViewItem>().Max(x => int.Parse(x.SubItems[2].Text));
            Statistic3[2] = AllEngScoreMax.ToString();

            //得到數學最高分->LINQ
            var AllMathScoreMax = listView.Items.Cast<ListViewItem>().Max(x => int.Parse(x.SubItems[3].Text));
            Statistic3[3] = AllMathScoreMax.ToString();
            //-------------------------------所有科目成績最高分區塊


            //-------------------------------所有科目成績最低分區塊
            Statistic4[0] = "最低分";
            //得到國文最低分->LINQ
            var AllChiScoreMin = listView.Items.Cast<ListViewItem>().Min(x => int.Parse(x.SubItems[1].Text));
            Statistic4[1] = AllChiScoreMin.ToString();

            //得到英文最低分->LINQ
            var AllEngScoreMin = listView.Items.Cast<ListViewItem>().Min(x => int.Parse(x.SubItems[2].Text));
            Statistic4[2] = AllEngScoreMin.ToString();

            //得到數學最低分->LINQ
            var AllMathScoreMin = listView.Items.Cast<ListViewItem>().Min(x => int.Parse(x.SubItems[3].Text));
            Statistic4[3] = AllMathScoreMin.ToString();
            //-------------------------------所有科目成績最低分區塊

            var listViewItem = new ListViewItem(Statistic1);
            StatisticlistView.Items.Add(listViewItem);

            var listViewItem2 = new ListViewItem(Statistic2);
            StatisticlistView.Items.Add(listViewItem2);

            var listViewItem3 = new ListViewItem(Statistic3);
            StatisticlistView.Items.Add(listViewItem3);

            var listViewItem4 = new ListViewItem(Statistic4);
            StatisticlistView.Items.Add(listViewItem4);

            //抓到場上所有的控制項，以其進行false
            foreach (Control item in this.Controls)
            {
                if (item.Name != "btnReset" && item.Name != "listView")
                {
                    item.Enabled = false;
                }
            }
        }
    }
}
