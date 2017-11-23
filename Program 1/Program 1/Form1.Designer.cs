namespace Program_1
{
    partial class program1
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
            this.wallSpaceLabel = new System.Windows.Forms.Label();
            this.numberOfCoatsLabel = new System.Windows.Forms.Label();
            this.priceOfPaintLabel = new System.Windows.Forms.Label();
            this.wallSpaceTextBox = new System.Windows.Forms.TextBox();
            this.numberOfCoatsTextBox = new System.Windows.Forms.TextBox();
            this.priceOfPaintTextBox = new System.Windows.Forms.TextBox();
            this.calculate = new System.Windows.Forms.Button();
            this.totalWallSpaceLabel = new System.Windows.Forms.Label();
            this.hoursOfLaborLabel = new System.Windows.Forms.Label();
            this.gallonsOfPaintNeededLabel = new System.Windows.Forms.Label();
            this.totalPriceOfPaintLabel = new System.Windows.Forms.Label();
            this.totalPriceOfLaborLabel = new System.Windows.Forms.Label();
            this.totalPriceOfJobLabel = new System.Windows.Forms.Label();
            this.totalWallSpaceOutPut = new System.Windows.Forms.Label();
            this.hoursOfLaborOutPut = new System.Windows.Forms.Label();
            this.gallonsOfPaintNeededOutPut = new System.Windows.Forms.Label();
            this.totalPriceOfPaintOutPut = new System.Windows.Forms.Label();
            this.totalPriceOfLaborOutPut = new System.Windows.Forms.Label();
            this.totalPriceOfJobOutPut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // wallSpaceLabel
            // 
            this.wallSpaceLabel.AutoSize = true;
            this.wallSpaceLabel.Location = new System.Drawing.Point(36, 39);
            this.wallSpaceLabel.Name = "wallSpaceLabel";
            this.wallSpaceLabel.Size = new System.Drawing.Size(139, 17);
            this.wallSpaceLabel.TabIndex = 0;
            this.wallSpaceLabel.Text = "Wall Space (in sq. ft)";
            // 
            // numberOfCoatsLabel
            // 
            this.numberOfCoatsLabel.AutoSize = true;
            this.numberOfCoatsLabel.Location = new System.Drawing.Point(36, 70);
            this.numberOfCoatsLabel.Name = "numberOfCoatsLabel";
            this.numberOfCoatsLabel.Size = new System.Drawing.Size(114, 17);
            this.numberOfCoatsLabel.TabIndex = 1;
            this.numberOfCoatsLabel.Text = "Number of Coats";
            // 
            // priceOfPaintLabel
            // 
            this.priceOfPaintLabel.AutoSize = true;
            this.priceOfPaintLabel.Location = new System.Drawing.Point(36, 98);
            this.priceOfPaintLabel.Name = "priceOfPaintLabel";
            this.priceOfPaintLabel.Size = new System.Drawing.Size(169, 17);
            this.priceOfPaintLabel.TabIndex = 2;
            this.priceOfPaintLabel.Text = "Price of Paint (per gallon)";
            // 
            // wallSpaceTextBox
            // 
            this.wallSpaceTextBox.Location = new System.Drawing.Point(241, 36);
            this.wallSpaceTextBox.Name = "wallSpaceTextBox";
            this.wallSpaceTextBox.Size = new System.Drawing.Size(100, 22);
            this.wallSpaceTextBox.TabIndex = 3;
            // 
            // numberOfCoatsTextBox
            // 
            this.numberOfCoatsTextBox.Location = new System.Drawing.Point(241, 67);
            this.numberOfCoatsTextBox.Name = "numberOfCoatsTextBox";
            this.numberOfCoatsTextBox.Size = new System.Drawing.Size(100, 22);
            this.numberOfCoatsTextBox.TabIndex = 4;
            // 
            // priceOfPaintTextBox
            // 
            this.priceOfPaintTextBox.Location = new System.Drawing.Point(241, 95);
            this.priceOfPaintTextBox.Name = "priceOfPaintTextBox";
            this.priceOfPaintTextBox.Size = new System.Drawing.Size(100, 22);
            this.priceOfPaintTextBox.TabIndex = 5;
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(141, 151);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(98, 28);
            this.calculate.TabIndex = 6;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // totalWallSpaceLabel
            // 
            this.totalWallSpaceLabel.AutoSize = true;
            this.totalWallSpaceLabel.Location = new System.Drawing.Point(36, 211);
            this.totalWallSpaceLabel.Name = "totalWallSpaceLabel";
            this.totalWallSpaceLabel.Size = new System.Drawing.Size(175, 17);
            this.totalWallSpaceLabel.TabIndex = 7;
            this.totalWallSpaceLabel.Text = "Total Wall Space (in sq. ft)";
            // 
            // hoursOfLaborLabel
            // 
            this.hoursOfLaborLabel.AutoSize = true;
            this.hoursOfLaborLabel.Location = new System.Drawing.Point(36, 239);
            this.hoursOfLaborLabel.Name = "hoursOfLaborLabel";
            this.hoursOfLaborLabel.Size = new System.Drawing.Size(103, 17);
            this.hoursOfLaborLabel.TabIndex = 8;
            this.hoursOfLaborLabel.Text = "Hours of Labor";
            // 
            // gallonsOfPaintNeededLabel
            // 
            this.gallonsOfPaintNeededLabel.AutoSize = true;
            this.gallonsOfPaintNeededLabel.Location = new System.Drawing.Point(36, 267);
            this.gallonsOfPaintNeededLabel.Name = "gallonsOfPaintNeededLabel";
            this.gallonsOfPaintNeededLabel.Size = new System.Drawing.Size(162, 17);
            this.gallonsOfPaintNeededLabel.TabIndex = 9;
            this.gallonsOfPaintNeededLabel.Text = "Gallons of Paint Needed";
            // 
            // totalPriceOfPaintLabel
            // 
            this.totalPriceOfPaintLabel.AutoSize = true;
            this.totalPriceOfPaintLabel.Location = new System.Drawing.Point(36, 295);
            this.totalPriceOfPaintLabel.Name = "totalPriceOfPaintLabel";
            this.totalPriceOfPaintLabel.Size = new System.Drawing.Size(128, 17);
            this.totalPriceOfPaintLabel.TabIndex = 10;
            this.totalPriceOfPaintLabel.Text = "Total Price of Paint";
            // 
            // totalPriceOfLaborLabel
            // 
            this.totalPriceOfLaborLabel.AutoSize = true;
            this.totalPriceOfLaborLabel.Location = new System.Drawing.Point(36, 325);
            this.totalPriceOfLaborLabel.Name = "totalPriceOfLaborLabel";
            this.totalPriceOfLaborLabel.Size = new System.Drawing.Size(133, 17);
            this.totalPriceOfLaborLabel.TabIndex = 11;
            this.totalPriceOfLaborLabel.Text = "Total Price of Labor";
            // 
            // totalPriceOfJobLabel
            // 
            this.totalPriceOfJobLabel.AutoSize = true;
            this.totalPriceOfJobLabel.Location = new System.Drawing.Point(36, 351);
            this.totalPriceOfJobLabel.Name = "totalPriceOfJobLabel";
            this.totalPriceOfJobLabel.Size = new System.Drawing.Size(119, 17);
            this.totalPriceOfJobLabel.TabIndex = 17;
            this.totalPriceOfJobLabel.Text = "Total Price of Job";
            // 
            // totalWallSpaceOutPut
            // 
            this.totalWallSpaceOutPut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalWallSpaceOutPut.Location = new System.Drawing.Point(241, 205);
            this.totalWallSpaceOutPut.Name = "totalWallSpaceOutPut";
            this.totalWallSpaceOutPut.Size = new System.Drawing.Size(100, 23);
            this.totalWallSpaceOutPut.TabIndex = 18;
            // 
            // hoursOfLaborOutPut
            // 
            this.hoursOfLaborOutPut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hoursOfLaborOutPut.Location = new System.Drawing.Point(241, 238);
            this.hoursOfLaborOutPut.Name = "hoursOfLaborOutPut";
            this.hoursOfLaborOutPut.Size = new System.Drawing.Size(100, 23);
            this.hoursOfLaborOutPut.TabIndex = 19;
            // 
            // gallonsOfPaintNeededOutPut
            // 
            this.gallonsOfPaintNeededOutPut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gallonsOfPaintNeededOutPut.Location = new System.Drawing.Point(241, 267);
            this.gallonsOfPaintNeededOutPut.Name = "gallonsOfPaintNeededOutPut";
            this.gallonsOfPaintNeededOutPut.Size = new System.Drawing.Size(100, 23);
            this.gallonsOfPaintNeededOutPut.TabIndex = 20;
            // 
            // totalPriceOfPaintOutPut
            // 
            this.totalPriceOfPaintOutPut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalPriceOfPaintOutPut.Location = new System.Drawing.Point(241, 295);
            this.totalPriceOfPaintOutPut.Name = "totalPriceOfPaintOutPut";
            this.totalPriceOfPaintOutPut.Size = new System.Drawing.Size(100, 23);
            this.totalPriceOfPaintOutPut.TabIndex = 21;
            // 
            // totalPriceOfLaborOutPut
            // 
            this.totalPriceOfLaborOutPut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalPriceOfLaborOutPut.Location = new System.Drawing.Point(241, 324);
            this.totalPriceOfLaborOutPut.Name = "totalPriceOfLaborOutPut";
            this.totalPriceOfLaborOutPut.Size = new System.Drawing.Size(100, 23);
            this.totalPriceOfLaborOutPut.TabIndex = 22;
            // 
            // totalPriceOfJobOutPut
            // 
            this.totalPriceOfJobOutPut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalPriceOfJobOutPut.Location = new System.Drawing.Point(241, 350);
            this.totalPriceOfJobOutPut.Name = "totalPriceOfJobOutPut";
            this.totalPriceOfJobOutPut.Size = new System.Drawing.Size(100, 23);
            this.totalPriceOfJobOutPut.TabIndex = 23;
            // 
            // program1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 388);
            this.Controls.Add(this.totalPriceOfJobOutPut);
            this.Controls.Add(this.totalPriceOfLaborOutPut);
            this.Controls.Add(this.totalPriceOfPaintOutPut);
            this.Controls.Add(this.gallonsOfPaintNeededOutPut);
            this.Controls.Add(this.hoursOfLaborOutPut);
            this.Controls.Add(this.totalWallSpaceOutPut);
            this.Controls.Add(this.totalPriceOfJobLabel);
            this.Controls.Add(this.totalPriceOfLaborLabel);
            this.Controls.Add(this.totalPriceOfPaintLabel);
            this.Controls.Add(this.gallonsOfPaintNeededLabel);
            this.Controls.Add(this.hoursOfLaborLabel);
            this.Controls.Add(this.totalWallSpaceLabel);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.priceOfPaintTextBox);
            this.Controls.Add(this.numberOfCoatsTextBox);
            this.Controls.Add(this.wallSpaceTextBox);
            this.Controls.Add(this.priceOfPaintLabel);
            this.Controls.Add(this.numberOfCoatsLabel);
            this.Controls.Add(this.wallSpaceLabel);
            this.Name = "program1";
            this.Text = "Program 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label wallSpaceLabel;
        private System.Windows.Forms.Label numberOfCoatsLabel;
        private System.Windows.Forms.Label priceOfPaintLabel;
        private System.Windows.Forms.TextBox wallSpaceTextBox;
        private System.Windows.Forms.TextBox numberOfCoatsTextBox;
        private System.Windows.Forms.TextBox priceOfPaintTextBox;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Label totalWallSpaceLabel;
        private System.Windows.Forms.Label hoursOfLaborLabel;
        private System.Windows.Forms.Label gallonsOfPaintNeededLabel;
        private System.Windows.Forms.Label totalPriceOfPaintLabel;
        private System.Windows.Forms.Label totalPriceOfLaborLabel;
        private System.Windows.Forms.Label totalPriceOfJobLabel;
        private System.Windows.Forms.Label totalWallSpaceOutPut;
        private System.Windows.Forms.Label hoursOfLaborOutPut;
        private System.Windows.Forms.Label gallonsOfPaintNeededOutPut;
        private System.Windows.Forms.Label totalPriceOfPaintOutPut;
        private System.Windows.Forms.Label totalPriceOfLaborOutPut;
        private System.Windows.Forms.Label totalPriceOfJobOutPut;
    }
}

