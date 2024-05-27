using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRACT_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            domainUpDown1.SelectedIndex = 0;
            domainUpDown2.SelectedIndex = 0;
            domainUpDown3.SelectedIndex = 0;
            domainUpDown4.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fraction d1 = new Fraction(1,
                   Convert.ToInt32(numericUpDown1.Value),
                   Convert.ToInt32(numericUpDown2.Value),
                   Convert.ToInt32(numericUpDown3.Value));
            Fraction d2 = new Fraction(1,
                   Convert.ToInt32(numericUpDown4.Value),
                   Convert.ToInt32(numericUpDown5.Value),
                   Convert.ToInt32(numericUpDown6.Value));
            Fraction d3 =d1.Addition(d2);
            numericUpDown7.Value = d3.integer;
            numericUpDown8.Value = d3.numerator;
            numericUpDown9.Value = d3.denominator;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fraction d1 = new Fraction(1,
                  Convert.ToInt32(numericUpDown7.Value),
                  Convert.ToInt32(numericUpDown8.Value),
                  Convert.ToInt32(numericUpDown9.Value));
            Fraction d2 = d1.Correct_Fraction();
            numericUpDown7.Value = d2.integer;
            numericUpDown8.Value = d2.numerator;
            numericUpDown9.Value = d2.denominator;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Fraction d1 = new Fraction(1,
                 Convert.ToInt32(numericUpDown7.Value),
                 Convert.ToInt32(numericUpDown8.Value),
                 Convert.ToInt32(numericUpDown9.Value));
            Fraction d2 = d1.Shorter_Fraction();
            numericUpDown7.Value = d2.integer;
            numericUpDown8.Value = d2.numerator;
            numericUpDown9.Value = d2.denominator;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Fraction d1 = new Fraction(1,
                 Convert.ToInt32(numericUpDown1.Value),
                  Convert.ToInt32(numericUpDown2.Value),
                   Convert.ToInt32(numericUpDown3.Value));
            Fraction d2 = new Fraction(1,
                   Convert.ToInt32(numericUpDown4.Value),
                   Convert.ToInt32(numericUpDown5.Value),
                   Convert.ToInt32(numericUpDown6.Value));
            Fraction d3;
           
            if (domainUpDown2.Text == "+")
            {
                d3 = d1 + d2;
                numericUpDown7.Value= d3.integer;
                numericUpDown8.Value= d3.numerator;
                numericUpDown9.Value= d3.denominator;
            }
            else if (domainUpDown2.Text == "-")
            {
                d3 = d1 - d2;
                numericUpDown7.Value = d3.integer;
                numericUpDown8.Value = d3.numerator;
                numericUpDown9.Value= d3.denominator;
            }
            else if(domainUpDown2.Text == "*")
            {
                d3 = d1 * d2;
                numericUpDown7.Value = d3.integer;
                numericUpDown8.Value = d3.numerator;
                numericUpDown9.Value= d3.denominator;
            }
            else if (domainUpDown2.Text == "/")
            {
                d3 = d1 / d2;
                numericUpDown7.Value = d3.integer;
                numericUpDown8.Value = d3.numerator;
                numericUpDown9.Value= d3.denominator;
            }
        }

        private void domainUpDown2_SelectedItemChanged(object sender, EventArgs e)
        {

        }
    }
    
}
