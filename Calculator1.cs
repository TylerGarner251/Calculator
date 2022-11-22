using System.Globalization;
using System.Linq.Expressions;
using System.Reflection;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
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
                if (MainDisplay.Text == "" && MainDisplay.Text != null) //if the display has no number and is blank then display 2
            {
                    MainDisplay.Text = "2";
                }
                else //if the display has anything else add one to the end
                {
                    MainDisplay.Text = MainDisplay.Text + "2";
                }
            EqualButton.Enabled = true;

        }

            private void threeButton_Click(object sender, EventArgs e)//makes the three button function and pressable
        {
                if (MainDisplay.Text == "" && MainDisplay.Text != null) //if the display has no number and is blank then display 3
            {
                    MainDisplay.Text = "3";//if the display has anything else add one to the end
            }
                else
                {
                    MainDisplay.Text = MainDisplay.Text + "3";
                }
            EqualButton.Enabled = true;

        }

            private void fourButton_Click(object sender, EventArgs e)//makes the four button function and pressable
        {
                if (MainDisplay.Text == "" && MainDisplay.Text != null) //if the display has no number and is blank then display 4
            {
                    MainDisplay.Text = "4";//if the display has anything else add one to the end
            }
                else
                {
                    MainDisplay.Text = MainDisplay.Text + "4";
                }
            EqualButton.Enabled = true;

        }

            private void fiveButton_Click(object sender, EventArgs e)//makes the five button function and pressable
        {
                if (MainDisplay.Text == "" && MainDisplay.Text != null) //if the display has no number and is blank then display 5
            {
                    MainDisplay.Text = "5";//if the display has anything else add one to the end
            }
                else
                {
                    MainDisplay.Text = MainDisplay.Text + "5";
                }
            EqualButton.Enabled = true;

        }

            private void sixButton_Click(object sender, EventArgs e)//makes the six button function and pressable
        {
                if (MainDisplay.Text == "" && MainDisplay.Text != null) //if the display has no number and is blank then display 6
            {
                    MainDisplay.Text = "6";//if the display has anything else add one to the end
            }
                else
                {
                    MainDisplay.Text = MainDisplay.Text + "6";
                }
            EqualButton.Enabled = true;

        }

            private void sevenButton_Click(object sender, EventArgs e)//makes the seven button function and pressable
        {
                if (MainDisplay.Text == "" && MainDisplay.Text != null) //if the display has no number and is blank then display 7
            {
                    MainDisplay.Text = "7";//if the display has anything else add one to the end
            }
                else
                {
                    MainDisplay.Text = MainDisplay.Text + "7";
                }
            EqualButton.Enabled = true;

        }

            private void eightButton_Click(object sender, EventArgs e)//makes the eight button function and pressable
        {
                if (MainDisplay.Text == "" && MainDisplay.Text != null) //if the display has no number and is blank then display 8
            {
                    MainDisplay.Text = "8";//if the display has anything else add one to the end
            }
                else
                {
                    MainDisplay.Text = MainDisplay.Text + "8";
                }
            EqualButton.Enabled = true;

        }

            private void nineButton_Click(object sender, EventArgs e)//makes the nine button function and pressable
        {
                if (MainDisplay.Text == "" && MainDisplay.Text != null) //if the display has no number and is blank then display 9
            {
                    MainDisplay.Text = "9";//if the display has anything else add one to the end
            }
                else
                {
                    MainDisplay.Text = MainDisplay.Text + "9";
                }
            EqualButton.Enabled = true;

        }

        private void EqualButton_Click(object sender, EventArgs e) //makes the equal button function and pressable
        {
            double Result;
            try
            {
                SecondNumber = Convert.ToDouble(MainDisplay.Text);
                SecondDisplay.Text = Convert.ToString(FirstNumber) + Operation + Convert.ToString(SecondNumber) + "=";

                if (Operation == "+") // if the operator is corresponding operator in the if statement then do the sum below
                {
                    Result = (FirstNumber + SecondNumber);
                    MainDisplay.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
                if (Operation == "-") // if the operator is corresponding operator in the if statement then do the sum below
                {
                    Result = (FirstNumber - SecondNumber);
                    MainDisplay.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
                if (Operation == "*") // if the operator is corresponding operator in the if statement then do the sum below
                {
                    Result = (FirstNumber * SecondNumber);
                    MainDisplay.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
                if (Operation == "/") // if the operator is corresponding operator in the if statement then do the sum below
                {
                    if (SecondNumber == 0) // if the number is a 0 then display the number as a 0
                    {
                        MainDisplay.Text = "0";
                    }
                    else
                    {
                        Result = (FirstNumber / SecondNumber); // if the number is a not a 0 then do the sum below
                        MainDisplay.Text = Convert.ToString(Result);
                        FirstNumber = Result;
                    }

                }
                if (Operation == "%") // if the operator is corresponding operator in the if statement then do the sum below
                {
                    Result = (SecondNumber / 100 * FirstNumber);
                    MainDisplay.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
                EqualButton.Enabled = false;
            }
            catch
            {
                MainDisplay.Text = "Error"; // if any of these functions fail then display this error message
            }
            }
                private void MultiplyButton_Click(object sender, EventArgs e)//makes the times button function and pressable
        {
            try
            {
                FirstNumber = Convert.ToDouble(MainDisplay.Text); //display the operator on the screen
                MainDisplay.Text = "";
                Operation = "*";
                SecondDisplay.Text = Convert.ToString(FirstNumber + Operation); // displays the operator and number on the top display
            }
            catch
            {
                MainDisplay.Text = "Error"; // if any of these functions fail then display this error message
            }
            EqualButton.Enabled = true;

        }

            private void DivideButton_Click(object sender, EventArgs e)//makes the divide button function and pressable
        {
            try
            {
                FirstNumber = Convert.ToDouble(MainDisplay.Text); //display the operator on the screen
                MainDisplay.Text = "";
                Operation = "/";
                SecondDisplay.Text = Convert.ToString(FirstNumber + Operation); // displays the operator and number on the top display
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
                FirstNumber = Convert.ToDouble(MainDisplay.Text); //display the operator on the screen
                MainDisplay.Text = "";
                Operation = "+";
                SecondDisplay.Text = Convert.ToString(FirstNumber + Operation); // displays the operator and number on the top display
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

                FirstNumber = Convert.ToDouble(MainDisplay.Text); //display the operator on the screen
                MainDisplay.Text = "";
                Operation = "-";
                SecondDisplay.Text = Convert.ToString(FirstNumber + Operation); // displays the operator and number on the top display
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

                FirstNumber = Convert.ToDouble(MainDisplay.Text); //display the operator on the screen
                MainDisplay.Text = "";
                Operation = "%";
                SecondDisplay.Text = Convert.ToString(FirstNumber + Operation); // displays the operator and number on the top display
            }
            catch
            {
                MainDisplay.Text = "Error";
            }
            EqualButton.Enabled = true;

        }

        private void decimalbutton_Click(object sender, EventArgs e)//makes the decimal button function and pressable
        {
            if (MainDisplay.Text == "" && MainDisplay.Text != null) //display the operator on the screen
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
            if (MainDisplay.Text == "" && MainDisplay.Text != null) //display the operator on the screen
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
            if (MainDisplay.Text == "" && MainDisplay.Text != null) // if the display has no value and or a 0 then memory will be registered as a 0
            {
                Memory = 0;
                EqualButton.Enabled = true;
            }
            else
            {
                Memory = int.Parse(MainDisplay.Text);
                EqualButton.Enabled = true;
            }

        }
            private void GetMemoryButton_Click(object sender, EventArgs e)//makes the memory button function and grabs from memory
        {
                if (MainDisplay.Text == "" && MainDisplay.Text != null) // if the memory has registered number then display the number that is stored
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

        private void VisualButton_Click(object sender, EventArgs e) // changes look of the form to calculator 2 design
        {
            this.Hide();
            Calculator2 f2 = new Calculator2();
            f2.ShowDialog(); // or form.ShowDialog(this);
        }

        private void BackspaceButton_Click(object sender, EventArgs e) // removes the previous number added to the calculator
        {
            int numberLength = MainDisplay.Text.Length;
            if (numberLength > 1)
            {
                MainDisplay.Text = MainDisplay.Text.Substring(0, numberLength - 1);
            }
            else
            {
                MainDisplay.Text = "";

            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e) // prevents memory leak and make sure when the user closes the window, the whole app closes down
        {
            Application.Exit();
        }
    }
    }