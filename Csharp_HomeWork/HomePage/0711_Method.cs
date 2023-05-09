using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace HomePage
{
    public partial class _0711_Method : Form
    {
        public _0711_Method()
        {
            InitializeComponent();
            button8.Text = "[10, 10] 二維陣列" + Environment.NewLine + "101010" + Environment.NewLine + "010101" + Environment.NewLine + "..........";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txtnum = TxtBoxNumber.Text;
            int age = 0;
            bool isNum = int.TryParse(txtnum, out age);
            if (isNum)
            {
                ResultBox.Text = int.Parse(TxtBoxNumber.Text) % 2 == 0 ? "您輸入的數值 " + TxtBoxNumber.Text + " 為偶數" : "您輸入的數值 " + TxtBoxNumber.Text + " 為奇數";
            }
            else
            {
                MessageBox.Show("請輸入整數");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ResultBox.Text = "結果";
        }

        private void BtnArrMaxMin_Click_1(object sender, EventArgs e)
        {
            int[] arr0711 = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            string arr0711Max = arr0711.Max().ToString();
            string arr0711Min = arr0711.Min().ToString();
            ResultBox.Text = "int陣列arr0711[1, 5, 6, 8, 7, 97, 54, 887, 65, 578]\n最大值為" + arr0711Max + "\n最小值" + arr0711Min;
        }

        private void BtnArrCheck_Click(object sender, EventArgs e)
        {
            string[] arr0711_Str = { "mother張", "emma", "迪克蕭", "J40", "Candy", "Cindy", "Coconut", "Motherfucker" };

            int resultnum = 0;
            int resultnum1 = 0;
            foreach (string item in arr0711_Str)
            {
                if (Regex.IsMatch(item, "C"))
                {
                    resultnum++;
                }

                if (Regex.IsMatch(item, "c") && item.Substring(0, 1) == "C")
                {
                    resultnum1++;
                }
            }
            int total = resultnum + resultnum1;
            ResultBox.Text = "arr0711_Str陣列：mother張　emma　迪克蕭　J40　Candy　Cindy　Coconut　Motherfucker\n有 C 及 c 的名字共有" + total + "個";
        }

        private void BtnTotalOddEven_Click(object sender, EventArgs e)
        {
            int Even = 0; //偶數
            int Odd = 0; //奇數
            int[] arr0711 = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            foreach (int item in arr0711)
            {
                if (item % 2 == 0)
                {
                    Even++;
                }
                if (item % 2 != 0)
                {
                    Odd++;
                }
            }
            ResultBox.Text = "int陣列arr0711[1, 5, 6, 8, 7, 97, 54, 887, 65, 578]\n奇數共" + Odd + "個\n" + "偶數共" + Even + "個";
        }

        private void BtnStringLong_Click(object sender, EventArgs e)
        {
            string[] arr0711_Str = { "mother張", "emma", "迪克蕭", "J40", "Candy", "Cindy", "Coconut", "Motherfucker" };

            foreach (string item in arr0711_Str)
            {
            }
            int maxLength = arr0711_Str.Max(y => y.Length);
            string longestName = arr0711_Str.FirstOrDefault(x => x.Length == maxLength);

            ResultBox.Text = "arr0711_Str陣列：mother張　emma　迪克蕭　J40　Candy　Cindy　Coconut　Motherfucker\n最長的名字為：" + longestName + "；長度為：" + maxLength;
        }

        private void Btn2DArray1_Click(object sender, EventArgs e)
        {
            int[,] array2D = new int[,] {
                { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
               { 1,  1, 1, 1, 1, 1, 1, 1, 1, 1  }
            };

            string result = "";
            for (int i = 0; i < 10; i++)
            {
                for (int k = 0; k < 10; k++)
                {
                    result += array2D[i, k].ToString();
                    result += " ";
                }
                result += "\n";
            }
            ResultBox.Text = result;
        }

        private void Btn2DArray2_Click(object sender, EventArgs e)
        {
            int[,] array2D = new int[,] {
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 1, 1, 1, 1, 1, 1, 1, 1, 0 },
                { 0, 1, 1, 1, 1, 1, 1, 1, 1, 0 },
                 { 0, 1, 1, 1, 1, 1, 1, 1, 1, 0 },
                 { 0, 1, 1, 1, 1, 1, 1, 1, 1, 0 },
                 { 0, 1, 1, 1, 1, 1, 1, 1, 1, 0 },
                 { 0, 1, 1, 1, 1, 1, 1, 1, 1, 0 },
                 { 0, 1, 1, 1, 1, 1, 1, 1, 1, 0 },
                 { 0, 1, 1, 1, 1, 1, 1, 1, 1, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            };

            string result = "";
            for (int i = 0; i < 10; i++)
            {
                for (int k = 0; k < 10; k++)
                {
                    result += array2D[i, k].ToString();
                    result += " ";
                }
                result += "\n";
            }
            ResultBox.Text = result;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int[,] array2D = new int[,] {
                { 1, 0, 1, 0, 1, 0, 1, 0, 1, 0 },
                { 0, 1, 0, 1, 0, 1, 0, 1, 0, 1 },
                { 1, 0, 1, 0, 1, 0, 1, 0, 1, 0 },
                  { 0, 1, 0, 1, 0, 1, 0, 1, 0, 1 },
                  { 1, 0, 1, 0, 1, 0, 1, 0, 1, 0 },
                 { 0, 1, 0, 1, 0, 1, 0, 1, 0, 1 },
                  { 1, 0, 1, 0, 1, 0, 1, 0, 1, 0 },
                  { 0, 1, 0, 1, 0, 1, 0, 1, 0, 1 },
                 { 1, 0, 1, 0, 1, 0, 1, 0, 1, 0 },
                 { 0, 1, 0, 1, 0, 1, 0, 1, 0, 1 },
            };

            string result = "";
            for (int i = 0; i < 10; i++)
            {
                for (int k = 0; k < 10; k++)
                {
                    result += array2D[i, k].ToString();
                    result += " ";
                }
                result += "\n";
            }
            ResultBox.Text = result;
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            int n1 = 100;
            int n2 = 200;
            ResultBox.Text = "換位前n1=" + n1 + ", n2=" + n2 + "\n";
            (n1, n2) = (n2, n1);
            ResultBox.Text += "換位後n1=" + n1 + ", n2=" + n2;
        }

        private void BtnArraySum_Click(object sender, EventArgs e)
        {
            int[] arr0711 = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            string arr0711Sum = arr0711.Sum().ToString();
            ResultBox.Text = "int陣列arr0711[1, 5, 6, 8, 7, 97, 54, 887, 65, 578]\n加總為：" + arr0711Sum;
        }

        private void BtnArr0711Max_Click(object sender, EventArgs e)
        {
            int[] arr0711 = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            string arr0711Max = arr0711.Max().ToString();
            ResultBox.Text = "int陣列arr0711[1, 5, 6, 8, 7, 97, 54, 887, 65, 578]\n最大值為：" + arr0711Max;
        }

        private void BtnArr0711Min_Click(object sender, EventArgs e)
        {
            int[] arr0711 = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            string arr0711Min = arr0711.Min().ToString();
            ResultBox.Text = "int陣列arr0711[1, 5, 6, 8, 7, 97, 54, 887, 65, 578]\n最小值為：" + arr0711Min;
        }
    }
}