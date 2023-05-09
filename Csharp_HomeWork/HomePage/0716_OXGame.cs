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
    public partial class _0716_OXGame : Form
    {
        public _0716_OXGame()
        {
            InitializeComponent();
        }

        bool turn = true; //true = X 的回合；false = Y 的回合
        int TurnCount = 0;

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("這是一個 Tic-Tac-Toe 遊戲，\n只要有三個相同的 X 或 O 連成「垂直」、「水平、「對角」線即勝利。", "遊戲說明");
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); //退出遊戲/結束應用程式
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "O";
            }
            turn = !turn;
            b.Enabled = false;
            TurnCount++;

            CheckWinner();
        }

        private void CheckWinner()
        {
            bool IsWinner = false;

            //水平檢查
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
            {
                IsWinner = true;
            }
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
            {
                IsWinner = true;
            }
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
            {
                IsWinner = true;
            }

            //垂直檢查
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
            {
                IsWinner = true;
            }
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
            {
                IsWinner = true;
            }
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
            {
                IsWinner = true;
            }

            //對角檢查
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
            {
                IsWinner = true;
            }
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
            {
                IsWinner = true;
            }

            if (IsWinner) //有贏家
            {
                DisableBtn();

                string winner = "";
                if (turn)
                {
                    winner = "O player";
                }
                else
                {
                    winner = "X player";
                }
                MessageBox.Show(winner + " Wins！", "比賽結束");
            }
            else
            { //平局 
                if (TurnCount == 9)
                {
                    MessageBox.Show(" 平局！按下確定重新開始遊戲", "比賽結束");
                    NewGame();
                }
            }
        }

        //當有某一方勝利時，禁用所有按鈕
        private void DisableBtn()
        {
            foreach (Control item in this.Controls)
            {
                if (item is Button)
                {
                    item.Enabled = false;
                }
            }

        }

        private void NewGame()
        {
            turn = true; //true = X 的回合；false = Y 的回合
            TurnCount = 0;

            foreach (Control item in this.Controls)
            {
                if (item is Button)
                {
                    item.Enabled = true;
                    item.Text = "";
                }
            }
        }

        private void StartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
        }
    }
}
