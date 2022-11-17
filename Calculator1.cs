using System.Globalization;
using System.Linq.Expressions;
using System.Reflection;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Calculator
    {
        public partial class Calculator : Form
        {
            double FirstNumber; //puts the first number of the equation into this variable
            double SecondNumber; //puts the second number of the equation into this variable
            string Operation; //puts the operator into this variable
            double Memory; //stores the displayed number into memory for use later on.
            public Calculator() //starts calculator
            {
                InitializeComponent();
            }
            private void zeroButton_Click(object sender, EventArgs e) //makes the zero button function and pressable
            {
                MainDisplay.Text = MainDisplay.Text + 0;
            EqualButton.Enabled = true;

        }

        private void oneButton_Click_1(object sender, EventArgs e)//makes the one button function and pressable
        {
            if (MainDisplay.Text == "" && MainDisplay.Text != null) //if the display has no number and is blank then display 1
            {
                MainDisplay.Text = "1";
            }
            else //if the display has anything else add one to the end
            {
                MainDisplay.Text = MainDisplay.Text + "1";
            }
            EqualButton.Enabled = true;
        }

        private void twoButton_Click(object sender, EventArgs e)//makes the two button function and pressable
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

            private void threeButton_Click(object sender, EventArgs e)//makes the three button function and pressable
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

            private void fourButton_Click(object sender, EventArgs e)//makes the four button function and pressable
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

            private void fiveButton_Click(object sender, EventArgs e)//makes the five button function and pressable
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

            private void sixButton_Click(object sender, EventArgs e)//makes the six button function and pressable
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

            private void sevenButton_Click(object sender, EventArgs e)//makes the seven button function and pressable
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

            private void eightButton_Click(object sender, EventArgs e)//makes the eight button function and pressable
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

            private void nineButton_Click(object sender, EventArgs e)//makes the nine button function and pressable
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

        private void EqualButton_Click(object sender, EventArgs e)//makes the equal button function and pressable
        {
            double Result;
            try
            {
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
                    Result = (SecondNumber / 100 * FirstNumber);
                    MainDisplay.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
                EqualButton.Enabled = false;
            }
            catch
            {
                MainDisplay.Text = "Error";
            }
            }
                private void MultiplyButton_Click(object sender, EventArgs e)//makes the times button function and pressable
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

            private void DivideButton_Click(object sender, EventArgs e)//makes the divide button function and pressable
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

            private void PlusButton_Click(object sender, EventArgs e)//makes the plus button function and pressable
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

            private void MinusButton_Click(object sender, EventArgs e)//makes the minus button function and pressable
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
        private void percentageButton_Click(object sender, EventArgs e)//makes the percentage button function and pressable
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

        private void decimalbutton_Click(object sender, EventArgs e)//makes the decimal button function and pressable
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
        private void pibutton_Click(object sender, EventArgs e)//makes the pi button function and pressable
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


        private void MainDisplay_TextChanged(object sender, EventArgs e)//Display the number at the bottom
        {

            }

            private void SecondDisplay_TextChanged(object sender, EventArgs e)//Displays the number at the top and equation
            {

            }

            private void AllClear_Click(object sender, EventArgs e)//clears all the displays
            {
                MainDisplay.Clear();
                SecondDisplay.Clear();
            EqualButton.Enabled = true;
        }

            private void MemoryButton_Click(object sender, EventArgs e)//makes the memory button function and stores memory
        {
                Memory = int.Parse(MainDisplay.Text);
            EqualButton.Enabled = true;

        }
            private void GetMemoryButton_Click(object sender, EventArgs e)//makes the memory button function and grabs from memory
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

        private void VisualButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Calculator2 f2 = new Calculator2();
            f2.ShowDialog(); // or form.ShowDialog(this);
        }
    }
    }