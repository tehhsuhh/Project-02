using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tessa_Biava_Project02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void WhiteRiceRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            baseLabel.Text = "White Rice with";
        }

        private void GreensRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            baseLabel.Text = "Greens with";
        }

        private void BrownRiceRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            baseLabel.Text = "Brown Rice with";
        }

        private void ApplyProteinButton_Click(object sender, EventArgs e)
        {
            //clear the label
            proteinLabel.Text = "";
        
        //search through check boxes to apply custom toppings
            if(spicyTunaCheckBox.Checked)
            {
                proteinLabel.Text += "Spicy Tuna \n";
            }
            if (crabCheckBox.Checked)
            {
                proteinLabel.Text += "Crab \n";
            }
            if (scallopsCheckBox.Checked)
            {
                proteinLabel.Text += "Scallops \n";
            }
            if (ahiCheckBox.Checked)
            {
                proteinLabel.Text += "Ahi Tuna \n";
            }
            if (tempuraCheckBox.Checked)
            {
                proteinLabel.Text += "Tempura Shrimp\n";
            }
            if (yellowtailCheckBox.Checked)
            {
                proteinLabel.Text += "Yellowtail \n";
            }
            if (spicyCrabCheckBox.Checked)
            {
                proteinLabel.Text += "Spicy Crab \n";
            }
        }

        private void SpecialtyApplyButton_Click(object sender, EventArgs e)
        {
            //clear the toppings label
            proteinLabel.Text = "";

            string specialty;

            //apply specialty toppings
            if (specialtyListBox.SelectedIndex != -1)
            {
                specialty = specialtyListBox.SelectedItem.ToString();

                switch (specialty)
                {
                    case "Small Poke Bowl":
                        proteinLabel.Text = "Small Poke Bowl.";
                        break;
                    case "Medium Poke Bowl":
                        proteinLabel.Text = "Medium Poke Bowl.";
                        break;
                    case "Large Poke Bowl":
                        proteinLabel.Text = "Large Poke Bowl.";
                        break;
                    case "Sushi Burrito":
                        proteinLabel.Text = "Adventurous Sushi Burrito!";
                        break;
                }
            }
        }
    }
}
