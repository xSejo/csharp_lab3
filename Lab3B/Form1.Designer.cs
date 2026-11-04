namespace Lab3B
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
            this.hairdresserComboBox = new System.Windows.Forms.ComboBox();
            this.listServices = new System.Windows.Forms.ListBox();
            this.listChargedItems = new System.Windows.Forms.ListBox();
            this.listPrices = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addServiceButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hairdresserComboBox
            // 
            this.hairdresserComboBox.FormattingEnabled = true;
            this.hairdresserComboBox.Items.AddRange(new object[] {
            "Jane Samley",
            "",
            "Pat Johnson",
            "",
            "Ron Chambers",
            "",
            "Sue Pallon",
            "",
            "Laurie Renkins"});
            this.hairdresserComboBox.Location = new System.Drawing.Point(41, 56);
            this.hairdresserComboBox.Name = "hairdresserComboBox";
            this.hairdresserComboBox.Size = new System.Drawing.Size(165, 21);
            this.hairdresserComboBox.TabIndex = 0;
            this.hairdresserComboBox.SelectedIndexChanged += new System.EventHandler(this.hairdresserComboBox_SelectedIndexChanged);
            // 
            // listServices
            // 
            this.listServices.FormattingEnabled = true;
            this.listServices.Items.AddRange(new object[] {
            "Cut",
            "Wash, blow-dry, and style",
            "Colour",
            "Highlights",
            "Extensions",
            "Up-do"});
            this.listServices.Location = new System.Drawing.Point(235, 56);
            this.listServices.Name = "listServices";
            this.listServices.Size = new System.Drawing.Size(182, 199);
            this.listServices.TabIndex = 1;
            this.listServices.SelectedIndexChanged += new System.EventHandler(this.listServices_SelectedIndexChanged);
            // 
            // listChargedItems
            // 
            this.listChargedItems.FormattingEnabled = true;
            this.listChargedItems.Location = new System.Drawing.Point(446, 56);
            this.listChargedItems.Name = "listChargedItems";
            this.listChargedItems.Size = new System.Drawing.Size(182, 199);
            this.listChargedItems.TabIndex = 2;
            this.listChargedItems.SelectedIndexChanged += new System.EventHandler(this.listChargedItems_SelectedIndexChanged);
            // 
            // listPrices
            // 
            this.listPrices.FormattingEnabled = true;
            this.listPrices.Location = new System.Drawing.Point(659, 56);
            this.listPrices.Name = "listPrices";
            this.listPrices.Size = new System.Drawing.Size(182, 199);
            this.listPrices.TabIndex = 3;
            this.listPrices.SelectedIndexChanged += new System.EventHandler(this.listPrices_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(37, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select a Hairdresser:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(231, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select a Service:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(442, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Charged Items:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(655, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Price:";
            // 
            // addServiceButton
            // 
            this.addServiceButton.Enabled = false;
            this.addServiceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addServiceButton.Location = new System.Drawing.Point(287, 420);
            this.addServiceButton.Name = "addServiceButton";
            this.addServiceButton.Size = new System.Drawing.Size(100, 45);
            this.addServiceButton.TabIndex = 8;
            this.addServiceButton.Text = "Add Service";
            this.addServiceButton.UseVisualStyleBackColor = true;
            this.addServiceButton.Click += new System.EventHandler(this.addServiceButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Enabled = false;
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.calculateButton.Location = new System.Drawing.Point(411, 420);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(146, 45);
            this.calculateButton.TabIndex = 9;
            this.calculateButton.Text = "Calculate Total Price";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.resetButton.Location = new System.Drawing.Point(580, 420);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(113, 45);
            this.resetButton.TabIndex = 10;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.exitButton.Location = new System.Drawing.Point(713, 420);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(128, 45);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(652, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Total Price:";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.BackColor = System.Drawing.SystemColors.Window;
            this.totalPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalPriceLabel.Location = new System.Drawing.Point(741, 369);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(100, 23);
            this.totalPriceLabel.TabIndex = 13;
            this.totalPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.totalPriceLabel.Click += new System.EventHandler(this.totalPriceLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 495);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.addServiceButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listPrices);
            this.Controls.Add(this.listChargedItems);
            this.Controls.Add(this.listServices);
            this.Controls.Add(this.hairdresserComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox hairdresserComboBox;
        private System.Windows.Forms.ListBox listServices;
        private System.Windows.Forms.ListBox listChargedItems;
        private System.Windows.Forms.ListBox listPrices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addServiceButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label totalPriceLabel;
    }
}

