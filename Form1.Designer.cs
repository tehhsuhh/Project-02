namespace Tessa_Biava_Project02
{
    partial class Form1
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
            this.specialtyListBox = new System.Windows.Forms.ListBox();
            this.baseGroupBox = new System.Windows.Forms.GroupBox();
            this.proteinGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.whiteRiceRadioButton = new System.Windows.Forms.RadioButton();
            this.greensRadioButton = new System.Windows.Forms.RadioButton();
            this.brownRiceRadioButton = new System.Windows.Forms.RadioButton();
            this.spicyTunaCheckBox = new System.Windows.Forms.CheckBox();
            this.crabCheckBox = new System.Windows.Forms.CheckBox();
            this.scallopsCheckBox = new System.Windows.Forms.CheckBox();
            this.ahiCheckBox = new System.Windows.Forms.CheckBox();
            this.tempuraCheckBox = new System.Windows.Forms.CheckBox();
            this.yellowtailCheckBox = new System.Windows.Forms.CheckBox();
            this.spicyCrabCheckBox = new System.Windows.Forms.CheckBox();
            this.specialtyApplyButton = new System.Windows.Forms.Button();
            this.applyProteinButton = new System.Windows.Forms.Button();
            this.yourBowlLabel = new System.Windows.Forms.Label();
            this.baseLabel = new System.Windows.Forms.Label();
            this.proteinLabel = new System.Windows.Forms.Label();
            this.baseGroupBox.SuspendLayout();
            this.proteinGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // specialtyListBox
            // 
            this.specialtyListBox.FormattingEnabled = true;
            this.specialtyListBox.Items.AddRange(new object[] {
            "Small Poke Bowl",
            "Medium Poke Bowl",
            "Large Poke Bowl",
            "Sushi Burrito"});
            this.specialtyListBox.Location = new System.Drawing.Point(37, 27);
            this.specialtyListBox.Name = "specialtyListBox";
            this.specialtyListBox.Size = new System.Drawing.Size(106, 69);
            this.specialtyListBox.TabIndex = 0;
            // 
            // baseGroupBox
            // 
            this.baseGroupBox.Controls.Add(this.brownRiceRadioButton);
            this.baseGroupBox.Controls.Add(this.greensRadioButton);
            this.baseGroupBox.Controls.Add(this.whiteRiceRadioButton);
            this.baseGroupBox.Location = new System.Drawing.Point(37, 102);
            this.baseGroupBox.Name = "baseGroupBox";
            this.baseGroupBox.Size = new System.Drawing.Size(83, 73);
            this.baseGroupBox.TabIndex = 1;
            this.baseGroupBox.TabStop = false;
            this.baseGroupBox.Text = "Choose Your Base:";
            // 
            // proteinGroupBox
            // 
            this.proteinGroupBox.Controls.Add(this.spicyCrabCheckBox);
            this.proteinGroupBox.Controls.Add(this.yellowtailCheckBox);
            this.proteinGroupBox.Controls.Add(this.tempuraCheckBox);
            this.proteinGroupBox.Controls.Add(this.ahiCheckBox);
            this.proteinGroupBox.Controls.Add(this.scallopsCheckBox);
            this.proteinGroupBox.Controls.Add(this.crabCheckBox);
            this.proteinGroupBox.Controls.Add(this.spicyTunaCheckBox);
            this.proteinGroupBox.Location = new System.Drawing.Point(37, 181);
            this.proteinGroupBox.Name = "proteinGroupBox";
            this.proteinGroupBox.Size = new System.Drawing.Size(187, 98);
            this.proteinGroupBox.TabIndex = 2;
            this.proteinGroupBox.TabStop = false;
            this.proteinGroupBox.Text = "Choose Your Protein:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.proteinLabel);
            this.groupBox1.Controls.Add(this.baseLabel);
            this.groupBox1.Controls.Add(this.yourBowlLabel);
            this.groupBox1.Location = new System.Drawing.Point(235, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 184);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // whiteRiceRadioButton
            // 
            this.whiteRiceRadioButton.AutoSize = true;
            this.whiteRiceRadioButton.Location = new System.Drawing.Point(3, 16);
            this.whiteRiceRadioButton.Name = "whiteRiceRadioButton";
            this.whiteRiceRadioButton.Size = new System.Drawing.Size(78, 17);
            this.whiteRiceRadioButton.TabIndex = 0;
            this.whiteRiceRadioButton.TabStop = true;
            this.whiteRiceRadioButton.Text = "White Rice";
            this.whiteRiceRadioButton.UseVisualStyleBackColor = true;
            this.whiteRiceRadioButton.CheckedChanged += new System.EventHandler(this.WhiteRiceRadioButton_CheckedChanged);
            // 
            // greensRadioButton
            // 
            this.greensRadioButton.AutoSize = true;
            this.greensRadioButton.Location = new System.Drawing.Point(3, 34);
            this.greensRadioButton.Name = "greensRadioButton";
            this.greensRadioButton.Size = new System.Drawing.Size(59, 17);
            this.greensRadioButton.TabIndex = 1;
            this.greensRadioButton.TabStop = true;
            this.greensRadioButton.Text = "Greens";
            this.greensRadioButton.UseVisualStyleBackColor = true;
            this.greensRadioButton.CheckedChanged += new System.EventHandler(this.GreensRadioButton_CheckedChanged);
            // 
            // brownRiceRadioButton
            // 
            this.brownRiceRadioButton.AutoSize = true;
            this.brownRiceRadioButton.Location = new System.Drawing.Point(3, 52);
            this.brownRiceRadioButton.Name = "brownRiceRadioButton";
            this.brownRiceRadioButton.Size = new System.Drawing.Size(80, 17);
            this.brownRiceRadioButton.TabIndex = 2;
            this.brownRiceRadioButton.TabStop = true;
            this.brownRiceRadioButton.Text = "Brown Rice";
            this.brownRiceRadioButton.UseVisualStyleBackColor = true;
            this.brownRiceRadioButton.CheckedChanged += new System.EventHandler(this.BrownRiceRadioButton_CheckedChanged);
            // 
            // spicyTunaCheckBox
            // 
            this.spicyTunaCheckBox.AutoSize = true;
            this.spicyTunaCheckBox.Location = new System.Drawing.Point(3, 19);
            this.spicyTunaCheckBox.Name = "spicyTunaCheckBox";
            this.spicyTunaCheckBox.Size = new System.Drawing.Size(80, 17);
            this.spicyTunaCheckBox.TabIndex = 3;
            this.spicyTunaCheckBox.Text = "Spicy Tuna";
            this.spicyTunaCheckBox.UseVisualStyleBackColor = true;
            // 
            // crabCheckBox
            // 
            this.crabCheckBox.AutoSize = true;
            this.crabCheckBox.Location = new System.Drawing.Point(3, 36);
            this.crabCheckBox.Name = "crabCheckBox";
            this.crabCheckBox.Size = new System.Drawing.Size(48, 17);
            this.crabCheckBox.TabIndex = 4;
            this.crabCheckBox.Text = "Crab";
            this.crabCheckBox.UseVisualStyleBackColor = true;
            // 
            // scallopsCheckBox
            // 
            this.scallopsCheckBox.AutoSize = true;
            this.scallopsCheckBox.Location = new System.Drawing.Point(3, 53);
            this.scallopsCheckBox.Name = "scallopsCheckBox";
            this.scallopsCheckBox.Size = new System.Drawing.Size(66, 17);
            this.scallopsCheckBox.TabIndex = 5;
            this.scallopsCheckBox.Text = "Scallops";
            this.scallopsCheckBox.UseVisualStyleBackColor = true;
            // 
            // ahiCheckBox
            // 
            this.ahiCheckBox.AutoSize = true;
            this.ahiCheckBox.Location = new System.Drawing.Point(3, 70);
            this.ahiCheckBox.Name = "ahiCheckBox";
            this.ahiCheckBox.Size = new System.Drawing.Size(41, 17);
            this.ahiCheckBox.TabIndex = 6;
            this.ahiCheckBox.Text = "Ahi";
            this.ahiCheckBox.UseVisualStyleBackColor = true;
            // 
            // tempuraCheckBox
            // 
            this.tempuraCheckBox.AutoSize = true;
            this.tempuraCheckBox.Location = new System.Drawing.Point(89, 20);
            this.tempuraCheckBox.Name = "tempuraCheckBox";
            this.tempuraCheckBox.Size = new System.Drawing.Size(103, 17);
            this.tempuraCheckBox.TabIndex = 7;
            this.tempuraCheckBox.Text = "Tempura Shrimp";
            this.tempuraCheckBox.UseVisualStyleBackColor = true;
            // 
            // yellowtailCheckBox
            // 
            this.yellowtailCheckBox.AutoSize = true;
            this.yellowtailCheckBox.Location = new System.Drawing.Point(89, 37);
            this.yellowtailCheckBox.Name = "yellowtailCheckBox";
            this.yellowtailCheckBox.Size = new System.Drawing.Size(70, 17);
            this.yellowtailCheckBox.TabIndex = 8;
            this.yellowtailCheckBox.Text = "Yellowtail";
            this.yellowtailCheckBox.UseVisualStyleBackColor = true;
            // 
            // spicyCrabCheckBox
            // 
            this.spicyCrabCheckBox.AutoSize = true;
            this.spicyCrabCheckBox.Location = new System.Drawing.Point(89, 54);
            this.spicyCrabCheckBox.Name = "spicyCrabCheckBox";
            this.spicyCrabCheckBox.Size = new System.Drawing.Size(77, 17);
            this.spicyCrabCheckBox.TabIndex = 9;
            this.spicyCrabCheckBox.Text = "Spicy Crab";
            this.spicyCrabCheckBox.UseVisualStyleBackColor = true;
            // 
            // specialtyApplyButton
            // 
            this.specialtyApplyButton.Location = new System.Drawing.Point(149, 50);
            this.specialtyApplyButton.Name = "specialtyApplyButton";
            this.specialtyApplyButton.Size = new System.Drawing.Size(75, 23);
            this.specialtyApplyButton.TabIndex = 0;
            this.specialtyApplyButton.Text = "Apply";
            this.specialtyApplyButton.UseVisualStyleBackColor = true;
            this.specialtyApplyButton.Click += new System.EventHandler(this.SpecialtyApplyButton_Click);
            // 
            // applyProteinButton
            // 
            this.applyProteinButton.Location = new System.Drawing.Point(37, 285);
            this.applyProteinButton.Name = "applyProteinButton";
            this.applyProteinButton.Size = new System.Drawing.Size(83, 23);
            this.applyProteinButton.TabIndex = 3;
            this.applyProteinButton.Text = "Apply Protein";
            this.applyProteinButton.UseVisualStyleBackColor = true;
            this.applyProteinButton.Click += new System.EventHandler(this.ApplyProteinButton_Click);
            // 
            // yourBowlLabel
            // 
            this.yourBowlLabel.AutoSize = true;
            this.yourBowlLabel.Location = new System.Drawing.Point(6, 16);
            this.yourBowlLabel.Name = "yourBowlLabel";
            this.yourBowlLabel.Size = new System.Drawing.Size(58, 13);
            this.yourBowlLabel.TabIndex = 4;
            this.yourBowlLabel.Text = "Your Bowl:";
            // 
            // baseLabel
            // 
            this.baseLabel.AutoSize = true;
            this.baseLabel.Location = new System.Drawing.Point(19, 32);
            this.baseLabel.Name = "baseLabel";
            this.baseLabel.Size = new System.Drawing.Size(0, 13);
            this.baseLabel.TabIndex = 5;
            // 
            // proteinLabel
            // 
            this.proteinLabel.AutoSize = true;
            this.proteinLabel.Location = new System.Drawing.Point(19, 49);
            this.proteinLabel.Name = "proteinLabel";
            this.proteinLabel.Size = new System.Drawing.Size(0, 13);
            this.proteinLabel.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 347);
            this.Controls.Add(this.applyProteinButton);
            this.Controls.Add(this.specialtyApplyButton);
            this.Controls.Add(this.proteinGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.baseGroupBox);
            this.Controls.Add(this.specialtyListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.baseGroupBox.ResumeLayout(false);
            this.baseGroupBox.PerformLayout();
            this.proteinGroupBox.ResumeLayout(false);
            this.proteinGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox specialtyListBox;
        private System.Windows.Forms.GroupBox baseGroupBox;
        private System.Windows.Forms.RadioButton brownRiceRadioButton;
        private System.Windows.Forms.RadioButton greensRadioButton;
        private System.Windows.Forms.RadioButton whiteRiceRadioButton;
        private System.Windows.Forms.GroupBox proteinGroupBox;
        private System.Windows.Forms.CheckBox spicyCrabCheckBox;
        private System.Windows.Forms.CheckBox yellowtailCheckBox;
        private System.Windows.Forms.CheckBox tempuraCheckBox;
        private System.Windows.Forms.CheckBox ahiCheckBox;
        private System.Windows.Forms.CheckBox scallopsCheckBox;
        private System.Windows.Forms.CheckBox crabCheckBox;
        private System.Windows.Forms.CheckBox spicyTunaCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label proteinLabel;
        private System.Windows.Forms.Label baseLabel;
        private System.Windows.Forms.Label yourBowlLabel;
        private System.Windows.Forms.Button specialtyApplyButton;
        private System.Windows.Forms.Button applyProteinButton;
    }
}

