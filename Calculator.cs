using Calculator.Classes;
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
    public partial class Calculator : Form
    {
        private List<double> numbers;
        private List<Operator> ops;
        private string equation;

        public Calculator()
        {
            InitializeComponent();

            this.numbers = new List<double>();
            this.ops = new List<Operator>();
            this.equation = "";

        }



        private void UpdateTextBox(string str, TextBox tb)
        {
            tb.Text = str;
        }



        private double ConvertToDouble(string str)
        {
            return Double.Parse(str);
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }


        #region Buttons 0-9
        private void btn_0_Click(object sender, EventArgs e)//button 0
        {
            this.equation += "0";
            UpdateTextBox(this.equation, this.tb_equation);
        }


        private void btn_1_Click(object sender, EventArgs e)//button 1
        {
            this.equation += "1";
            UpdateTextBox(this.equation, this.tb_equation);
        }


        private void button8_Click(object sender, EventArgs e)//button 2
        {
            this.equation += "2";
            UpdateTextBox(this.equation, this.tb_equation);
        }

        private void btn_3_Click(object sender, EventArgs e)//button 3
        {
            this.equation += "3";
            UpdateTextBox(this.equation, this.tb_equation);
        }

        private void btn_4_Click(object sender, EventArgs e)//button 4
        {
            this.equation += "4";
            UpdateTextBox(this.equation, this.tb_equation);
        }

        private void btn_5_Click(object sender, EventArgs e)//button 5
        {
            this.equation += "5";
            UpdateTextBox(this.equation, this.tb_equation);
        }

        private void btn_6_Click(object sender, EventArgs e)//button 6
        {
            this.equation += "6";
            UpdateTextBox(this.equation, this.tb_equation);
        }

        private void btn_7_Click(object sender, EventArgs e)//button 7
        {
            this.equation += "7";
            UpdateTextBox(this.equation, this.tb_equation);
        }

        private void btn_8_Click(object sender, EventArgs e)//button8
        {
            this.equation += "8";
            UpdateTextBox(this.equation, this.tb_equation);
        }

        private void btn_9_Click(object sender, EventArgs e)//button 9
        {
            this.equation += "9";
            UpdateTextBox(this.equation, this.tb_equation);
        }
        #endregion



        #region +-*/
        private void btn_plus_Click(object sender, EventArgs e)
        {
            this.numbers.Add(ConvertToDouble(this.equation));
            this.ops.Add(new Operator('+'));
            this.equation = "";
            //UpdateTextBox(this.equation, this.tb_equation);
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            this.numbers.Add(ConvertToDouble(this.equation));
            this.ops.Add(new Operator('-'));
            this.equation = "";
            //UpdateTextBox(this.equation, this.tb_equation);
        }

        private void btn_multiply_Click(object sender, EventArgs e)
        {
            this.numbers.Add(ConvertToDouble(this.equation));
            this.ops.Add(new Operator('*'));
            this.equation = "";
            //UpdateTextBox(this.equation, this.tb_equation);
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            this.numbers.Add(ConvertToDouble(this.equation));
            this.ops.Add(new Operator('/'));
            this.equation = "";
            //UpdateTextBox(this.equation, this.tb_equation);
        }

        #endregion



        private void btn_decimal_Click(object sender, EventArgs e)
        {
            this.equation += ".";
            UpdateTextBox(this.equation, this.tb_equation);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.equation = "";
            UpdateTextBox(this.equation, this.tb_equation);
            this.numbers.Clear();
            this.ops.Clear();
        }

        private void btn_equals_Click(object sender, EventArgs e)
        {
            this.numbers.Add(ConvertToDouble(this.equation));
            this.ops.Add(new Operator('-'));
            this.equation = this.solve();
            this.UpdateTextBox(this.equation, this.tb_equation);
        }


        private string solve()
        {
            double before = numbers[0];
            for(int i = 1; i < this.numbers.Count; i++)
            {
                before = ops[i - 1].apply(before, numbers[1]);
            }
            return before.ToString();
        }

    }//Calculator


}
