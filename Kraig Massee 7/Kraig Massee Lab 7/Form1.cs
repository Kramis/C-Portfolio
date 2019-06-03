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

namespace Kraig_Massee_Lab_7
{
    public partial class wordProcessorForm : Form
    {
        public wordProcessorForm()
        {
            InitializeComponent();
        }


        private void wordProcessorForm_Load(object sender, EventArgs e)
        {
            //Set images for buttons in toolstrip
            myToolStrip.ImageList = myImageList;
            closeButton.ImageIndex = 0;
            saveButton.ImageIndex = 1;
            openButton.ImageIndex = 2;
            cutButton.ImageIndex = 3;
            copyButton.ImageIndex = 4;
            pasteButton.ImageIndex = 5;
            undoButton.ImageIndex = 6;
            redoButton.ImageIndex = 7;
            alignCenterButton.ImageIndex = 8;
            alignLeftButton.ImageIndex = 9;
            alignRightButton.ImageIndex = 10;
            wordCountButton.ImageIndex = 11;
            clearButton.ImageIndex = 12;
        }
                
        private void colorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                // choices to edit text in myRichTextBox
                switch (colorComboBox.SelectedIndex)
                {
                    case 0: //Allows change of color through color picker
                        myColorDialog.ShowDialog();
                        myRichTextBox.SelectionColor = myColorDialog.Color;
                        break;
                    case 1: //Allows change of font through font picker
                        myFontDialog.ShowDialog();
                        myRichTextBox.SelectionFont = myFontDialog.Font;
                        break;
                    case 2:
                        //User can type in color to choose color of text
                        string inputResponse = null;
                        inputResponse =
                        Interaction.InputBox
                        ("Type in a color" + Environment.NewLine + "Example: Red, Green Blue", " ");
                        string myresult = inputResponse.ToUpper();//changes the input to upper case                      
                        myRichTextBox.SelectionColor = Color.FromName(myresult); //Changes color to typed color
                        break;
                    case 3: //Resets color and font.
                        myRichTextBox.SelectionColor = Color.Empty;
                        myRichTextBox.Font = new Font(myRichTextBox.Font, FontStyle.Regular);
                        break;
                }
            }
        }


        private void alignRightButton_Click(object sender, EventArgs e)
        {
            {
                //align right
                myRichTextBox.SelectionAlignment = HorizontalAlignment.Right;
            }
        }

        private void alignLeftButton_Click(object sender, EventArgs e)
        {

            //align left
            myRichTextBox.SelectionAlignment = HorizontalAlignment.Left;

        }

        private void alignCenterButton_Click(object sender, EventArgs e)
        {
            {
                //align center
                myRichTextBox.SelectionAlignment = HorizontalAlignment.Center;
            }
        }

        private void pasteButton_Click(object sender, EventArgs e)
        {
            // Determine if there is any text in the Clipboard to paste into the text box.
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                // Determine if any text is selected in the text box.
                if (myRichTextBox.SelectionLength > 0)
                {
                    // Ask user if they want to paste over currently selected text.
                    if (MessageBox.Show("Do you want to paste over current selection?", "Cut Example", MessageBoxButtons.YesNo) == DialogResult.No)
                        // Move selection to the point after the current selection and paste.
                        myRichTextBox.SelectionStart = myRichTextBox.SelectionStart + myRichTextBox.SelectionLength;
                }
                // Paste current text in Clipboard into text box.
                myRichTextBox.Paste();
            }
        }

        private void cutButton_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    // Ensure that text is currently selected in the text box.   
                    if (myRichTextBox.SelectedText != "")
                        // Cut the selected text in the control and paste it into the Clipboard.
                        myRichTextBox.Cut();
                }
            }
            catch
            {
                MessageBox.Show("No text selected");
            }
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    // Ensure that text is selected in the text box.   
                    if (myRichTextBox.SelectionLength > 0)
                        // Copy the selected text to the Clipboard.
                        myRichTextBox.Copy();
                }
            }
            catch
            {
                MessageBox.Show("No text selected");
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            { //Opens save .rtf file form
                SaveFileDialog mySaveFile = new SaveFileDialog();
                mySaveFile.Filter = "RTF Files|*.rtf";
                if (mySaveFile.ShowDialog() ==
                    DialogResult.OK && mySaveFile.FileName != null)
                {
                    myRichTextBox.SaveFile(mySaveFile.FileName, RichTextBoxStreamType.RichText);
                }
            }
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            try 
            { //Opens open .rtf file form
                OpenFileDialog myOpenFile = new OpenFileDialog();
                myOpenFile.Filter = "RTF Files|*.RTF";
                if (myOpenFile.ShowDialog() == DialogResult.OK)
                {
                    if (myOpenFile.FileName != null)
                    {
                        myRichTextBox.Clear();
                        myRichTextBox.LoadFile(myOpenFile.FileName);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Failed to open the file");
            }
        }

        private void wordCountButton_Click(object sender, EventArgs e)
        {
            {   //Counts words in between spaces of selected text
                string counter = myRichTextBox.SelectedText.Trim();
                string[] words = counter.Split(' ');
                MessageBox.Show("The number of words is " + words.Length.ToString());
            }
        }

        private void openNotePadButton_Click(object sender, EventArgs e)
        {
            try
            { //Opens Notepad.exe
                System.Diagnostics.Process[] myProcess =
                    System.Diagnostics.Process.GetProcessesByName("Notepad");
                if (myProcess.Length > 0)
                {
                    MessageBox.Show("Notepad is already open");
                }
                else
                {
                    notePadProcess.EnableRaisingEvents = true;
                    notePadProcess.Start();
                    noteToolStripStatusLabel.Text = "Notepad is running";
                }
            }
            catch
            {
                MessageBox.Show("Cannot open notepad");
            }
        }

        private void closeNotePadButton_Click(object sender, EventArgs e)
        {
            {
                try
                { //Closes notepad, various error messages if complication
                    System.Diagnostics.Process[] myProcess =
                        System.Diagnostics.Process.GetProcessesByName("Notepad");
                    if (myProcess.Length > 0)
                    {
                        notePadProcess.Kill();
                        noteToolStripStatusLabel.Text = "notepad is stopped";
                        MessageBox.Show("Notepad was terminated");
                    }
                    else
                    {
                        MessageBox.Show("Notepad is not running");
                    }
                }
                catch
                {
                    MessageBox.Show("error Closing notepad");
                }
            }
        }

        private void openChromeButton_Click(object sender, EventArgs e)
        {
            {
                try
                { //Opens Chrome.exe
                    System.Diagnostics.Process[] myProcess =
                        System.Diagnostics.Process.GetProcessesByName("Chrome");
                    if (myProcess.Length > 0)
                    {
                        MessageBox.Show("Chrome is already open");
                    }
                    else
                    {
                        chromeProcess.EnableRaisingEvents = true;
                        chromeProcess.Start();
                        noteToolStripStatusLabel.Text = "Chrome is running";
                    }
                }
                catch
                {
                    MessageBox.Show("Cannot open Chrome");
                }
            }
        }

        private void closeChromeButton_Click(object sender, EventArgs e)
        {
            {
                try
                {   //Closes Chrome, various error messages if complication
                    System.Diagnostics.Process[] myProcess =
                        System.Diagnostics.Process.GetProcessesByName("Chrome");
                    if (myProcess.Length > 0)
                    {
                        chromeProcess.Kill();
                        noteToolStripStatusLabel.Text = "Chrome is stopped";
                        MessageBox.Show("Chrome was terminated");
                    }
                    else
                    {
                        MessageBox.Show("Chrome is not running");
                    }
                }
                catch
                {
                    MessageBox.Show("error Closing Chrome");
                }
            }
        }

        private void openWordButton_Click(object sender, EventArgs e)
        {
            {
                try
                {   //Opens WinWord.exe
                    System.Diagnostics.Process[] myProcess =
                        System.Diagnostics.Process.GetProcessesByName("WINWORD");
                    if (myProcess.Length > 0)
                    {
                        MessageBox.Show("Word is already open");
                    }
                    else
                    {
                        wordProcess.EnableRaisingEvents = true;
                        wordProcess.Start();
                        noteToolStripStatusLabel.Text = "Word is running";
                    }
                }
                catch
                {
                    MessageBox.Show("Cannot open Word");
                }
            }
        }

        private void closeWordButton_Click(object sender, EventArgs e)
        {
            {
                try
                {   //Closes Word, various error messages if complication
                    System.Diagnostics.Process[] myProcess =
                        System.Diagnostics.Process.GetProcessesByName("WINWORD");
                    if (myProcess.Length > 0)
                    {
                        wordProcess.Kill();
                        noteToolStripStatusLabel.Text = "Word is stopped";
                        MessageBox.Show("Word was terminated");
                    }
                    else
                    {
                        MessageBox.Show("Word is not running");
                    }
                }
                catch
                {
                    MessageBox.Show("error Closing Word");
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        { //Clears rich text box
            myRichTextBox.Text = " ";
        }

        private void redoButton_Click(object sender, EventArgs e)
        {
            {
                // Determines if a Redo operation can be performed.
                if (myRichTextBox.CanRedo == true)
                {
                    // Determines if the redo operation deletes text.
                    if (myRichTextBox.RedoActionName != "Delete")
                        // Perform the redo.
                        myRichTextBox.Redo();
                }
            }
        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            {
                // Determine if last operation can be undone in text box.   
                if (myRichTextBox.CanUndo == true)
                {
                    // Undo the last operation.
                    myRichTextBox.Undo();
                }
            }

        }

        private void myTimer_Tick(object sender, EventArgs e)
        {   //Sets status label to current time
            timeToolStripStatusLabel.Text = DateTime.Now.ToString();
        }

        private void availableDateTimePicker_ValueChanged(object sender, EventArgs e) {

            if (availableComboBox.Items.Contains(availableDateTimePicker.Value.ToString()))
                { //Duplicate validation
                MessageBox.Show("The date is not available");
                }
            else
            { //Add value to combobox
                availableComboBox.Items.Add(availableDateTimePicker.Value.ToString());
                MessageBox.Show("The date has been added");
            }
        }

        private void addScheduleToArrayButton_Click(object sender, EventArgs e)
        {
           
            {
                //We create a string array. The size of it is equal to the number of items we have in our listbox
                string[] testList = new string[availableComboBox.Items.Count];
                //we read the content of the list box and store them into an array
                for (int index = 0; index < availableComboBox.Items.Count; index++)
                {
                    testList[index] = availableComboBox.Items[index].ToString();
                    if (myAvailabilityTextBox.Text.Contains(testList[index]))
                    {
                        MessageBox.Show("Duplicates not allowed");
                    }
                    else
                    {
                        //we display the content of the array into a textbox
                        myAvailabilityTextBox.Text += (testList[index].ToString()) + Environment.NewLine;
                    }
                }

            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //declaring the buttons for exit
            DialogResult result = MessageBox.Show
               ("Do you want to save the text file?"
               , "Question", MessageBoxButtons.YesNoCancel,
               MessageBoxIcon.Information);
            //If result is Yes, close the program.
            if (result == DialogResult.No)
                {
                    this.Close();
                }
            else if (result == DialogResult.Cancel)
                {
                MessageBox.Show("Enjoy the program");
                }
                else
                {
                    saveButton.PerformClick();
                    this.Close();
                }
            }

        private void timeToolStripStatusLabel_Click(object sender, EventArgs e)
        {

        }
    }
    }
