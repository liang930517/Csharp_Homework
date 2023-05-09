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
    public partial class Guess : Form
    {
        public Guess()
        {
            InitializeComponent();
        }

        int answer = new Random().Next(1, 100);
        int from = 1;
        int to = 100;

        public static DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Font = new Font("Arial", 15, FontStyle.Bold);
            label.Text = promptText;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(36, 36, 372, 13);
            textBox.SetBounds(36, 86, 300, 20);

            buttonOk.SetBounds(80, 130, 100, 30);
            buttonCancel.SetBounds(200, 130, 100, 30);

            label.AutoSize = true;
            form.ClientSize = new Size(400, 200);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;


            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }

        private void dialogButton_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(answer);
            string value = "";
            if (InputBox("Guess Number", "please input a number", ref value) == DialogResult.OK)
            {
                
                bool isNum = int.TryParse(value, out int age);

                if (isNum)
                {
                    int user = int.Parse(value);

                    if (user < answer)
                    {
                        from = user;
                        labelTitle.Text = "Too Small!!!!\nBetween " + from + " And " + to;
                    }
                    else if (user == answer)
                    {
                        MessageBox.Show("Bingo!!! You got " + answer);
                    }
                    else if (user > answer)
                    {
                        to = user;
                        labelTitle.Text = "Too Large!!!!\nBetween " + from + " And " + to;
                    }
                }
                else
                {
                    MessageBox.Show("請輸入 1~100 之間的數字");
                    return;
                }
            }
        }

        private void BtnShowAns_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Answer：" + answer);
        }
    }
}
