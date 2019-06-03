namespace Kraig_Massee_Lab_7
{
    partial class wordProcessorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wordProcessorForm));
            this.myToolStrip = new System.Windows.Forms.ToolStrip();
            this.closeButton = new System.Windows.Forms.ToolStripButton();
            this.saveButton = new System.Windows.Forms.ToolStripButton();
            this.openButton = new System.Windows.Forms.ToolStripButton();
            this.cutButton = new System.Windows.Forms.ToolStripButton();
            this.copyButton = new System.Windows.Forms.ToolStripButton();
            this.pasteButton = new System.Windows.Forms.ToolStripButton();
            this.undoButton = new System.Windows.Forms.ToolStripButton();
            this.redoButton = new System.Windows.Forms.ToolStripButton();
            this.alignCenterButton = new System.Windows.Forms.ToolStripButton();
            this.alignLeftButton = new System.Windows.Forms.ToolStripButton();
            this.alignRightButton = new System.Windows.Forms.ToolStripButton();
            this.wordCountButton = new System.Windows.Forms.ToolStripButton();
            this.clearButton = new System.Windows.Forms.ToolStripButton();
            this.colorComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.availableComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.myImageList = new System.Windows.Forms.ImageList(this.components);
            this.myRichTextBox = new System.Windows.Forms.RichTextBox();
            this.myColorDialog = new System.Windows.Forms.ColorDialog();
            this.myFontDialog = new System.Windows.Forms.FontDialog();
            this.availableDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.callProgramsGroupBox = new System.Windows.Forms.GroupBox();
            this.closeWordButton = new System.Windows.Forms.Button();
            this.closeChromeButton = new System.Windows.Forms.Button();
            this.openWordButton = new System.Windows.Forms.Button();
            this.openChromeButton = new System.Windows.Forms.Button();
            this.closeNotePadButton = new System.Windows.Forms.Button();
            this.openNotePadButton = new System.Windows.Forms.Button();
            this.notePadProcess = new System.Diagnostics.Process();
            this.chromeProcess = new System.Diagnostics.Process();
            this.wordProcess = new System.Diagnostics.Process();
            this.noChangeAvailabilityLabel = new System.Windows.Forms.Label();
            this.myAvailabilityTextBox = new System.Windows.Forms.TextBox();
            this.addScheduleToArrayButton = new System.Windows.Forms.Button();
            this.myStatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.timeToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.noteToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.myTimer = new System.Windows.Forms.Timer(this.components);
            this.myToolStrip.SuspendLayout();
            this.callProgramsGroupBox.SuspendLayout();
            this.myStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // myToolStrip
            // 
            this.myToolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.myToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeButton,
            this.saveButton,
            this.openButton,
            this.cutButton,
            this.copyButton,
            this.pasteButton,
            this.undoButton,
            this.redoButton,
            this.alignCenterButton,
            this.alignLeftButton,
            this.alignRightButton,
            this.wordCountButton,
            this.clearButton,
            this.colorComboBox,
            this.availableComboBox});
            this.myToolStrip.Location = new System.Drawing.Point(0, 0);
            this.myToolStrip.Name = "myToolStrip";
            this.myToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.myToolStrip.Size = new System.Drawing.Size(1968, 40);
            this.myToolStrip.TabIndex = 0;
            this.myToolStrip.Text = "toolStrip1";
            // 
            // closeButton
            // 
            this.closeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(36, 37);
            this.closeButton.Text = "Close";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveButton.Image = ((System.Drawing.Image)(resources.GetObject("saveButton.Image")));
            this.saveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(36, 37);
            this.saveButton.Text = "Save";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // openButton
            // 
            this.openButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openButton.Image = ((System.Drawing.Image)(resources.GetObject("openButton.Image")));
            this.openButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(36, 37);
            this.openButton.Text = "Open";
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // cutButton
            // 
            this.cutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutButton.Image = ((System.Drawing.Image)(resources.GetObject("cutButton.Image")));
            this.cutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutButton.Name = "cutButton";
            this.cutButton.Size = new System.Drawing.Size(36, 37);
            this.cutButton.Text = "Cut";
            this.cutButton.Click += new System.EventHandler(this.cutButton_Click);
            // 
            // copyButton
            // 
            this.copyButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyButton.Image = ((System.Drawing.Image)(resources.GetObject("copyButton.Image")));
            this.copyButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(36, 37);
            this.copyButton.Text = "Copy";
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // pasteButton
            // 
            this.pasteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteButton.Image")));
            this.pasteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteButton.Name = "pasteButton";
            this.pasteButton.Size = new System.Drawing.Size(36, 37);
            this.pasteButton.Text = "Paste";
            this.pasteButton.Click += new System.EventHandler(this.pasteButton_Click);
            // 
            // undoButton
            // 
            this.undoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.undoButton.Image = ((System.Drawing.Image)(resources.GetObject("undoButton.Image")));
            this.undoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(36, 37);
            this.undoButton.Text = "Undo";
            this.undoButton.Click += new System.EventHandler(this.undoButton_Click);
            // 
            // redoButton
            // 
            this.redoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.redoButton.Image = ((System.Drawing.Image)(resources.GetObject("redoButton.Image")));
            this.redoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.redoButton.Name = "redoButton";
            this.redoButton.Size = new System.Drawing.Size(36, 37);
            this.redoButton.Text = "Redo";
            this.redoButton.Click += new System.EventHandler(this.redoButton_Click);
            // 
            // alignCenterButton
            // 
            this.alignCenterButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.alignCenterButton.Image = ((System.Drawing.Image)(resources.GetObject("alignCenterButton.Image")));
            this.alignCenterButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.alignCenterButton.Name = "alignCenterButton";
            this.alignCenterButton.Size = new System.Drawing.Size(36, 37);
            this.alignCenterButton.Text = "Align Center";
            this.alignCenterButton.Click += new System.EventHandler(this.alignCenterButton_Click);
            // 
            // alignLeftButton
            // 
            this.alignLeftButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.alignLeftButton.Image = ((System.Drawing.Image)(resources.GetObject("alignLeftButton.Image")));
            this.alignLeftButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.alignLeftButton.Name = "alignLeftButton";
            this.alignLeftButton.Size = new System.Drawing.Size(36, 37);
            this.alignLeftButton.Text = "Align Left";
            this.alignLeftButton.Click += new System.EventHandler(this.alignLeftButton_Click);
            // 
            // alignRightButton
            // 
            this.alignRightButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.alignRightButton.Image = ((System.Drawing.Image)(resources.GetObject("alignRightButton.Image")));
            this.alignRightButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.alignRightButton.Name = "alignRightButton";
            this.alignRightButton.Size = new System.Drawing.Size(36, 37);
            this.alignRightButton.Text = "Align Right";
            this.alignRightButton.Click += new System.EventHandler(this.alignRightButton_Click);
            // 
            // wordCountButton
            // 
            this.wordCountButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.wordCountButton.Image = ((System.Drawing.Image)(resources.GetObject("wordCountButton.Image")));
            this.wordCountButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.wordCountButton.Name = "wordCountButton";
            this.wordCountButton.Size = new System.Drawing.Size(36, 37);
            this.wordCountButton.Text = "Word Count";
            this.wordCountButton.Click += new System.EventHandler(this.wordCountButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clearButton.Image = ((System.Drawing.Image)(resources.GetObject("clearButton.Image")));
            this.clearButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(36, 37);
            this.clearButton.Text = "Clear";
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // colorComboBox
            // 
            this.colorComboBox.Items.AddRange(new object[] {
            "Color",
            "Font",
            "Any Color",
            "Reset"});
            this.colorComboBox.Name = "colorComboBox";
            this.colorComboBox.Size = new System.Drawing.Size(238, 40);
            this.colorComboBox.Text = "Color";
            this.colorComboBox.SelectedIndexChanged += new System.EventHandler(this.colorComboBox_SelectedIndexChanged);
            // 
            // availableComboBox
            // 
            this.availableComboBox.Name = "availableComboBox";
            this.availableComboBox.Size = new System.Drawing.Size(238, 40);
            this.availableComboBox.Text = "I am available on";
            // 
            // myImageList
            // 
            this.myImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("myImageList.ImageStream")));
            this.myImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.myImageList.Images.SetKeyName(0, "close.PNG");
            this.myImageList.Images.SetKeyName(1, "Save.PNG");
            this.myImageList.Images.SetKeyName(2, "open.PNG");
            this.myImageList.Images.SetKeyName(3, "cut.PNG");
            this.myImageList.Images.SetKeyName(4, "copy.PNG");
            this.myImageList.Images.SetKeyName(5, "paste.PNG");
            this.myImageList.Images.SetKeyName(6, "undo.PNG");
            this.myImageList.Images.SetKeyName(7, "redo.PNG");
            this.myImageList.Images.SetKeyName(8, "aligncenter.PNG");
            this.myImageList.Images.SetKeyName(9, "alignleft.PNG");
            this.myImageList.Images.SetKeyName(10, "alignright.PNG");
            this.myImageList.Images.SetKeyName(11, "wordcount.PNG");
            this.myImageList.Images.SetKeyName(12, "clear.PNG");
            // 
            // myRichTextBox
            // 
            this.myRichTextBox.Location = new System.Drawing.Point(26, 81);
            this.myRichTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.myRichTextBox.Name = "myRichTextBox";
            this.myRichTextBox.Size = new System.Drawing.Size(1084, 1062);
            this.myRichTextBox.TabIndex = 1;
            this.myRichTextBox.Text = "";
            // 
            // availableDateTimePicker
            // 
            this.availableDateTimePicker.CustomFormat = "";
            this.availableDateTimePicker.Location = new System.Drawing.Point(1510, 23);
            this.availableDateTimePicker.Margin = new System.Windows.Forms.Padding(6);
            this.availableDateTimePicker.Name = "availableDateTimePicker";
            this.availableDateTimePicker.Size = new System.Drawing.Size(396, 31);
            this.availableDateTimePicker.TabIndex = 2;
            this.availableDateTimePicker.ValueChanged += new System.EventHandler(this.availableDateTimePicker_ValueChanged);
            // 
            // callProgramsGroupBox
            // 
            this.callProgramsGroupBox.Controls.Add(this.closeWordButton);
            this.callProgramsGroupBox.Controls.Add(this.closeChromeButton);
            this.callProgramsGroupBox.Controls.Add(this.openWordButton);
            this.callProgramsGroupBox.Controls.Add(this.openChromeButton);
            this.callProgramsGroupBox.Controls.Add(this.closeNotePadButton);
            this.callProgramsGroupBox.Controls.Add(this.openNotePadButton);
            this.callProgramsGroupBox.Location = new System.Drawing.Point(1144, 700);
            this.callProgramsGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.callProgramsGroupBox.Name = "callProgramsGroupBox";
            this.callProgramsGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.callProgramsGroupBox.Size = new System.Drawing.Size(600, 548);
            this.callProgramsGroupBox.TabIndex = 3;
            this.callProgramsGroupBox.TabStop = false;
            this.callProgramsGroupBox.Text = "Call Programs";
            // 
            // closeWordButton
            // 
            this.closeWordButton.Location = new System.Drawing.Point(332, 402);
            this.closeWordButton.Margin = new System.Windows.Forms.Padding(6);
            this.closeWordButton.Name = "closeWordButton";
            this.closeWordButton.Size = new System.Drawing.Size(226, 44);
            this.closeWordButton.TabIndex = 5;
            this.closeWordButton.Text = "Close Word";
            this.closeWordButton.UseVisualStyleBackColor = true;
            this.closeWordButton.Click += new System.EventHandler(this.closeWordButton_Click);
            // 
            // closeChromeButton
            // 
            this.closeChromeButton.Location = new System.Drawing.Point(332, 250);
            this.closeChromeButton.Margin = new System.Windows.Forms.Padding(6);
            this.closeChromeButton.Name = "closeChromeButton";
            this.closeChromeButton.Size = new System.Drawing.Size(226, 44);
            this.closeChromeButton.TabIndex = 4;
            this.closeChromeButton.Text = "Close Chrome";
            this.closeChromeButton.UseVisualStyleBackColor = true;
            this.closeChromeButton.Click += new System.EventHandler(this.closeChromeButton_Click);
            // 
            // openWordButton
            // 
            this.openWordButton.Location = new System.Drawing.Point(42, 402);
            this.openWordButton.Margin = new System.Windows.Forms.Padding(6);
            this.openWordButton.Name = "openWordButton";
            this.openWordButton.Size = new System.Drawing.Size(226, 44);
            this.openWordButton.TabIndex = 3;
            this.openWordButton.Text = "Open Word";
            this.openWordButton.UseVisualStyleBackColor = true;
            this.openWordButton.Click += new System.EventHandler(this.openWordButton_Click);
            // 
            // openChromeButton
            // 
            this.openChromeButton.Location = new System.Drawing.Point(42, 250);
            this.openChromeButton.Margin = new System.Windows.Forms.Padding(6);
            this.openChromeButton.Name = "openChromeButton";
            this.openChromeButton.Size = new System.Drawing.Size(226, 44);
            this.openChromeButton.TabIndex = 2;
            this.openChromeButton.Text = "Open Chrome";
            this.openChromeButton.UseVisualStyleBackColor = true;
            this.openChromeButton.Click += new System.EventHandler(this.openChromeButton_Click);
            // 
            // closeNotePadButton
            // 
            this.closeNotePadButton.Location = new System.Drawing.Point(332, 100);
            this.closeNotePadButton.Margin = new System.Windows.Forms.Padding(6);
            this.closeNotePadButton.Name = "closeNotePadButton";
            this.closeNotePadButton.Size = new System.Drawing.Size(226, 44);
            this.closeNotePadButton.TabIndex = 1;
            this.closeNotePadButton.Text = "Close Notepad";
            this.closeNotePadButton.UseVisualStyleBackColor = true;
            this.closeNotePadButton.Click += new System.EventHandler(this.closeNotePadButton_Click);
            // 
            // openNotePadButton
            // 
            this.openNotePadButton.Location = new System.Drawing.Point(42, 100);
            this.openNotePadButton.Margin = new System.Windows.Forms.Padding(6);
            this.openNotePadButton.Name = "openNotePadButton";
            this.openNotePadButton.Size = new System.Drawing.Size(226, 44);
            this.openNotePadButton.TabIndex = 0;
            this.openNotePadButton.Text = "Open Notepad";
            this.openNotePadButton.UseVisualStyleBackColor = true;
            this.openNotePadButton.Click += new System.EventHandler(this.openNotePadButton_Click);
            // 
            // notePadProcess
            // 
            this.notePadProcess.StartInfo.Domain = "";
            this.notePadProcess.StartInfo.FileName = "notepad.exe";
            this.notePadProcess.StartInfo.LoadUserProfile = false;
            this.notePadProcess.StartInfo.Password = null;
            this.notePadProcess.StartInfo.StandardErrorEncoding = null;
            this.notePadProcess.StartInfo.StandardOutputEncoding = null;
            this.notePadProcess.StartInfo.UserName = "";
            this.notePadProcess.SynchronizingObject = this;
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
            // wordProcess
            // 
            this.wordProcess.StartInfo.Domain = "";
            this.wordProcess.StartInfo.FileName = "WINWORD.EXE";
            this.wordProcess.StartInfo.LoadUserProfile = false;
            this.wordProcess.StartInfo.Password = null;
            this.wordProcess.StartInfo.StandardErrorEncoding = null;
            this.wordProcess.StartInfo.StandardOutputEncoding = null;
            this.wordProcess.StartInfo.UserName = "";
            this.wordProcess.SynchronizingObject = this;
            // 
            // noChangeAvailabilityLabel
            // 
            this.noChangeAvailabilityLabel.AutoSize = true;
            this.noChangeAvailabilityLabel.Location = new System.Drawing.Point(1370, 194);
            this.noChangeAvailabilityLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.noChangeAvailabilityLabel.Name = "noChangeAvailabilityLabel";
            this.noChangeAvailabilityLabel.Size = new System.Drawing.Size(150, 25);
            this.noChangeAvailabilityLabel.TabIndex = 6;
            this.noChangeAvailabilityLabel.Text = "My Availability";
            // 
            // myAvailabilityTextBox
            // 
            this.myAvailabilityTextBox.Location = new System.Drawing.Point(1186, 246);
            this.myAvailabilityTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.myAvailabilityTextBox.Multiline = true;
            this.myAvailabilityTextBox.Name = "myAvailabilityTextBox";
            this.myAvailabilityTextBox.Size = new System.Drawing.Size(512, 269);
            this.myAvailabilityTextBox.TabIndex = 7;
            // 
            // addScheduleToArrayButton
            // 
            this.addScheduleToArrayButton.Location = new System.Drawing.Point(1186, 571);
            this.addScheduleToArrayButton.Margin = new System.Windows.Forms.Padding(6);
            this.addScheduleToArrayButton.Name = "addScheduleToArrayButton";
            this.addScheduleToArrayButton.Size = new System.Drawing.Size(516, 44);
            this.addScheduleToArrayButton.TabIndex = 9;
            this.addScheduleToArrayButton.Text = "Add schedule to array";
            this.addScheduleToArrayButton.UseVisualStyleBackColor = true;
            this.addScheduleToArrayButton.Click += new System.EventHandler(this.addScheduleToArrayButton_Click);
            // 
            // myStatusStrip
            // 
            this.myStatusStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.myStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.timeToolStripStatusLabel,
            this.noteToolStripStatusLabel});
            this.myStatusStrip.Location = new System.Drawing.Point(0, 1281);
            this.myStatusStrip.Name = "myStatusStrip";
            this.myStatusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 28, 0);
            this.myStatusStrip.Size = new System.Drawing.Size(1968, 38);
            this.myStatusStrip.TabIndex = 10;
            this.myStatusStrip.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(200, 32);
            // 
            // timeToolStripStatusLabel
            // 
            this.timeToolStripStatusLabel.Name = "timeToolStripStatusLabel";
            this.timeToolStripStatusLabel.Size = new System.Drawing.Size(0, 33);
            this.timeToolStripStatusLabel.Click += new System.EventHandler(this.timeToolStripStatusLabel_Click);
            // 
            // noteToolStripStatusLabel
            // 
            this.noteToolStripStatusLabel.Name = "noteToolStripStatusLabel";
            this.noteToolStripStatusLabel.Size = new System.Drawing.Size(295, 33);
            this.noteToolStripStatusLabel.Text = "                                        ";
            // 
            // myTimer
            // 
            this.myTimer.Enabled = true;
            this.myTimer.Tick += new System.EventHandler(this.myTimer_Tick);
            // 
            // wordProcessorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1968, 1319);
            this.Controls.Add(this.addScheduleToArrayButton);
            this.Controls.Add(this.myAvailabilityTextBox);
            this.Controls.Add(this.noChangeAvailabilityLabel);
            this.Controls.Add(this.callProgramsGroupBox);
            this.Controls.Add(this.availableDateTimePicker);
            this.Controls.Add(this.myRichTextBox);
            this.Controls.Add(this.myToolStrip);
            this.Controls.Add(this.myStatusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "wordProcessorForm";
            this.Text = "Word Processor";
            this.Load += new System.EventHandler(this.wordProcessorForm_Load);
            this.myToolStrip.ResumeLayout(false);
            this.myToolStrip.PerformLayout();
            this.callProgramsGroupBox.ResumeLayout(false);
            this.myStatusStrip.ResumeLayout(false);
            this.myStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip myToolStrip;
        private System.Windows.Forms.ToolStripButton closeButton;
        private System.Windows.Forms.ToolStripButton saveButton;
        private System.Windows.Forms.ToolStripButton openButton;
        private System.Windows.Forms.ToolStripButton cutButton;
        private System.Windows.Forms.ToolStripButton copyButton;
        private System.Windows.Forms.ToolStripButton pasteButton;
        private System.Windows.Forms.ToolStripButton undoButton;
        private System.Windows.Forms.ToolStripButton redoButton;
        private System.Windows.Forms.ToolStripButton alignCenterButton;
        private System.Windows.Forms.ToolStripButton alignLeftButton;
        private System.Windows.Forms.ToolStripButton alignRightButton;
        private System.Windows.Forms.ToolStripButton wordCountButton;
        private System.Windows.Forms.ToolStripButton clearButton;
        private System.Windows.Forms.ToolStripComboBox colorComboBox;
        private System.Windows.Forms.ToolStripComboBox availableComboBox;
        private System.Windows.Forms.ImageList myImageList;
        private System.Windows.Forms.RichTextBox myRichTextBox;
        private System.Windows.Forms.ColorDialog myColorDialog;
        private System.Windows.Forms.FontDialog myFontDialog;
        private System.Windows.Forms.DateTimePicker availableDateTimePicker;
        private System.Windows.Forms.GroupBox callProgramsGroupBox;
        private System.Windows.Forms.Button closeWordButton;
        private System.Windows.Forms.Button closeChromeButton;
        private System.Windows.Forms.Button openWordButton;
        private System.Windows.Forms.Button openChromeButton;
        private System.Windows.Forms.Button closeNotePadButton;
        private System.Windows.Forms.Button openNotePadButton;
        private System.Diagnostics.Process notePadProcess;
        private System.Diagnostics.Process chromeProcess;
        private System.Diagnostics.Process wordProcess;
        private System.Windows.Forms.TextBox myAvailabilityTextBox;
        private System.Windows.Forms.Label noChangeAvailabilityLabel;
        private System.Windows.Forms.Button addScheduleToArrayButton;
        private System.Windows.Forms.StatusStrip myStatusStrip;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel timeToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel noteToolStripStatusLabel;
        private System.Windows.Forms.Timer myTimer;
    }
}

