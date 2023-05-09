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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text;
            string EngName = txtEngName.Text;
            string Sex = txtSex.Text;
            string StarSign = txtStarSign.Text;
            MessageBox.Show("Hello，我是" + Name + "\n\r 英文名字是" + EngName + "\n\r 性別是" + Sex + "\n\r 星座是" + StarSign + "\n\r 很高興認識你~");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text;
            string EngName = txtEngName.Text;
            string Sex = txtSex.Text;
            string StarSign = txtStarSign.Text;
            MessageBox.Show("Hi，我是" + Name + "\n\r 英文名字是" + EngName + "\n\r 性別是" + Sex + "\n\r 星座是" + StarSign + "\n\r 很高興認識你~");
        }
    }
}
