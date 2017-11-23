namespace Program_2
{
    partial class program2
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
            this.creditHoursEarnedLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.creditHoursEarnedInput = new System.Windows.Forms.TextBox();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // creditHoursEarnedLabel
            // 
            this.creditHoursEarnedLabel.Location = new System.Drawing.Point(12, 27);
            this.creditHoursEarnedLabel.Name = "creditHoursEarnedLabel";
            this.creditHoursEarnedLabel.Size = new System.Drawing.Size(137, 58);
            this.creditHoursEarnedLabel.TabIndex = 0;
            this.creditHoursEarnedLabel.Text = "Credit Hours Earned (If Graduate Student enter 0 [zero])";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 116);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(121, 17);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name (Last, First)";
            // 
            // creditHoursEarnedInput
            // 
            this.creditHoursEarnedInput.Location = new System.Drawing.Point(170, 45);
            this.creditHoursEarnedInput.Name = "creditHoursEarnedInput";
            this.creditHoursEarnedInput.Size = new System.Drawing.Size(100, 22);
            this.creditHoursEarnedInput.TabIndex = 2;
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(170, 113);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(100, 22);
            this.nameInput.TabIndex = 3;
            // 
            // calculateButton
            // 
            this.calculateButton.AutoSize = true;
            this.calculateButton.Location = new System.Drawing.Point(95, 187);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(76, 27);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculate_Click);
            // 
            // program2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.creditHoursEarnedInput);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.creditHoursEarnedLabel);
            this.Name = "program2";
            this.Text = "Program 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label creditHoursEarnedLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox creditHoursEarnedInput;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Button calculateButton;
    }
}

