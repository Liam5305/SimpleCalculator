using System;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float num1, ans;
        int count;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // 1 Button
        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        // 2 Button
        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }
        // 3 Button
        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }
        // 4 Button
        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }
        // 5 Button
        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }
        // 6 Button
        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }
        // 7 Button
        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }
        // 8 Button
        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }
        // 9 Button
        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }
        // 0 Button
        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }
        // 00 Button
        private void btn00_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0 + 0;
        }
        // Subtract Button
        private void btnSubtract_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                num1 = float.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                count = 1;
            }
        }
        // Add Button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 2;
        }
        // Multiply Button
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 3;
        }
        // Divide Button
        private void btnDivide_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 4;
        }
        // Calculation Button and method
        private void btnEquals_Click(object sender, EventArgs e)
        {
            compute(count);
        }
        public void compute(int count)
        {
            switch (count)
            {
                case 1:
                    ans = num1 - float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 2:
                    ans = num1 += float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 3:
                    ans = num1 * float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 4:
                    ans = num1 / float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                default:
                    break;
            }
        }

        // Delete (C) Button
        private void btnDelete_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            count = 0;
        }
        // Decimal Point Button
        private void btnDecimal_Click(object sender, EventArgs e)
        {
            int c = textBox1.TextLength;
            int flag = 0;
            string text = textBox1.Text;
            for (int i = 0; i < c; i++)
            {
                if (text[i].ToString() == ".")
                {
                    flag = 1; break;
                }
                else
                {
                    flag = 0;
                }
            }
            if (flag == 0)
            {
                textBox1.Text = textBox1.Text + ".";
            }
        }
    }
}
