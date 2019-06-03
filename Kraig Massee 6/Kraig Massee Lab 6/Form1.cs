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
using System.IO;

namespace Kraig_Massee_Lab_6
{
    public partial class electoralCollegeForm : Form
    {
        public electoralCollegeForm()
        {
            InitializeComponent();
            {
                try
                {
                    //Will open state-codes.txt file and display the content into a listbox
                    string state;
                    StreamReader inputFile;
                    inputFile = File.OpenText("state-codes.txt");
                    loadSectionComboBox.Items.Clear();
                    while (!inputFile.EndOfStream)
                    {
                        state = inputFile.ReadLine();

                        loadSectionComboBox.Items.Add(state);
                    }
                    inputFile.Close();
                }
                catch
                {
                    MessageBox.Show("Wrong Operation!");
                }
            }
        }

        private void updateList(Dictionary<string, string> dict, ListView list) //List items to hold added subitem names
        {
            #region Sort
            list.Items.Clear();

            string[] arrays = dict.Keys.ToArray();
            int num = 0;
            while (num <= dict.Count)
            {
                if (num == dict.Count)
                {
                    break;
                }
                ListViewItem lvi;
                ListViewItem.ListViewSubItem lvsi;

                lvi = new ListViewItem();
                lvi.Text = dict[arrays[num]].ToString();
                lvi.ImageIndex = 0;
                lvi.Tag = dict[arrays[num]].ToString();

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = arrays[num];
                lvi.SubItems.Add(lvsi);

                list.Items.Add(lvi);

                list.EndUpdate();

                num++;
            }
            //end
            #endregion
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

        private void loadSectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Switch case to set stateTextBox text and load the associated image and tooltip
            switch (loadSectionComboBox.SelectedItem)
            {
                case "OR":
                    {
                        stateTextBox.Text = "State of Oregon";
                        stateImagePictureBox.Visible = true;
                        //Try for image load
                        try
                        {
                            //If the operation is normal,this line of code will execute
                            this.stateImagePictureBox.Image = Image.FromFile("oregon.jpg");
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
                        tt.SetToolTip(stateImagePictureBox, "Flag of Oregon");
                    }
                    break;

                case "WA":
                    {
                        stateTextBox.Text = "State of Washington";
                        stateImagePictureBox.Visible = true;
                        //Try for image load
                        try
                        {
                            //If the operation is normal,this line of code will execute
                            this.stateImagePictureBox.Image = Image.FromFile("washington.jpg");
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
                        tt.SetToolTip(stateImagePictureBox, "Flag of Washington");
                    }
                    break;
                case "CA":
                    {
                        stateTextBox.Text = "State of California";
                        stateImagePictureBox.Visible = true;
                        //Try for image load
                        try
                        {
                            //If the operation is normal,this line of code will execute
                            this.stateImagePictureBox.Image = Image.FromFile("california.jpg");
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
                        tt.SetToolTip(stateImagePictureBox, "Flag of California");
                    }
                    break;
                case "NY":
                    {
                        stateTextBox.Text = "State of New York";
                        stateImagePictureBox.Visible = true;
                        //Try for image load
                        try
                        {
                            //If the operation is normal,this line of code will execute
                            this.stateImagePictureBox.Image = Image.FromFile("newyork.jpg");
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
                        tt.SetToolTip(stateImagePictureBox, "Flag of New York");
                    }
                    break;
                case "ID":
                    {
                        stateTextBox.Text = "State of Idaho";
                        stateImagePictureBox.Visible = true;
                        //Try for image load
                        try
                        {
                            //If the operation is normal,this line of code will execute
                            this.stateImagePictureBox.Image = Image.FromFile("idaho.jpg");
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
                        tt.SetToolTip(stateImagePictureBox, "Flag of Idaho");
                    }
                    break;
                case "TX":
                    {
                        stateTextBox.Text = "State of Texas";
                        stateImagePictureBox.Visible = true;
                        //Try for image load
                        try
                        {
                            //If the operation is normal,this line of code will execute
                            this.stateImagePictureBox.Image = Image.FromFile("texas.jpg");
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
                        tt.SetToolTip(stateImagePictureBox, "Flag of Texas");
                    }
                    break;
                case "MI":
                    {
                        stateTextBox.Text = "State of Michigan";
                        stateImagePictureBox.Visible = true;
                        //Try for image load
                        try
                        {
                            //If the operation is normal,this line of code will execute
                            this.stateImagePictureBox.Image = Image.FromFile("michigan.jpg");
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
                        tt.SetToolTip(stateImagePictureBox, "Flag of Michigan");
                    }
                    break;
            }
        }



        private void fileProcessButton_Click(object sender, EventArgs e)
        {
            //Ensures a state has been selected in the combobox
            if (stateTextBox.Text == "")
            {
                MessageBox.Show
                ("Please select a state from the dropdown."
                , "Warning!", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            else
            {
                //Adds selected State info to listview
                AddInformationToList();
            }
            {
                //Searches for duplicate text within list view to find if duplicates are being added
                Dictionary<string, string> dict = new Dictionary<string, string>();

                int num = 0;
                while (num <= electoralVotesListView.Items.Count)
                {
                    if (num == electoralVotesListView.Items.Count)
                    {
                        break;
                    }
                    //error duplicate message box
                    if (dict.ContainsKey(electoralVotesListView.Items[num].SubItems[1].Text).Equals(true))
                    {
                        MessageBox.Show
                        ("No Duplicates"
                        , "Warning!", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    }

                    if (dict.ContainsKey(electoralVotesListView.Items[num].SubItems[1].Text).Equals(false))
                    {
                        dict.Add(electoralVotesListView.Items[num].SubItems[1].Text, electoralVotesListView.Items[num].SubItems[0].Text);
                    }
                    num++;
                }
                updateList(dict, electoralVotesListView);
            }

        }
            public void AddInformationToList()
            //Adds information to the list view
            {
            if (stateTextBox.Text.Contains("State of Oregon"))
            {
                ListViewItem oregon = electoralVotesListView.Items.Add(stateTextBox.Text);
                oregon.SubItems.Add("7");
                oregon.SubItems.Add("Voted Democrat");
               
            }
            else if (stateTextBox.Text.Contains("State of Washington"))
            {
                ListViewItem washington = electoralVotesListView.Items.Add(stateTextBox.Text);
                washington.SubItems.Add("12");
                washington.SubItems.Add("Voted Democrat");
                
            }
            else if (stateTextBox.Text.Contains("State of California"))
            {
                ListViewItem california = electoralVotesListView.Items.Add(stateTextBox.Text);
                california.SubItems.Add("55");
                california.SubItems.Add("Voted Democrat");
                
            }
            else if (stateTextBox.Text.Contains("State of New York"))
            {
                ListViewItem newyork = electoralVotesListView.Items.Add(stateTextBox.Text);
                newyork.SubItems.Add("29");
                newyork.SubItems.Add("Voted Democrat");
                
            }
            else if (stateTextBox.Text.Contains("State of Idaho"))
            {
                ListViewItem idaho = electoralVotesListView.Items.Add(stateTextBox.Text);
                idaho.SubItems.Add("4");
                idaho.SubItems.Add("Voted Republican");
                
            }
            else if (stateTextBox.Text.Contains("State of Texas"))
            {
                ListViewItem texas = electoralVotesListView.Items.Add(stateTextBox.Text);
                texas.SubItems.Add("38");
                texas.SubItems.Add("Voted Republican");
                
            }
            else if (stateTextBox.Text.Contains("State of Michigan"))
            {
                ListViewItem michigan = electoralVotesListView.Items.Add(stateTextBox.Text);
                michigan.SubItems.Add("16");
                michigan.SubItems.Add("Voted Republican");
            }


        }
        
    
        private void appendButton_Click(object sender, EventArgs e)
        {
            {

                //this works after referncing Microsoft Visual Basic
                string inputResponse = null;
                // This will prompted the user for a question and check to see if the user entered Yes or No
                inputResponse =
                Interaction.InputBox
                ("Enter State name" + Environment.NewLine + "Example: NY, ID, TX, MI", " ");
                string myresult = inputResponse.ToUpper();//changes the input to upper case
                if (loadSectionComboBox.Items.Contains(myresult))
                {
                    MessageBox.Show("Duplicate not allowed", "Error");
                }
                //Adds abbreviation to combobox and then writes this to text file
                else if (myresult == "NY")
                {
                    loadSectionComboBox.Items.Add("NY");
                    StreamWriter outputFile;
                    outputFile = File.AppendText("state-codes.txt");
                    outputFile.WriteLine("NY");
                    outputFile.Close();

                }
                else if (myresult == "ID")
                {
                    loadSectionComboBox.Items.Add("ID");
                    StreamWriter outputFile;
                    outputFile = File.AppendText("state-codes.txt");
                    outputFile.WriteLine("ID");
                    outputFile.Close();

                }

                else if (myresult == "TX")
                {
                    loadSectionComboBox.Items.Add("TX");
                    StreamWriter outputFile;
                    outputFile = File.AppendText("state-codes.txt");
                    outputFile.WriteLine("TX");
                    outputFile.Close();

                }

                else if (myresult == "MI")
                {
                    loadSectionComboBox.Items.Add("MI");
                    StreamWriter outputFile;
                    outputFile = File.AppendText("state-codes.txt");
                    outputFile.WriteLine("MI");
                    outputFile.Close();

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
                    MessageBox.Show("Please enter valid State name");
                }
                
            }

        }

        public void totalElectoralVotesButton_Click(object sender, EventArgs e)
        {
            //allows totaling of values in Electoral vote section of list view
            int total = 0;

            if (null != electoralVotesListView.FindItemWithText("7"))
            {
                total += 7;
            }

            if (null != electoralVotesListView.FindItemWithText("12"))
            {
                total += 12;
            }

            if (null != electoralVotesListView.FindItemWithText("55"))
            {
                total += 55;
            }

            if (null != electoralVotesListView.FindItemWithText("29"))
            {
                total += 29;
            }

            if (null != electoralVotesListView.FindItemWithText("4"))
            {
                total += 4;
            }

            if (null != electoralVotesListView.FindItemWithText("38"))
            {
                total += 38;
            }

            if (null != electoralVotesListView.FindItemWithText("16"))
            {
                total += 16;
            }
            string totalString = total.ToString();
            totalElectoralVotesLabel.Text = "Total Electoral Votes: " + totalString;
        }
        
        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            electoralVotesGroupBox.BackColor = Color.Red;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            electoralVotesGroupBox.BackColor = Color.Green;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            electoralVotesGroupBox.BackColor = Color.Blue;
        }

        private void purpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            electoralVotesGroupBox.BackColor = SystemColors.Control;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear various combobox and text box. Set groupbox background color to control.
            stateTextBox.Text = null;
            loadSectionComboBox.Text = null;
            electoralVotesGroupBox.BackColor = SystemColors.Control;
            totalElectoralVotesLabel.Text = null;
            stateImagePictureBox.Image = null;
            //Clear list box
            electoralVotesListView.Items.Clear();
            electoralVotesListView.Refresh();

        }
        private void baclgroundContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Dialog result yes will save state of text file.
            //Cancel will close exit button message box
            {
                //declaring the buttons for exit
                DialogResult result = MessageBox.Show
                   ("Do you want to save the text file?"
                   , "Question", MessageBoxButtons.YesNoCancel,
                   MessageBoxIcon.Information);
                //If result is Yes, close the program.
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("You clicked on Yes. Thanks for using the program");
                    StreamWriter outputFile;
                    outputFile = File.AppendText("state-codes.txt");
                    outputFile.Close();
                    this.Close();
                }
                // if the result is no display message and exit program
                else if (result == DialogResult.No)
                {
                    MessageBox.Show("File not saved");
                    this.Close();
                }
            }

        }
    }
    
}

