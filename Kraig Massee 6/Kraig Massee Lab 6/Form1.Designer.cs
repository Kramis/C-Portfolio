namespace Kraig_Massee_Lab_6
{
    partial class electoralCollegeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(electoralCollegeForm));
            this.loadSectionGroupBox = new System.Windows.Forms.GroupBox();
            this.appendButton = new System.Windows.Forms.Button();
            this.stateImagePictureBox = new System.Windows.Forms.PictureBox();
            this.loadSectionComboBox = new System.Windows.Forms.ComboBox();
            this.selectedStateGroupBox = new System.Windows.Forms.GroupBox();
            this.fileProcessButton = new System.Windows.Forms.Button();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.selectedStateLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.electoralVotesGroupBox = new System.Windows.Forms.GroupBox();
            this.totalElectoralVotesNumberLabel = new System.Windows.Forms.Label();
            this.totalElectoralVotesButton = new System.Windows.Forms.Button();
            this.totalElectoralVotesLabel = new System.Windows.Forms.Label();
            this.electoralVotesListView = new System.Windows.Forms.ListView();
            this.stateNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.electoralColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.commentColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.baclgroundContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backgrounColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadSectionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stateImagePictureBox)).BeginInit();
            this.selectedStateGroupBox.SuspendLayout();
            this.electoralVotesGroupBox.SuspendLayout();
            this.baclgroundContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadSectionGroupBox
            // 
            this.loadSectionGroupBox.Controls.Add(this.appendButton);
            this.loadSectionGroupBox.Controls.Add(this.stateImagePictureBox);
            this.loadSectionGroupBox.Controls.Add(this.loadSectionComboBox);
            this.loadSectionGroupBox.Location = new System.Drawing.Point(24, 225);
            this.loadSectionGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.loadSectionGroupBox.Name = "loadSectionGroupBox";
            this.loadSectionGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.loadSectionGroupBox.Size = new System.Drawing.Size(500, 865);
            this.loadSectionGroupBox.TabIndex = 0;
            this.loadSectionGroupBox.TabStop = false;
            this.loadSectionGroupBox.Text = "Load Section";
            // 
            // appendButton
            // 
            this.appendButton.Location = new System.Drawing.Point(166, 748);
            this.appendButton.Margin = new System.Windows.Forms.Padding(6);
            this.appendButton.Name = "appendButton";
            this.appendButton.Size = new System.Drawing.Size(150, 44);
            this.appendButton.TabIndex = 2;
            this.appendButton.Text = "&Append";
            this.appendButton.UseVisualStyleBackColor = true;
            this.appendButton.Click += new System.EventHandler(this.appendButton_Click);
            // 
            // stateImagePictureBox
            // 
            this.stateImagePictureBox.Location = new System.Drawing.Point(30, 265);
            this.stateImagePictureBox.Margin = new System.Windows.Forms.Padding(6);
            this.stateImagePictureBox.Name = "stateImagePictureBox";
            this.stateImagePictureBox.Size = new System.Drawing.Size(440, 423);
            this.stateImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.stateImagePictureBox.TabIndex = 1;
            this.stateImagePictureBox.TabStop = false;
            // 
            // loadSectionComboBox
            // 
            this.loadSectionComboBox.FormattingEnabled = true;
            this.loadSectionComboBox.Location = new System.Drawing.Point(30, 88);
            this.loadSectionComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.loadSectionComboBox.Name = "loadSectionComboBox";
            this.loadSectionComboBox.Size = new System.Drawing.Size(436, 33);
            this.loadSectionComboBox.TabIndex = 0;
            this.loadSectionComboBox.SelectedIndexChanged += new System.EventHandler(this.loadSectionComboBox_SelectedIndexChanged);
            // 
            // selectedStateGroupBox
            // 
            this.selectedStateGroupBox.Controls.Add(this.fileProcessButton);
            this.selectedStateGroupBox.Controls.Add(this.stateTextBox);
            this.selectedStateGroupBox.Controls.Add(this.selectedStateLabel);
            this.selectedStateGroupBox.Location = new System.Drawing.Point(536, 225);
            this.selectedStateGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.selectedStateGroupBox.Name = "selectedStateGroupBox";
            this.selectedStateGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.selectedStateGroupBox.Size = new System.Drawing.Size(500, 673);
            this.selectedStateGroupBox.TabIndex = 1;
            this.selectedStateGroupBox.TabStop = false;
            this.selectedStateGroupBox.Text = "Selected State";
            // 
            // fileProcessButton
            // 
            this.fileProcessButton.Location = new System.Drawing.Point(142, 458);
            this.fileProcessButton.Margin = new System.Windows.Forms.Padding(6);
            this.fileProcessButton.Name = "fileProcessButton";
            this.fileProcessButton.Size = new System.Drawing.Size(218, 44);
            this.fileProcessButton.TabIndex = 2;
            this.fileProcessButton.Text = "&File Process";
            this.fileProcessButton.UseVisualStyleBackColor = true;
            this.fileProcessButton.Click += new System.EventHandler(this.fileProcessButton_Click);
            // 
            // stateTextBox
            // 
            this.stateTextBox.Location = new System.Drawing.Point(30, 296);
            this.stateTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.ReadOnly = true;
            this.stateTextBox.Size = new System.Drawing.Size(436, 31);
            this.stateTextBox.TabIndex = 1;
            // 
            // selectedStateLabel
            // 
            this.selectedStateLabel.AutoSize = true;
            this.selectedStateLabel.Location = new System.Drawing.Point(174, 173);
            this.selectedStateLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.selectedStateLabel.Name = "selectedStateLabel";
            this.selectedStateLabel.Size = new System.Drawing.Size(152, 25);
            this.selectedStateLabel.TabIndex = 0;
            this.selectedStateLabel.Text = "Selected State";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(566, 973);
            this.clearButton.Margin = new System.Windows.Forms.Padding(6);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(150, 44);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(856, 973);
            this.exitButton.Margin = new System.Windows.Forms.Padding(6);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(150, 44);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "e&Xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // electoralVotesGroupBox
            // 
            this.electoralVotesGroupBox.Controls.Add(this.totalElectoralVotesNumberLabel);
            this.electoralVotesGroupBox.Controls.Add(this.totalElectoralVotesButton);
            this.electoralVotesGroupBox.Controls.Add(this.totalElectoralVotesLabel);
            this.electoralVotesGroupBox.Controls.Add(this.electoralVotesListView);
            this.electoralVotesGroupBox.Location = new System.Drawing.Point(1048, 225);
            this.electoralVotesGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.electoralVotesGroupBox.Name = "electoralVotesGroupBox";
            this.electoralVotesGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.electoralVotesGroupBox.Size = new System.Drawing.Size(896, 865);
            this.electoralVotesGroupBox.TabIndex = 4;
            this.electoralVotesGroupBox.TabStop = false;
            this.electoralVotesGroupBox.Text = "Electoral Votes";
            // 
            // totalElectoralVotesNumberLabel
            // 
            this.totalElectoralVotesNumberLabel.AutoSize = true;
            this.totalElectoralVotesNumberLabel.Location = new System.Drawing.Point(276, 565);
            this.totalElectoralVotesNumberLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.totalElectoralVotesNumberLabel.Name = "totalElectoralVotesNumberLabel";
            this.totalElectoralVotesNumberLabel.Size = new System.Drawing.Size(102, 25);
            this.totalElectoralVotesNumberLabel.TabIndex = 3;
            this.totalElectoralVotesNumberLabel.Text = "               ";
            // 
            // totalElectoralVotesButton
            // 
            this.totalElectoralVotesButton.Location = new System.Drawing.Point(54, 748);
            this.totalElectoralVotesButton.Margin = new System.Windows.Forms.Padding(6);
            this.totalElectoralVotesButton.Name = "totalElectoralVotesButton";
            this.totalElectoralVotesButton.Size = new System.Drawing.Size(150, 44);
            this.totalElectoralVotesButton.TabIndex = 2;
            this.totalElectoralVotesButton.Text = "&Total";
            this.totalElectoralVotesButton.UseVisualStyleBackColor = true;
            this.totalElectoralVotesButton.Click += new System.EventHandler(this.totalElectoralVotesButton_Click);
            // 
            // totalElectoralVotesLabel
            // 
            this.totalElectoralVotesLabel.Location = new System.Drawing.Point(42, 510);
            this.totalElectoralVotesLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.totalElectoralVotesLabel.Name = "totalElectoralVotesLabel";
            this.totalElectoralVotesLabel.Size = new System.Drawing.Size(476, 96);
            this.totalElectoralVotesLabel.TabIndex = 1;
            this.totalElectoralVotesLabel.Text = "Total Electoral Votes: ";
            // 
            // electoralVotesListView
            // 
            this.electoralVotesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.stateNameColumn,
            this.electoralColumn,
            this.commentColumn});
            this.electoralVotesListView.GridLines = true;
            this.electoralVotesListView.Location = new System.Drawing.Point(52, 135);
            this.electoralVotesListView.Margin = new System.Windows.Forms.Padding(6);
            this.electoralVotesListView.Name = "electoralVotesListView";
            this.electoralVotesListView.Size = new System.Drawing.Size(796, 271);
            this.electoralVotesListView.TabIndex = 0;
            this.electoralVotesListView.UseCompatibleStateImageBehavior = false;
            this.electoralVotesListView.View = System.Windows.Forms.View.Details;
            // 
            // stateNameColumn
            // 
            this.stateNameColumn.Text = "State Name";
            this.stateNameColumn.Width = 132;
            // 
            // electoralColumn
            // 
            this.electoralColumn.Text = "Electoral";
            this.electoralColumn.Width = 95;
            // 
            // commentColumn
            // 
            this.commentColumn.Text = "Comment";
            this.commentColumn.Width = 168;
            // 
            // baclgroundContextMenuStrip
            // 
            this.baclgroundContextMenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.baclgroundContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgrounColorToolStripMenuItem});
            this.baclgroundContextMenuStrip.Name = "baclgroundContextMenuStrip";
            this.baclgroundContextMenuStrip.Size = new System.Drawing.Size(282, 40);
            this.baclgroundContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.baclgroundContextMenuStrip_Opening);
            // 
            // backgrounColorToolStripMenuItem
            // 
            this.backgrounColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.purpleToolStripMenuItem});
            this.backgrounColorToolStripMenuItem.Name = "backgrounColorToolStripMenuItem";
            this.backgrounColorToolStripMenuItem.Size = new System.Drawing.Size(281, 36);
            this.backgrounColorToolStripMenuItem.Text = "&Backgroung Color";
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(178, 38);
            this.redToolStripMenuItem.Text = "Red";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(178, 38);
            this.greenToolStripMenuItem.Text = "Green";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(178, 38);
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // purpleToolStripMenuItem
            // 
            this.purpleToolStripMenuItem.Name = "purpleToolStripMenuItem";
            this.purpleToolStripMenuItem.Size = new System.Drawing.Size(178, 38);
            this.purpleToolStripMenuItem.Text = "Reset";
            this.purpleToolStripMenuItem.Click += new System.EventHandler(this.purpleToolStripMenuItem_Click);
            // 
            // electoralCollegeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1062);
            this.ContextMenuStrip = this.baclgroundContextMenuStrip;
            this.Controls.Add(this.electoralVotesGroupBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.selectedStateGroupBox);
            this.Controls.Add(this.loadSectionGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "electoralCollegeForm";
            this.Text = "Electoral College Votes";
            this.loadSectionGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stateImagePictureBox)).EndInit();
            this.selectedStateGroupBox.ResumeLayout(false);
            this.selectedStateGroupBox.PerformLayout();
            this.electoralVotesGroupBox.ResumeLayout(false);
            this.electoralVotesGroupBox.PerformLayout();
            this.baclgroundContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox loadSectionGroupBox;
        private System.Windows.Forms.PictureBox stateImagePictureBox;
        private System.Windows.Forms.ComboBox loadSectionComboBox;
        private System.Windows.Forms.Button appendButton;
        private System.Windows.Forms.GroupBox selectedStateGroupBox;
        private System.Windows.Forms.Button fileProcessButton;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.Label selectedStateLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox electoralVotesGroupBox;
        private System.Windows.Forms.Label totalElectoralVotesNumberLabel;
        private System.Windows.Forms.Button totalElectoralVotesButton;
        private System.Windows.Forms.Label totalElectoralVotesLabel;
        private System.Windows.Forms.ListView electoralVotesListView;
        private System.Windows.Forms.ColumnHeader stateNameColumn;
        private System.Windows.Forms.ColumnHeader electoralColumn;
        private System.Windows.Forms.ColumnHeader commentColumn;
        private System.Windows.Forms.ContextMenuStrip baclgroundContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem backgrounColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purpleToolStripMenuItem;
    }
}

