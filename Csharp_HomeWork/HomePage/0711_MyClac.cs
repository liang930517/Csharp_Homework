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
    public partial class _0711_MyClac : Form
    {
        public _0711_MyClac()
        {
            InitializeComponent();
        }

        private void btnAddUp_Click(object sender, EventArgs e)
        {
            CheckType("add");
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            CheckType("subtract");
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            CheckType("multiply");
        }

        private void btnDivided_Click(object sender, EventArgs e)
        {
            CheckType("divided");
        }

        void CheckType(string type)
        {
            //object textBoxResults = new System.Windows.Forms.TextBox();
            string num1 = textBoxNum1.Text;
            string num2 = textBoxNum2.Text;

            if (num1 == "" || num2 == "")
            {
                MessageBox.Show("請輸入數值");
            }
            else
            {
                try
                {
                    switch (type)
                    {
                        case "add":
                            int totalNumberAdd = int.Parse(textBoxNum1.Text) + int.Parse(textBoxNum2.Text);
                            textBoxAns.Text = totalNumberAdd.ToString();
                            break;
                        case "subtract":
                            int totalNumberSubtract = int.Parse(textBoxNum1.Text) - int.Parse(textBoxNum2.Text);
                            textBoxAns.Text = totalNumberSubtract.ToString();
                            break;
                        case "multiply":
                            int totalNumberMultiply = int.Parse(textBoxNum1.Text) * int.Parse(textBoxNum2.Text);
                            textBoxAns.Text = totalNumberMultiply.ToString();
                            break;
                        case "divided":
                            int totalNumberDivided = int.Parse(textBoxNum1.Text) / int.Parse(textBoxNum2.Text);
                            textBoxAns.Text = totalNumberDivided.ToString();
                            break;
                    }
                }
                catch
                {
                    MessageBox.Show("請輸入數值");
                }
            }
        }
    }
}
