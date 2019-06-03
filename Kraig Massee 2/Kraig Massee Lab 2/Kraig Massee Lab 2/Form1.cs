//Program: Picture Box
//Date: January 2019
//Author: Kraig Massee

//Displays a form with multiple picture boxes and controls to manipulate picture boxes and labels. Contains a clear button to clear
//the picture boxes and labels and an exit button to exit the program
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Kraig_Massee_Lab_2
{
    public partial class pictureBoxForm : Form
    {
        public pictureBoxForm()
        {
            InitializeComponent();
        }

        private void pictureBoxForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //When the eXit button is click this will show a Message box and then close the program
            MessageBox.Show("The Program will be terminated");
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //When the Clear button is clicked this method clears all picture box images and the labels associated with them
            onePictureBox.Image = null;
            twoPictureBox.Image = null;
            threePictureBox.Image = null;
            fourPictureBox.Image = null;
            fivePictureBox.Image = null;
            onePictureBoxLabel.Text = null;
            twoPictureBoxLabel.Text = null;
            threePictureBoxLabel.Text = null;
            fourPictureBoxLabel.Text = null;
            fivePictureBoxLabel.Text = null;
        }

        private void onePictureBoxLabel_Click(object sender, EventArgs e)
        {

        }

        private void twoPictureBoxLabel_Click(object sender, EventArgs e)
        {

        }

        private void threePictureBoxLabel_Click(object sender, EventArgs e)
        {

        }

        private void fourPictureBoxLabel_Click(object sender, EventArgs e)
        {

        }

        private void fivePictureBoxLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void onePictureBox_Click(object sender, EventArgs e)
        {
            //This sets the onePictureBoxLabel to visible on click of the onePictureBox
            onePictureBoxLabel.Visible = true;
        }

        private void twoPictureBox_Click(object sender, EventArgs e)
        {
            //This sets the twoPictureBoxLabel to visible on click of the twoPictureBox
            twoPictureBoxLabel.Visible = true;
        }

        private void threePictureBox_Click(object sender, EventArgs e)
        {
            //This sets the threePictureBoxLabel to visible on click of the threePictureBox
            threePictureBoxLabel.Visible = true;
        }

        private void fourPictureBox_Click(object sender, EventArgs e)
        {
            //This sets the fourPictureBoxLabel to visible on click of the fourPictureBox
            fourPictureBoxLabel.Visible = true;
        }

        private void fivePictureBox_Click(object sender, EventArgs e)
        {
            //This sets the fivePictureBoxLabel to visible on click of the fivePictureBox
            fivePictureBoxLabel.Visible = true;
        }
    }
}
