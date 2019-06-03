namespace Kraig_Massee_Lab_4
{
    partial class stateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stateForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oregonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.washingtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.californiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxRadioButtons = new System.Windows.Forms.GroupBox();
            this.radioButtonCalifornia = new System.Windows.Forms.RadioButton();
            this.radioButtonWashington = new System.Windows.Forms.RadioButton();
            this.radioButtonOregon = new System.Windows.Forms.RadioButton();
            this.groupBoxThreeButtons = new System.Windows.Forms.GroupBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.inputBoxButton = new System.Windows.Forms.Button();
            this.phoneCheckBox = new System.Windows.Forms.CheckBox();
            this.phoneNumberMaskTextBox = new System.Windows.Forms.MaskedTextBox();
            this.changeColorCheckBox = new System.Windows.Forms.CheckBox();
            this.changeColorGroupBox = new System.Windows.Forms.GroupBox();
            this.backgroundColorTextBox = new System.Windows.Forms.TextBox();
            this.backgroundColorButton = new System.Windows.Forms.Button();
            this.colorDescriptionLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.statePictureBox = new System.Windows.Forms.PictureBox();
            this.stateInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.nickNameInformationLabel = new System.Windows.Forms.Label();
            this.climateInformationLabel = new System.Windows.Forms.Label();
            this.nicknameNoChangeLabel = new System.Windows.Forms.Label();
            this.climateNoChangeLabel = new System.Windows.Forms.Label();
            this.populationInformationLabel = new System.Windows.Forms.Label();
            this.populationNoChangeLabel = new System.Windows.Forms.Label();
            this.mainStateLabel = new System.Windows.Forms.Label();
            this.toolTipControl = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.groupBoxRadioButtons.SuspendLayout();
            this.groupBoxThreeButtons.SuspendLayout();
            this.changeColorGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statePictureBox)).BeginInit();
            this.stateInformationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.statesToolStripMenuItem,
            this.utilitiesToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(984, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eXitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // eXitToolStripMenuItem
            // 
            this.eXitToolStripMenuItem.Name = "eXitToolStripMenuItem";
            this.eXitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eXitToolStripMenuItem.Text = "e&Xit";
            this.eXitToolStripMenuItem.Click += new System.EventHandler(this.eXitToolStripMenuItem_Click);
            // 
            // statesToolStripMenuItem
            // 
            this.statesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oregonToolStripMenuItem,
            this.washingtonToolStripMenuItem,
            this.californiaToolStripMenuItem});
            this.statesToolStripMenuItem.Name = "statesToolStripMenuItem";
            this.statesToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.statesToolStripMenuItem.Text = "&States";
            // 
            // oregonToolStripMenuItem
            // 
            this.oregonToolStripMenuItem.Name = "oregonToolStripMenuItem";
            this.oregonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.oregonToolStripMenuItem.Text = "&Oregon";
            this.oregonToolStripMenuItem.Click += new System.EventHandler(this.oregonToolStripMenuItem_Click);
            // 
            // washingtonToolStripMenuItem
            // 
            this.washingtonToolStripMenuItem.Name = "washingtonToolStripMenuItem";
            this.washingtonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.washingtonToolStripMenuItem.Text = "&Washington";
            this.washingtonToolStripMenuItem.Click += new System.EventHandler(this.washingtonToolStripMenuItem_Click);
            // 
            // californiaToolStripMenuItem
            // 
            this.californiaToolStripMenuItem.Name = "californiaToolStripMenuItem";
            this.californiaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.californiaToolStripMenuItem.Text = "&California";
            this.californiaToolStripMenuItem.Click += new System.EventHandler(this.californiaToolStripMenuItem_Click);
            // 
            // utilitiesToolStripMenuItem
            // 
            this.utilitiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputBoxToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.utilitiesToolStripMenuItem.Name = "utilitiesToolStripMenuItem";
            this.utilitiesToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.utilitiesToolStripMenuItem.Text = "&Utilities";
            // 
            // inputBoxToolStripMenuItem
            // 
            this.inputBoxToolStripMenuItem.Name = "inputBoxToolStripMenuItem";
            this.inputBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inputBoxToolStripMenuItem.Text = "&Input Box";
            this.inputBoxToolStripMenuItem.Click += new System.EventHandler(this.inputBoxToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clearToolStripMenuItem.Text = "&Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // groupBoxRadioButtons
            // 
            this.groupBoxRadioButtons.Controls.Add(this.radioButtonCalifornia);
            this.groupBoxRadioButtons.Controls.Add(this.radioButtonWashington);
            this.groupBoxRadioButtons.Controls.Add(this.radioButtonOregon);
            this.groupBoxRadioButtons.Location = new System.Drawing.Point(100, 50);
            this.groupBoxRadioButtons.Name = "groupBoxRadioButtons";
            this.groupBoxRadioButtons.Size = new System.Drawing.Size(150, 150);
            this.groupBoxRadioButtons.TabIndex = 1;
            this.groupBoxRadioButtons.TabStop = false;
            this.groupBoxRadioButtons.Text = "States";
            this.groupBoxRadioButtons.Enter += new System.EventHandler(this.groupBoxRadioButtons_Enter);
            // 
            // radioButtonCalifornia
            // 
            this.radioButtonCalifornia.AutoSize = true;
            this.radioButtonCalifornia.Location = new System.Drawing.Point(6, 107);
            this.radioButtonCalifornia.Name = "radioButtonCalifornia";
            this.radioButtonCalifornia.Size = new System.Drawing.Size(68, 17);
            this.radioButtonCalifornia.TabIndex = 2;
            this.radioButtonCalifornia.Text = "California";
            this.toolTipControl.SetToolTip(this.radioButtonCalifornia, "State of California");
            this.radioButtonCalifornia.UseVisualStyleBackColor = true;
            this.radioButtonCalifornia.CheckedChanged += new System.EventHandler(this.radioButtonCalifornia_CheckedChanged);
            // 
            // radioButtonWashington
            // 
            this.radioButtonWashington.AutoSize = true;
            this.radioButtonWashington.Location = new System.Drawing.Point(6, 67);
            this.radioButtonWashington.Name = "radioButtonWashington";
            this.radioButtonWashington.Size = new System.Drawing.Size(82, 17);
            this.radioButtonWashington.TabIndex = 1;
            this.radioButtonWashington.Text = "Washington";
            this.toolTipControl.SetToolTip(this.radioButtonWashington, "State of Washington");
            this.radioButtonWashington.UseVisualStyleBackColor = true;
            this.radioButtonWashington.CheckedChanged += new System.EventHandler(this.radioButtonWashington_CheckedChanged);
            // 
            // radioButtonOregon
            // 
            this.radioButtonOregon.AutoSize = true;
            this.radioButtonOregon.Location = new System.Drawing.Point(6, 27);
            this.radioButtonOregon.Name = "radioButtonOregon";
            this.radioButtonOregon.Size = new System.Drawing.Size(60, 17);
            this.radioButtonOregon.TabIndex = 0;
            this.radioButtonOregon.Text = "Oregon";
            this.toolTipControl.SetToolTip(this.radioButtonOregon, "State of Oregon");
            this.radioButtonOregon.UseVisualStyleBackColor = true;
            this.radioButtonOregon.CheckedChanged += new System.EventHandler(this.radioButtonOregon_CheckedChanged);
            // 
            // groupBoxThreeButtons
            // 
            this.groupBoxThreeButtons.Controls.Add(this.exitButton);
            this.groupBoxThreeButtons.Controls.Add(this.clearButton);
            this.groupBoxThreeButtons.Controls.Add(this.inputBoxButton);
            this.groupBoxThreeButtons.Location = new System.Drawing.Point(100, 207);
            this.groupBoxThreeButtons.Name = "groupBoxThreeButtons";
            this.groupBoxThreeButtons.Size = new System.Drawing.Size(111, 120);
            this.groupBoxThreeButtons.TabIndex = 2;
            this.groupBoxThreeButtons.TabStop = false;
            this.groupBoxThreeButtons.Text = "Your Options";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(18, 80);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "e&Xit";
            this.toolTipControl.SetToolTip(this.exitButton, "Click to exit");
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(18, 50);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "&Clear";
            this.toolTipControl.SetToolTip(this.clearButton, "Click to clear all");
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // inputBoxButton
            // 
            this.inputBoxButton.Location = new System.Drawing.Point(18, 20);
            this.inputBoxButton.Name = "inputBoxButton";
            this.inputBoxButton.Size = new System.Drawing.Size(75, 23);
            this.inputBoxButton.TabIndex = 0;
            this.inputBoxButton.Text = "&Input Box";
            this.toolTipControl.SetToolTip(this.inputBoxButton, "Click for question");
            this.inputBoxButton.UseVisualStyleBackColor = true;
            this.inputBoxButton.Click += new System.EventHandler(this.inputBoxButton_Click);
            // 
            // phoneCheckBox
            // 
            this.phoneCheckBox.AutoSize = true;
            this.phoneCheckBox.Location = new System.Drawing.Point(15, 350);
            this.phoneCheckBox.Name = "phoneCheckBox";
            this.phoneCheckBox.Size = new System.Drawing.Size(63, 17);
            this.phoneCheckBox.TabIndex = 3;
            this.phoneCheckBox.Text = "Phone?";
            this.toolTipControl.SetToolTip(this.phoneCheckBox, "Click to enter phone number");
            this.phoneCheckBox.UseVisualStyleBackColor = true;
            this.phoneCheckBox.CheckedChanged += new System.EventHandler(this.phoneCheckBox_CheckedChanged);
            // 
            // phoneNumberMaskTextBox
            // 
            this.phoneNumberMaskTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberMaskTextBox.Location = new System.Drawing.Point(15, 374);
            this.phoneNumberMaskTextBox.Mask = "(999) 000-0000";
            this.phoneNumberMaskTextBox.Name = "phoneNumberMaskTextBox";
            this.phoneNumberMaskTextBox.Size = new System.Drawing.Size(120, 24);
            this.phoneNumberMaskTextBox.TabIndex = 4;
            this.toolTipControl.SetToolTip(this.phoneNumberMaskTextBox, "Enter phone number here");
            this.phoneNumberMaskTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.phoneNumberMaskTextBox_MaskInputRejected);
            // 
            // changeColorCheckBox
            // 
            this.changeColorCheckBox.AutoSize = true;
            this.changeColorCheckBox.Location = new System.Drawing.Point(15, 468);
            this.changeColorCheckBox.Name = "changeColorCheckBox";
            this.changeColorCheckBox.Size = new System.Drawing.Size(191, 17);
            this.changeColorCheckBox.TabIndex = 5;
            this.changeColorCheckBox.Text = "Click to change the color of screen";
            this.toolTipControl.SetToolTip(this.changeColorCheckBox, "Activate background color box");
            this.changeColorCheckBox.UseVisualStyleBackColor = true;
            this.changeColorCheckBox.CheckedChanged += new System.EventHandler(this.changeColorCheckBox_CheckedChanged);
            // 
            // changeColorGroupBox
            // 
            this.changeColorGroupBox.Controls.Add(this.backgroundColorTextBox);
            this.changeColorGroupBox.Controls.Add(this.backgroundColorButton);
            this.changeColorGroupBox.Controls.Add(this.colorDescriptionLabel);
            this.changeColorGroupBox.Location = new System.Drawing.Point(15, 508);
            this.changeColorGroupBox.Name = "changeColorGroupBox";
            this.changeColorGroupBox.Size = new System.Drawing.Size(300, 150);
            this.changeColorGroupBox.TabIndex = 6;
            this.changeColorGroupBox.TabStop = false;
            this.changeColorGroupBox.Text = "Choose Color";
            // 
            // backgroundColorTextBox
            // 
            this.backgroundColorTextBox.Location = new System.Drawing.Point(194, 13);
            this.backgroundColorTextBox.Name = "backgroundColorTextBox";
            this.backgroundColorTextBox.Size = new System.Drawing.Size(100, 20);
            this.backgroundColorTextBox.TabIndex = 2;
            this.toolTipControl.SetToolTip(this.backgroundColorTextBox, "Type color here");
            // 
            // backgroundColorButton
            // 
            this.backgroundColorButton.Location = new System.Drawing.Point(10, 56);
            this.backgroundColorButton.Name = "backgroundColorButton";
            this.backgroundColorButton.Size = new System.Drawing.Size(75, 23);
            this.backgroundColorButton.TabIndex = 1;
            this.backgroundColorButton.Text = "&Background Color";
            this.toolTipControl.SetToolTip(this.backgroundColorButton, "click to change background color of this box after typing in color");
            this.backgroundColorButton.UseVisualStyleBackColor = true;
            this.backgroundColorButton.Click += new System.EventHandler(this.backgroundColorButton_Click);
            // 
            // colorDescriptionLabel
            // 
            this.colorDescriptionLabel.Location = new System.Drawing.Point(7, 20);
            this.colorDescriptionLabel.Name = "colorDescriptionLabel";
            this.colorDescriptionLabel.Size = new System.Drawing.Size(166, 33);
            this.colorDescriptionLabel.TabIndex = 0;
            this.colorDescriptionLabel.Text = "Green, Blue, Red, Purple, Pink, or Reset";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateLabel.Location = new System.Drawing.Point(400, 50);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(82, 33);
            this.stateLabel.TabIndex = 7;
            this.stateLabel.Text = "State";
            // 
            // statePictureBox
            // 
            this.statePictureBox.Location = new System.Drawing.Point(500, 50);
            this.statePictureBox.Name = "statePictureBox";
            this.statePictureBox.Size = new System.Drawing.Size(225, 150);
            this.statePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.statePictureBox.TabIndex = 8;
            this.statePictureBox.TabStop = false;
            // 
            // stateInformationGroupBox
            // 
            this.stateInformationGroupBox.Controls.Add(this.nickNameInformationLabel);
            this.stateInformationGroupBox.Controls.Add(this.climateInformationLabel);
            this.stateInformationGroupBox.Controls.Add(this.nicknameNoChangeLabel);
            this.stateInformationGroupBox.Controls.Add(this.climateNoChangeLabel);
            this.stateInformationGroupBox.Controls.Add(this.populationInformationLabel);
            this.stateInformationGroupBox.Controls.Add(this.populationNoChangeLabel);
            this.stateInformationGroupBox.Controls.Add(this.mainStateLabel);
            this.stateInformationGroupBox.Location = new System.Drawing.Point(500, 230);
            this.stateInformationGroupBox.Name = "stateInformationGroupBox";
            this.stateInformationGroupBox.Size = new System.Drawing.Size(450, 500);
            this.stateInformationGroupBox.TabIndex = 9;
            this.stateInformationGroupBox.TabStop = false;
            this.stateInformationGroupBox.Text = "State Information";
            this.toolTipControl.SetToolTip(this.stateInformationGroupBox, "State information (Click on \"States\" buttons");
            // 
            // nickNameInformationLabel
            // 
            this.nickNameInformationLabel.AutoSize = true;
            this.nickNameInformationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nickNameInformationLabel.Location = new System.Drawing.Point(51, 374);
            this.nickNameInformationLabel.Name = "nickNameInformationLabel";
            this.nickNameInformationLabel.Size = new System.Drawing.Size(28, 18);
            this.nickNameInformationLabel.TabIndex = 6;
            this.nickNameInformationLabel.Text = "     ";
            // 
            // climateInformationLabel
            // 
            this.climateInformationLabel.AutoSize = true;
            this.climateInformationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.climateInformationLabel.Location = new System.Drawing.Point(51, 267);
            this.climateInformationLabel.Name = "climateInformationLabel";
            this.climateInformationLabel.Size = new System.Drawing.Size(32, 18);
            this.climateInformationLabel.TabIndex = 5;
            this.climateInformationLabel.Text = "      ";
            // 
            // nicknameNoChangeLabel
            // 
            this.nicknameNoChangeLabel.AutoSize = true;
            this.nicknameNoChangeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nicknameNoChangeLabel.Location = new System.Drawing.Point(49, 344);
            this.nicknameNoChangeLabel.Name = "nicknameNoChangeLabel";
            this.nicknameNoChangeLabel.Size = new System.Drawing.Size(116, 25);
            this.nicknameNoChangeLabel.TabIndex = 4;
            this.nicknameNoChangeLabel.Text = "Nick Name";
            // 
            // climateNoChangeLabel
            // 
            this.climateNoChangeLabel.AutoSize = true;
            this.climateNoChangeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.climateNoChangeLabel.Location = new System.Drawing.Point(49, 235);
            this.climateNoChangeLabel.Name = "climateNoChangeLabel";
            this.climateNoChangeLabel.Size = new System.Drawing.Size(84, 25);
            this.climateNoChangeLabel.TabIndex = 3;
            this.climateNoChangeLabel.Text = "Climate";
            this.climateNoChangeLabel.Click += new System.EventHandler(this.climateNoChangeLabel_Click);
            // 
            // populationInformationLabel
            // 
            this.populationInformationLabel.AutoSize = true;
            this.populationInformationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.populationInformationLabel.Location = new System.Drawing.Point(51, 160);
            this.populationInformationLabel.Name = "populationInformationLabel";
            this.populationInformationLabel.Size = new System.Drawing.Size(32, 18);
            this.populationInformationLabel.TabIndex = 2;
            this.populationInformationLabel.Text = "      ";
            // 
            // populationNoChangeLabel
            // 
            this.populationNoChangeLabel.AutoSize = true;
            this.populationNoChangeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.populationNoChangeLabel.Location = new System.Drawing.Point(49, 132);
            this.populationNoChangeLabel.Name = "populationNoChangeLabel";
            this.populationNoChangeLabel.Size = new System.Drawing.Size(114, 25);
            this.populationNoChangeLabel.TabIndex = 1;
            this.populationNoChangeLabel.Text = "Population";
            // 
            // mainStateLabel
            // 
            this.mainStateLabel.AutoSize = true;
            this.mainStateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainStateLabel.Location = new System.Drawing.Point(47, 60);
            this.mainStateLabel.Name = "mainStateLabel";
            this.mainStateLabel.Size = new System.Drawing.Size(62, 37);
            this.mainStateLabel.TabIndex = 0;
            this.mainStateLabel.Text = "     ";
            // 
            // stateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.stateInformationGroupBox);
            this.Controls.Add(this.statePictureBox);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.changeColorGroupBox);
            this.Controls.Add(this.changeColorCheckBox);
            this.Controls.Add(this.phoneNumberMaskTextBox);
            this.Controls.Add(this.phoneCheckBox);
            this.Controls.Add(this.groupBoxThreeButtons);
            this.Controls.Add(this.groupBoxRadioButtons);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "stateForm";
            this.Text = "Favorite States";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBoxRadioButtons.ResumeLayout(false);
            this.groupBoxRadioButtons.PerformLayout();
            this.groupBoxThreeButtons.ResumeLayout(false);
            this.changeColorGroupBox.ResumeLayout(false);
            this.changeColorGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statePictureBox)).EndInit();
            this.stateInformationGroupBox.ResumeLayout(false);
            this.stateInformationGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oregonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem washingtonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem californiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxRadioButtons;
        private System.Windows.Forms.RadioButton radioButtonCalifornia;
        private System.Windows.Forms.RadioButton radioButtonWashington;
        private System.Windows.Forms.RadioButton radioButtonOregon;
        private System.Windows.Forms.GroupBox groupBoxThreeButtons;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button inputBoxButton;
        private System.Windows.Forms.CheckBox phoneCheckBox;
        private System.Windows.Forms.MaskedTextBox phoneNumberMaskTextBox;
        private System.Windows.Forms.CheckBox changeColorCheckBox;
        private System.Windows.Forms.GroupBox changeColorGroupBox;
        private System.Windows.Forms.TextBox backgroundColorTextBox;
        private System.Windows.Forms.Button backgroundColorButton;
        private System.Windows.Forms.Label colorDescriptionLabel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.PictureBox statePictureBox;
        private System.Windows.Forms.GroupBox stateInformationGroupBox;
        private System.Windows.Forms.Label climateNoChangeLabel;
        private System.Windows.Forms.Label populationInformationLabel;
        private System.Windows.Forms.Label populationNoChangeLabel;
        private System.Windows.Forms.Label mainStateLabel;
        private System.Windows.Forms.Label nickNameInformationLabel;
        private System.Windows.Forms.Label climateInformationLabel;
        private System.Windows.Forms.Label nicknameNoChangeLabel;
        private System.Windows.Forms.ToolTip toolTipControl;
    }
}

