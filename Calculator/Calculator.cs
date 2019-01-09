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
    public enum Op { Add, Sub, Mul, Div, Eql }


    // 윈폼 공부가 안돼 있으니 절차지향적으로 짜게 되었다...
    // 디자인에 있는 버튼들 사용자 정의 클래스에선 못 가져오나?
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private bool isNewNum = true;
        private double accum = 0.0;
        private Op prevOp = Op.Eql;

        private void NumButton_Click(object sender, EventArgs e)
        {
            Button Clicked = sender as Button;

            if (ResultLabel.Text == "0" || isNewNum)
            {
                ResultLabel.Text = Clicked.Text;
                isNewNum = false;
                SetOpBtnColor(Op.Eql);
            }
            else
                ResultLabel.Text += Clicked.Text;
        }

        private void Op4Button_Click(object sender, EventArgs e)
        {
            Button Clicked = sender as Button;
            if (!isNewNum)
            {
                switch (prevOp)
                {
                    case Op.Eql:
                        accum = double.Parse(ResultLabel.Text);
                        break;
                    case Op.Add:
                        accum += double.Parse(ResultLabel.Text);
                        break;
                    case Op.Sub:
                        accum -= double.Parse(ResultLabel.Text);
                        break;
                    case Op.Mul:
                        accum *= double.Parse(ResultLabel.Text);
                        break;
                    case Op.Div:
                        double divisor = double.Parse(ResultLabel.Text);
                        if (divisor == 0)
                        {
                            MessageBox.Show("0으로 나눌 수 없소!");
                            Reset();
                            break;
                        }
                        accum /= divisor;
                        break;
                }

                ResultLabel.Text = accum.ToString();
                isNewNum = true;
            }

            switch (Clicked.Text)
            {
                case "+":
                    SetOpBtnColor(Op.Add);
                    prevOp = Op.Add;
                    break;
                case "-":
                    SetOpBtnColor(Op.Sub);
                    prevOp = Op.Sub;
                    break;
                case "×":
                    SetOpBtnColor(Op.Mul);
                    prevOp = Op.Mul;
                    break;
                case "÷":
                    SetOpBtnColor(Op.Div);
                    prevOp = Op.Div;
                    break;
                case "=":
                    SetOpBtnColor(Op.Eql);
                    prevOp = Op.Eql;
                    break;
            }
        }

        private void Reset()
        {
            isNewNum = true;
            accum = 0.0;
            ResultLabel.Text = "0";
            SetOpBtnColor(Op.Eql);
            prevOp = Op.Eql;
        }

        private void SetOpBtnColor(Op newOp)
        {
            AddButton.BackColor = Color.Silver;
            SubButton.BackColor = Color.Silver;
            DivButton.BackColor = Color.Silver;
            MulButton.BackColor = Color.Silver;

            switch(newOp)
            {
                case Op.Add:
                    AddButton.BackColor = Color.DodgerBlue;
                    break;
                case Op.Sub:
                    SubButton.BackColor = Color.DodgerBlue;
                    break;
                case Op.Div:
                    DivButton.BackColor = Color.DodgerBlue;
                    break;
                case Op.Mul:
                    MulButton.BackColor = Color.DodgerBlue;
                    break;
            }
        }

        private void DotButton_Click(object sender, EventArgs e)
        {
            if (isNewNum)
            {
                ResultLabel.Text = "0.";
                isNewNum = false;
            }
            else if (!ResultLabel.Text.Contains("."))
            {
                ResultLabel.Text += ".";
            }
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            if (!isNewNum)
            {
                int len = ResultLabel.Text[0] == '-' ? ResultLabel.Text.Length - 1 : ResultLabel.Text.Length;
                if (len > 1)
                    ResultLabel.Text = ResultLabel.Text.Remove(ResultLabel.Text.Length - 1, 1);
                else
                    ResultLabel.Text = "0";
            }
        }

        private void ClrButton_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void NegButton_Click(object sender, EventArgs e)
        {
            if (ResultLabel.Text != "0")
                if (ResultLabel.Text[0] == '-')
                    ResultLabel.Text = ResultLabel.Text.Remove(0, 1);
                else
                    ResultLabel.Text = ResultLabel.Text.Insert(0, "-");
            isNewNum = false;
        }

        private void SqrtButton_Click(object sender, EventArgs e)
        {
            double num = double.Parse(ResultLabel.Text);
            if (num < 0)
            {
                MessageBox.Show("음수의 제곱근을 구할 수 없소!");
                return;
            }
            num = Math.Sqrt(num);
            ResultLabel.Text = num.ToString();
            isNewNum = false;
        }
    }
}
