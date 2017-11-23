namespace Program_4
{
    partial class program4
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
            this.addPackageGroupBox = new System.Windows.Forms.GroupBox();
            this.heightInput = new System.Windows.Forms.TextBox();
            this.widthInput = new System.Windows.Forms.TextBox();
            this.lenghtInput = new System.Windows.Forms.TextBox();
            this.addPackageButton = new System.Windows.Forms.Button();
            this.heightLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.origenLabel = new System.Windows.Forms.Label();
            this.destinationLabel = new System.Windows.Forms.Label();
            this.origenInput = new System.Windows.Forms.TextBox();
            this.destinationInput = new System.Windows.Forms.TextBox();
            this.costGroupBox = new System.Windows.Forms.GroupBox();
            this.costListBox = new System.Windows.Forms.ListBox();
            this.detailsButton = new System.Windows.Forms.Button();
            this.sendToUofLButton = new System.Windows.Forms.Button();
            this.sendFromUofLButton = new System.Windows.Forms.Button();
            this.weightLabel = new System.Windows.Forms.Label();
            this.weightInput = new System.Windows.Forms.TextBox();
            this.addPackageGroupBox.SuspendLayout();
            this.costGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addPackageGroupBox
            // 
            this.addPackageGroupBox.Controls.Add(this.weightInput);
            this.addPackageGroupBox.Controls.Add(this.weightLabel);
            this.addPackageGroupBox.Controls.Add(this.destinationInput);
            this.addPackageGroupBox.Controls.Add(this.origenInput);
            this.addPackageGroupBox.Controls.Add(this.destinationLabel);
            this.addPackageGroupBox.Controls.Add(this.origenLabel);
            this.addPackageGroupBox.Controls.Add(this.heightInput);
            this.addPackageGroupBox.Controls.Add(this.widthInput);
            this.addPackageGroupBox.Controls.Add(this.lenghtInput);
            this.addPackageGroupBox.Controls.Add(this.addPackageButton);
            this.addPackageGroupBox.Controls.Add(this.heightLabel);
            this.addPackageGroupBox.Controls.Add(this.widthLabel);
            this.addPackageGroupBox.Controls.Add(this.lengthLabel);
            this.addPackageGroupBox.Location = new System.Drawing.Point(12, 12);
            this.addPackageGroupBox.Name = "addPackageGroupBox";
            this.addPackageGroupBox.Size = new System.Drawing.Size(365, 245);
            this.addPackageGroupBox.TabIndex = 0;
            this.addPackageGroupBox.TabStop = false;
            this.addPackageGroupBox.Text = "Add Package";
            // 
            // heightInput
            // 
            this.heightInput.Location = new System.Drawing.Point(167, 146);
            this.heightInput.Name = "heightInput";
            this.heightInput.Size = new System.Drawing.Size(141, 22);
            this.heightInput.TabIndex = 6;
            // 
            // widthInput
            // 
            this.widthInput.Location = new System.Drawing.Point(167, 118);
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(141, 22);
            this.widthInput.TabIndex = 5;
            // 
            // lenghtInput
            // 
            this.lenghtInput.Location = new System.Drawing.Point(167, 89);
            this.lenghtInput.Name = "lenghtInput";
            this.lenghtInput.Size = new System.Drawing.Size(141, 22);
            this.lenghtInput.TabIndex = 4;
            // 
            // addPackageButton
            // 
            this.addPackageButton.AutoSize = true;
            this.addPackageButton.Location = new System.Drawing.Point(131, 211);
            this.addPackageButton.Name = "addPackageButton";
            this.addPackageButton.Size = new System.Drawing.Size(102, 28);
            this.addPackageButton.TabIndex = 3;
            this.addPackageButton.Text = "Add Package";
            this.addPackageButton.UseVisualStyleBackColor = true;
            this.addPackageButton.Click += new System.EventHandler(this.addPackageButton_Click);
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(33, 149);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(53, 17);
            this.heightLabel.TabIndex = 2;
            this.heightLabel.Text = "Height:";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(30, 121);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(48, 17);
            this.widthLabel.TabIndex = 1;
            this.widthLabel.Text = "Width:";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(30, 92);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(56, 17);
            this.lengthLabel.TabIndex = 0;
            this.lengthLabel.Text = "Length:";
            // 
            // origenLabel
            // 
            this.origenLabel.AutoSize = true;
            this.origenLabel.Location = new System.Drawing.Point(30, 34);
            this.origenLabel.Name = "origenLabel";
            this.origenLabel.Size = new System.Drawing.Size(79, 17);
            this.origenLabel.TabIndex = 7;
            this.origenLabel.Text = "Origen Zip:";
            // 
            // destinationLabel
            // 
            this.destinationLabel.AutoSize = true;
            this.destinationLabel.Location = new System.Drawing.Point(30, 63);
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Size = new System.Drawing.Size(107, 17);
            this.destinationLabel.TabIndex = 8;
            this.destinationLabel.Text = "Destination Zip:";
            // 
            // origenInput
            // 
            this.origenInput.Location = new System.Drawing.Point(167, 31);
            this.origenInput.Name = "origenInput";
            this.origenInput.Size = new System.Drawing.Size(141, 22);
            this.origenInput.TabIndex = 9;
            // 
            // destinationInput
            // 
            this.destinationInput.Location = new System.Drawing.Point(167, 60);
            this.destinationInput.Name = "destinationInput";
            this.destinationInput.Size = new System.Drawing.Size(141, 22);
            this.destinationInput.TabIndex = 10;
            // 
            // costGroupBox
            // 
            this.costGroupBox.Controls.Add(this.sendFromUofLButton);
            this.costGroupBox.Controls.Add(this.sendToUofLButton);
            this.costGroupBox.Controls.Add(this.detailsButton);
            this.costGroupBox.Controls.Add(this.costListBox);
            this.costGroupBox.Location = new System.Drawing.Point(401, 12);
            this.costGroupBox.Name = "costGroupBox";
            this.costGroupBox.Size = new System.Drawing.Size(392, 245);
            this.costGroupBox.TabIndex = 1;
            this.costGroupBox.TabStop = false;
            this.costGroupBox.Text = "Cost";
            // 
            // costListBox
            // 
            this.costListBox.FormattingEnabled = true;
            this.costListBox.ItemHeight = 16;
            this.costListBox.Location = new System.Drawing.Point(6, 21);
            this.costListBox.Name = "costListBox";
            this.costListBox.Size = new System.Drawing.Size(380, 148);
            this.costListBox.TabIndex = 0;
            // 
            // detailsButton
            // 
            this.detailsButton.Location = new System.Drawing.Point(14, 189);
            this.detailsButton.Name = "detailsButton";
            this.detailsButton.Size = new System.Drawing.Size(117, 27);
            this.detailsButton.TabIndex = 1;
            this.detailsButton.Text = "Details";
            this.detailsButton.UseVisualStyleBackColor = true;
            this.detailsButton.Click += new System.EventHandler(this.detailsButton_Click);
            // 
            // sendToUofLButton
            // 
            this.sendToUofLButton.AutoSize = true;
            this.sendToUofLButton.Location = new System.Drawing.Point(137, 190);
            this.sendToUofLButton.Name = "sendToUofLButton";
            this.sendToUofLButton.Size = new System.Drawing.Size(117, 27);
            this.sendToUofLButton.TabIndex = 2;
            this.sendToUofLButton.Text = "Send to UofL";
            this.sendToUofLButton.UseVisualStyleBackColor = true;
            this.sendToUofLButton.Click += new System.EventHandler(this.sendToUofLButton_Click);
            // 
            // sendFromUofLButton
            // 
            this.sendFromUofLButton.AutoSize = true;
            this.sendFromUofLButton.Location = new System.Drawing.Point(260, 189);
            this.sendFromUofLButton.Name = "sendFromUofLButton";
            this.sendFromUofLButton.Size = new System.Drawing.Size(117, 27);
            this.sendFromUofLButton.TabIndex = 3;
            this.sendFromUofLButton.Text = "Send from UofL";
            this.sendFromUofLButton.UseVisualStyleBackColor = true;
            this.sendFromUofLButton.Click += new System.EventHandler(this.sendFromUofLButton_Click);
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(30, 178);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(56, 17);
            this.weightLabel.TabIndex = 11;
            this.weightLabel.Text = "Weight:";
            // 
            // weightInput
            // 
            this.weightInput.Location = new System.Drawing.Point(167, 175);
            this.weightInput.Name = "weightInput";
            this.weightInput.Size = new System.Drawing.Size(141, 22);
            this.weightInput.TabIndex = 12;
            // 
            // program4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 269);
            this.Controls.Add(this.costGroupBox);
            this.Controls.Add(this.addPackageGroupBox);
            this.Name = "program4";
            this.Text = "Program 4";
            this.addPackageGroupBox.ResumeLayout(false);
            this.addPackageGroupBox.PerformLayout();
            this.costGroupBox.ResumeLayout(false);
            this.costGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox addPackageGroupBox;
        private System.Windows.Forms.TextBox heightInput;
        private System.Windows.Forms.TextBox widthInput;
        private System.Windows.Forms.TextBox lenghtInput;
        private System.Windows.Forms.Button addPackageButton;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.TextBox destinationInput;
        private System.Windows.Forms.TextBox origenInput;
        private System.Windows.Forms.Label destinationLabel;
        private System.Windows.Forms.Label origenLabel;
        private System.Windows.Forms.GroupBox costGroupBox;
        private System.Windows.Forms.Button sendFromUofLButton;
        private System.Windows.Forms.Button sendToUofLButton;
        private System.Windows.Forms.Button detailsButton;
        private System.Windows.Forms.ListBox costListBox;
        private System.Windows.Forms.TextBox weightInput;
        private System.Windows.Forms.Label weightLabel;
    }
}

