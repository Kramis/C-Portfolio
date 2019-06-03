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
/*
 * Author: Kraig Massee
 * Date 2/16/2019
 * Title: Lab 5 Pizza Shop
 * Known bugs: None. 
 */
namespace Kraig_Massee_Lab_5
{
    public partial class pizzaShopForm : Form
    {
        public pizzaShopForm()
        //hide order group box before login. Set the combobox items
        {
            InitializeComponent();
            orderPizzaMainGroupBox.Visible = false;
            orderGroupBox.Visible = false;
            topBarMenuStrip.Visible = false;
            specialsComboBox.Items.Add("PEPPERONI PIZZA");
            specialsComboBox.Items.Add("CHEESE PIZZA");
            specialsComboBox.Items.Add("CALZONE PIZZA");
            specialsComboBox.Items.Add("ITALIAN PIZZA");
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


        private void customerNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Lower case handling and backspace for customer name
            if (e.KeyChar >= 97 && e.KeyChar <= 122 || e.KeyChar == 8)
            {

            }
            else
            {
                passwordLoginErrorProvider.SetError(customerNameTextBox, "Lower case only");
                e.Handled = true;
            }
        }


        private void loginButton_Click(object sender, EventArgs e)
        {
            {//validating customer input name and password
                if (customerNameTextBox.Text == "kraig" && customerNumberTextBox.Text == "1234567")
                {
                    //turning off the error provider if the input is valid. Setting orderPizza group box to visible
                    MessageBox.Show("Welcome");
                    passwordLoginErrorProvider.SetError(customerNameTextBox, null);
                    passwordLoginErrorProvider.SetError(customerNumberTextBox, null);
                    orderPizzaMainGroupBox.Visible = true;
                    orderGroupBox.Visible = true;
                    topBarMenuStrip.Visible = true;
                }
                else if (customerNameTextBox.Text == "frank" && customerNumberTextBox.Text == "7654321")
                {
                    //turning off the error provider if the input is valid. Setting orderPizza group box to visible
                    MessageBox.Show("Welcome");
                    passwordLoginErrorProvider.SetError(customerNameTextBox, null);
                    passwordLoginErrorProvider.SetError(customerNumberTextBox, null);
                    orderPizzaMainGroupBox.Visible = true;
                    topBarMenuStrip.Visible = true;
                }
                else if (customerNameTextBox.Text == "jill" && customerNumberTextBox.Text == "1234321")
                {
                    //turning off the error provider if the input is valid. Setting orderPizza group box to visible
                    MessageBox.Show("Welcome");
                    passwordLoginErrorProvider.SetError(customerNameTextBox, null);
                    passwordLoginErrorProvider.SetError(customerNumberTextBox, null);
                    orderPizzaMainGroupBox.Visible = true;
                    topBarMenuStrip.Visible = true;
                }
                else
                {
                    //if either username or password is incorrect, error will show on both boxes to enter correct information.
                    MessageBox.Show("Please enter correct username and password");
                    passwordLoginErrorProvider.SetError(customerNameTextBox, " username is not acceptable");
                    passwordLoginErrorProvider.SetError(customerNumberTextBox, " password is not acceptable");
                }
            }
        }

        private void customerNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            //setting max length for customer number
            customerNumberTextBox.MaxLength = 7;
            customerNumberTextBox.PasswordChar = '*';
        }

        private void customerNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Number handling and text box space
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8)
            {

            }
            else
            {
                passwordLoginErrorProvider.SetError(customerNumberTextBox, "Numbers only");
                e.Handled = true;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            //cancel login
            customerNameTextBox.Clear();
            customerNumberTextBox.Clear();
            passwordLoginErrorProvider.SetError(customerNameTextBox, null);
            passwordLoginErrorProvider.SetError(customerNumberTextBox, null);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //declaring the buttons for exit
            DialogResult result = MessageBox.Show
               ("No pizza? do you want to exit anyway?"
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

        private void specialsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //If valid pizza is added, switch case will be selected and image and label will load.
            switch (specialsComboBox.SelectedItem)
            {
                case "PEPPERONI PIZZA":
                    {
                        pizzaPictureBox.Visible = true;
                        //Try for image load
                        try
                        {
                            //If the operation is normal,this line of code will execute
                            this.pizzaPictureBox.Image = Image.FromFile("pepperoni.jpg");
                        }
                        catch
                        {
                            //    if the operation detects picture load failure,
                            //the control will be passed to the catch statement
                            MessageBox.Show
                                ("The image for this pizza did not load."
                                , "Warning!", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                        ToolTip tt = ToolTipHelper.GetControlToolTip("");
                        tt.SetToolTip(pizzaPictureBox, "Pepperoni Pizza");
                        typeOfPizzaLabel.Text = "Pepperoni Pizza $12.99";
                    }
                    break;
                case "CHEESE PIZZA":
                    {
                        pizzaPictureBox.Visible = true;
                        //Try for image load
                        try
                        {
                            //If the operation is normal,this line of code will execute
                            this.pizzaPictureBox.Image = Image.FromFile("cheese.jpg");
                        }
                        catch
                        {
                            //    if the operation detects picture load failure,
                            //the control will be passed to the catch statement
                            MessageBox.Show
                                ("The image for this pizza did not load."
                                , "Warning!", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                        ToolTip tt = ToolTipHelper.GetControlToolTip("");
                        tt.SetToolTip(pizzaPictureBox, "Cheese Pizza");
                        typeOfPizzaLabel.Text = "Cheese Pizza $13.99";
                    }
                    break;
                case "CALZONE PIZZA":
                    {
                        pizzaPictureBox.Visible = true;
                        //Try for image load
                        try
                        {
                            //If the operation is normal,this line of code will execute
                            this.pizzaPictureBox.Image = Image.FromFile("calzone.jpg");
                        }
                        catch
                        {
                            //    if the operation detects picture load failure,
                            //the control will be passed to the catch statement
                            MessageBox.Show
                                ("The image for this pizza did not load."
                                , "Warning!", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                        ToolTip tt = ToolTipHelper.GetControlToolTip("");
                        tt.SetToolTip(pizzaPictureBox, "Calzone Pizza");
                        typeOfPizzaLabel.Text = "Calzone Pizza $14.99";
                    }
                    break;
                case "ITALIAN PIZZA":
                    {
                        pizzaPictureBox.Visible = true;
                        //Try for image load
                        try
                        {
                            //If the operation is normal,this line of code will execute
                            this.pizzaPictureBox.Image = Image.FromFile("italian.jpg");
                        }
                        catch
                        {
                            //    if the operation detects picture load failure,
                            //the control will be passed to the catch statement
                            MessageBox.Show
                                ("The image for this pizza did not load."
                                , "Warning!", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                        ToolTip tt = ToolTipHelper.GetControlToolTip("");
                        tt.SetToolTip(pizzaPictureBox, "Italian Pizza");
                        typeOfPizzaLabel.Text = "Italian Pizza $15.99";
                    }
                    break;
            }

        }


        private void arrangeButton_Click(object sender, EventArgs e)
        { 
            //sorting of combo box. remove selected index for clean sort
            specialsComboBox.Sorted = true;
            specialsComboBox.Items.Remove(specialsComboBox.SelectedIndex);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            {
                {
                    //creates input box for pizza search. While statement to continue enterig pizzas if "YES" is entered in the input box
                    string yesNoResponse = null;
                    yesNoResponse =
                    Interaction.InputBox
                    ("Do you want to search a pizza?" + Environment.NewLine + "Answer Yes or No", "Your input needed", " ");
                    string yesNoResult = yesNoResponse.ToLower();//changes the input to lower case
                    if (yesNoResult == "no")
                    {
                        MessageBox.Show("You closed the Window");
                    }
                    if (yesNoResult == " ")
                    {
                        MessageBox.Show("blank text");
                    }

                    while (yesNoResult == "yes")
                    {
                        string inputResponse = null;
                        inputResponse =
                        Interaction.InputBox
                        ("Enter the item you want to search", "Searching Pizzas");
                        string myresult = inputResponse.ToUpper();//changes the input to lower case
                            if (myresult == "PEPPERONI PIZZA")
                        {
                            MessageBox.Show("Pizza Found PEPPERONI PIZZA");
                        }

                        else if (myresult == "CHEESE PIZZA")
                        {
                            MessageBox.Show("Pizza Found CHEESE PIZZA");
                        }
                        else if (myresult == "CALZONE PIZZA")
                        {
                            MessageBox.Show("Pizza Found CALZONE");
                        }
                        else if (myresult == "CHEESE PIZZA")
                        {
                            MessageBox.Show("Pizza Found ITALIAN PIZZA");
                        }
                        else
                        {
                            MessageBox.Show("Pizza not found");
                        }

                        yesNoResponse =
                            Interaction.InputBox
                            ("Do you want to search a pizza?" + Environment.NewLine + "Answer Yes or No", "Your input needed", " ");
                            if (yesNoResponse == "no")
                        {
                            yesNoResult = "no";
                            MessageBox.Show("You closed the Window");
                        }
                            
                    }

                }
            }


        }

        private void addToShoppingCartButton_Click(object sender, EventArgs e)
        {
            //handles duplicate and no text entered. Adds pizza types to list box of price and pizza.
            if (selectedPizzaListBox.Items.Contains(orderPizzaTextBox.Text.ToUpper()))
            {
                MessageBox.Show("Duplicates not allowed");
            }
            else if (orderPizzaTextBox.Text == "CHEESE PIZZA")
            {
                passwordLoginErrorProvider.SetError(orderPizzaTextBox, null);
                selectedPizzaListBox.Items.Add(orderPizzaTextBox.Text.ToUpper());
                priceListBox.Items.Add(13.99);
                try
                {
                    //If the operation is normal,this line of code will execute
                    this.pizzaPictureBox.Image = Image.FromFile("cheese.jpg");
                }
                catch
                {
                    //    if the operation detects picture load failure,
                    //the control will be passed to the catch statement
                    MessageBox.Show
                        ("The image for this pizza did not load."
                        , "Warning!", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                ToolTip tt = ToolTipHelper.GetControlToolTip("");
                tt.SetToolTip(pizzaPictureBox, "Cheese Pizza");
                typeOfPizzaLabel.Text = "Cheese Pizza $13.99";
            }
        
            else if (orderPizzaTextBox.Text == "PEPPERONI PIZZA")
            {
                passwordLoginErrorProvider.SetError(orderPizzaTextBox, null);
                selectedPizzaListBox.Items.Add(orderPizzaTextBox.Text.ToUpper());
                priceListBox.Items.Add(12.99);
                try
                {
                    //If the operation is normal,this line of code will execute
                    this.pizzaPictureBox.Image = Image.FromFile("pepperoni.jpg");
                }
                catch
                {
                    //    if the operation detects picture load failure,
                    //the control will be passed to the catch statement
                    MessageBox.Show
                        ("The image for this pizza did not load."
                        , "Warning!", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                ToolTip tt = ToolTipHelper.GetControlToolTip("");
                tt.SetToolTip(pizzaPictureBox, "Pepperoni Pizza");
                typeOfPizzaLabel.Text = "Pepperoni Pizza $12.99";
            }
            else if (orderPizzaTextBox.Text == "CALZONE PIZZA")
            {
                passwordLoginErrorProvider.SetError(orderPizzaTextBox, null);
                selectedPizzaListBox.Items.Add(orderPizzaTextBox.Text.ToUpper());
                priceListBox.Items.Add(14.99);
                try
                {
                    //If the operation is normal,this line of code will execute
                    this.pizzaPictureBox.Image = Image.FromFile("calzone.jpg");
                }
                catch
                {
                    //    if the operation detects picture load failure,
                    //the control will be passed to the catch statement
                    MessageBox.Show
                        ("The image for this pizza did not load."
                        , "Warning!", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                ToolTip tt = ToolTipHelper.GetControlToolTip("");
                tt.SetToolTip(pizzaPictureBox, "Calzone Pizza");
                typeOfPizzaLabel.Text = "Calzone Pizza $14.99";
            }
        
            else if (orderPizzaTextBox.Text == "ITALIAN PIZZA")
            {
                passwordLoginErrorProvider.SetError(orderPizzaTextBox, null);
                selectedPizzaListBox.Items.Add(orderPizzaTextBox.Text.ToUpper());
                priceListBox.Items.Add(15.99);
                //Try for image load
                try
                {
                    //If the operation is normal,this line of code will execute
                    this.pizzaPictureBox.Image = Image.FromFile("italian.jpg");
                }
                catch
                {
                    //    if the operation detects picture load failure,
                    //the control will be passed to the catch statement
                    MessageBox.Show
                        ("The image for this pizza did not load."
                        , "Warning!", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                ToolTip tt = ToolTipHelper.GetControlToolTip("");
                tt.SetToolTip(pizzaPictureBox, "Italian Pizza");
                typeOfPizzaLabel.Text = "Italian Pizza $15.99";
            }
            else
            {
                MessageBox.Show("Please enter valid Pizza name");
            }
            orderPizzaTextBox.ResetText();
        }

        private void removeFromCartButton_Click(object sender, EventArgs e)
        {
            //allows individual clearing of either price or pizza.
            try
            {
                selectedPizzaListBox.Items.RemoveAt(selectedPizzaListBox.SelectedIndex);
            }
            catch
            {
            MessageBox.Show("Price Removed");
            }
            try
            {
                priceListBox.Items.RemoveAt(priceListBox.SelectedIndex);
            }
            catch
            {
                MessageBox.Show("Pizza Removed");
            }
        }


        private void orderPizzaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Upper case handling and backspace
            if (e.KeyChar >= 65 && e.KeyChar <= 90 || e.KeyChar == 8 || e.KeyChar == 32)
            {

            }
            else
            {
                passwordLoginErrorProvider.SetError(orderPizzaTextBox, "Upper case only");
                e.Handled = true;
            }
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            //clears all forms
            priceListBox.Items.Clear();
            selectedPizzaListBox.Items.Clear();
            typeOfPizzaLabel.Text = "";
            pizzaPictureBox.Image = null;
            customerNameTextBox.Text = null;
            customerNumberTextBox.Text = null;
            orderPizzaMainGroupBox.Visible = false;
            topBarMenuStrip.Visible = false;
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Menustrip button
            loginButton.PerformClick();
        }

        private void eXitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Menustrip button
            exitButton.PerformClick();
        }

        private void addToShoppingCartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Menustrip button
            addToShoppingCartButton.PerformClick();
        }

        private void removeFromTheCartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Menustrip button
            removeFromCartButton.PerformClick();
        }

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Menustrip button
            clearAllButton.PerformClick();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Menustrip button
            searchButton.PerformClick();
        }

        private void arrangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Menustrip button
            arrangeButton.PerformClick();
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Menustrip button
            cancelButton.PerformClick();
        }

        private void eXitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //Menustrip button
            exitButton.PerformClick();
        }

        private void selectedPizzaListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}