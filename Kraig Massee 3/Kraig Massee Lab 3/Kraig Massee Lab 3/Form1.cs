using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Author: Kraig Massee
  Date: 1/28/2019
  Lab #: 3
  Bugs: Used if statement to work around dividing by zero. This was not discussed in the current chapters,
   however the instructions in the syllabus say to use internet resources, and I was able to find this solution
   to run the program to "be similar to the demo that is posted under the content for this week." There is no solution
   in the book or in the lecture notes/videos on this, so I figure this will do.
*/
namespace Kraig_Massee_Lab_3
{
    public partial class calculatorForm : Form
    {

        public calculatorForm()
        {

            InitializeComponent();
             /*
             * Load Image picture box of calculator image
             */
            this.calculatorImagePictureBox.Image = Image.FromFile("calculator.png");
        }

        private void myCalculatorMainLabel_Click(object sender, EventArgs e)
        {

        }

        private void processOutputGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void topEnterNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void bottomEnterNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void topNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void resultDisplayLabel_Click(object sender, EventArgs e)
        {

        }

        private void calculatorImagePictureBox_Click(object sender, EventArgs e)
        {

        }

        private void multiplicationButton_Click(object sender, EventArgs e)
        {
            /*
             * Set result label to blank. Declare boxOne and boxTwo to be the numbers entered
             * in the text boxes. Converts string to double. Multiplies the two numbers and sets it to result. Converts
             * result into string and sets it to resultDisplayLabel. Catch only allows numbers to be entered into
             * the text boxes. Error message will be displayed if non-numbers are entered.
             */
            resultDisplayLabel.Text = "";
            try
            {
                double boxOne, boxTwo, result;
                boxOne = double.Parse(topNumberTextBox.Text);
                try
                {
                    boxTwo = double.Parse(bottomNumberTextBox.Text);
                    result = (boxOne * boxTwo);
                    resultDisplayLabel.Text = result.ToString("n2");
                }
                catch
                {
                    MessageBox.Show("Please enter a valid number into the second text box");
                    topNumberTextBox.Focus();
                    topNumberTextBox.Select();

                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid number into the first text box");
                bottomNumberTextBox.Focus();
                bottomNumberTextBox.Select();

            }
        }

        private void additionButton_Click(object sender, EventArgs e)
        {
            /*
             * Set result label to blank. Declare boxOne and boxTwo to be the numbers entered
             * in the text boxes. Converts string to double. Adds the two numbers and sets it to result. Converts
             * result into string and sets it to resultDisplayLabel. Catch only allows numbers to be entered into
             * the text boxes. Error message will be displayed if non-numbers are entered.
             */
            resultDisplayLabel.Text = "";
            try
            {
                double boxOne, boxTwo, result;
                boxOne = double.Parse(topNumberTextBox.Text);
                try
                {
                    boxTwo = double.Parse(bottomNumberTextBox.Text);
                    result = (boxOne + boxTwo);
                    resultDisplayLabel.Text = result.ToString("n2");
                }
                catch
                {
                    MessageBox.Show("Please enter a valid number into the second text box");
                    topNumberTextBox.Focus();
                    topNumberTextBox.Select();

                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid number into the first text box");
                bottomNumberTextBox.Focus();
                bottomNumberTextBox.Select();

            }
        }

        private void differenceButton_Click(object sender, EventArgs e)
        {
            /*
             * Set result label to blank. Declare boxOne and boxTwo to be the numbers entered
             * in the text boxes. Converts string to double. Subtracts the two numbers and sets it to result. Converts
             * result into string and sets it to resultDisplayLabel. Catch only allows numbers to be entered into
             * the text boxes. Error message will be displayed if non-numbers are entered.
             */
            resultDisplayLabel.Text = "";
            try
            {
                double boxOne, boxTwo, result;
                boxOne = double.Parse(topNumberTextBox.Text);
                try
                {
                    boxTwo = double.Parse(bottomNumberTextBox.Text);
                    result = (boxOne - boxTwo);
                    resultDisplayLabel.Text = result.ToString("n2");
                }
                catch
                {
                    MessageBox.Show("Please enter a valid number into the second text box");
                    topNumberTextBox.Focus();
                    topNumberTextBox.Select();

                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid number into the first text box");
                bottomNumberTextBox.Focus();
                bottomNumberTextBox.Select();

            }
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            /*
             * Set result label to blank. Declare boxOne and boxTwo to be the numbers entered
             * in the text boxes. Converts string to double. Divides the two numbers and sets it to result. IF
             * the denominator is a zero a message box declares it is not a valid denominator. Converts
             * result into string and sets it to resultDisplayLabel. Catch only allows numbers to be entered into
             * the text boxes. Error message will be displayed if non-numbers are entered.
             */
            resultDisplayLabel.Text = "";
            try
            {
                double boxOne, boxTwo, result;
                boxOne = double.Parse(topNumberTextBox.Text);
                try
                {
                    boxTwo = double.Parse(bottomNumberTextBox.Text);
                    result = (boxOne / boxTwo);
                    if(boxTwo == 0)
                    {
                        MessageBox.Show("Zero is not a valid denominator");
                    }
                    resultDisplayLabel.Text = result.ToString("n2");
                }
                catch
                {
                    MessageBox.Show("Please enter a valid number into the second text box");
                    topNumberTextBox.Focus();
                    topNumberTextBox.Select();
                }
 
            }
            catch
            {
                MessageBox.Show("Please enter a valid number into the first text box");
                bottomNumberTextBox.Focus();
                bottomNumberTextBox.Select();
            }


        }

        private void modulusButton_Click(object sender, EventArgs e)
        {
            /*
          /*
           * Set result label to blank. Declare boxOne and boxTwo to be the numbers entered
           * in the text boxes. Converts string to double. Mods the two numbers and sets it to result. Converts
           * result into string and sets it to resultDisplayLabel. Catch only allows numbers to be entered into
           * the text boxes. Error message will be displayed if non-numbers are entered.
           */
            resultDisplayLabel.Text = "";
            try
            {
                double boxOne, boxTwo, result;
                boxOne = double.Parse(topNumberTextBox.Text);
                try
                {
                    boxTwo = double.Parse(bottomNumberTextBox.Text);
                    result = (boxOne % boxTwo);
                    resultDisplayLabel.Text = result.ToString("n2");
                }
                catch
                {
                    MessageBox.Show("Please enter a valid number into the second text box");
                    topNumberTextBox.Focus();
                    topNumberTextBox.Select();

                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid number into the first text box");
                bottomNumberTextBox.Focus();
                bottomNumberTextBox.Select();

            }
        }


        private void powerButton_Click(object sender, EventArgs e)
        {
            /*
             * Set result label to blank. Declare boxOne and boxTwo to be the numbers entered
             * in the text boxes. Converts string to double. performs exponential function on the two numbers and sets it to result. Converts
             * result into string and sets it to resultDisplayLabel. Catch only allows numbers to be entered into
             * the text boxes. Error message will be displayed if non-numbers are entered.
             */
            resultDisplayLabel.Text = "";
            try
            {
                double boxOne, boxTwo, result;
                boxOne = double.Parse(topNumberTextBox.Text);
                try
                {
                    boxTwo = double.Parse(bottomNumberTextBox.Text);
                    result = Math.Pow(boxOne, boxTwo);
                    resultDisplayLabel.Text = result.ToString("n2");
                }
                catch
                {
                    MessageBox.Show("Please enter a valid number into the second text box");
                    topNumberTextBox.Focus();
                    topNumberTextBox.Select();

                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid number into the first text box");
                bottomNumberTextBox.Focus();
                bottomNumberTextBox.Select();

            }
        }






        private void clearButton_Click(object sender, EventArgs e)
        {
              /*
             * When the clear button is clicked or the quick access key is used the text boxes
             * and result label will clear
             */
            topNumberTextBox.Text = null;
            bottomNumberTextBox.Text = null;
            resultDisplayLabel.Text = null;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
              /*
             * When the eXit button is clicked a message box will appear with OK and Cancel options
             * The OK button will close the program and the cancel button will bring the user back
             * to the program
             */
            DialogResult dialogResult = MessageBox.Show
            ("The Program will be terminated", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.OK)
            {
                this.Close();
            }
        }


    }
}
