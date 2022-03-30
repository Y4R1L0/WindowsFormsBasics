using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson1.Forms
{
    public partial class CalcForm : Form
    {
        Int32 lim = 9;
        Double a, b;
        public CalcForm()
        {
            InitializeComponent();
        }

        private void CalcForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonDigit_Click(object sender, EventArgs e)
        {
            var ClickedButton = sender as Button;
            if (textBox1.Text.Contains('-') || textBox1.Text.Contains('.')) lim = 10;
            else lim = 9;
            if (textBox1.Text.Contains('-') && textBox1.Text.Contains('.')) lim = 11;
            else lim = 9;
            if (textBox1.Text.Length>=lim)return;
                //if (ClickedButton == null) return;
                if (textBox1.Text.Equals("0")) textBox1.Text = ClickedButton.Text;
                else textBox1.Text += ClickedButton.Text;

        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString('0');
            labelStory.Text=null;
        }
        private void buttonDigitErase_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 1)
            {
                Double length = textBox1.Text.Length - 1;
                String text = textBox1.Text;
                textBox1.Clear();
                for (int i = 0; i < length; i++)
                {
                    textBox1.Text = textBox1.Text + text[i];
                }
            }
            else if (textBox1.Text.Length == 1) {
                textBox1.Text = Convert.ToString('0');
            }
        }

        private void buttonPlusMinus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("0")) return;
            else
            {
                Double otr = Convert.ToDouble(textBox1.Text);
                otr *= -1;
                textBox1.Text = Convert.ToString(otr);
                return;
            }
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString('0');
        }


        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < lim)
            {
                if (textBox1.Text.Contains(".")) return;
                else textBox1.Text += ".";
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            labelStory.Text = (Convert.ToString(a) + '+'); 
            textBox1.Text = Convert.ToString('0');
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            labelStory.Text = (Convert.ToString(a) + '-');
            textBox1.Text = Convert.ToString('0');
        }

        private void buttonGen_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            labelStory.Text = (Convert.ToString(a) + '*');
            textBox1.Text = Convert.ToString('0');
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            labelStory.Text = (Convert.ToString(a) + '/');
            textBox1.Text = Convert.ToString('0');
        }
        private void buttonEqual_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < lim)
            {
                b = Convert.ToDouble(textBox1.Text);
                if (labelStory.Text.Contains('+'))
                {
                    textBox1.Text = Convert.ToString(a + b);
                    labelStory.Text += Convert.ToString(b);
                }
                if (labelStory.Text.Contains('-'))
                {
                    textBox1.Text = Convert.ToString(a - b);
                    labelStory.Text += Convert.ToString(b);
                }
                if (labelStory.Text.Contains('*'))
                {
                    textBox1.Text = Convert.ToString(a * b);
                    labelStory.Text += Convert.ToString(b);
                }
                if (labelStory.Text.Contains('/'))
                {
                    textBox1.Text = Convert.ToString(a / b);
                    labelStory.Text += Convert.ToString(b);
                }
            }
        }

    }
}
