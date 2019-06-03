namespace Kraig_Massee_Lab_8
{
    partial class bookStoreForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bookStoreForm));
            this.myMainToolStrip = new System.Windows.Forms.ToolStrip();
            this.exitToolStrip = new System.Windows.Forms.ToolStripButton();
            this.shoppingCartClearToolStrip = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.loginGroupBox = new System.Windows.Forms.GroupBox();
            this.loginClearButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.phoneNumberMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.phoneNumberMaskedTextBoxLabel = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.bookSelectionGroupBox = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.takeNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchWebToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitNotepadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitChromeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksInStockListBox = new System.Windows.Forms.ListBox();
            this.noChangebooksInStockLabel = new System.Windows.Forms.Label();
            this.bookSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.timeStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.selectedBooksGroupBox = new System.Windows.Forms.GroupBox();
            this.changeBookPriceLabel = new System.Windows.Forms.Label();
            this.noChangeBookPriceLabel = new System.Windows.Forms.Label();
            this.specificBookPictureBox = new System.Windows.Forms.PictureBox();
            this.topicPictureBox = new System.Windows.Forms.PictureBox();
            this.discountBooksTextBoxLabel = new System.Windows.Forms.TextBox();
            this.shoppingCartGroupBox = new System.Windows.Forms.GroupBox();
            this.totalNoChangeLabel = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.clearShoppingCartButton = new System.Windows.Forms.Button();
            this.removeFromShoppingCartButton = new System.Windows.Forms.Button();
            this.addToShoppingCartButton = new System.Windows.Forms.Button();
            this.shoppingCartComboBox = new System.Windows.Forms.ComboBox();
            this.processGroupBox = new System.Windows.Forms.GroupBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearAllProcessButton = new System.Windows.Forms.Button();
            this.finalizeButton = new System.Windows.Forms.Button();
            this.myErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextProcess = new System.Diagnostics.Process();
            this.chromeProcess = new System.Diagnostics.Process();
            this.myTimer = new System.Windows.Forms.Timer(this.components);
            this.listViewPrice = new System.Windows.Forms.ListView();
            this.BookName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BookPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.myWebBrowser = new System.Windows.Forms.WebBrowser();
            this.webButton = new System.Windows.Forms.Button();
            this.commentGroupBox = new System.Windows.Forms.GroupBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.commentClearButton = new System.Windows.Forms.Button();
            this.yourCommentRichTextBox = new System.Windows.Forms.RichTextBox();
            this.bookTitleTextBox = new System.Windows.Forms.TextBox();
            this.yourNameTextBox = new System.Windows.Forms.TextBox();
            this.noChangeBookNameLabel = new System.Windows.Forms.Label();
            this.noChangeNameLabel = new System.Windows.Forms.Label();
            this.myMainToolStrip.SuspendLayout();
            this.loginGroupBox.SuspendLayout();
            this.bookSelectionGroupBox.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.mainStatusStrip.SuspendLayout();
            this.selectedBooksGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.specificBookPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topicPictureBox)).BeginInit();
            this.shoppingCartGroupBox.SuspendLayout();
            this.processGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myErrorProvider)).BeginInit();
            this.commentGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // myMainToolStrip
            // 
            this.myMainToolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.myMainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStrip,
            this.shoppingCartClearToolStrip,
            this.toolStripButton,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5});
            this.myMainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.myMainToolStrip.Name = "myMainToolStrip";
            this.myMainToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.myMainToolStrip.Size = new System.Drawing.Size(2474, 39);
            this.myMainToolStrip.TabIndex = 0;
            this.myMainToolStrip.Text = "toolStrip1";
            this.myMainToolStrip.Visible = false;
            // 
            // exitToolStrip
            // 
            this.exitToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.exitToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStrip.Image")));
            this.exitToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exitToolStrip.Name = "exitToolStrip";
            this.exitToolStrip.Size = new System.Drawing.Size(36, 36);
            this.exitToolStrip.Text = "Exit";
            this.exitToolStrip.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // shoppingCartClearToolStrip
            // 
            this.shoppingCartClearToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.shoppingCartClearToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("shoppingCartClearToolStrip.Image")));
            this.shoppingCartClearToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.shoppingCartClearToolStrip.Name = "shoppingCartClearToolStrip";
            this.shoppingCartClearToolStrip.Size = new System.Drawing.Size(36, 36);
            this.shoppingCartClearToolStrip.Text = "Clear Form";
            this.shoppingCartClearToolStrip.Click += new System.EventHandler(this.shoppingCartClearToolStrip_Click);
            // 
            // toolStripButton
            // 
            this.toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton.Image")));
            this.toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton.Name = "toolStripButton";
            this.toolStripButton.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton.Text = "Save Comment";
            this.toolStripButton.Click += new System.EventHandler(this.toolStripButton_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton1.Text = "Add to Shopping Cart";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton2.Text = "Remove From Shopping Cart";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton3.Text = "Clear Shopping Cart";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton4.Text = "Finalize the Order";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton5.Text = "Watch A Video";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // loginGroupBox
            // 
            this.loginGroupBox.Controls.Add(this.loginClearButton);
            this.loginGroupBox.Controls.Add(this.loginButton);
            this.loginGroupBox.Controls.Add(this.phoneNumberMaskedTextBox);
            this.loginGroupBox.Controls.Add(this.phoneNumberMaskedTextBoxLabel);
            this.loginGroupBox.Controls.Add(this.userNameTextBox);
            this.loginGroupBox.Controls.Add(this.userNameLabel);
            this.loginGroupBox.Location = new System.Drawing.Point(26, 56);
            this.loginGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.loginGroupBox.Name = "loginGroupBox";
            this.loginGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.loginGroupBox.Size = new System.Drawing.Size(2118, 135);
            this.loginGroupBox.TabIndex = 1;
            this.loginGroupBox.TabStop = false;
            this.loginGroupBox.Text = "Login";
            // 
            // loginClearButton
            // 
            this.loginClearButton.Location = new System.Drawing.Point(1622, 37);
            this.loginClearButton.Margin = new System.Windows.Forms.Padding(6);
            this.loginClearButton.Name = "loginClearButton";
            this.loginClearButton.Size = new System.Drawing.Size(150, 44);
            this.loginClearButton.TabIndex = 5;
            this.loginClearButton.Text = "&Clear";
            this.loginClearButton.UseVisualStyleBackColor = true;
            this.loginClearButton.Click += new System.EventHandler(this.loginClearButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(1330, 38);
            this.loginButton.Margin = new System.Windows.Forms.Padding(6);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(150, 44);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "&Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // phoneNumberMaskedTextBox
            // 
            this.phoneNumberMaskedTextBox.Location = new System.Drawing.Point(896, 38);
            this.phoneNumberMaskedTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.phoneNumberMaskedTextBox.Mask = "(999) 000-0000";
            this.phoneNumberMaskedTextBox.Name = "phoneNumberMaskedTextBox";
            this.phoneNumberMaskedTextBox.Size = new System.Drawing.Size(164, 31);
            this.phoneNumberMaskedTextBox.TabIndex = 3;
            // 
            // phoneNumberMaskedTextBoxLabel
            // 
            this.phoneNumberMaskedTextBoxLabel.AutoSize = true;
            this.phoneNumberMaskedTextBoxLabel.Location = new System.Drawing.Point(726, 38);
            this.phoneNumberMaskedTextBoxLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.phoneNumberMaskedTextBoxLabel.Name = "phoneNumberMaskedTextBoxLabel";
            this.phoneNumberMaskedTextBoxLabel.Size = new System.Drawing.Size(155, 25);
            this.phoneNumberMaskedTextBoxLabel.TabIndex = 2;
            this.phoneNumberMaskedTextBoxLabel.Text = "Phone Number";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(204, 38);
            this.userNameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(366, 31);
            this.userNameTextBox.TabIndex = 1;
            this.userNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.userNameTextBox_KeyPress);
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(14, 38);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(176, 25);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "Enter User Name";
            // 
            // bookSelectionGroupBox
            // 
            this.bookSelectionGroupBox.ContextMenuStrip = this.contextMenuStrip;
            this.bookSelectionGroupBox.Controls.Add(this.booksInStockListBox);
            this.bookSelectionGroupBox.Controls.Add(this.noChangebooksInStockLabel);
            this.bookSelectionGroupBox.Controls.Add(this.bookSelectionComboBox);
            this.bookSelectionGroupBox.Location = new System.Drawing.Point(26, 204);
            this.bookSelectionGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.bookSelectionGroupBox.Name = "bookSelectionGroupBox";
            this.bookSelectionGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.bookSelectionGroupBox.Size = new System.Drawing.Size(400, 1015);
            this.bookSelectionGroupBox.TabIndex = 2;
            this.bookSelectionGroupBox.TabStop = false;
            this.bookSelectionGroupBox.Text = "Book Selection";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.takeNotesToolStripMenuItem,
            this.searchWebToolStripMenuItem,
            this.quitNotepadToolStripMenuItem,
            this.quitChromeToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(237, 148);
            // 
            // takeNotesToolStripMenuItem
            // 
            this.takeNotesToolStripMenuItem.Name = "takeNotesToolStripMenuItem";
            this.takeNotesToolStripMenuItem.Size = new System.Drawing.Size(236, 36);
            this.takeNotesToolStripMenuItem.Text = "Take Notes";
            this.takeNotesToolStripMenuItem.Click += new System.EventHandler(this.takeNotesToolStripMenuItem_Click);
            // 
            // searchWebToolStripMenuItem
            // 
            this.searchWebToolStripMenuItem.Name = "searchWebToolStripMenuItem";
            this.searchWebToolStripMenuItem.Size = new System.Drawing.Size(236, 36);
            this.searchWebToolStripMenuItem.Text = "Search Web";
            this.searchWebToolStripMenuItem.Click += new System.EventHandler(this.searchWebToolStripMenuItem_Click);
            // 
            // quitNotepadToolStripMenuItem
            // 
            this.quitNotepadToolStripMenuItem.Name = "quitNotepadToolStripMenuItem";
            this.quitNotepadToolStripMenuItem.Size = new System.Drawing.Size(236, 36);
            this.quitNotepadToolStripMenuItem.Text = "Quit Notepad";
            this.quitNotepadToolStripMenuItem.Click += new System.EventHandler(this.quitNotepadToolStripMenuItem_Click);
            // 
            // quitChromeToolStripMenuItem
            // 
            this.quitChromeToolStripMenuItem.Name = "quitChromeToolStripMenuItem";
            this.quitChromeToolStripMenuItem.Size = new System.Drawing.Size(236, 36);
            this.quitChromeToolStripMenuItem.Text = "Quit Chrome";
            this.quitChromeToolStripMenuItem.Click += new System.EventHandler(this.quitChromeToolStripMenuItem_Click);
            // 
            // booksInStockListBox
            // 
            this.booksInStockListBox.FormattingEnabled = true;
            this.booksInStockListBox.ItemHeight = 25;
            this.booksInStockListBox.Location = new System.Drawing.Point(14, 650);
            this.booksInStockListBox.Margin = new System.Windows.Forms.Padding(6);
            this.booksInStockListBox.Name = "booksInStockListBox";
            this.booksInStockListBox.Size = new System.Drawing.Size(370, 354);
            this.booksInStockListBox.TabIndex = 2;
            this.booksInStockListBox.SelectedIndexChanged += new System.EventHandler(this.booksInStockListBox_SelectedIndexChanged);
            // 
            // noChangebooksInStockLabel
            // 
            this.noChangebooksInStockLabel.AutoSize = true;
            this.noChangebooksInStockLabel.Location = new System.Drawing.Point(20, 517);
            this.noChangebooksInStockLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.noChangebooksInStockLabel.Name = "noChangebooksInStockLabel";
            this.noChangebooksInStockLabel.Size = new System.Drawing.Size(155, 25);
            this.noChangebooksInStockLabel.TabIndex = 1;
            this.noChangebooksInStockLabel.Text = "Books In Stock";
            // 
            // bookSelectionComboBox
            // 
            this.bookSelectionComboBox.FormattingEnabled = true;
            this.bookSelectionComboBox.Location = new System.Drawing.Point(12, 62);
            this.bookSelectionComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.bookSelectionComboBox.Name = "bookSelectionComboBox";
            this.bookSelectionComboBox.Size = new System.Drawing.Size(372, 33);
            this.bookSelectionComboBox.TabIndex = 0;
            this.bookSelectionComboBox.SelectedIndexChanged += new System.EventHandler(this.bookSelectionComboBox_SelectedIndexChanged);
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timeStatusLabel});
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 1242);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 28, 0);
            this.mainStatusStrip.Size = new System.Drawing.Size(2474, 37);
            this.mainStatusStrip.TabIndex = 3;
            this.mainStatusStrip.Text = "mainStatusStrip";
            // 
            // timeStatusLabel
            // 
            this.timeStatusLabel.Name = "timeStatusLabel";
            this.timeStatusLabel.Size = new System.Drawing.Size(63, 32);
            this.timeStatusLabel.Text = "time";
            // 
            // selectedBooksGroupBox
            // 
            this.selectedBooksGroupBox.Controls.Add(this.changeBookPriceLabel);
            this.selectedBooksGroupBox.Controls.Add(this.noChangeBookPriceLabel);
            this.selectedBooksGroupBox.Controls.Add(this.specificBookPictureBox);
            this.selectedBooksGroupBox.Controls.Add(this.topicPictureBox);
            this.selectedBooksGroupBox.Location = new System.Drawing.Point(440, 463);
            this.selectedBooksGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.selectedBooksGroupBox.Name = "selectedBooksGroupBox";
            this.selectedBooksGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.selectedBooksGroupBox.Size = new System.Drawing.Size(716, 756);
            this.selectedBooksGroupBox.TabIndex = 4;
            this.selectedBooksGroupBox.TabStop = false;
            this.selectedBooksGroupBox.Text = "Selected Books";
            // 
            // changeBookPriceLabel
            // 
            this.changeBookPriceLabel.AutoSize = true;
            this.changeBookPriceLabel.Location = new System.Drawing.Point(198, 704);
            this.changeBookPriceLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.changeBookPriceLabel.Name = "changeBookPriceLabel";
            this.changeBookPriceLabel.Size = new System.Drawing.Size(0, 25);
            this.changeBookPriceLabel.TabIndex = 3;
            // 
            // noChangeBookPriceLabel
            // 
            this.noChangeBookPriceLabel.AutoSize = true;
            this.noChangeBookPriceLabel.Location = new System.Drawing.Point(12, 706);
            this.noChangeBookPriceLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.noChangeBookPriceLabel.Name = "noChangeBookPriceLabel";
            this.noChangeBookPriceLabel.Size = new System.Drawing.Size(122, 25);
            this.noChangeBookPriceLabel.TabIndex = 2;
            this.noChangeBookPriceLabel.Text = "Book Price:";
            // 
            // specificBookPictureBox
            // 
            this.specificBookPictureBox.Location = new System.Drawing.Point(14, 346);
            this.specificBookPictureBox.Margin = new System.Windows.Forms.Padding(6);
            this.specificBookPictureBox.Name = "specificBookPictureBox";
            this.specificBookPictureBox.Size = new System.Drawing.Size(454, 354);
            this.specificBookPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.specificBookPictureBox.TabIndex = 1;
            this.specificBookPictureBox.TabStop = false;
            // 
            // topicPictureBox
            // 
            this.topicPictureBox.Location = new System.Drawing.Point(14, 38);
            this.topicPictureBox.Margin = new System.Windows.Forms.Padding(6);
            this.topicPictureBox.Name = "topicPictureBox";
            this.topicPictureBox.Size = new System.Drawing.Size(336, 296);
            this.topicPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.topicPictureBox.TabIndex = 0;
            this.topicPictureBox.TabStop = false;
            // 
            // discountBooksTextBoxLabel
            // 
            this.discountBooksTextBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountBooksTextBoxLabel.Location = new System.Drawing.Point(440, 375);
            this.discountBooksTextBoxLabel.Margin = new System.Windows.Forms.Padding(6);
            this.discountBooksTextBoxLabel.Name = "discountBooksTextBoxLabel";
            this.discountBooksTextBoxLabel.ReadOnly = true;
            this.discountBooksTextBoxLabel.Size = new System.Drawing.Size(712, 41);
            this.discountBooksTextBoxLabel.TabIndex = 5;
            this.discountBooksTextBoxLabel.Text = "Discount Book Store";
            this.discountBooksTextBoxLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // shoppingCartGroupBox
            // 
            this.shoppingCartGroupBox.Controls.Add(this.totalNoChangeLabel);
            this.shoppingCartGroupBox.Controls.Add(this.totalPriceLabel);
            this.shoppingCartGroupBox.Controls.Add(this.clearShoppingCartButton);
            this.shoppingCartGroupBox.Controls.Add(this.removeFromShoppingCartButton);
            this.shoppingCartGroupBox.Controls.Add(this.addToShoppingCartButton);
            this.shoppingCartGroupBox.Controls.Add(this.shoppingCartComboBox);
            this.shoppingCartGroupBox.Location = new System.Drawing.Point(1168, 204);
            this.shoppingCartGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.shoppingCartGroupBox.Name = "shoppingCartGroupBox";
            this.shoppingCartGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.shoppingCartGroupBox.Size = new System.Drawing.Size(400, 437);
            this.shoppingCartGroupBox.TabIndex = 6;
            this.shoppingCartGroupBox.TabStop = false;
            this.shoppingCartGroupBox.Text = "Shopping Cart";
            // 
            // totalNoChangeLabel
            // 
            this.totalNoChangeLabel.AutoSize = true;
            this.totalNoChangeLabel.Location = new System.Drawing.Point(10, 345);
            this.totalNoChangeLabel.Name = "totalNoChangeLabel";
            this.totalNoChangeLabel.Size = new System.Drawing.Size(121, 25);
            this.totalNoChangeLabel.TabIndex = 5;
            this.totalNoChangeLabel.Text = "Total Price:";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Location = new System.Drawing.Point(91, 345);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(96, 25);
            this.totalPriceLabel.TabIndex = 4;
            this.totalPriceLabel.Text = "              ";
            // 
            // clearShoppingCartButton
            // 
            this.clearShoppingCartButton.Location = new System.Drawing.Point(0, 245);
            this.clearShoppingCartButton.Margin = new System.Windows.Forms.Padding(6);
            this.clearShoppingCartButton.Name = "clearShoppingCartButton";
            this.clearShoppingCartButton.Size = new System.Drawing.Size(398, 44);
            this.clearShoppingCartButton.TabIndex = 3;
            this.clearShoppingCartButton.Text = "&Clear Shopping Cart";
            this.clearShoppingCartButton.UseVisualStyleBackColor = true;
            this.clearShoppingCartButton.Click += new System.EventHandler(this.clearShoppingCartButton_Click);
            // 
            // removeFromShoppingCartButton
            // 
            this.removeFromShoppingCartButton.Location = new System.Drawing.Point(0, 189);
            this.removeFromShoppingCartButton.Margin = new System.Windows.Forms.Padding(6);
            this.removeFromShoppingCartButton.Name = "removeFromShoppingCartButton";
            this.removeFromShoppingCartButton.Size = new System.Drawing.Size(400, 44);
            this.removeFromShoppingCartButton.TabIndex = 2;
            this.removeFromShoppingCartButton.Text = "&Remove";
            this.removeFromShoppingCartButton.UseVisualStyleBackColor = true;
            this.removeFromShoppingCartButton.Click += new System.EventHandler(this.removeFromShoppingCartButton_Click);
            // 
            // addToShoppingCartButton
            // 
            this.addToShoppingCartButton.Location = new System.Drawing.Point(2, 133);
            this.addToShoppingCartButton.Margin = new System.Windows.Forms.Padding(6);
            this.addToShoppingCartButton.Name = "addToShoppingCartButton";
            this.addToShoppingCartButton.Size = new System.Drawing.Size(398, 44);
            this.addToShoppingCartButton.TabIndex = 1;
            this.addToShoppingCartButton.Text = "Add to Shopping Cart";
            this.addToShoppingCartButton.UseVisualStyleBackColor = true;
            this.addToShoppingCartButton.Click += new System.EventHandler(this.addToShoppingCartButton_Click);
            // 
            // shoppingCartComboBox
            // 
            this.shoppingCartComboBox.FormattingEnabled = true;
            this.shoppingCartComboBox.Location = new System.Drawing.Point(14, 60);
            this.shoppingCartComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.shoppingCartComboBox.MaxDropDownItems = 15;
            this.shoppingCartComboBox.Name = "shoppingCartComboBox";
            this.shoppingCartComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.shoppingCartComboBox.Size = new System.Drawing.Size(370, 33);
            this.shoppingCartComboBox.TabIndex = 0;
            this.shoppingCartComboBox.Text = "Thank You for Shopping";
            // 
            // processGroupBox
            // 
            this.processGroupBox.Controls.Add(this.exitButton);
            this.processGroupBox.Controls.Add(this.clearAllProcessButton);
            this.processGroupBox.Controls.Add(this.finalizeButton);
            this.processGroupBox.Location = new System.Drawing.Point(1168, 654);
            this.processGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.processGroupBox.Name = "processGroupBox";
            this.processGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.processGroupBox.Size = new System.Drawing.Size(400, 565);
            this.processGroupBox.TabIndex = 7;
            this.processGroupBox.TabStop = false;
            this.processGroupBox.Text = "Process";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(14, 388);
            this.exitButton.Margin = new System.Windows.Forms.Padding(6);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(374, 44);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearAllProcessButton
            // 
            this.clearAllProcessButton.Location = new System.Drawing.Point(14, 262);
            this.clearAllProcessButton.Margin = new System.Windows.Forms.Padding(6);
            this.clearAllProcessButton.Name = "clearAllProcessButton";
            this.clearAllProcessButton.Size = new System.Drawing.Size(374, 44);
            this.clearAllProcessButton.TabIndex = 1;
            this.clearAllProcessButton.Text = "Clear All";
            this.clearAllProcessButton.UseVisualStyleBackColor = true;
            this.clearAllProcessButton.Click += new System.EventHandler(this.clearAllProcessButton_Click);
            // 
            // finalizeButton
            // 
            this.finalizeButton.Location = new System.Drawing.Point(14, 135);
            this.finalizeButton.Margin = new System.Windows.Forms.Padding(6);
            this.finalizeButton.Name = "finalizeButton";
            this.finalizeButton.Size = new System.Drawing.Size(374, 44);
            this.finalizeButton.TabIndex = 0;
            this.finalizeButton.Text = "Finalize the Order";
            this.finalizeButton.UseVisualStyleBackColor = true;
            this.finalizeButton.Click += new System.EventHandler(this.finalizeButton_Click);
            // 
            // myErrorProvider
            // 
            this.myErrorProvider.ContainerControl = this;
            // 
            // contextProcess
            // 
            this.contextProcess.StartInfo.Domain = "";
            this.contextProcess.StartInfo.FileName = "notepad.exe";
            this.contextProcess.StartInfo.LoadUserProfile = false;
            this.contextProcess.StartInfo.Password = null;
            this.contextProcess.StartInfo.StandardErrorEncoding = null;
            this.contextProcess.StartInfo.StandardOutputEncoding = null;
            this.contextProcess.StartInfo.UserName = "";
            this.contextProcess.SynchronizingObject = this;
            // 
            // chromeProcess
            // 
            this.chromeProcess.StartInfo.Domain = "";
            this.chromeProcess.StartInfo.FileName = "chrome.exe";
            this.chromeProcess.StartInfo.LoadUserProfile = false;
            this.chromeProcess.StartInfo.Password = null;
            this.chromeProcess.StartInfo.StandardErrorEncoding = null;
            this.chromeProcess.StartInfo.StandardOutputEncoding = null;
            this.chromeProcess.StartInfo.UserName = "";
            this.chromeProcess.SynchronizingObject = this;
            // 
            // myTimer
            // 
            this.myTimer.Enabled = true;
            this.myTimer.Tick += new System.EventHandler(this.myTimer_Tick);
            // 
            // listViewPrice
            // 
            this.listViewPrice.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BookName,
            this.BookPrice});
            this.listViewPrice.GridLines = true;
            this.listViewPrice.Location = new System.Drawing.Point(1578, 204);
            this.listViewPrice.Name = "listViewPrice";
            this.listViewPrice.Size = new System.Drawing.Size(705, 400);
            this.listViewPrice.TabIndex = 8;
            this.listViewPrice.UseCompatibleStateImageBehavior = false;
            this.listViewPrice.View = System.Windows.Forms.View.Details;
            this.listViewPrice.Visible = false;
            // 
            // BookName
            // 
            this.BookName.Text = "Book Name";
            this.BookName.Width = 200;
            // 
            // BookPrice
            // 
            this.BookPrice.Text = "Book Price";
            this.BookPrice.Width = 100;
            // 
            // myWebBrowser
            // 
            this.myWebBrowser.Location = new System.Drawing.Point(1927, 721);
            this.myWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.myWebBrowser.Name = "myWebBrowser";
            this.myWebBrowser.Size = new System.Drawing.Size(505, 430);
            this.myWebBrowser.TabIndex = 9;
            this.myWebBrowser.Visible = false;
            // 
            // webButton
            // 
            this.webButton.Location = new System.Drawing.Point(1980, 1169);
            this.webButton.Name = "webButton";
            this.webButton.Size = new System.Drawing.Size(395, 55);
            this.webButton.TabIndex = 11;
            this.webButton.Text = "&Watch A Video of Selected Book";
            this.webButton.UseVisualStyleBackColor = true;
            this.webButton.Visible = false;
            this.webButton.Click += new System.EventHandler(this.webButton_Click);
            // 
            // commentGroupBox
            // 
            this.commentGroupBox.Controls.Add(this.submitButton);
            this.commentGroupBox.Controls.Add(this.commentClearButton);
            this.commentGroupBox.Controls.Add(this.yourCommentRichTextBox);
            this.commentGroupBox.Controls.Add(this.bookTitleTextBox);
            this.commentGroupBox.Controls.Add(this.yourNameTextBox);
            this.commentGroupBox.Controls.Add(this.noChangeBookNameLabel);
            this.commentGroupBox.Controls.Add(this.noChangeNameLabel);
            this.commentGroupBox.Location = new System.Drawing.Point(1596, 721);
            this.commentGroupBox.Name = "commentGroupBox";
            this.commentGroupBox.Size = new System.Drawing.Size(313, 430);
            this.commentGroupBox.TabIndex = 12;
            this.commentGroupBox.TabStop = false;
            this.commentGroupBox.Text = "Comments";
            this.commentGroupBox.Visible = false;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(36, 372);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(116, 52);
            this.submitButton.TabIndex = 6;
            this.submitButton.Text = "&Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // commentClearButton
            // 
            this.commentClearButton.Location = new System.Drawing.Point(182, 372);
            this.commentClearButton.Name = "commentClearButton";
            this.commentClearButton.Size = new System.Drawing.Size(116, 52);
            this.commentClearButton.TabIndex = 5;
            this.commentClearButton.Text = "&Clear";
            this.commentClearButton.UseVisualStyleBackColor = true;
            this.commentClearButton.Click += new System.EventHandler(this.commentClearButton_Click);
            // 
            // yourCommentRichTextBox
            // 
            this.yourCommentRichTextBox.Location = new System.Drawing.Point(17, 202);
            this.yourCommentRichTextBox.Name = "yourCommentRichTextBox";
            this.yourCommentRichTextBox.Size = new System.Drawing.Size(290, 163);
            this.yourCommentRichTextBox.TabIndex = 4;
            this.yourCommentRichTextBox.Text = "";
            // 
            // bookTitleTextBox
            // 
            this.bookTitleTextBox.Location = new System.Drawing.Point(140, 127);
            this.bookTitleTextBox.Name = "bookTitleTextBox";
            this.bookTitleTextBox.Size = new System.Drawing.Size(167, 31);
            this.bookTitleTextBox.TabIndex = 3;
            // 
            // yourNameTextBox
            // 
            this.yourNameTextBox.Location = new System.Drawing.Point(140, 61);
            this.yourNameTextBox.Name = "yourNameTextBox";
            this.yourNameTextBox.Size = new System.Drawing.Size(167, 31);
            this.yourNameTextBox.TabIndex = 2;
            // 
            // noChangeBookNameLabel
            // 
            this.noChangeBookNameLabel.AutoSize = true;
            this.noChangeBookNameLabel.Location = new System.Drawing.Point(12, 133);
            this.noChangeBookNameLabel.Name = "noChangeBookNameLabel";
            this.noChangeBookNameLabel.Size = new System.Drawing.Size(114, 25);
            this.noChangeBookNameLabel.TabIndex = 1;
            this.noChangeBookNameLabel.Text = "Book Title:";
            // 
            // noChangeNameLabel
            // 
            this.noChangeNameLabel.AutoSize = true;
            this.noChangeNameLabel.Location = new System.Drawing.Point(7, 68);
            this.noChangeNameLabel.Name = "noChangeNameLabel";
            this.noChangeNameLabel.Size = new System.Drawing.Size(126, 25);
            this.noChangeNameLabel.TabIndex = 0;
            this.noChangeNameLabel.Text = "Your Name:";
            // 
            // bookStoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2474, 1279);
            this.Controls.Add(this.commentGroupBox);
            this.Controls.Add(this.webButton);
            this.Controls.Add(this.myWebBrowser);
            this.Controls.Add(this.listViewPrice);
            this.Controls.Add(this.processGroupBox);
            this.Controls.Add(this.shoppingCartGroupBox);
            this.Controls.Add(this.discountBooksTextBoxLabel);
            this.Controls.Add(this.selectedBooksGroupBox);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.bookSelectionGroupBox);
            this.Controls.Add(this.loginGroupBox);
            this.Controls.Add(this.myMainToolStrip);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "bookStoreForm";
            this.Text = "Kraig\'s Bookstore";
            this.myMainToolStrip.ResumeLayout(false);
            this.myMainToolStrip.PerformLayout();
            this.loginGroupBox.ResumeLayout(false);
            this.loginGroupBox.PerformLayout();
            this.bookSelectionGroupBox.ResumeLayout(false);
            this.bookSelectionGroupBox.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.selectedBooksGroupBox.ResumeLayout(false);
            this.selectedBooksGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.specificBookPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topicPictureBox)).EndInit();
            this.shoppingCartGroupBox.ResumeLayout(false);
            this.shoppingCartGroupBox.PerformLayout();
            this.processGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myErrorProvider)).EndInit();
            this.commentGroupBox.ResumeLayout(false);
            this.commentGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip myMainToolStrip;
        private System.Windows.Forms.ToolStripButton exitToolStrip;
        private System.Windows.Forms.ToolStripButton shoppingCartClearToolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButton;
        private System.Windows.Forms.GroupBox loginGroupBox;
        private System.Windows.Forms.Button loginClearButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.MaskedTextBox phoneNumberMaskedTextBox;
        private System.Windows.Forms.Label phoneNumberMaskedTextBoxLabel;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.GroupBox bookSelectionGroupBox;
        private System.Windows.Forms.ListBox booksInStockListBox;
        private System.Windows.Forms.Label noChangebooksInStockLabel;
        private System.Windows.Forms.ComboBox bookSelectionComboBox;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.GroupBox selectedBooksGroupBox;
        private System.Windows.Forms.TextBox discountBooksTextBoxLabel;
        private System.Windows.Forms.Label changeBookPriceLabel;
        private System.Windows.Forms.Label noChangeBookPriceLabel;
        private System.Windows.Forms.PictureBox specificBookPictureBox;
        private System.Windows.Forms.PictureBox topicPictureBox;
        private System.Windows.Forms.GroupBox shoppingCartGroupBox;
        private System.Windows.Forms.Button clearShoppingCartButton;
        private System.Windows.Forms.Button removeFromShoppingCartButton;
        private System.Windows.Forms.Button addToShoppingCartButton;
        private System.Windows.Forms.ComboBox shoppingCartComboBox;
        private System.Windows.Forms.GroupBox processGroupBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearAllProcessButton;
        private System.Windows.Forms.Button finalizeButton;
        private System.Windows.Forms.ErrorProvider myErrorProvider;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem takeNotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchWebToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitNotepadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitChromeToolStripMenuItem;
        private System.Diagnostics.Process contextProcess;
        private System.Diagnostics.Process chromeProcess;
        private System.Windows.Forms.ToolStripStatusLabel timeStatusLabel;
        private System.Windows.Forms.Timer myTimer;
        private System.Windows.Forms.ListView listViewPrice;
        private System.Windows.Forms.ColumnHeader BookName;
        private System.Windows.Forms.ColumnHeader BookPrice;
        private System.Windows.Forms.Button webButton;
        private System.Windows.Forms.WebBrowser myWebBrowser;
        private System.Windows.Forms.GroupBox commentGroupBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button commentClearButton;
        private System.Windows.Forms.RichTextBox yourCommentRichTextBox;
        private System.Windows.Forms.TextBox bookTitleTextBox;
        private System.Windows.Forms.Label noChangeBookNameLabel;
        private System.Windows.Forms.Label noChangeNameLabel;
        private System.Windows.Forms.TextBox yourNameTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.Label totalNoChangeLabel;
        private System.Windows.Forms.Label totalPriceLabel;
    }
}

