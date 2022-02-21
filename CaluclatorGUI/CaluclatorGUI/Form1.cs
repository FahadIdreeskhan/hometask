using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CaluclatorGUI
{
    public partial class Calculator : Form
    {
        //global variables

        string sign;

        double val1;

        double val2;

        int trackkeypoint=0;

        public Calculator()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + cmd7.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            double v;
            if (txtbox.Text.Length <= 0) return;
            v = double.Parse(txtbox.Text);
            txtbox.Text = Math.Sin(v).ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            sign = "/";
            if (txtbox.Text.Length <= 0) return;
            val1 = double.Parse(txtbox.Text);
            txtbox.Text = ""; 
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmd0_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + cmd0.Text;
        }

        private void cmd1_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + cmd1.Text;
        }

        private void cmd2_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + cmd2.Text;
        }

        private void cmd3_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + cmd3.Text;
        }

        private void cmd4_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + cmd4.Text;
        }

        private void cmd5_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + cmd5.Text;
        }

        private void cmd6_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + cmd6.Text;
        }

        private void cmd8_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + cmd8.Text;
        }

        private void cmd9_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text + cmd9.Text;
        }

        private void cmdequal_Click(object sender, EventArgs e)
        {
            if (txtbox.Text.Length <= 0) return;
            val2 = double.Parse(txtbox.Text);

            double result;

            if (sign == "+")
            {

                result = val1 + val2;

                txtbox.Text = result.ToString();

            }

            else if (sign == "-")
            {

                result = val1 - val2;

                txtbox.Text = result.ToString();

            }

            else if (sign == "*")
            {

                result = val1 * val2;

                txtbox.Text = result.ToString();

            }

            else
            {

                result = val1 / val2;

                txtbox.Text = result.ToString();

            }
        }

        private void cmdclear_Click(object sender, EventArgs e)
        {
            //clear Texts

            txtbox.Text = "";

            val1 = 0;

            val2 = 0;

            sign = "";
        }

        private void cmdcos_Click(object sender, EventArgs e)
        {
            double v;
            if (txtbox.Text.Length <= 0) return;
            v = double.Parse(txtbox.Text);
            txtbox.Text = Math.Cos(v).ToString();
        }

        private void cmdsquare_Click(object sender, EventArgs e)
        {
            double v;
            if (txtbox.Text.Length <= 0) return;
            v = double.Parse(txtbox.Text);
            txtbox.Text = Math.Pow(v, 2).ToString();
        }

        private void cmdsqrt_Click(object sender, EventArgs e)
        {
            double v;
            if (txtbox.Text.Length <= 0) return;
            v = double.Parse(txtbox.Text);
            txtbox.Text = Math.Sqrt(v).ToString();
        }

        private void cmdtan_Click(object sender, EventArgs e)
        {
            double v;
            if (txtbox.Text.Length <= 0) return;
            v = double.Parse(txtbox.Text);
            txtbox.Text = Math.Tan(v).ToString();
        }

        private void buttonsubtract_Click(object sender, EventArgs e)
        {
            sign = "-";
            if (txtbox.Text.Length <= 0) return;
            val1 = double.Parse(txtbox.Text);
            txtbox.Text = "";
        }

        private void cmdplus_Click(object sender, EventArgs e)
        {
            sign = "+";
            if (txtbox.Text.Length <= 0) return;
            val1 = double.Parse(txtbox.Text);
            txtbox.Text = "";
        }

        private void cmdmultiply_Click(object sender, EventArgs e)
        {
            sign = "*";
            if (txtbox.Text.Length <= 0) return;
            val1 = double.Parse(txtbox.Text);
            txtbox.Text = "";
        }

        private void txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keycode;
            keycode = e.KeyChar;
            //accept only number from key 0 to key 9, key back, and key dot

            if (keycode >= 48 && keycode <= 57 || keycode == 8 || keycode == 32 || keycode == 46)
            {

                //key dot allowed only one time

                if (keycode == 46) ++trackkeypoint;

                if (trackkeypoint > 1) { e.Handled = true; --trackkeypoint; }

            }

            else e.Handled = true;
        }

       
    }
}
