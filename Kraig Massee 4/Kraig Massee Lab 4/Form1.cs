using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

/*Lab 4
Due Date: 2/4/2019
Programmer: Kraig Massee
Class: CIS 130N
known bugs: None. For readability I should have named the radioButtons with the prefix of "Oregon", "Washington", and "California" 
                   with the control type being set at the end of the name.
*/

namespace Kraig_Massee_Lab_4
{
    public partial class stateForm : Form
    {
        public stateForm()
        {
            InitializeComponent();
            //Sets the check box controlled controls to non-visible
            phoneNumberMaskTextBox.Visible = false;
            changeColorGroupBox.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void groupBoxRadioButtons_Enter(object sender, EventArgs e)
        {

        }
        private void climateNoChangeLabel_Click(object sender, EventArgs e)
        {

        }
        private void phoneCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //making the masked text box visible or invisible
            if (phoneCheckBox.Checked)
            {
                phoneNumberMaskTextBox.Visible = true;
            }
            else
            {
                phoneNumberMaskTextBox.Visible = false;
            }
        }

        private void changeColorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //making the change background color group box visible or invisible
            if (changeColorCheckBox.Checked)
            {
                changeColorGroupBox.Visible = true;
            }
            else
            {
                changeColorGroupBox.Visible = false;
            }
        }

        private void backgroundColorButton_Click(object sender, EventArgs e)
        {
            /*using switch conditional structure to detect user's choice entered in backgroundColorTextBox
             * and setting it to the specified color when backgroundColorButton is clicked
             */

            switch (backgroundColorTextBox.Text.ToLower())
            {
                case "green":
                    changeColorGroupBox.BackColor = Color.Green;
                    break;
                case "blue":
                    changeColorGroupBox.BackColor = Color.Blue;
                    break;
                case "red":
                    changeColorGroupBox.BackColor = Color.Red;
                    break;
                case "purple":
                    changeColorGroupBox.BackColor = Color.Purple;
                    break;
                case "pink":
                    changeColorGroupBox.BackColor = Color.Pink;
                    break;
                case "reset":
                    changeColorGroupBox.BackColor = SystemColors.Control;
                    break;
                default:
                    MessageBox.Show("Enter Green, Blue, Red, Pink, Purple, or Reset");
                    break;
            }
        }

        private void inputBoxButton_Click(object sender, EventArgs e)
        {
            string inputResponse = null;
            // This will prompt the user if they want to go into any of these states
            inputResponse =
                Interaction.InputBox
                ("Do you want to go to any of these states?" + Environment.NewLine + "Answer Yes or No", "Your input needed", " ");
            string myresult = inputResponse.ToLower();//changes the input to lower case
            if (myresult == "yes")
            {
                MessageBox.Show("Your answer was YES");
            }
            else if (myresult == "no")
            {
                MessageBox.Show("your answer was NO");
            }
            else if (myresult == "")
            {
                MessageBox.Show("You Canceled the box");
            }

            else if (myresult == " ")
            {
                MessageBox.Show("You entered blank text!");
            }
            else
            {
                MessageBox.Show("Please enter Yes or No");
            }
        }

        class ToolTipHelper
        //A Class instance of the tt variable. Reusable.
        {
            private static readonly Dictionary<string, ToolTip> tooltips = new Dictionary<string, ToolTip>();

            public static ToolTip GetControlToolTip(string controlName)
            {
                if (tooltips.ContainsKey(controlName))
                {
                    return tooltips[controlName];
                }
                else
                {
                    ToolTip tt = new ToolTip();
                    tooltips.Add(controlName, tt);
                    return tt;
                }
            }
        }



        private void radioButtonOregon_CheckedChanged(object sender, EventArgs e)
        {
            /*Makes visible the information for the radioButtonOregon information visible.
             *Sets the background color, loads the image into the picture box.
             *Sets the tooltip defined in the ToolTipHelper class to the desired value.
             *Sets the label information
             */
            statePictureBox.Visible = true;
            stateInformationGroupBox.Visible = true;
            stateInformationGroupBox.BackColor = Color.Green;
            //Try for image load
            try
            {
                //If the operation is normal,this line of code will execute
                this.statePictureBox.Image = Image.FromFile("Oregon.jpg");
            }
            catch
            {
                //    if the operation detects picture load failure,
                //the control will be passed to the catch statement
                MessageBox.Show
                    ("The image for this State did not load."
                    , "Warning!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            ToolTip tt = ToolTipHelper.GetControlToolTip("");
            tt.SetToolTip(statePictureBox, "A view of Mt. Hood");
            mainStateLabel.Text = "State of Oregon";
            populationInformationLabel.Text = "The State of Oregon has about 2 million people";
            climateInformationLabel.Text = "Oregon's Climate is mild";
            nickNameInformationLabel.Text = "The Beaver State";
        }

        private void radioButtonWashington_CheckedChanged(object sender, EventArgs e)
        {
            /*Makes visible the information for the radioButtonWashington information visible.
            *Sets the background color, loads the image into the picture box.
            *Sets the tooltip defined in the ToolTipHelper class to the desired value.
            *Sets the label information
            */
            statePictureBox.Visible = true;
            stateInformationGroupBox.Visible = true;
            stateInformationGroupBox.BackColor = Color.MediumPurple;
            //Try for image load
            try
            {
                //If the operation is normal,this line of code will execute
                this.statePictureBox.Image = Image.FromFile("Washington.jpg");
            }
            catch
            {
                //    if the operation detects picture load failure,
                //the control will be passed to the catch statement
                MessageBox.Show
                    ("The image for this State did not load."
                    , "Warning!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            ToolTip tt = ToolTipHelper.GetControlToolTip("");
            tt.SetToolTip(statePictureBox, "A view of Seattle");
            mainStateLabel.Text = "State of Washington";
            populationInformationLabel.Text = "The State of Washington has about 7 million people";
            climateInformationLabel.Text = "Washington's climate is mild, with a moderate" + Environment.NewLine + "amount of rain";
            nickNameInformationLabel.Text = "The Evergreen State";
        }

        private void radioButtonCalifornia_CheckedChanged(object sender, EventArgs e)
        {
            /*Makes visible the information for the radioButtonCalifornia information visible.
            Sets the background color, loads the image into the picture box.
            *Sets the tooltip defined in the ToolTipHelper class to the desired value.
            *Sets the label information
            */
            statePictureBox.Visible = true;
            stateInformationGroupBox.Visible = true;
            stateInformationGroupBox.BackColor = Color.Orange;
            //Try for image load
            try
            {
                //If the operation is normal,this line of code will execute
                this.statePictureBox.Image = Image.FromFile("California.jpg");
            }
            catch
            {
                //    if the operation detects picture load failure,
                //the control will be passed to the catch statement
                MessageBox.Show
                    ("The image for this State did not load."
                    , "Warning!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            ToolTip tt = ToolTipHelper.GetControlToolTip("");
            tt.SetToolTip(statePictureBox, "A view of a Californian pier");
            mainStateLabel.Text = "State of California";
            populationInformationLabel.Text = "The State of California has about 40 million people";
            climateInformationLabel.Text = "California's climate is varied.";
            nickNameInformationLabel.Text = "The Golden State";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            /* Clears the radio buttons, makes the MaskedTextBox invisible and changeColorGroup box invisible
             * Unchecks the check mark controls. Clears the text boxes, sets the backgroundColorGroupBox to default.
             */
            radioButtonOregon.Checked = false;
            radioButtonWashington.Checked = false;
            radioButtonCalifornia.Checked = false;
            phoneNumberMaskTextBox.Visible = false;
            phoneCheckBox.Checked = false;
            changeColorGroupBox.Visible = false;
            changeColorCheckBox.Checked = false;
            statePictureBox.Visible = false;
            stateInformationGroupBox.Visible = false;
            phoneNumberMaskTextBox.Clear();
            backgroundColorTextBox.Clear();
            changeColorGroupBox.BackColor = SystemColors.Control;

        }

        private void phoneNumberMaskTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //declaring the buttons
            DialogResult result = MessageBox.Show
               ("input exist, do you want to exit anyway?"
               , "Question", MessageBoxButtons.YesNoCancel,
               MessageBoxIcon.Information);
            //If result is Yes, close the program.
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("You clicked on Yes. Thanks for using the program");
                this.Close();
            }
            // if the result is no display a message and go back to the program.
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Enjoy the program");
            }
        }

        private void eXitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //menu bar exit click will perform exitButton function.
            exitButton.PerformClick();
        }

        private void oregonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //menu bar Oregon click will perform radiobuttonOregon function.
            radioButtonOregon.PerformClick();
        }

        private void washingtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //menu bar Oregon click will perform radiobuttonWashington function.
            radioButtonWashington.PerformClick();
        }

        private void californiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //menu bar Oregon click will perform radiobuttonCalifornia function.
            radioButtonCalifornia.PerformClick();
        }

        private void inputBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //menu bar Input Box will perform inputBox Button function.
            inputBoxButton.PerformClick();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //menu bar Clear click will perform the 
            clearButton.PerformClick();
        }
    }

}

