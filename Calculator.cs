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
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result = 0.0,
               num1 = 0.0,
               num2 = 0.0,
               temp = 0.0,
               memory = 0.0,
               memoryResult = 0.0;
        public Calculator()
        {
            InitializeComponent();
            Inputtb.BorderStyle = BorderStyle.None;
            MCButton.Enabled = true;
            MRButton.Enabled = true;

        }
        private void CButton_MouseHover(object sender, EventArgs e)
        {
            CButton.BackColor = Color.Silver;
        }

        private void CButton_MouseLeave(object sender, EventArgs e)
        {
            CButton.BackColor = Color.Gainsboro;
        }

        private void ArrowButton_MouseHover(object sender, EventArgs e)
        {
            ArrowButton.BackColor = Color.Silver;
        }

        private void ArrowButton_MouseLeave(object sender, EventArgs e)
        {
            ArrowButton.BackColor = Color.Gainsboro;
        }

        private void FractionButton_MouseHover(object sender, EventArgs e)
        {
            FractionButton.BackColor = Color.Silver;
        }

        private void FractionButton_MouseLeave(object sender, EventArgs e)
        {
            FractionButton.BackColor = Color.Gainsboro;
        }

        private void x2Button_MouseHover(object sender, EventArgs e)
        {
            x2Button.BackColor = Color.Silver;
        }

        private void x2Button_MouseLeave(object sender, EventArgs e)
        {
            x2Button.BackColor = Color.Gainsboro;
        }

        private void SquareRootButton_MouseHover(object sender, EventArgs e)
        {
            SquareRootButton.BackColor = Color.Silver;
        }

        private void SquareRootButton_MouseLeave(object sender, EventArgs e)
        {
            SquareRootButton.BackColor = Color.Gainsboro;
        }

        private void DivisionButton_MouseHover(object sender, EventArgs e)
        {
            DivisionButton.BackColor = Color.Silver;
        }

        private void DivisionButton_MouseLeave(object sender, EventArgs e)
        {
            DivisionButton.BackColor = Color.Gainsboro;
        }

        private void MultiplyButton_MouseHover(object sender, EventArgs e)
        {
            MultiplyButton.BackColor = Color.Silver;
        }

        private void MultiplyButton_MouseLeave(object sender, EventArgs e)
        {
            MultiplyButton.BackColor = Color.Gainsboro;
        }

        private void MinusButton_MouseHover(object sender, EventArgs e)
        {
            MinusButton.BackColor = Color.Silver;
        }

        private void MinusButton_MouseLeave(object sender, EventArgs e)
        {
            MinusButton.BackColor = Color.Gainsboro;
        }

        private void PlusButton_MouseHover(object sender, EventArgs e)
        {
            PlusButton.BackColor = Color.Silver;
        }

        private void PlusButton_MouseLeave(object sender, EventArgs e)
        {
            PlusButton.BackColor = Color.Gainsboro;
        }

        private void EqualButton_MouseHover(object sender, EventArgs e)
        {
            EqualButton.BackColor = Color.CornflowerBlue;
        }

        private void EqualButton_MouseLeave(object sender, EventArgs e)
        {
            EqualButton.BackColor = Color.LightSteelBlue;
        }

        private void SevenButton_MouseHover(object sender, EventArgs e)
        {
            SevenButton.BackColor = Color.Silver;
        }

        private void SevenButton_MouseLeave(object sender, EventArgs e)
        {
            SevenButton.BackColor = Color.WhiteSmoke;
        }

        private void EightButton_MouseHover(object sender, EventArgs e)
        {
            EightButton.BackColor = Color.Silver;
        }

        private void EightButton_MouseLeave(object sender, EventArgs e)
        {
            EightButton.BackColor = Color.WhiteSmoke;
        }

        private void NineButton_MouseHover(object sender, EventArgs e)
        {
            NineButton.BackColor = Color.Silver;
        }

        private void NineButton_MouseLeave(object sender, EventArgs e)
        {
            NineButton.BackColor = Color.WhiteSmoke;
        }

        private void FourButton_MouseHover(object sender, EventArgs e)
        {
            FourButton.BackColor = Color.Silver;
        }

        private void FourButton_MouseLeave(object sender, EventArgs e)
        {
            FourButton.BackColor = Color.WhiteSmoke;
        }

        private void FiveButton_MouseHover(object sender, EventArgs e)
        {
            FiveButton.BackColor = Color.Silver;
        }

        private void FiveButton_MouseLeave(object sender, EventArgs e)
        {
            FiveButton.BackColor = Color.WhiteSmoke;
        }

        private void SixButton_MouseHover(object sender, EventArgs e)
        {
            SixButton.BackColor = Color.Silver;
        }

        private void SixButton_MouseLeave(object sender, EventArgs e)
        {
            SixButton.BackColor = Color.WhiteSmoke;
        }

        private void OneButton_MouseHover(object sender, EventArgs e)
        {
            OneButton.BackColor = Color.Silver;
        }

        private void OneButton_MouseLeave(object sender, EventArgs e)
        {
            OneButton.BackColor = Color.WhiteSmoke;
        }

        private void TwoButton_MouseHover(object sender, EventArgs e)
        {
            TwoButton.BackColor = Color.Silver;
        }

        private void TwoButton_MouseLeave(object sender, EventArgs e)
        {
            TwoButton.BackColor = Color.WhiteSmoke;
        }

        private void ThreeButton_MouseHover(object sender, EventArgs e)
        {
            ThreeButton.BackColor = Color.Silver;
        }

        private void ThreeButton_MouseLeave(object sender, EventArgs e)
        {
            ThreeButton.BackColor = Color.WhiteSmoke;
        }

        private void PlusMinButton_MouseHover(object sender, EventArgs e)
        {
            PlusMinButton.BackColor = Color.Silver;
        }

        private void PlusMinButton_MouseLeave(object sender, EventArgs e)
        {
            PlusMinButton.BackColor = Color.WhiteSmoke;
        }

        private void ZeroButton_MouseHover(object sender, EventArgs e)
        {
            ZeroButton.BackColor = Color.Silver;
        }

        private void ZeroButton_MouseLeave(object sender, EventArgs e)
        {
            ZeroButton.BackColor = Color.WhiteSmoke;
        }

        private void DotButton_MouseHover(object sender, EventArgs e)
        {
            DotButton.BackColor = Color.Silver;
        }

        private void DotButton_MouseLeave(object sender, EventArgs e)
        {
            DotButton.BackColor = Color.WhiteSmoke;
        }
        private void CEButton_MouseLeave(object sender, EventArgs e)
        {
            CEButton.BackColor = Color.Gainsboro;
        }

        private void CEButton_MouseHover(object sender, EventArgs e)
        {
            CEButton.BackColor = Color.Silver;
        }
        private void x3Button_MouseHover(object sender, EventArgs e)
        {
            x3Button.BackColor = Color.Silver;
        }

        private void x3Button_MouseLeave(object sender, EventArgs e)
        {
            x3Button.BackColor = Color.Gainsboro;
        }

       

        private void SevenButton_Click(object sender, EventArgs e)
        {
            Inputtb.Text = "";
            input += "7";
            Inputtb.Text += input;
            HistoryLabel.Text = Inputtb.Text;
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            Inputtb.Text = "";
            input += "8";
            Inputtb.Text += input;
            HistoryLabel.Text = Inputtb.Text;
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            Inputtb.Text = "";
            input += "1";
            Inputtb.Text += input;
            HistoryLabel.Text = Inputtb.Text;
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            Inputtb.Text = "";
            input += "2";
            Inputtb.Text += input;
            HistoryLabel.Text = Inputtb.Text;
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            Inputtb.Text = "";
            input += "3";
            Inputtb.Text += input;
            HistoryLabel.Text = Inputtb.Text;
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            Inputtb.Text = "";
            input += "0";
            Inputtb.Text += input;
            HistoryLabel.Text = Inputtb.Text;
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            Inputtb.Text = "";
            input += "9";
            Inputtb.Text += input;
            HistoryLabel.Text = Inputtb.Text;
        }

     

        private void FourButton_Click(object sender, EventArgs e)
        {

            Inputtb.Text = "";
            input += "4";
            Inputtb.Text += input;
            HistoryLabel.Text = Inputtb.Text;
        }

       

        private void FiveButton_Click(object sender, EventArgs e)
        {
            Inputtb.Text = "";
            input += "5";
            Inputtb.Text += input;
            HistoryLabel.Text = Inputtb.Text;
        }

        

        private void SixButton_Click(object sender, EventArgs e)
        {
            Inputtb.Text = "";
            input += "6";
            Inputtb.Text += input;
            HistoryLabel.Text = Inputtb.Text;
        }
        private void DotButton_Click(object sender, EventArgs e)
        {
            Inputtb.Text = "";
            input += ".";
            Inputtb.Text += input;
            HistoryLabel.Text = Inputtb.Text;
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            Inputtb.Text = Inputtb.Text + '+';
            operation = '+';
            operand1 = input;
            input = string.Empty;

        }

        private void x2Button_Click(object sender, EventArgs e)
        {
            Inputtb.Text = $"sqr({Inputtb.Text})";
            operation = '^';
            operand1 = input;
            input = string.Empty;

        }

        private void SquareRootButton_Click(object sender, EventArgs e)
        {
            Inputtb.Text = $"√({Inputtb.Text})";
            operation = '√';
            operand1 = input;
            input = string.Empty;
        }

        private void x3Button_Click(object sender, EventArgs e)
        {
            Inputtb.Text = $"{Inputtb.Text}^3";
            operation = '3';
            operand1 = input;
            input = string.Empty;
        }
        private void FractionButton_Click(object sender, EventArgs e)
        {
            if (Inputtb.Text == "0")
            {
                Inputtb.Text = "Cannot divide by zero";
            }
            else
            {
                Inputtb.Text = $"1 /{ Inputtb.Text}";
            }
            operation = '.';
            operand1 = input;
            input = string.Empty;
        }

        private void DivisionButton_Click(object sender, EventArgs e)
        {
            Inputtb.Text = Inputtb.Text + '/';
            operation = '/';
            operand1 = input;
            input = string.Empty;
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            Inputtb.Text = Inputtb.Text + '*';
            operation = '*';
            operand1 = input;
            input = string.Empty;
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            Inputtb.Text = Inputtb.Text + '-';
            operation = '-';
            operand1 = input;
            input = string.Empty;
        }
        private void PlusMinButton_Click(object sender, EventArgs e)
        {
            double.TryParse(input, out temp);
            if (temp > 0)
            {
                Inputtb.Text = "-" + Inputtb.Text;
                temp = -temp;
                input = temp.ToString();
            }
            else
            {
                temp = -temp;
                input = temp.ToString();
                Inputtb.Text = $"{temp}";
            }
        }
        private void EqualButton_Click(object sender, EventArgs e)
        {
            operand2 = input;

            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            Inputtb.Clear();

            switch (operation)
            {
                case '+':
                    {
                        result = num1 + num2;
                        Inputtb.Text = result.ToString();
                        HistoryLabel.Text = $"{num1} + {num2} =";
                        input = result.ToString();
                        break;
                    }
                case '*':
                    {
                        result = num1 * num2;
                        Inputtb.Text = result.ToString();
                        HistoryLabel.Text = $"{num1}*{num2}=";
                        input = result.ToString();
                        break;
                    }
                case '/':
                    {
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                            Inputtb.Text = result.ToString();
                            HistoryLabel.Text = $"{num1}/{num2}=";
                            input = result.ToString();
                        }
                        else
                        {
                            Inputtb.Text = "Cannot divide by zero";
                        }
                        break;
                    }
                case '-':
                    {
                        result = num1 - num2;
                        Inputtb.Text = result.ToString();
                        HistoryLabel.Text = $"{num1}-{num2}=";
                        input = result.ToString();
                        break;
                    }
                case '^':
                    {
                        result = num1 * num1;
                        Inputtb.Text = result.ToString();
                        HistoryLabel.Text = $"sqr({num1})";
                        input = result.ToString();
                        break;
                    }
                case '√':
                    {
                        result = Math.Sqrt(num1);
                        Inputtb.Text = result.ToString();
                        HistoryLabel.Text = $"√({num1})";
                        input = result.ToString();
                        break;
                    }
                case '.':
                    {
                        result = 1 / num1;
                        Inputtb.Text = result.ToString();
                        HistoryLabel.Text = $"1/({num1})";
                        input = result.ToString();
                        break;
                    }
                case '3':
                    {
                        result = num1 * num1 * num1;
                        Inputtb.Text = result.ToString();
                        HistoryLabel.Text = $"{num1} ^ 3 =";
                        input = result.ToString();
                        break;
                    }
            }
        }

        private void MplusButton_Click(object sender, EventArgs e)
        {
            if (memoryResult == 0)
            {
                memoryResult = memory + Double.Parse(Inputtb.Text);
            }
            else
            {
                memoryResult = memoryResult + Double.Parse(Inputtb.Text);
            }
        }

        

        private void MRButton_Click(object sender, EventArgs e)
        {
            if (memoryResult == 0)
            {
                Inputtb.Text = memory.ToString();
            }
            else
            {
                Inputtb.Text = memoryResult.ToString(); ;
            }
        }
        private void MminButton_Click(object sender, EventArgs e)
        {
            if (memoryResult == 0)
            {
                memoryResult = memory - Double.Parse(Inputtb.Text);
            }
            else
            {
                memoryResult = memoryResult - Double.Parse(Inputtb.Text);
            }          
        }
        private void MCButton_Click(object sender, EventArgs e)
        {
            memory = 0;
            memoryResult = 0;
            MCButton.Enabled = false;
            MRButton.Enabled = false;
        }
        private void MSButton_Click(object sender, EventArgs e)
        {
            memory = Double.Parse(Inputtb.Text);
            MCButton.Enabled = true;
            MRButton.Enabled = true;
        }
        private void ArrowButton_Click(object sender, EventArgs e)
        {
            if (Inputtb.Text.Length > 0)
            {
                string Inputmin = Inputtb.Text.Remove(Inputtb.Text.Length - 1, 1);
                Inputtb.Text = Inputmin;
                input = Inputtb.Text;
                HistoryLabel.Text = Inputtb.Text;
            }
        }
        private void CButton_Click(object sender, EventArgs e)
        {
            Inputtb.Text = "0";
            HistoryLabel.Text = "";
            result = 0;
            num1 = 0;
            num2 = 0;
            input = string.Empty;
        }
        private void CEButton_Click(object sender, EventArgs e)
        {
            Inputtb.Text = "0";
            input = Inputtb.Text;
        }
    }
}
