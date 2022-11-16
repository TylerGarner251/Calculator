using System.Globalization;
using System.Linq.Expressions;
using System.Reflection;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Calculator
    {
        public partial class Calculator : Form
        {
            double FirstNumber;
            double SecondNumber;
            string Operation;
            double Memory;
            public Calculator()
            {
                InitializeComponent();
            }
            private void zeroButton_Click(object sender, EventArgs e)
            {
                MainDisplay.Text = MainDisplay.Text + 0;
            EqualButton.Enabled = true;

        }

            private void oneButton_Click(object sender, EventArgs e)
            {
                if (MainDisplay.Text == "" && MainDisplay.Text != null)
                {
                    MainDisplay.Text = "1";
                }
                else
                {
                    MainDisplay.Text = MainDisplay.Text + "1";
                }
            EqualButton.Enabled = true;
        }

            private void twoButton_Click(object sender, EventArgs e)
            {
                if (MainDisplay.Text == "" && MainDisplay.Text != null)
                {
                    MainDisplay.Text = "2";
                }
                else
                {
                    MainDisplay.Text = MainDisplay.Text + "2";
                }
            EqualButton.Enabled = true;

        }

            private void threeButton_Click(object sender, EventArgs e)
            {
                if (MainDisplay.Text == "" && MainDisplay.Text != null)
                {
                    MainDisplay.Text = "3";
                }
                else
                {
                    MainDisplay.Text = MainDisplay.Text + "3";
                }
            EqualButton.Enabled = true;

        }

            private void fourButton_Click(object sender, EventArgs e)
            {
                if (MainDisplay.Text == "" && MainDisplay.Text != null)
                {
                    MainDisplay.Text = "4";
                }
                else
                {
                    MainDisplay.Text = MainDisplay.Text + "4";
                }
            EqualButton.Enabled = true;

        }

            private void fiveButton_Click(object sender, EventArgs e)
            {
                if (MainDisplay.Text == "" && MainDisplay.Text != null)
                {
                    MainDisplay.Text = "5";
                }
                else
                {
                    MainDisplay.Text = MainDisplay.Text + "5";
                }
            EqualButton.Enabled = true;

        }

            private void sixButton_Click(object sender, EventArgs e)
            {
                if (MainDisplay.Text == "" && MainDisplay.Text != null)
                {
                    MainDisplay.Text = "6";
                }
                else
                {
                    MainDisplay.Text = MainDisplay.Text + "6";
                }
            EqualButton.Enabled = true;

        }

            private void sevenButton_Click(object sender, EventArgs e)
            {
                if (MainDisplay.Text == "" && MainDisplay.Text != null)
                {
                    MainDisplay.Text = "7";
                }
                else
                {
                    MainDisplay.Text = MainDisplay.Text + "7";
                }
            EqualButton.Enabled = true;

        }

            private void eightButton_Click(object sender, EventArgs e)
            {
                if (MainDisplay.Text == "" && MainDisplay.Text != null)
                {
                    MainDisplay.Text = "8";
                }
                else
                {
                    MainDisplay.Text = MainDisplay.Text + "8";
                }
            EqualButton.Enabled = true;

        }

            private void nineButton_Click(object sender, EventArgs e)
            {
                if (MainDisplay.Text == "" && MainDisplay.Text != null)
                {
                    MainDisplay.Text = "9";
                }
                else
                {
                    MainDisplay.Text = MainDisplay.Text + "9";
                }
            EqualButton.Enabled = true;

        }

            private void EqualButton_Click(object sender, EventArgs e)
            {
                double Result;
                SecondNumber = Convert.ToDouble(MainDisplay.Text);
                SecondDisplay.Text = Convert.ToString(FirstNumber) + Operation + Convert.ToString(SecondNumber) + "=";

                if (Operation == "+")
                {
                    Result = (FirstNumber + SecondNumber);
                    MainDisplay.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
                if (Operation == "-")
                {
                    Result = (FirstNumber - SecondNumber);
                    MainDisplay.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
                if (Operation == "*")
                {
                    Result = (FirstNumber * SecondNumber);
                    MainDisplay.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
                if (Operation == "/")
                {
                    if (SecondNumber == 0)
                    {
                        MainDisplay.Text = "0";
                    }
                    else
                    {
                        Result = (FirstNumber / SecondNumber);
                        MainDisplay.Text = Convert.ToString(Result);
                        FirstNumber = Result;
                    }
            

                }
                if (Operation == "%")
                {
                    Result = (SecondNumber/100*FirstNumber);
                    MainDisplay.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
                EqualButton.Enabled = false;
            }

                private void MultiplyButton_Click(object sender, EventArgs e)
            {
            try
            {
                FirstNumber = Convert.ToDouble(MainDisplay.Text);
                MainDisplay.Text = "";
                Operation = "*";
                SecondDisplay.Text = Convert.ToString(FirstNumber + Operation);
            }
            catch
            {
                MainDisplay.Text = "Error";
            }
            EqualButton.Enabled = true;

        }

            private void DivideButton_Click(object sender, EventArgs e)
            {
            try
            {
                FirstNumber = Convert.ToDouble(MainDisplay.Text);
                MainDisplay.Text = "";
                Operation = "/";
                SecondDisplay.Text = Convert.ToString(FirstNumber + Operation);
            }
            catch
            {
                MainDisplay.Text = "Error";
            }
            EqualButton.Enabled = true;

        }

            private void PlusButton_Click(object sender, EventArgs e)
            {
            try
            {
                FirstNumber = Convert.ToDouble(MainDisplay.Text);
                MainDisplay.Text = "";
                Operation = "+";
                SecondDisplay.Text = Convert.ToString(FirstNumber + Operation);
            }
            catch
            {
                MainDisplay.Text = "Error";
            }
            EqualButton.Enabled = true;

        }

            private void MinusButton_Click(object sender, EventArgs e)
            {
            try
            {

                FirstNumber = Convert.ToDouble(MainDisplay.Text);
                MainDisplay.Text = "";
                Operation = "-";
                SecondDisplay.Text = Convert.ToString(FirstNumber + Operation);
            }
            catch
            {
                MainDisplay.Text = "Error";
            }
            EqualButton.Enabled = true;
        }
        private void percentageButton_Click(object sender, EventArgs e)
        {
            try
            {

                FirstNumber = Convert.ToDouble(MainDisplay.Text);
                MainDisplay.Text = "";
                Operation = "%";
                SecondDisplay.Text = Convert.ToString(FirstNumber + Operation);
            }
            catch
            {
                MainDisplay.Text = "Error";
            }
            EqualButton.Enabled = true;

        }

        private void decimalbutton_Click(object sender, EventArgs e)
        {
            if (MainDisplay.Text == "" && MainDisplay.Text != null)
            {
                MainDisplay.Text = ".";
            }
            else
            {
                MainDisplay.Text = MainDisplay.Text + ".";
            }
            EqualButton.Enabled = true;

        }
        private void pibutton_Click(object sender, EventArgs e)
        {
            if (MainDisplay.Text == "" && MainDisplay.Text != null)
            {
                MainDisplay.Text = "3.142";
            }
            else
            {
                MainDisplay.Text = MainDisplay.Text + "3.142";
            }
            EqualButton.Enabled = true;

        }


        private void MainDisplay_TextChanged(object sender, EventArgs e)
            {

            }

            private void SecondDisplay_TextChanged(object sender, EventArgs e)
            {

            }

            private void AllClear_Click(object sender, EventArgs e)
            {
                MainDisplay.Clear();
                SecondDisplay.Clear();
            EqualButton.Enabled = true;
        }

            private void MemoryButton_Click(object sender, EventArgs e)
            {
                Memory = int.Parse(MainDisplay.Text);
            EqualButton.Enabled = true;

        }
            private void GetMemoryButton_Click(object sender, EventArgs e)
            {
                if (MainDisplay.Text == "" && MainDisplay.Text != null)
                {
                    MainDisplay.Text = Convert.ToString(Memory);
                }
                else
                {
                    MainDisplay.Text = MainDisplay.Text + Convert.ToString(Memory);
                }
            EqualButton.Enabled = true;
        }
        private void Calculator_Load(object sender, EventArgs e)
        {

        }
    }
    }