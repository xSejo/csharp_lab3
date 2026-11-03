/*
  Name: Joseph Perez
  Student Number: 000977171
  Date: November 01 2026
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
    /// Represents the main form of the Perfect Cut Hair Salon application.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Initializes a new instance of the Form1 class.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the listServices control to enable the add service button.
        /// </summary>
        private void listServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listServices.SelectedIndex != -1)
            {
                addServiceButton.Enabled = true;
            }
        }

        /// <summary>
        /// Adds the selected hairdresser and services to the receipt list boxes and updates UI state.
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
                listChargedItems.Items.Add(hairdresser);

                string[] hairdresserParts = hairdresser.Split('$');
                listPrices.Items.Add(hairdresserParts[1]);

                hairdresserComboBox.Enabled = false;
                calculateButton.Enabled = true;
            }

            foreach (var item in listServices.SelectedItems)
            {
                string service = item.ToString();
                listChargedItems.Items.Add(service);

                string[] serviceParts = service.Split('$');
                listPrices.Items.Add(serviceParts[1]);
            }

            listServices.ClearSelected();
            addServiceButton.Enabled = false;
        }

        /// <summary>
        /// Calculates the total cost of all items in the prices list box and formats it as currency.
        /// </summary>
        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal total = 0m;

            foreach (var item in listPrices.Items)
            {
                total += decimal.Parse(item.ToString());
            }

            totalPriceLabel.Text = $"{total:C}";
        }

        /// <summary>
        /// Resets the form back to its default startup state.
        /// </summary>
        private void resetButton_Click(object sender, EventArgs e)
        {
            hairdresserComboBox.SelectedIndex = 0;

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
        /// Exits the application.
        /// </summary>
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the listChargedItems control.
        /// </summary>
        private void listChargedItems_SelectedIndexChanged(object sender, EventArgs e) { }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the listPrices control.
        /// </summary>
        private void listPrices_SelectedIndexChanged(object sender, EventArgs e) { }

        /// <summary>
        /// Handles the Click event of the totalPriceLabel control.
        /// </summary>
        private void totalPriceLabel_Click(object sender, EventArgs e) { }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the hairdresserComboBox control.
        /// </summary>
        private void hairdresserComboBox_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}