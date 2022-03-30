using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson1
{
    public partial class Form1 : Form
    {
        private Int32 cnt,cntSur;
        public Form1()
        {
            InitializeComponent();
            cnt = 0;
            cntSur = 0;
        }

        private void buttonTrap_Click(object sender, EventArgs e)
        {
            cnt++;
            labelDemo.Text = $"Oh no, you will be eaten by SuperBattleSharkX228 {cnt} times!!1!!1";
            listBoxDemo.Items.Add($"You pressed button {cnt} times");
        }
         

        private void checkBoxDemo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDemo.Checked)
            {
                checkBoxDemo.ForeColor = Color.Red;
            }
            else
            {
                checkBoxDemo.ForeColor = Color.Green; 
            }
                cntSur++;
            listBoxDemo.Items.Add($"You survived {cntSur} times!!!");

        }
        private void textBoxDemo_CheckedChanged(object sender, EventArgs e)
        {
            //labelBox.Text = textBoxDemo.Text;
        }
    }
    }