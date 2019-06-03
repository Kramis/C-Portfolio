namespace Kraig_Massee_Lab_5
{
    partial class pizzaShopForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pizzaShopForm));
            this.topBarMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.specialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToShoppingCartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeFromTheCartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginGroupBox = new System.Windows.Forms.GroupBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.customerNumberTextBox = new System.Windows.Forms.TextBox();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.customerNumberLabel = new System.Windows.Forms.Label();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.orderPizzaMainGroupBox = new System.Windows.Forms.GroupBox();
            this.typeOfPizzaLabel = new System.Windows.Forms.Label();
            this.pizzaPictureBox = new System.Windows.Forms.PictureBox();
            this.priceListBox = new System.Windows.Forms.ListBox();
            this.selectedPizzaListBox = new System.Windows.Forms.ListBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.selectedPizzaLabel = new System.Windows.Forms.Label();
            this.orderGroupBox = new System.Windows.Forms.GroupBox();
            this.clearAllButton = new System.Windows.Forms.Button();
            this.removeFromCartButton = new System.Windows.Forms.Button();
            this.addToShoppingCartButton = new System.Windows.Forms.Button();
            this.orderPizzaTextBox = new System.Windows.Forms.TextBox();
            this.orderInstructionLabel = new System.Windows.Forms.Label();
            this.specialsGroupBox = new System.Windows.Forms.GroupBox();
            this.arrangeButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.specialsComboBox = new System.Windows.Forms.ComboBox();
            this.specialsLabel = new System.Windows.Forms.Label();
            this.passwordLoginErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTipPizzaControl = new System.Windows.Forms.ToolTip(this.components);
            this.topBarMenuStrip.SuspendLayout();
            this.loginGroupBox.SuspendLayout();
            this.orderPizzaMainGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaPictureBox)).BeginInit();
            this.orderGroupBox.SuspendLayout();
            this.specialsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordLoginErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // topBarMenuStrip
            // 
            this.topBarMenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.topBarMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.specialsToolStripMenuItem,
            this.orderToolStripMenuItem});
            this.topBarMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.topBarMenuStrip.Name = "topBarMenuStrip";
            this.topBarMenuStrip.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.topBarMenuStrip.Size = new System.Drawing.Size(2798, 44);
            this.topBarMenuStrip.TabIndex = 0;
            this.topBarMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.cancelToolStripMenuItem,
            this.eXitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(185, 38);
            this.clearToolStripMenuItem.Text = "&Login";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(185, 38);
            this.cancelToolStripMenuItem.Text = "&Cancel";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
            // 
            // eXitToolStripMenuItem
            // 
            this.eXitToolStripMenuItem.Name = "eXitToolStripMenuItem";
            this.eXitToolStripMenuItem.Size = new System.Drawing.Size(185, 38);
            this.eXitToolStripMenuItem.Text = "e&Xit";
            this.eXitToolStripMenuItem.Click += new System.EventHandler(this.eXitToolStripMenuItem_Click_1);
            // 
            // specialsToolStripMenuItem
            // 
            this.specialsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.arrangeToolStripMenuItem});
            this.specialsToolStripMenuItem.Name = "specialsToolStripMenuItem";
            this.specialsToolStripMenuItem.Size = new System.Drawing.Size(112, 36);
            this.specialsToolStripMenuItem.Text = "&Specials";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(198, 38);
            this.searchToolStripMenuItem.Text = "&Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // arrangeToolStripMenuItem
            // 
            this.arrangeToolStripMenuItem.Name = "arrangeToolStripMenuItem";
            this.arrangeToolStripMenuItem.Size = new System.Drawing.Size(198, 38);
            this.arrangeToolStripMenuItem.Text = "&Arrange";
            this.arrangeToolStripMenuItem.Click += new System.EventHandler(this.arrangeToolStripMenuItem_Click);
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToShoppingCartToolStripMenuItem,
            this.removeFromTheCartToolStripMenuItem,
            this.clearAllToolStripMenuItem});
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(88, 36);
            this.orderToolStripMenuItem.Text = "Order";
            // 
            // addToShoppingCartToolStripMenuItem
            // 
            this.addToShoppingCartToolStripMenuItem.Name = "addToShoppingCartToolStripMenuItem";
            this.addToShoppingCartToolStripMenuItem.Size = new System.Drawing.Size(346, 38);
            this.addToShoppingCartToolStripMenuItem.Text = "&Add to shopping cart";
            this.addToShoppingCartToolStripMenuItem.Click += new System.EventHandler(this.addToShoppingCartToolStripMenuItem_Click);
            // 
            // removeFromTheCartToolStripMenuItem
            // 
            this.removeFromTheCartToolStripMenuItem.Name = "removeFromTheCartToolStripMenuItem";
            this.removeFromTheCartToolStripMenuItem.Size = new System.Drawing.Size(346, 38);
            this.removeFromTheCartToolStripMenuItem.Text = "&Remove from the cart";
            this.removeFromTheCartToolStripMenuItem.Click += new System.EventHandler(this.removeFromTheCartToolStripMenuItem_Click);
            // 
            // clearAllToolStripMenuItem
            // 
            this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(346, 38);
            this.clearAllToolStripMenuItem.Text = "&Clear All";
            this.clearAllToolStripMenuItem.Click += new System.EventHandler(this.clearAllToolStripMenuItem_Click);
            // 
            // loginGroupBox
            // 
            this.loginGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.loginGroupBox.Controls.Add(this.exitButton);
            this.loginGroupBox.Controls.Add(this.cancelButton);
            this.loginGroupBox.Controls.Add(this.loginButton);
            this.loginGroupBox.Controls.Add(this.customerNumberTextBox);
            this.loginGroupBox.Controls.Add(this.customerNameTextBox);
            this.loginGroupBox.Controls.Add(this.customerNumberLabel);
            this.loginGroupBox.Controls.Add(this.customerNameLabel);
            this.loginGroupBox.Location = new System.Drawing.Point(100, 125);
            this.loginGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.loginGroupBox.Name = "loginGroupBox";
            this.loginGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.loginGroupBox.Size = new System.Drawing.Size(2100, 385);
            this.loginGroupBox.TabIndex = 1;
            this.loginGroupBox.TabStop = false;
            this.loginGroupBox.Text = "Log in";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(908, 308);
            this.exitButton.Margin = new System.Windows.Forms.Padding(6);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(150, 44);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "e&Xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(510, 308);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(6);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(150, 44);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "&Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(112, 308);
            this.loginButton.Margin = new System.Windows.Forms.Padding(6);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(150, 44);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "&Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // customerNumberTextBox
            // 
            this.customerNumberTextBox.Location = new System.Drawing.Point(510, 246);
            this.customerNumberTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.customerNumberTextBox.Name = "customerNumberTextBox";
            this.customerNumberTextBox.Size = new System.Drawing.Size(318, 31);
            this.customerNumberTextBox.TabIndex = 3;
            this.toolTipPizzaControl.SetToolTip(this.customerNumberTextBox, "enter 7 digit customer number");
            this.customerNumberTextBox.TextChanged += new System.EventHandler(this.customerNumberTextBox_TextChanged);
            this.customerNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.customerNumberTextBox_KeyPress);
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(510, 100);
            this.customerNameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(318, 31);
            this.customerNameTextBox.TabIndex = 2;
            this.toolTipPizzaControl.SetToolTip(this.customerNameTextBox, "enter customer name lower case");
            this.customerNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.customerNameTextBox_KeyPress);
            // 
            // customerNumberLabel
            // 
            this.customerNumberLabel.AutoSize = true;
            this.customerNumberLabel.Location = new System.Drawing.Point(82, 254);
            this.customerNumberLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.customerNumberLabel.Name = "customerNumberLabel";
            this.customerNumberLabel.Size = new System.Drawing.Size(299, 25);
            this.customerNumberLabel.TabIndex = 1;
            this.customerNumberLabel.Text = "Enter 7 digit customer number";
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Location = new System.Drawing.Point(76, 108);
            this.customerNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(370, 25);
            this.customerNameLabel.TabIndex = 0;
            this.customerNameLabel.Text = "Enter customer name in all lowercase";
            // 
            // orderPizzaMainGroupBox
            // 
            this.orderPizzaMainGroupBox.Controls.Add(this.typeOfPizzaLabel);
            this.orderPizzaMainGroupBox.Controls.Add(this.pizzaPictureBox);
            this.orderPizzaMainGroupBox.Controls.Add(this.priceListBox);
            this.orderPizzaMainGroupBox.Controls.Add(this.selectedPizzaListBox);
            this.orderPizzaMainGroupBox.Controls.Add(this.priceLabel);
            this.orderPizzaMainGroupBox.Controls.Add(this.selectedPizzaLabel);
            this.orderPizzaMainGroupBox.Controls.Add(this.orderGroupBox);
            this.orderPizzaMainGroupBox.Controls.Add(this.specialsGroupBox);
            this.orderPizzaMainGroupBox.Location = new System.Drawing.Point(100, 521);
            this.orderPizzaMainGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.orderPizzaMainGroupBox.Name = "orderPizzaMainGroupBox";
            this.orderPizzaMainGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.orderPizzaMainGroupBox.Size = new System.Drawing.Size(2600, 769);
            this.orderPizzaMainGroupBox.TabIndex = 2;
            this.orderPizzaMainGroupBox.TabStop = false;
            this.orderPizzaMainGroupBox.Text = "Order Pizza";
            // 
            // typeOfPizzaLabel
            // 
            this.typeOfPizzaLabel.AutoSize = true;
            this.typeOfPizzaLabel.Location = new System.Drawing.Point(2230, 698);
            this.typeOfPizzaLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.typeOfPizzaLabel.Name = "typeOfPizzaLabel";
            this.typeOfPizzaLabel.Size = new System.Drawing.Size(0, 25);
            this.typeOfPizzaLabel.TabIndex = 7;
            // 
            // pizzaPictureBox
            // 
            this.pizzaPictureBox.Location = new System.Drawing.Point(2230, 377);
            this.pizzaPictureBox.Margin = new System.Windows.Forms.Padding(6);
            this.pizzaPictureBox.Name = "pizzaPictureBox";
            this.pizzaPictureBox.Size = new System.Drawing.Size(326, 308);
            this.pizzaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pizzaPictureBox.TabIndex = 6;
            this.pizzaPictureBox.TabStop = false;
            // 
            // priceListBox
            // 
            this.priceListBox.FormattingEnabled = true;
            this.priceListBox.ItemHeight = 25;
            this.priceListBox.Location = new System.Drawing.Point(1908, 377);
            this.priceListBox.Margin = new System.Windows.Forms.Padding(6);
            this.priceListBox.Name = "priceListBox";
            this.priceListBox.Size = new System.Drawing.Size(236, 304);
            this.priceListBox.TabIndex = 5;
            // 
            // selectedPizzaListBox
            // 
            this.selectedPizzaListBox.FormattingEnabled = true;
            this.selectedPizzaListBox.ItemHeight = 25;
            this.selectedPizzaListBox.Location = new System.Drawing.Point(1378, 377);
            this.selectedPizzaListBox.Margin = new System.Windows.Forms.Padding(6);
            this.selectedPizzaListBox.Name = "selectedPizzaListBox";
            this.selectedPizzaListBox.Size = new System.Drawing.Size(444, 304);
            this.selectedPizzaListBox.TabIndex = 4;
            this.selectedPizzaListBox.SelectedIndexChanged += new System.EventHandler(this.selectedPizzaListBox_SelectedIndexChanged);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(1902, 321);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(61, 25);
            this.priceLabel.TabIndex = 3;
            this.priceLabel.Text = "Price";
            // 
            // selectedPizzaLabel
            // 
            this.selectedPizzaLabel.AutoSize = true;
            this.selectedPizzaLabel.Location = new System.Drawing.Point(1372, 321);
            this.selectedPizzaLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.selectedPizzaLabel.Name = "selectedPizzaLabel";
            this.selectedPizzaLabel.Size = new System.Drawing.Size(218, 25);
            this.selectedPizzaLabel.TabIndex = 2;
            this.selectedPizzaLabel.Text = "Your Selected Pizzas";
            // 
            // orderGroupBox
            // 
            this.orderGroupBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.orderGroupBox.Controls.Add(this.clearAllButton);
            this.orderGroupBox.Controls.Add(this.removeFromCartButton);
            this.orderGroupBox.Controls.Add(this.addToShoppingCartButton);
            this.orderGroupBox.Controls.Add(this.orderPizzaTextBox);
            this.orderGroupBox.Controls.Add(this.orderInstructionLabel);
            this.orderGroupBox.Location = new System.Drawing.Point(14, 352);
            this.orderGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.orderGroupBox.Name = "orderGroupBox";
            this.orderGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.orderGroupBox.Size = new System.Drawing.Size(1200, 385);
            this.orderGroupBox.TabIndex = 1;
            this.orderGroupBox.TabStop = false;
            this.orderGroupBox.Text = "Order";
            // 
            // clearAllButton
            // 
            this.clearAllButton.Location = new System.Drawing.Point(26, 258);
            this.clearAllButton.Margin = new System.Windows.Forms.Padding(6);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Size = new System.Drawing.Size(341, 44);
            this.clearAllButton.TabIndex = 4;
            this.clearAllButton.Text = "&Clear All";
            this.clearAllButton.UseVisualStyleBackColor = true;
            this.clearAllButton.Click += new System.EventHandler(this.clearAllButton_Click);
            // 
            // removeFromCartButton
            // 
            this.removeFromCartButton.Location = new System.Drawing.Point(26, 171);
            this.removeFromCartButton.Margin = new System.Windows.Forms.Padding(6);
            this.removeFromCartButton.Name = "removeFromCartButton";
            this.removeFromCartButton.Size = new System.Drawing.Size(341, 44);
            this.removeFromCartButton.TabIndex = 3;
            this.removeFromCartButton.Text = "&Remove from the cart";
            this.removeFromCartButton.UseVisualStyleBackColor = true;
            this.removeFromCartButton.Click += new System.EventHandler(this.removeFromCartButton_Click);
            // 
            // addToShoppingCartButton
            // 
            this.addToShoppingCartButton.Location = new System.Drawing.Point(26, 85);
            this.addToShoppingCartButton.Margin = new System.Windows.Forms.Padding(6);
            this.addToShoppingCartButton.Name = "addToShoppingCartButton";
            this.addToShoppingCartButton.Size = new System.Drawing.Size(341, 44);
            this.addToShoppingCartButton.TabIndex = 2;
            this.addToShoppingCartButton.Text = "&Add to shopping cart";
            this.addToShoppingCartButton.UseVisualStyleBackColor = true;
            this.addToShoppingCartButton.Click += new System.EventHandler(this.addToShoppingCartButton_Click);
            // 
            // orderPizzaTextBox
            // 
            this.orderPizzaTextBox.Location = new System.Drawing.Point(610, 25);
            this.orderPizzaTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.orderPizzaTextBox.Name = "orderPizzaTextBox";
            this.orderPizzaTextBox.Size = new System.Drawing.Size(354, 31);
            this.orderPizzaTextBox.TabIndex = 1;
            this.orderPizzaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.orderPizzaTextBox_KeyPress);
            // 
            // orderInstructionLabel
            // 
            this.orderInstructionLabel.AutoSize = true;
            this.orderInstructionLabel.Location = new System.Drawing.Point(20, 38);
            this.orderInstructionLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.orderInstructionLabel.Name = "orderInstructionLabel";
            this.orderInstructionLabel.Size = new System.Drawing.Size(553, 25);
            this.orderInstructionLabel.TabIndex = 0;
            this.orderInstructionLabel.Text = "Add pizzas to the shopping cart No Duplicates - All Caps";
            // 
            // specialsGroupBox
            // 
            this.specialsGroupBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.specialsGroupBox.Controls.Add(this.arrangeButton);
            this.specialsGroupBox.Controls.Add(this.searchButton);
            this.specialsGroupBox.Controls.Add(this.specialsComboBox);
            this.specialsGroupBox.Controls.Add(this.specialsLabel);
            this.specialsGroupBox.Location = new System.Drawing.Point(14, 35);
            this.specialsGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.specialsGroupBox.Name = "specialsGroupBox";
            this.specialsGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.specialsGroupBox.Size = new System.Drawing.Size(600, 288);
            this.specialsGroupBox.TabIndex = 0;
            this.specialsGroupBox.TabStop = false;
            this.specialsGroupBox.Text = "Specials";
            // 
            // arrangeButton
            // 
            this.arrangeButton.Location = new System.Drawing.Point(20, 169);
            this.arrangeButton.Margin = new System.Windows.Forms.Padding(6);
            this.arrangeButton.Name = "arrangeButton";
            this.arrangeButton.Size = new System.Drawing.Size(150, 44);
            this.arrangeButton.TabIndex = 3;
            this.arrangeButton.Text = "&Arrange";
            this.arrangeButton.UseVisualStyleBackColor = true;
            this.arrangeButton.Click += new System.EventHandler(this.arrangeButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(20, 77);
            this.searchButton.Margin = new System.Windows.Forms.Padding(6);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(150, 44);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "&Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // specialsComboBox
            // 
            this.specialsComboBox.FormattingEnabled = true;
            this.specialsComboBox.Location = new System.Drawing.Point(270, 21);
            this.specialsComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.specialsComboBox.Name = "specialsComboBox";
            this.specialsComboBox.Size = new System.Drawing.Size(314, 33);
            this.specialsComboBox.TabIndex = 1;
            this.specialsComboBox.Text = "Special Pizzas";
            this.specialsComboBox.SelectedIndexChanged += new System.EventHandler(this.specialsComboBox_SelectedIndexChanged);
            // 
            // specialsLabel
            // 
            this.specialsLabel.AutoSize = true;
            this.specialsLabel.Location = new System.Drawing.Point(14, 38);
            this.specialsLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.specialsLabel.Name = "specialsLabel";
            this.specialsLabel.Size = new System.Drawing.Size(246, 25);
            this.specialsLabel.TabIndex = 0;
            this.specialsLabel.Text = "Click to see our specials";
            // 
            // passwordLoginErrorProvider
            // 
            this.passwordLoginErrorProvider.ContainerControl = this;
            // 
            // pizzaShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2798, 1494);
            this.Controls.Add(this.orderPizzaMainGroupBox);
            this.Controls.Add(this.loginGroupBox);
            this.Controls.Add(this.topBarMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.topBarMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "pizzaShopForm";
            this.Text = "Pizza Shop";
            this.topBarMenuStrip.ResumeLayout(false);
            this.topBarMenuStrip.PerformLayout();
            this.loginGroupBox.ResumeLayout(false);
            this.loginGroupBox.PerformLayout();
            this.orderPizzaMainGroupBox.ResumeLayout(false);
            this.orderPizzaMainGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaPictureBox)).EndInit();
            this.orderGroupBox.ResumeLayout(false);
            this.orderGroupBox.PerformLayout();
            this.specialsGroupBox.ResumeLayout(false);
            this.specialsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordLoginErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip topBarMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem specialsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.GroupBox loginGroupBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox customerNumberTextBox;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.Label customerNumberLabel;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.GroupBox orderPizzaMainGroupBox;
        private System.Windows.Forms.GroupBox orderGroupBox;
        private System.Windows.Forms.GroupBox specialsGroupBox;
        private System.Windows.Forms.ListBox priceListBox;
        private System.Windows.Forms.ListBox selectedPizzaListBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label selectedPizzaLabel;
        private System.Windows.Forms.Button clearAllButton;
        private System.Windows.Forms.Button removeFromCartButton;
        private System.Windows.Forms.Button addToShoppingCartButton;
        private System.Windows.Forms.TextBox orderPizzaTextBox;
        private System.Windows.Forms.Label orderInstructionLabel;
        private System.Windows.Forms.Button arrangeButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ComboBox specialsComboBox;
        private System.Windows.Forms.Label specialsLabel;
        private System.Windows.Forms.Label typeOfPizzaLabel;
        private System.Windows.Forms.PictureBox pizzaPictureBox;
        private System.Windows.Forms.ErrorProvider passwordLoginErrorProvider;
        private System.Windows.Forms.ToolTip toolTipPizzaControl;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToShoppingCartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeFromTheCartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXitToolStripMenuItem;
    }
}

