using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BarPOS.WineTable;

namespace HomePage
{
    public partial class _0705_POS : Form
    {
        public _0705_POS()
        {
            InitializeComponent();
        }

        //先建立實作
        Products Beer = new Products() { Name = "Beer", Price = 120, Amount = 0, TotalPrice = 0 };
        Products Mojito = new Products() { Name = "Mojito", Price = 180, Amount = 0, TotalPrice = 0 };
        Products Whisky = new Products() { Name = "Whisky", Price = 380, Amount = 0, TotalPrice = 0 };
        Products Champagne = new Products() { Name = "Champagne", Price = 320, Amount = 0, TotalPrice = 0 };

        //建立按鈕事件
        private void Products_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            //因為傳進來 object sender不知道自己是什麼，所以要用這個寫法去抓buuton的(Name)
            switch (clickedButton.Name)
            {
                case "btnBeer":
                    Beer.Amount++; //總瓶數
                    Beer.TotalPrice += Beer.Price; //總金額
                    break;
                case "btnMojito":
                    Mojito.Amount++; //總瓶數
                    Mojito.TotalPrice += Mojito.Price; //總金額
                    break;
                case "btnWhisky":
                    Whisky.Amount++; //總瓶數
                    Whisky.TotalPrice += Whisky.Price; //總金額
                    break;
                case "btnChampagne":
                    Champagne.Amount++; //總瓶數
                    Champagne.TotalPrice += Champagne.Price; //總金額
                    break;
            }
            Display(); //顯示到購物清單事件
        }


        private void Display()
        {
            ShopList.Text = ""; //因為預設為尚未點餐，所以每次有東西就要reset掉
            int price = Beer.TotalPrice + Mojito.TotalPrice + Whisky.TotalPrice + Champagne.TotalPrice;  //計算總金額
            totalPrice.Text = price.ToString(); //將總金額秀在 totalPrice 裡面

            //判斷每個商品的數量是否不是0，而當不是時每次都增加1，不會洗掉文字跟往下疊加
            if (Beer.Amount != 0)
            {
                ShopList.Text += "啤酒Beer x" + Beer.Amount + "，共NT$" + Beer.TotalPrice + "\n";
            }
            if (Mojito.Amount != 0)
            {
                ShopList.Text += "莫西多Mojito x" + Mojito.Amount + "，共NT$" + Mojito.TotalPrice + "\n";
            }
            if (Whisky.Amount != 0)
            {
                ShopList.Text += "威士忌Whisky x" + Whisky.Amount + "，共NT$" + Whisky.TotalPrice + "\n";
            }
            if (Champagne.Amount != 0)
            {
                ShopList.Text += "香檳Champagne x" + Champagne.Amount + "，共NT$" + Champagne.TotalPrice + "\n";
            }
        }

        private void PayforCash_Click(object sender, EventArgs e)
        {
            if (totalPrice.Text == "0" || totalPrice.Text == "")
            {
                MessageBox.Show("尚未點餐！", "確認付款", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("總金額：NT$" + totalPrice.Text, "確認付款", MessageBoxButtons.OKCancel);
            }
        }

        private void PayforCard_Click(object sender, EventArgs e)
        {
            if (totalPrice.Text == "0" || totalPrice.Text == "")
            {
                MessageBox.Show("尚未點餐！", "確認付款", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("總金額：NT$" + totalPrice.Text + "\r\n折扣後金額：NT$" + int.Parse(totalPrice.Text) * 0.9, "確認付款", MessageBoxButtons.OKCancel);
            }
        }

        private void cleanShopList_Click(object sender, EventArgs e)
        {
            if (ShopList.Text != "")
            {
                DialogResult result = MessageBox.Show("您確定要清除內容嗎？", "清除清單", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    totalPrice.Text = 0.ToString(); //reset 總金額
                    ShopList.Text = "尚未點餐"; //rest 購物清單

                    //將實作裡的 Products 項目 reset 掉，清除後再點擊才能重新計算
                    Beer = new Products() { Name = "Beer", Price = 120, Amount = 0, TotalPrice = 0 };
                    Mojito = new Products() { Name = "Mojito", Price = 180, Amount = 0, TotalPrice = 0 };
                    Whisky = new Products() { Name = "Whisky", Price = 380, Amount = 0, TotalPrice = 0 };
                    Champagne = new Products() { Name = "Champagne", Price = 320, Amount = 0, TotalPrice = 0 };
                }
                else
                {
                    return;
                }
            }
        }
    }


    
}
