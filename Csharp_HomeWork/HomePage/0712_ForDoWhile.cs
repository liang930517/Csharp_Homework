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
    public partial class _0712_ForDoWhile : Form
    {
        public _0712_ForDoWhile()
        {
            InitializeComponent();
        }

        private void BtnXmasTree_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxXmasTree.Text))
            {
                MessageBox.Show("請輸入數值");
                return;
            }

            string SetNumber = TextBoxXmasTree.Text;
            int Target = int.Parse(SetNumber);

            int addup = 1;
            string result = "";
            for (int i = 0; i < Target; i++) //輸入的數值
            {
                for (int k = 0; k < addup; k++)
                {
                    result += "✭";
                }
                result += "\n";
                addup++;
            }
            ResultBox.Text = result;
        }

        private void ForBtn_Click(object sender, EventArgs e)
        {
            int result = 0;
            int from = int.Parse(FromTextBox.Text);
            int to = int.Parse(ToTextBox.Text);
            int step = int.Parse(StepTextBox.Text);
            //int range = 0;

            //if (step > from) {
            //    range = step - from;
            //}

            for (int i = from; i <= to; i += step)
            {
                result += i;
                //MessageBox.Show("............" + i);
            }
            ResultBox.Text = from + " 到 " + to + " 相隔 " + "\n" + "加總為 " + result;
        }

        private void WhileBtn_Click(object sender, EventArgs e)
        {
            int result = 0;
            int from = int.Parse(FromTextBox.Text);
            int to = int.Parse(ToTextBox.Text);
            int step = int.Parse(StepTextBox.Text);
            //int range = to / from;

            int num = from;
            while (num < to)
            {
                num += step;
                result = num;
                //MessageBox.Show("............" + num);
            }
            num = from;
            //result += from;
            ResultBox.Text = from + " 到 " + to + " 相隔 " + "\n" + "加總為 " + result;
        }

        private void DoBtn_Click(object sender, EventArgs e)
        {

            int result = 0;
            int from = int.Parse(FromTextBox.Text);
            int to = int.Parse(ToTextBox.Text);
            int step = int.Parse(StepTextBox.Text);
            //int range = step - from;

            int num = from;
            //for (int i = from; i <= to; i += step)
            do
            {
                if (from < to)
                {
                    num += step;
                }
                num = from;
            } while (from < to);
            result = num;
            ResultBox.Text = from + " 到 " + to + " 相隔 " + "\n" + "加總為 " + result;
        }

        private void BtnMultTable_Click(object sender, EventArgs e)
        {
            string result = "";
            for (int i = 1; i < 10; i += 1)
            {
                for (int a = 2; a < 10; a++)
                {
                    int total = i * a;
                    if (total.ToString().Length == 2)
                    {
                        result += "  " + a + "x " + i + "=" + i * a + "｜";
                    }
                    else
                    {
                        result += "  " + a + "x " + i + "= " + i * a + "  |  ";
                    }
                    //result += a + "x" + i + "=" + i * a + " | \n";
                }
                result += "\n";
            }
            ResultBox.Text = "九九乘法表\n" + result;
        }

        private void BtnBinary_Click(object sender, EventArgs e)
        {
            string val = "100";
            int from = 10;
            int to = 2;

            string result = Convert.ToString(Convert.ToInt32(val, from), to);
            ResultBox.Text = result;
        }

        private void BtnLotto_Click(object sender, EventArgs e)
        {
            string[] row = new string[6]; //建立新的string array
            Random RanNum = new Random(); //產生隨機數字
            for (int i = 0; i < row.Length; i++)
            {
                int ranNum1 = RanNum.Next(1, 49); //樂透數字為1~49
                row[i] = ranNum1.ToString();
            }
            ResultBox.Text = "樂透號碼\n" + string.Join("　", row);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ResultBox.Text = "結果";
        }
    }
}
