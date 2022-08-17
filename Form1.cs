using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private string Op;
        private double Op1;
        private double Op2;
        private double result;
        public Form1()
        {
            InitializeComponent();
        }

        private void 机型转换ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 stu=new Form2();
            this.Hide();
            stu.ShowDialog();
            this.Close();
        }

        private void BtNumber1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
            Op1 = System.Convert.ToDouble(textBox1.Text);
        }

        private void BtNumber2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
            Op1 = System.Convert.ToDouble(textBox1.Text);
        }

        private void BtNumber3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
            Op1 = System.Convert.ToDouble(textBox1.Text);
        }

        private void BtNumber4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
            Op1 = System.Convert.ToDouble(textBox1.Text);
        }

        private void BtNumber5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
            Op1 = System.Convert.ToDouble(textBox1.Text);
        }

        private void BtNumber6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
            Op1 = System.Convert.ToDouble(textBox1.Text);
        }

        private void BtNumber7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
            Op1 = System.Convert.ToDouble(textBox1.Text);
        }

        private void BtNumber8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
            Op1 = System.Convert.ToDouble(textBox1.Text);
        }

        private void BtNumber9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
            Op1 = System.Convert.ToDouble(textBox1.Text);
        }

        private void BtNumber0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
            Op1 = System.Convert.ToDouble(textBox1.Text);
        }

        private void BtComma_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.IndexOf(".")<0)
                textBox1.Text+=((Button)sender).Text;
            else
            { }
        }

        private void BtDebgyu_Click(object sender, EventArgs e)
        {
            switch(Op)
            {
                case "+":
                    result = Op2 + Op1;
                    break;
                case "-":
                    result = Op2 - Op1;
                    break;
                case "*":
                    result = Op2 * Op1;
                    break;
                case "/":
                    if(Op2==0)
                    {
                        Console.WriteLine("错误，被除数不能为0！");
                    }
                    else
                    {
                        result= Op2/ Op1;
                    }
                    break;
                case "%":
                    result = Op2 % Op1;
                    break;
                case "^":
                    int m;double n;
                    m = 1;n = Op2;
                    while(m+1<=Op1)
                    {
                        n = n * Op2;
                        m++;
                    }
                    result = n;
                    break;
            }
            textBox1.Text = System.Convert.ToString(result);
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            Op = "+";
            Op2 = Op1;
            textBox1.Text = "";
        }

        private void BtSubtract_Click(object sender, EventArgs e)
        {
            Op = "-";
            Op2 = Op1;
            textBox1.Text = "";
        }

        private void BtMult_Click(object sender, EventArgs e)
        {
            Op = "*";
            Op2 = Op1;
            textBox1.Text = "";
        }

        private void BtDivision_Click(object sender, EventArgs e)
        {
            Op = "/";
            Op2 = Op1;
            textBox1.Text = "";
        }

        private void BtRemedial_Click(object sender, EventArgs e)
        {
            Op = "%";
            Op2 = Op1;
            textBox1.Text = "";
        }

        private void BtPower_Click(object sender, EventArgs e)
        {
            Op = "^";
            Op2 = Op1;
            textBox1.Text = "";
        }

        private void BtDel_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length>=1)
            {
                textBox1.Text=textBox1.Text.Substring(0,textBox1.Text.Length-1);
            }
            if(textBox1.Text.Length==0)
            {
                textBox1.Text = "";
            }
        }

        private void Btsin_Click(object sender, EventArgs e)
        {
            Convert.ToDouble(Op1);
            textBox1.Text = System.Convert.ToString(Math.Sin(Op1 * Math.PI / 180));
        }

        private void Btcos_Click(object sender, EventArgs e)
        {
            Convert.ToDouble(Op1);
            textBox1.Text = System.Convert.ToString(Math.Cos(Op1 * Math.PI / 180));
        }

        private void Bttan_Click(object sender, EventArgs e)
        {
            Convert.ToDouble(Op1);
            textBox1.Text = System.Convert.ToString(Math.Tan(Op1 * Math.PI / 180));
        }

        private void BtFactorial_Click(object sender, EventArgs e)
        {
            int i, j;
            i = 1;j = 1;
            while(i<=Op1)
            {
                j *= i;
                i++;
            }
            textBox1.Text = System.Convert.ToString(j);
        }

        private void BtIndex_Click(object sender, EventArgs e)
        {
            int a, b;
            a = 1; b = 1;
            while (a <= Op1)
            {
                b *= 10;
                a++;
            }
            textBox1.Text = System.Convert.ToString(b);
        }

        private void BtSquare_Click(object sender, EventArgs e)
        {
            textBox1.Text = System.Convert.ToString(Op1 * Op1);
        }

        private void BtCube_Click(object sender, EventArgs e)
        {
            textBox1.Text = System.Convert.ToString(Op1 * Op1 * Op1);
        }

        private void BtPI_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + Math.PI;
            Op1 = System.Convert.ToDouble(textBox1.Text);
        }

        private void BtLog_Click(object sender, EventArgs e)
        {
            textBox1.Text = System.Convert.ToString(Math.Log10(Op1));
        }

        private void BtIn_Click(object sender, EventArgs e)
        {
            textBox1.Text = System.Convert.ToString(Math.Log(Op1));
        }

        private void BtClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Op = "";
            Op1 = 0;
            Op2 = 0;
            result = 0;
        }
    }
}