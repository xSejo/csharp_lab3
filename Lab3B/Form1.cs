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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hairdresserComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listServices_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listChargedItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listPrices_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void totalPriceLabel_Click(object sender, EventArgs e)
        {

        }

        private void addServiceButton_Click(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {

        }

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

        private void exitButton_Click(object sender, EventArgs e)
        {

        }
    }
}
