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
    public partial class _0704_Loan : Form
    {
        public _0704_Loan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int theFinanced = int.Parse(textBox1.Text);
            int theRate = int.Parse(textBox4.Text);
            int theMonth = int.Parse(textBox3.Text);

            double theAmount = theFinanced / theMonth + 0.5;
            theRate = theRate / 1200;
            double totalInterest = 0;
            for (var i = 0; i < theAmount; i++)
            {
                double theInterest = theFinanced * theRate + 0.5;

                //console.log("----------------");
                //console.log("theInterest   " + theInterest);
                //console.log("theFinanced   " + theFinanced);
                //console.log("theRate   " + theRate);
                //insertLine(theAmount, theInterest);
                //theFinanced = theFinanced - theAmount;
                totalInterest += theInterest;
            }
            MessageBox.Show("............" + totalInterest);
        }
    }
}
