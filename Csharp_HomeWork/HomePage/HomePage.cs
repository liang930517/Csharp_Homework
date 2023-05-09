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
    public partial class Form1 : Form
    {

        Form currentForm = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void OpenForm(Form form)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Form Setting --------------
            form.TopLevel = false;
            form.Visible = true;
            splitContainer2.Panel2.Controls.Add(form);
            form.BringToFront();
            //form.SetBounds(500, 0, 850, 500);


            currentForm = form;
            currentForm.Show();

            //f2.Dock = DockStyle.Fill; //滿版
            //f2.Dock = DockStyle.Fill; //滿版
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            OpenForm(f2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _0704_Loan f3 = new _0704_Loan();
            OpenForm(f3);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _0705_POS f4 = new _0705_POS();
            OpenForm(f4);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _0708_Student_StructForm f5 = new _0708_Student_StructForm();
            OpenForm(f5);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _0709_StudentsGrand f6 = new _0709_StudentsGrand();
            OpenForm(f6);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            _0710_StudentsGrand_List f7 = new _0710_StudentsGrand_List();
            OpenForm(f7);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            _0711_Method f8 = new _0711_Method();
            OpenForm(f8);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            _0711_MyClac f9 = new _0711_MyClac();
            OpenForm(f9);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            _0712_ForDoWhile f10 = new _0712_ForDoWhile();
            OpenForm(f10);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            _0716_OXGame f11 = new _0716_OXGame();
            OpenForm(f11);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Guess f12 = new Guess();
            OpenForm(f12);
        }
    }
}
