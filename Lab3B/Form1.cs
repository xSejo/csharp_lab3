/*
  Name: Joseph Perez
  Student Number: 000977171
  Date: November 01, 2026
  Purpose: A Windows Forms App that determines pricing for a hair salon.
  Statement of Authorship: I certify that this material is my original work. No other person's work has been used without due acknowledgement.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3B
{
    /// <summary>
    /// Main window for the Perfect Cut Hair Salon pricing calculator.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Sets up the form, selects the first hairdresser by default, and disables the action buttons until a service is picked.
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            if (hairdresserComboBox.Items.Count > 0)
            {
                hairdresserComboBox.SelectedIndex = 0;
            }

            addServiceButton.Enabled = false;
            calculateButton.Enabled = false;
        }

        /// <summary>
        /// Turns on the "Add Service" button as soon as the user clicks a service in the list.
        /// </summary>
        private void listServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listServices.SelectedIndex != -1)
            {
                addServiceButton.Enabled = true;
            }
            else
            {
                addServiceButton.Enabled = false;
            }
        }

        /// <summary>
        /// Adds the chosen hairdresser (on the first click) and any selected services to the receipt and price lists.
        /// </summary>
        private void addServiceButton_Click(object sender, EventArgs e)
        {
            if (hairdresserComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("Select a hairdresser first");
                return;
            }

            if (listChargedItems.Items.Count == 0)
            {
                string hairdresser = hairdresserComboBox.SelectedItem.ToString();
                decimal hairdresserRate = 0m;

                if (hairdresser.Contains("$"))
                {
                    string[] hairdresserParts = hairdresser.Split('$');
                    hairdresserRate = decimal.Parse(hairdresserParts[1]);
                }
                else
                {
                    switch (hairdresserComboBox.SelectedIndex)
                    {
                        case 0:
                            hairdresserRate = 30m;
                            break;
                        case 1:
                            hairdresserRate = 45m;
                            break;
                        case 2:
                            hairdresserRate = 40m;
                            break;
                        case 3:
                            hairdresserRate = 50m;
                            break;
                        case 4:
                            hairdresserRate = 55m;
                            break;
                    }
                }

                listChargedItems.Items.Add(hairdresser);
                listPrices.Items.Add($"{hairdresserRate:C}");

                hairdresserComboBox.Enabled = false;
                calculateButton.Enabled = true;
            }

            foreach (var item in listServices.SelectedItems)
            {
                string service = item.ToString();
                decimal serviceRate = 0m;

                if (service.Contains("$"))
                {
                    string[] serviceParts = service.Split('$');
                    serviceRate = decimal.Parse(serviceParts[1]);
                }
                else
                {
                    switch (service)
                    {
                        case "Cut":
                            serviceRate = 30m;
                            break;
                        case "Wash, blow-dry, and style":
                            serviceRate = 20m;
                            break;
                        case "Colour":
                            serviceRate = 40m;
                            break;
                        case "Highlights":
                            serviceRate = 50m;
                            break;
                        case "Extension":
                        case "Extensions":
                            serviceRate = 200m;
                            break;
                        case "Up-do":
                            serviceRate = 60m;
                            break;
                    }
                }

                listChargedItems.Items.Add(service);
                listPrices.Items.Add($"{serviceRate:C}");
            }

            listServices.ClearSelected();
            addServiceButton.Enabled = false;
        }

        /// <summary>
        /// Adds up all the prices in the Price list and displays the final total.
        /// </summary>
        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal total = 0m;

            foreach (var item in listPrices.Items)
            {
                string priceText = item.ToString().Replace("$", "");
                total += decimal.Parse(priceText);
            }

            totalPriceLabel.Text = $"{total:C}";
        }

        /// <summary>
        /// Clears the receipt lists and total price, and resets the form back to the beginning.
        /// </summary>
        private void resetButton_Click(object sender, EventArgs e)
        {
            if (hairdresserComboBox.Items.Count > 0)
            {
                hairdresserComboBox.SelectedIndex = 0;
            }

            listServices.ClearSelected();
            listChargedItems.Items.Clear();
            listPrices.Items.Clear();

            totalPriceLabel.Text = "";

            addServiceButton.Enabled = false;
            calculateButton.Enabled = false;
            hairdresserComboBox.Enabled = true;
            hairdresserComboBox.Focus();
        }

        /// <summary>
        /// Closes the program when the Exit button is clicked.
        /// </summary>
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Unused event handler for the Charged Items list box.
        /// </summary>
        private void listChargedItems_SelectedIndexChanged(object sender, EventArgs e) { }

        /// <summary>
        /// Unused event handler for the Prices list box.
        /// </summary>
        private void listPrices_SelectedIndexChanged(object sender, EventArgs e) { }

        /// <summary>
        /// Unused event handler for the Total Price label.
        /// </summary>
        private void totalPriceLabel_Click(object sender, EventArgs e) { }

        /// <summary>
        /// Unused event handler for the Hairdresser dropdown.
        /// </summary>
        private void hairdresserComboBox_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}