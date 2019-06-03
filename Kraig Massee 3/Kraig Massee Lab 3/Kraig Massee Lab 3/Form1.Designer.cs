namespace Kraig_Massee_Lab_3
{
    partial class calculatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calculatorForm));
            this.calculatorImagePictureBox = new System.Windows.Forms.PictureBox();
            this.myCalculatorMainLabel = new System.Windows.Forms.Label();
            this.enterNumberGroupBox = new System.Windows.Forms.GroupBox();
            this.bottomNumberTextBox = new System.Windows.Forms.TextBox();
            this.topNumberTextBox = new System.Windows.Forms.TextBox();
            this.bottomEnterNumberLabel = new System.Windows.Forms.Label();
            this.topEnterNumberLabel = new System.Windows.Forms.Label();
            this.processOutputGroupBox = new System.Windows.Forms.GroupBox();
            this.equalSixLabel = new System.Windows.Forms.Label();
            this.equalFiveLabel = new System.Windows.Forms.Label();
            this.equalFourLabel = new System.Windows.Forms.Label();
            this.equalThreeLabel = new System.Windows.Forms.Label();
            this.equalTwoLabel = new System.Windows.Forms.Label();
            this.equalOneLabel = new System.Windows.Forms.Label();
            this.powerButton = new System.Windows.Forms.Button();
            this.modulusButton = new System.Windows.Forms.Button();
            this.differenceButton = new System.Windows.Forms.Button();
            this.divisionButton = new System.Windows.Forms.Button();
            this.additionButton = new System.Windows.Forms.Button();
            this.multiplicationButton = new System.Windows.Forms.Button();
            this.resultDisplayLabel = new System.Windows.Forms.Label();
            this.buttonGroupBox = new System.Windows.Forms.GroupBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.toolTipInformation = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.calculatorImagePictureBox)).BeginInit();
            this.enterNumberGroupBox.SuspendLayout();
            this.processOutputGroupBox.SuspendLayout();
            this.buttonGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // calculatorImagePictureBox
            // 
            this.calculatorImagePictureBox.Location = new System.Drawing.Point(70, 69);
            this.calculatorImagePictureBox.Margin = new System.Windows.Forms.Padding(6);
            this.calculatorImagePictureBox.Name = "calculatorImagePictureBox";
            this.calculatorImagePictureBox.Size = new System.Drawing.Size(200, 192);
            this.calculatorImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.calculatorImagePictureBox.TabIndex = 0;
            this.calculatorImagePictureBox.TabStop = false;
            this.calculatorImagePictureBox.Click += new System.EventHandler(this.calculatorImagePictureBox_Click);
            // 
            // myCalculatorMainLabel
            // 
            this.myCalculatorMainLabel.AutoSize = true;
            this.myCalculatorMainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myCalculatorMainLabel.Location = new System.Drawing.Point(468, 67);
            this.myCalculatorMainLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.myCalculatorMainLabel.Name = "myCalculatorMainLabel";
            this.myCalculatorMainLabel.Size = new System.Drawing.Size(629, 108);
            this.myCalculatorMainLabel.TabIndex = 1;
            this.myCalculatorMainLabel.Text = "My Calculator";
            this.myCalculatorMainLabel.Click += new System.EventHandler(this.myCalculatorMainLabel_Click);
            // 
            // enterNumberGroupBox
            // 
            this.enterNumberGroupBox.Controls.Add(this.bottomNumberTextBox);
            this.enterNumberGroupBox.Controls.Add(this.topNumberTextBox);
            this.enterNumberGroupBox.Controls.Add(this.bottomEnterNumberLabel);
            this.enterNumberGroupBox.Controls.Add(this.topEnterNumberLabel);
            this.enterNumberGroupBox.Location = new System.Drawing.Point(114, 300);
            this.enterNumberGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.enterNumberGroupBox.Name = "enterNumberGroupBox";
            this.enterNumberGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.enterNumberGroupBox.Size = new System.Drawing.Size(600, 577);
            this.enterNumberGroupBox.TabIndex = 2;
            this.enterNumberGroupBox.TabStop = false;
            this.enterNumberGroupBox.Text = "Input";
            // 
            // bottomNumberTextBox
            // 
            this.bottomNumberTextBox.Location = new System.Drawing.Point(374, 400);
            this.bottomNumberTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.bottomNumberTextBox.Name = "bottomNumberTextBox";
            this.bottomNumberTextBox.Size = new System.Drawing.Size(196, 31);
            this.bottomNumberTextBox.TabIndex = 3;
            this.toolTipInformation.SetToolTip(this.bottomNumberTextBox, "Denominator");
            // 
            // topNumberTextBox
            // 
            this.topNumberTextBox.Location = new System.Drawing.Point(374, 144);
            this.topNumberTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.topNumberTextBox.Name = "topNumberTextBox";
            this.topNumberTextBox.Size = new System.Drawing.Size(196, 31);
            this.topNumberTextBox.TabIndex = 2;
            this.toolTipInformation.SetToolTip(this.topNumberTextBox, "Numerator");
            this.topNumberTextBox.TextChanged += new System.EventHandler(this.topNumberTextBox_TextChanged);
            // 
            // bottomEnterNumberLabel
            // 
            this.bottomEnterNumberLabel.AutoSize = true;
            this.bottomEnterNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottomEnterNumberLabel.Location = new System.Drawing.Point(10, 392);
            this.bottomEnterNumberLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.bottomEnterNumberLabel.Name = "bottomEnterNumberLabel";
            this.bottomEnterNumberLabel.Size = new System.Drawing.Size(306, 48);
            this.bottomEnterNumberLabel.TabIndex = 1;
            this.bottomEnterNumberLabel.Text = "Enter a number";
            this.bottomEnterNumberLabel.Click += new System.EventHandler(this.bottomEnterNumberLabel_Click);
            // 
            // topEnterNumberLabel
            // 
            this.topEnterNumberLabel.AutoSize = true;
            this.topEnterNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topEnterNumberLabel.Location = new System.Drawing.Point(10, 137);
            this.topEnterNumberLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.topEnterNumberLabel.Name = "topEnterNumberLabel";
            this.topEnterNumberLabel.Size = new System.Drawing.Size(306, 48);
            this.topEnterNumberLabel.TabIndex = 0;
            this.topEnterNumberLabel.Text = "Enter a number";
            this.topEnterNumberLabel.Click += new System.EventHandler(this.topEnterNumberLabel_Click);
            // 
            // processOutputGroupBox
            // 
            this.processOutputGroupBox.Controls.Add(this.equalSixLabel);
            this.processOutputGroupBox.Controls.Add(this.equalFiveLabel);
            this.processOutputGroupBox.Controls.Add(this.equalFourLabel);
            this.processOutputGroupBox.Controls.Add(this.equalThreeLabel);
            this.processOutputGroupBox.Controls.Add(this.equalTwoLabel);
            this.processOutputGroupBox.Controls.Add(this.equalOneLabel);
            this.processOutputGroupBox.Controls.Add(this.powerButton);
            this.processOutputGroupBox.Controls.Add(this.modulusButton);
            this.processOutputGroupBox.Controls.Add(this.differenceButton);
            this.processOutputGroupBox.Controls.Add(this.divisionButton);
            this.processOutputGroupBox.Controls.Add(this.additionButton);
            this.processOutputGroupBox.Controls.Add(this.multiplicationButton);
            this.processOutputGroupBox.Controls.Add(this.resultDisplayLabel);
            this.processOutputGroupBox.Location = new System.Drawing.Point(856, 300);
            this.processOutputGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.processOutputGroupBox.Name = "processOutputGroupBox";
            this.processOutputGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.processOutputGroupBox.Size = new System.Drawing.Size(600, 577);
            this.processOutputGroupBox.TabIndex = 3;
            this.processOutputGroupBox.TabStop = false;
            this.processOutputGroupBox.Text = "Process Output";
            this.processOutputGroupBox.Enter += new System.EventHandler(this.processOutputGroupBox_Enter);
            // 
            // equalSixLabel
            // 
            this.equalSixLabel.AutoSize = true;
            this.equalSixLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalSixLabel.Location = new System.Drawing.Point(204, 479);
            this.equalSixLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.equalSixLabel.Name = "equalSixLabel";
            this.equalSixLabel.Size = new System.Drawing.Size(46, 48);
            this.equalSixLabel.TabIndex = 12;
            this.equalSixLabel.Text = "=";
            // 
            // equalFiveLabel
            // 
            this.equalFiveLabel.AutoSize = true;
            this.equalFiveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalFiveLabel.Location = new System.Drawing.Point(204, 390);
            this.equalFiveLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.equalFiveLabel.Name = "equalFiveLabel";
            this.equalFiveLabel.Size = new System.Drawing.Size(46, 48);
            this.equalFiveLabel.TabIndex = 11;
            this.equalFiveLabel.Text = "=";
            // 
            // equalFourLabel
            // 
            this.equalFourLabel.AutoSize = true;
            this.equalFourLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalFourLabel.Location = new System.Drawing.Point(204, 306);
            this.equalFourLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.equalFourLabel.Name = "equalFourLabel";
            this.equalFourLabel.Size = new System.Drawing.Size(46, 48);
            this.equalFourLabel.TabIndex = 10;
            this.equalFourLabel.Text = "=";
            // 
            // equalThreeLabel
            // 
            this.equalThreeLabel.AutoSize = true;
            this.equalThreeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalThreeLabel.Location = new System.Drawing.Point(204, 219);
            this.equalThreeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.equalThreeLabel.Name = "equalThreeLabel";
            this.equalThreeLabel.Size = new System.Drawing.Size(46, 48);
            this.equalThreeLabel.TabIndex = 9;
            this.equalThreeLabel.Text = "=";
            // 
            // equalTwoLabel
            // 
            this.equalTwoLabel.AutoSize = true;
            this.equalTwoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalTwoLabel.Location = new System.Drawing.Point(204, 133);
            this.equalTwoLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.equalTwoLabel.Name = "equalTwoLabel";
            this.equalTwoLabel.Size = new System.Drawing.Size(46, 48);
            this.equalTwoLabel.TabIndex = 8;
            this.equalTwoLabel.Text = "=";
            // 
            // equalOneLabel
            // 
            this.equalOneLabel.AutoSize = true;
            this.equalOneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalOneLabel.Location = new System.Drawing.Point(204, 46);
            this.equalOneLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.equalOneLabel.Name = "equalOneLabel";
            this.equalOneLabel.Size = new System.Drawing.Size(46, 48);
            this.equalOneLabel.TabIndex = 7;
            this.equalOneLabel.Text = "=";
            // 
            // powerButton
            // 
            this.powerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powerButton.Location = new System.Drawing.Point(10, 471);
            this.powerButton.Margin = new System.Windows.Forms.Padding(6);
            this.powerButton.Name = "powerButton";
            this.powerButton.Size = new System.Drawing.Size(182, 67);
            this.powerButton.TabIndex = 6;
            this.powerButton.Text = "^";
            this.toolTipInformation.SetToolTip(this.powerButton, "Exponent");
            this.powerButton.UseVisualStyleBackColor = true;
            this.powerButton.Click += new System.EventHandler(this.powerButton_Click);
            // 
            // modulusButton
            // 
            this.modulusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modulusButton.Location = new System.Drawing.Point(10, 385);
            this.modulusButton.Margin = new System.Windows.Forms.Padding(6);
            this.modulusButton.Name = "modulusButton";
            this.modulusButton.Size = new System.Drawing.Size(182, 67);
            this.modulusButton.TabIndex = 5;
            this.modulusButton.Text = "%";
            this.toolTipInformation.SetToolTip(this.modulusButton, "Modulus");
            this.modulusButton.UseVisualStyleBackColor = true;
            this.modulusButton.Click += new System.EventHandler(this.modulusButton_Click);
            // 
            // differenceButton
            // 
            this.differenceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.differenceButton.Location = new System.Drawing.Point(10, 298);
            this.differenceButton.Margin = new System.Windows.Forms.Padding(6);
            this.differenceButton.Name = "differenceButton";
            this.differenceButton.Size = new System.Drawing.Size(182, 67);
            this.differenceButton.TabIndex = 4;
            this.differenceButton.Text = "-";
            this.toolTipInformation.SetToolTip(this.differenceButton, "Subtract");
            this.differenceButton.UseVisualStyleBackColor = true;
            this.differenceButton.Click += new System.EventHandler(this.differenceButton_Click);
            // 
            // divisionButton
            // 
            this.divisionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisionButton.Location = new System.Drawing.Point(10, 212);
            this.divisionButton.Margin = new System.Windows.Forms.Padding(6);
            this.divisionButton.Name = "divisionButton";
            this.divisionButton.Size = new System.Drawing.Size(182, 67);
            this.divisionButton.TabIndex = 3;
            this.divisionButton.Text = "/";
            this.toolTipInformation.SetToolTip(this.divisionButton, "Divide");
            this.divisionButton.UseVisualStyleBackColor = true;
            this.divisionButton.Click += new System.EventHandler(this.divisionButton_Click);
            // 
            // additionButton
            // 
            this.additionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additionButton.Location = new System.Drawing.Point(10, 125);
            this.additionButton.Margin = new System.Windows.Forms.Padding(6);
            this.additionButton.Name = "additionButton";
            this.additionButton.Size = new System.Drawing.Size(182, 67);
            this.additionButton.TabIndex = 2;
            this.additionButton.Text = "+";
            this.toolTipInformation.SetToolTip(this.additionButton, "Addition");
            this.additionButton.UseVisualStyleBackColor = true;
            this.additionButton.Click += new System.EventHandler(this.additionButton_Click);
            // 
            // multiplicationButton
            // 
            this.multiplicationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplicationButton.Location = new System.Drawing.Point(10, 38);
            this.multiplicationButton.Margin = new System.Windows.Forms.Padding(6);
            this.multiplicationButton.Name = "multiplicationButton";
            this.multiplicationButton.Size = new System.Drawing.Size(182, 67);
            this.multiplicationButton.TabIndex = 1;
            this.multiplicationButton.Text = "X";
            this.toolTipInformation.SetToolTip(this.multiplicationButton, "Multiply");
            this.multiplicationButton.UseVisualStyleBackColor = true;
            this.multiplicationButton.Click += new System.EventHandler(this.multiplicationButton_Click);
            // 
            // resultDisplayLabel
            // 
            this.resultDisplayLabel.BackColor = System.Drawing.SystemColors.Window;
            this.resultDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultDisplayLabel.Location = new System.Drawing.Point(328, 265);
            this.resultDisplayLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.resultDisplayLabel.Name = "resultDisplayLabel";
            this.resultDisplayLabel.Size = new System.Drawing.Size(228, 46);
            this.resultDisplayLabel.TabIndex = 0;
            this.resultDisplayLabel.Click += new System.EventHandler(this.resultDisplayLabel_Click);
            // 
            // buttonGroupBox
            // 
            this.buttonGroupBox.Controls.Add(this.exitButton);
            this.buttonGroupBox.Controls.Add(this.clearButton);
            this.buttonGroupBox.Location = new System.Drawing.Point(114, 888);
            this.buttonGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.buttonGroupBox.Name = "buttonGroupBox";
            this.buttonGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.buttonGroupBox.Size = new System.Drawing.Size(1342, 150);
            this.buttonGroupBox.TabIndex = 4;
            this.buttonGroupBox.TabStop = false;
            this.buttonGroupBox.Text = "Operations";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(964, 54);
            this.exitButton.Margin = new System.Windows.Forms.Padding(6);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(150, 44);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "e&Xit";
            this.toolTipInformation.SetToolTip(this.exitButton, "Exit Program");
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(228, 54);
            this.clearButton.Margin = new System.Windows.Forms.Padding(6);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(150, 44);
            this.clearButton.TabIndex = 0;
            this.clearButton.Text = "&Clear";
            this.toolTipInformation.SetToolTip(this.clearButton, "Clear boxes");
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // toolTipInformation
            // 
            this.toolTipInformation.Tag = "";
            this.toolTipInformation.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipInformation.ToolTipTitle = "ToolTip";
            // 
            // calculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1568, 1062);
            this.Controls.Add(this.buttonGroupBox);
            this.Controls.Add(this.processOutputGroupBox);
            this.Controls.Add(this.enterNumberGroupBox);
            this.Controls.Add(this.myCalculatorMainLabel);
            this.Controls.Add(this.calculatorImagePictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "calculatorForm";
            this.Text = "Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.calculatorImagePictureBox)).EndInit();
            this.enterNumberGroupBox.ResumeLayout(false);
            this.enterNumberGroupBox.PerformLayout();
            this.processOutputGroupBox.ResumeLayout(false);
            this.processOutputGroupBox.PerformLayout();
            this.buttonGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox calculatorImagePictureBox;
        private System.Windows.Forms.Label myCalculatorMainLabel;
        private System.Windows.Forms.GroupBox enterNumberGroupBox;
        private System.Windows.Forms.GroupBox processOutputGroupBox;
        private System.Windows.Forms.Label bottomEnterNumberLabel;
        private System.Windows.Forms.Label topEnterNumberLabel;
        private System.Windows.Forms.GroupBox buttonGroupBox;
        private System.Windows.Forms.TextBox bottomNumberTextBox;
        private System.Windows.Forms.TextBox topNumberTextBox;
        private System.Windows.Forms.Label resultDisplayLabel;
        private System.Windows.Forms.Button powerButton;
        private System.Windows.Forms.Button modulusButton;
        private System.Windows.Forms.Button differenceButton;
        private System.Windows.Forms.Button divisionButton;
        private System.Windows.Forms.Button additionButton;
        private System.Windows.Forms.Button multiplicationButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label equalSixLabel;
        private System.Windows.Forms.Label equalFiveLabel;
        private System.Windows.Forms.Label equalFourLabel;
        private System.Windows.Forms.Label equalThreeLabel;
        private System.Windows.Forms.Label equalTwoLabel;
        private System.Windows.Forms.Label equalOneLabel;
        private System.Windows.Forms.ToolTip toolTipInformation;
    }
}

