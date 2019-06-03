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

namespace Kraig_Massee_Lab_8
{
    public partial class bookStoreForm : Form
    {
        public bookStoreForm()
        {
            // Set various group box to invisible until login. Add items to combobox
            InitializeComponent();
            bookSelectionGroupBox.Visible = false;
            selectedBooksGroupBox.Visible = false;
            shoppingCartGroupBox.Visible = false;
            processGroupBox.Visible = false;
            discountBooksTextBoxLabel.Visible = false;
            bookSelectionComboBox.Items.Add("Programming");
            bookSelectionComboBox.Items.Add("HTML");
            bookSelectionComboBox.Items.Add("CSS");
        }

        private void userNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Lower case handling and backspace for user name
            if (e.KeyChar >= 97 && e.KeyChar <= 122 || e.KeyChar == 8)
            {
            }
            else
            {
                myErrorProvider.SetError(userNameTextBox, "Lower case only");
                e.Handled = true;
            }

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //Exclude masked text box format for matching login credentials
            if (phoneNumberMaskedTextBox.MaskFull)
            {
                phoneNumberMaskedTextBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            }
            else
            {
                MessageBox.Show("Enter password");
            }
            //Array for login credentials
            string[] password = { "1111111111", "2222222222", "3333333333", "4444444444", "5555555555" };

            string[] userNames = { "kraig", "jennifer", "john", "emily", "charles" };

            string enteredUserName = phoneNumberMaskedTextBox.Text;
            string enteredPassword = userNameTextBox.Text;

            //find the index from the username array
            var indexResult = password.Select((r, i) => new { Value = r, Index = i })
                                      .FirstOrDefault(r => r.Value == enteredUserName);
            if (indexResult == null)
            {
                MessageBox.Show("Invalid login credentials");
                return;
            }

            int indexOfUserName = indexResult.Index;

            //Compare the password from that index. 
            if (indexOfUserName < userNames.Length && userNames[indexOfUserName] == enteredPassword)
            {
                //Shows book store after authentication
                MessageBox.Show("User authenticated");
                bookSelectionGroupBox.Visible = true;
                selectedBooksGroupBox.Visible = true;
                shoppingCartGroupBox.Visible = true;
                processGroupBox.Visible = true;
                discountBooksTextBoxLabel.Visible = true;
                commentGroupBox.Visible = true;
                myWebBrowser.Visible = true;
                webButton.Visible = true;
                listViewPrice.Visible = true;
                myMainToolStrip.Visible = true;
            }
            else
            {
                MessageBox.Show("Invalid login credentials");
            }
        }

        private void bookSelectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Cases for various subjects. Loads image and populates List Box
            switch (bookSelectionComboBox.SelectedItem)
            {
                case "Programming":
                    {
                        try
                        {
                        this.topicPictureBox.Image = Image.FromFile("programming.jpg");
                        booksInStockListBox.Items.Clear();
                        booksInStockListBox.Items.Add("Python the Hard Way");
                        booksInStockListBox.Items.Add("Head First C#");
                        booksInStockListBox.Items.Add("JavaScript");
                        }
                        catch
                        {
                            MessageBox.Show("Image Load Failed");
                        }
                        break;
                    }
                case "HTML":
                    {
                        try
                        {
                        this.topicPictureBox.Image = Image.FromFile("html.jpg");
                        booksInStockListBox.Items.Clear();
                        booksInStockListBox.Items.Add("Black Book");
                        booksInStockListBox.Items.Add("HTML Bootcamp");
                        booksInStockListBox.Items.Add("Pro HTML5");
                        }
                        catch
                        {
                            MessageBox.Show("Image Load Failed");
                        }
                    }
                    break;
                case "CSS":
                    {
                        try {
                        this.topicPictureBox.Image = Image.FromFile("css.jpg");
                        booksInStockListBox.Items.Clear();
                        booksInStockListBox.Items.Add("Beginning CSS");
                        booksInStockListBox.Items.Add("Jump Start CSS");
                        booksInStockListBox.Items.Add("CSS3 for Web Designers");
                        }
                        catch
                        {
                            MessageBox.Show("Image Load Failed");
                        }
                    }
                    break;
            }
        }
        private void booksInStockListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (booksInStockListBox.SelectedItem)
            //Specific book switch cases. Loads image and changes book price label. Catches error if no image
            //load or text does change/load.
            {
                case "Python the Hard Way":
                    {
                        try
                        {
                            this.specificBookPictureBox.Image = Image.FromFile("python.jpg");
                            changeBookPriceLabel.Text = "$1020";
                        }
                        catch
                        {
                            MessageBox.Show("Image Load Failed");
                        }
                        break;
                    }
                case "Head First C#":
                    {
                        try
                        { 
                        this.specificBookPictureBox.Image = Image.FromFile("csharp.jpg");
                        changeBookPriceLabel.Text = "$1323";
                        }
                        catch
                        {
                            MessageBox.Show("Image Load Failed");
                        }
                        break;
                    }
                case "JavaScript":
                    {
                        try
                        {
                        this.specificBookPictureBox.Image = Image.FromFile("javascript.jpg");
                        changeBookPriceLabel.Text = "$740";
                        }
                        catch
                        {
                            MessageBox.Show("Image Load Failed");
                        }
                        break;
                    }
                case "Black Book":
                    {
                        try
                        { 
                        this.specificBookPictureBox.Image = Image.FromFile("htmlone.jpg");
                        changeBookPriceLabel.Text = "$550";
                        }
                        catch
                        {
                            MessageBox.Show("Image Load Failed");
                        }
                        break;
                    }
                case "HTML Bootcamp":
                    {
                        try
                        { 
                        this.specificBookPictureBox.Image = Image.FromFile("htmltwo.jpg");
                        changeBookPriceLabel.Text = "$350";
                        }
                        catch
                        {
                            MessageBox.Show("Image Load Failed");
                        }
                        break;
                    }
                case "Pro HTML5":
                    {
                        try
                        {
                        this.specificBookPictureBox.Image = Image.FromFile("htmlthree.jpg");
                        changeBookPriceLabel.Text = "$525";
                        }
                        catch
                        {
                            MessageBox.Show("Image Load Failed");
                        }
                        break;
                    }
                case "Beginning CSS":
                    {
                        try
                        {
                        this.specificBookPictureBox.Image = Image.FromFile("cssone.jpg");
                        changeBookPriceLabel.Text = "$232";
                        }
                        catch
                        {
                            MessageBox.Show("Image Load Failed");
                        }
                        break;
                    }
                case "Jump Start CSS":
                    {
                        try
                        {
                        this.specificBookPictureBox.Image = Image.FromFile("csstwo.png");
                        changeBookPriceLabel.Text = "$241";
                        }
                        catch
                        {
                            MessageBox.Show("Image Load Failed");
                        }
                        break;
                    }
                case "CSS3 for Web Designers":
                    {
                        try
                        {
                        this.specificBookPictureBox.Image = Image.FromFile("cssthree.png");
                        changeBookPriceLabel.Text = "$213";
                        }
                        catch
                        {
                            MessageBox.Show("Image Load Failed");
                        }
                        break;
                    }
            }
        }

        private void addToShoppingCartButton_Click(object sender, EventArgs e)
        {
            //Adds item selected in List Box to combo box. Duplicate handling. No item selected handling
            if (string.IsNullOrEmpty(booksInStockListBox.Text))
            {
                MessageBox.Show("Must select item to add to cart");
            }
            else
            {
                string addedItem = "";
                addedItem = booksInStockListBox.SelectedItem.ToString();
                if (shoppingCartComboBox.Items.Contains(addedItem))
                {
                    MessageBox.Show("No duplicates");
                }

                else
                {
                    shoppingCartComboBox.Items.Add(addedItem);
                    shoppingCartComboBox.SelectedIndex = 0;
                }
            }
        }

        private void removeFromShoppingCartButton_Click(object sender, EventArgs e)
        {
            //Removes selected item from cart. Must have item selected
            if (string.IsNullOrEmpty(shoppingCartComboBox.Text))
            {
                MessageBox.Show("Must select item to remove");
            }
            else if (shoppingCartComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Must select item to remove");
            }
            else
            {
                shoppingCartComboBox.Items.Remove(shoppingCartComboBox.SelectedItem);
                shoppingCartComboBox.Text = "";
            }
        }

        private void clearShoppingCartButton_Click(object sender, EventArgs e)
        {
            //Clears items in shoppingCartComboBox
            shoppingCartComboBox.Items.Clear();
            shoppingCartComboBox.Items.Remove(shoppingCartComboBox.SelectedText);
        }

        private void finalizeButton_Click(object sender, EventArgs e)
        {
            //declaring the buttons finalization
            DialogResult result = MessageBox.Show
               ("Do want to finalize the order?"
               , "Question", MessageBoxButtons.YesNoCancel,
               MessageBoxIcon.Information);
            
            if (result == DialogResult.No)
            {
                MessageBox.Show("You canceled the finalization");
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Enjoy the program");
            }
            else
            {
                shoppingCartComboBox.SelectedIndex = -1;
                if (shoppingCartComboBox.Text == "Thank You for Shopping")
                {
                    MessageBox.Show("The shopping cart is empty");
                }
                else
                {
                    //Disables buttons to add more items to shopping cart
                    addToShoppingCartButton.Enabled = false;
                    removeFromShoppingCartButton.Enabled = false;
                    clearShoppingCartButton.Enabled = false;
                }
            }
            //Adds various items to the List View if they are in the shoppingCartComboBox
            string totalCostString;
            int totalCost = 0;
            if (shoppingCartComboBox.Items.Contains("Python the Hard Way"))
            {
                totalCost += 1020;
                ListViewItem lst = new ListViewItem("Python the Hard Way");
                lst.SubItems.Add("$1020.00");
                listViewPrice.Items.Add(lst);
            }
            if (shoppingCartComboBox.Items.Contains("Head First C#"))
            {
                totalCost += 1323;
                ListViewItem lst = new ListViewItem("Head First C#");
                lst.SubItems.Add("$1323.00");
                listViewPrice.Items.Add(lst);
            }
            if (shoppingCartComboBox.Items.Contains("JavaScript"))
            {
                totalCost += 740;
                ListViewItem lst = new ListViewItem("JavaScript");
                lst.SubItems.Add("$740.00");
                listViewPrice.Items.Add(lst);
            }
            if (shoppingCartComboBox.Items.Contains("Black Book"))
            {
                totalCost += 550;
                ListViewItem lst = new ListViewItem("Black Book");
                lst.SubItems.Add("$550.00");
                listViewPrice.Items.Add(lst);
            }
            if (shoppingCartComboBox.Items.Contains("HTML Bootcamp"))
            {
                totalCost += 350;
                ListViewItem lst = new ListViewItem("HTML Bootcamp");
                lst.SubItems.Add("$350.00");
                listViewPrice.Items.Add(lst);
            }
            if (shoppingCartComboBox.Items.Contains("Pro HTML5"))
            {
                totalCost += 525;
                ListViewItem lst = new ListViewItem("Pro HTML5");
                lst.SubItems.Add("$525.00");
                listViewPrice.Items.Add(lst);
            }
            if (shoppingCartComboBox.Items.Contains("Beginning CSS"))
            {
                totalCost += 232;
                ListViewItem lst = new ListViewItem("Beginning CSS");
                lst.SubItems.Add("$232.00");
                listViewPrice.Items.Add(lst);
            }
            if (shoppingCartComboBox.Items.Contains("Jump Start CSS"))
            {
                totalCost += 241;
                ListViewItem lst = new ListViewItem("Jump Start CSS");
                lst.SubItems.Add("$241.00");
                listViewPrice.Items.Add(lst);
            }
            if (shoppingCartComboBox.Items.Contains("CSS3 for Web Designers"))
            {
                totalCost += 213;
                ListViewItem lst = new ListViewItem("CSS3 for Web Designers");
                lst.SubItems.Add("$213.00");
                listViewPrice.Items.Add(lst);
            }
            totalCostString = totalCost.ToString();
            totalPriceLabel.Text = totalCostString;
        }

        private void takeNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
                        contextProcess.EnableRaisingEvents = true;
                        contextProcess.Start();
                    }
                }
                catch
                {
                    MessageBox.Show("Cannot open notepad");
                }
            }
        }

        private void quitNotepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                try
                { //Closes notepad, various error messages if complication
                    System.Diagnostics.Process[] myProcess =
                        System.Diagnostics.Process.GetProcessesByName("Notepad");
                    if (myProcess.Length > 0)
                    {
                        contextProcess.Kill();
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

        private void searchWebToolStripMenuItem_Click(object sender, EventArgs e)
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
                    }
                }
                catch
                {
                    MessageBox.Show("Cannot open Chrome");
                }
            }
        }

        private void quitChromeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                try
                {   //Closes Chrome, various error messages if complication
                    System.Diagnostics.Process[] myProcess =
                        System.Diagnostics.Process.GetProcessesByName("Chrome");
                    if (myProcess.Length > 0)
                    {
                        chromeProcess.Kill();
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

        private void myTimer_Tick(object sender, EventArgs e)
        {
            {   //Sets status label to current time
                timeStatusLabel.Text = DateTime.Now.ToString();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //declaring the buttons for exit
            DialogResult result = MessageBox.Show
               ("Do want to quit?"
               , "Question", MessageBoxButtons.YesNoCancel,
               MessageBoxIcon.Information);
            //If result is Yes, close the program.
            if (result == DialogResult.No)
            {
                MessageBox.Show("You canceled the exit");
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Enjoy the program");
            }
            else
            {
                this.Close();
            }
        }

        private void clearAllProcessButton_Click(object sender, EventArgs e)
        {
            //Sets the form back to default
            yourNameTextBox.Clear();
            bookTitleTextBox.Clear();
            yourCommentRichTextBox.Clear();
            addToShoppingCartButton.Enabled = true;
            removeFromShoppingCartButton.Enabled = true;
            clearShoppingCartButton.Enabled = true;
            userNameTextBox.Text = null;
            phoneNumberMaskedTextBox.Text = null;
            totalPriceLabel.Text = "";
            changeBookPriceLabel.Text = "";
            foreach (ListViewItem lstItem in listViewPrice.Items)
            {
                lstItem.Remove();
            }
            shoppingCartComboBox.Items.Clear();
            booksInStockListBox.Items.Clear();
            this.topicPictureBox.Image = null;
            specificBookPictureBox.Image = null;
            bookSelectionGroupBox.Visible = false;
            selectedBooksGroupBox.Visible = false;
            shoppingCartGroupBox.Visible = false;
            processGroupBox.Visible = false;
            discountBooksTextBoxLabel.Visible = false;
            commentGroupBox.Visible = false;
            myWebBrowser.Visible = false;
            webButton.Visible = false;
            listViewPrice.Visible = false;
            myMainToolStrip.Visible = false;
        }

        private void loginClearButton_Click(object sender, EventArgs e)
        {
            //Clears login information
            userNameTextBox.Text = null;
            phoneNumberMaskedTextBox.Text = null;
        }

        private void webButton_Click(object sender, EventArgs e)
        {
            //Loads video into Web Browser
                if (booksInStockListBox.SelectedItem == null)
                {
                MessageBox.Show("Please select a book");
                }
                else if (booksInStockListBox.SelectedItem.ToString() == "Python the Hard Way")
                {
                    myWebBrowser.Navigate("https://www.youtube.com/watch?v=rfscVS0vtbw");
                }
                else if (booksInStockListBox.SelectedItem.ToString() == "Head First C#")
                {
                    myWebBrowser.Navigate("https://www.youtube.com/watch?v=x9oUSbT9TQo");
                }
                else if (booksInStockListBox.SelectedItem.ToString() == "JavaScript")
                {
                    myWebBrowser.Navigate("https://www.youtube.com/watch?v=PkZNo7MFNFg");
                }
                else if (booksInStockListBox.SelectedItem.ToString() == "Black Book")
                {
                    myWebBrowser.Navigate("https://www.youtube.com/watch?v=9VnjAQTUf5k");
                }
                else if (booksInStockListBox.SelectedItem.ToString() == "HTML Bootcamp")
                {
                    myWebBrowser.Navigate("https://www.youtube.com/watch?v=pQN-pnXPaVg");
                }
                else if (booksInStockListBox.SelectedItem.ToString() == "Pro HTML5")
                {
                    myWebBrowser.Navigate("https://www.youtube.com/watch?v=bWPMSSsVdPk");
                }
                else if (booksInStockListBox.SelectedItem.ToString() == "Beginning CSS")
                {
                    myWebBrowser.Navigate("https://www.youtube.com/watch?v=yfoY53QXEnI");
                }
                else if (booksInStockListBox.SelectedItem.ToString() == "Jump Start CSS")
                {
                    myWebBrowser.Navigate("https://www.youtube.com/watch?v=wmAP2xvNs08");
                }
                else if (booksInStockListBox.SelectedItem.ToString() == "CSS3 for Web Designers")
                {
                    myWebBrowser.Navigate("https://www.youtube.com/watch?v=ieTHC78giGQ");
                }

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            //Enter comment information
            if (yourNameTextBox.Text == "")
            {
                MessageBox.Show("Enter Name");
            }
            else if (bookTitleTextBox.Text == "")
            {
                MessageBox.Show("Enter Book Title");
            }
            else if (yourCommentRichTextBox.Text == "")
            {
                MessageBox.Show("Enter Comment");
            }
            else
            {
                //Write comment information to file
                MessageBox.Show("Comments saved");
                File.WriteAllText("comment.txt", yourNameTextBox.Text + Environment.NewLine);
                File.AppendAllText("comment.txt", bookTitleTextBox.Text + Environment.NewLine);
                File.AppendAllText("comment.txt", yourCommentRichTextBox.Text + Environment.NewLine);
            }
        }

        private void commentClearButton_Click(object sender, EventArgs e)
        {
            //Clears all comment information
            yourNameTextBox.Clear();
            bookTitleTextBox.Clear();
            yourCommentRichTextBox.Clear();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //Performs exit button click
            exitButton.PerformClick();
        }

        private void toolStripButton_Click(object sender, EventArgs e)
        {
            {
                { //Opens save .rtf file form
                    SaveFileDialog mySaveFile = new SaveFileDialog();
                    mySaveFile.Filter = "RTF Files|*.rtf";
                    if (mySaveFile.ShowDialog() ==
                        DialogResult.OK && mySaveFile.FileName != null)
                    {
                        yourCommentRichTextBox.SaveFile(mySaveFile.FileName, RichTextBoxStreamType.RichText);
                    }
                }
            }
        }

        /*
         * Code below performs various button clicks. Menu Strip controls
         */
        private void shoppingCartClearToolStrip_Click(object sender, EventArgs e)
        {
            clearAllProcessButton.PerformClick();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            addToShoppingCartButton.PerformClick();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            removeFromShoppingCartButton.PerformClick();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            clearShoppingCartButton.PerformClick();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            finalizeButton.PerformClick();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            webButton.PerformClick();
        }
    }
}
