namespace AlfonsoLeone15002679
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
            this.countriesListBox = new System.Windows.Forms.ListBox();
            this.tradingPartnersListBox = new System.Windows.Forms.ListBox();
            this.countriesLabel = new System.Windows.Forms.Label();
            this.tradingPartnersLabel = new System.Windows.Forms.Label();
            this.gdpGrowthLabel = new System.Windows.Forms.Label();
            this.inflationLabel = new System.Windows.Forms.Label();
            this.tradeBalanceLabel = new System.Windows.Forms.Label();
            this.hdiRankingLabel = new System.Windows.Forms.Label();
            this.gdpGrowthTextField = new System.Windows.Forms.TextBox();
            this.inflationTextField = new System.Windows.Forms.TextBox();
            this.tradeBalanceTextField = new System.Windows.Forms.TextBox();
            this.hdiRankingTextField = new System.Windows.Forms.TextBox();
            this.saveDetailsButton = new System.Windows.Forms.Button();
            this.addCountryButton = new System.Windows.Forms.Button();
            this.deleteCountryButton = new System.Windows.Forms.Button();
            this.addPartnerButton = new System.Windows.Forms.Button();
            this.deletePartnerButton = new System.Windows.Forms.Button();
            this.addCountryTextField = new System.Windows.Forms.TextBox();
            this.addPartnerTextField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.depthLabel = new System.Windows.Forms.Label();
            this.NoCountriesLabel = new System.Windows.Forms.Label();
            this.searchCountryLabel = new System.Windows.Forms.Label();
            this.searchCountryTextField = new System.Windows.Forms.TextBox();
            this.partnersComboBox = new System.Windows.Forms.ComboBox();
            this.tradingWithLabel = new System.Windows.Forms.Label();
            this.bestTraderButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // countriesListBox
            // 
            this.countriesListBox.FormattingEnabled = true;
            this.countriesListBox.ItemHeight = 25;
            this.countriesListBox.Location = new System.Drawing.Point(73, 191);
            this.countriesListBox.Name = "countriesListBox";
            this.countriesListBox.Size = new System.Drawing.Size(396, 479);
            this.countriesListBox.TabIndex = 0;
            this.countriesListBox.SelectedIndexChanged += new System.EventHandler(this.countriesListBox_SelectedIndexChanged);
            // 
            // tradingPartnersListBox
            // 
            this.tradingPartnersListBox.FormattingEnabled = true;
            this.tradingPartnersListBox.ItemHeight = 25;
            this.tradingPartnersListBox.Location = new System.Drawing.Point(529, 191);
            this.tradingPartnersListBox.Name = "tradingPartnersListBox";
            this.tradingPartnersListBox.Size = new System.Drawing.Size(416, 479);
            this.tradingPartnersListBox.TabIndex = 1;
            // 
            // countriesLabel
            // 
            this.countriesLabel.AutoSize = true;
            this.countriesLabel.Location = new System.Drawing.Point(68, 160);
            this.countriesLabel.Name = "countriesLabel";
            this.countriesLabel.Size = new System.Drawing.Size(104, 25);
            this.countriesLabel.TabIndex = 2;
            this.countriesLabel.Text = "Countries";
            // 
            // tradingPartnersLabel
            // 
            this.tradingPartnersLabel.AutoSize = true;
            this.tradingPartnersLabel.Location = new System.Drawing.Point(524, 160);
            this.tradingPartnersLabel.Name = "tradingPartnersLabel";
            this.tradingPartnersLabel.Size = new System.Drawing.Size(172, 25);
            this.tradingPartnersLabel.TabIndex = 3;
            this.tradingPartnersLabel.Text = "Trading Partners";
            // 
            // gdpGrowthLabel
            // 
            this.gdpGrowthLabel.AutoSize = true;
            this.gdpGrowthLabel.Location = new System.Drawing.Point(1029, 274);
            this.gdpGrowthLabel.Name = "gdpGrowthLabel";
            this.gdpGrowthLabel.Size = new System.Drawing.Size(131, 25);
            this.gdpGrowthLabel.TabIndex = 4;
            this.gdpGrowthLabel.Text = "GDP Growth";
            // 
            // inflationLabel
            // 
            this.inflationLabel.AutoSize = true;
            this.inflationLabel.Location = new System.Drawing.Point(1029, 354);
            this.inflationLabel.Name = "inflationLabel";
            this.inflationLabel.Size = new System.Drawing.Size(87, 25);
            this.inflationLabel.TabIndex = 5;
            this.inflationLabel.Text = "Inflation";
            // 
            // tradeBalanceLabel
            // 
            this.tradeBalanceLabel.AutoSize = true;
            this.tradeBalanceLabel.Location = new System.Drawing.Point(1029, 448);
            this.tradeBalanceLabel.Name = "tradeBalanceLabel";
            this.tradeBalanceLabel.Size = new System.Drawing.Size(152, 25);
            this.tradeBalanceLabel.TabIndex = 6;
            this.tradeBalanceLabel.Text = "Trade Balance";
            // 
            // hdiRankingLabel
            // 
            this.hdiRankingLabel.AutoSize = true;
            this.hdiRankingLabel.Location = new System.Drawing.Point(1029, 534);
            this.hdiRankingLabel.Name = "hdiRankingLabel";
            this.hdiRankingLabel.Size = new System.Drawing.Size(132, 25);
            this.hdiRankingLabel.TabIndex = 7;
            this.hdiRankingLabel.Text = "HDI Ranking";
            // 
            // gdpGrowthTextField
            // 
            this.gdpGrowthTextField.Location = new System.Drawing.Point(1187, 268);
            this.gdpGrowthTextField.Name = "gdpGrowthTextField";
            this.gdpGrowthTextField.Size = new System.Drawing.Size(118, 31);
            this.gdpGrowthTextField.TabIndex = 8;
            // 
            // inflationTextField
            // 
            this.inflationTextField.Location = new System.Drawing.Point(1187, 354);
            this.inflationTextField.Name = "inflationTextField";
            this.inflationTextField.Size = new System.Drawing.Size(118, 31);
            this.inflationTextField.TabIndex = 9;
            // 
            // tradeBalanceTextField
            // 
            this.tradeBalanceTextField.Location = new System.Drawing.Point(1187, 442);
            this.tradeBalanceTextField.Name = "tradeBalanceTextField";
            this.tradeBalanceTextField.Size = new System.Drawing.Size(118, 31);
            this.tradeBalanceTextField.TabIndex = 10;
            // 
            // hdiRankingTextField
            // 
            this.hdiRankingTextField.Location = new System.Drawing.Point(1187, 534);
            this.hdiRankingTextField.Name = "hdiRankingTextField";
            this.hdiRankingTextField.Size = new System.Drawing.Size(118, 31);
            this.hdiRankingTextField.TabIndex = 11;
            // 
            // saveDetailsButton
            // 
            this.saveDetailsButton.Location = new System.Drawing.Point(1097, 611);
            this.saveDetailsButton.Name = "saveDetailsButton";
            this.saveDetailsButton.Size = new System.Drawing.Size(165, 59);
            this.saveDetailsButton.TabIndex = 12;
            this.saveDetailsButton.Text = "Save Details";
            this.saveDetailsButton.UseVisualStyleBackColor = true;
            this.saveDetailsButton.Click += new System.EventHandler(this.saveDetailsButton_Click);
            // 
            // addCountryButton
            // 
            this.addCountryButton.Location = new System.Drawing.Point(73, 717);
            this.addCountryButton.Name = "addCountryButton";
            this.addCountryButton.Size = new System.Drawing.Size(173, 59);
            this.addCountryButton.TabIndex = 13;
            this.addCountryButton.Text = "Add Country";
            this.addCountryButton.UseVisualStyleBackColor = true;
            this.addCountryButton.Click += new System.EventHandler(this.addCountryButton_Click);
            // 
            // deleteCountryButton
            // 
            this.deleteCountryButton.Location = new System.Drawing.Point(73, 795);
            this.deleteCountryButton.Name = "deleteCountryButton";
            this.deleteCountryButton.Size = new System.Drawing.Size(173, 59);
            this.deleteCountryButton.TabIndex = 14;
            this.deleteCountryButton.Text = "Delete Country";
            this.deleteCountryButton.UseVisualStyleBackColor = true;
            this.deleteCountryButton.Click += new System.EventHandler(this.deleteCountryButton_Click);
            // 
            // addPartnerButton
            // 
            this.addPartnerButton.Location = new System.Drawing.Point(529, 717);
            this.addPartnerButton.Name = "addPartnerButton";
            this.addPartnerButton.Size = new System.Drawing.Size(195, 59);
            this.addPartnerButton.TabIndex = 15;
            this.addPartnerButton.Text = "Add Partner";
            this.addPartnerButton.UseVisualStyleBackColor = true;
            this.addPartnerButton.Click += new System.EventHandler(this.addPartnerButton_Click);
            // 
            // deletePartnerButton
            // 
            this.deletePartnerButton.Location = new System.Drawing.Point(529, 795);
            this.deletePartnerButton.Name = "deletePartnerButton";
            this.deletePartnerButton.Size = new System.Drawing.Size(195, 59);
            this.deletePartnerButton.TabIndex = 16;
            this.deletePartnerButton.Text = "Delete Partner";
            this.deletePartnerButton.UseVisualStyleBackColor = true;
            this.deletePartnerButton.Click += new System.EventHandler(this.deletePartnerButton_Click);
            // 
            // addCountryTextField
            // 
            this.addCountryTextField.Location = new System.Drawing.Point(269, 731);
            this.addCountryTextField.Name = "addCountryTextField";
            this.addCountryTextField.Size = new System.Drawing.Size(200, 31);
            this.addCountryTextField.TabIndex = 17;
            // 
            // addPartnerTextField
            // 
            this.addPartnerTextField.Location = new System.Drawing.Point(763, 731);
            this.addPartnerTextField.Name = "addPartnerTextField";
            this.addPartnerTextField.Size = new System.Drawing.Size(182, 31);
            this.addPartnerTextField.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(552, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Depth:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(762, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "No of Countries:";
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.Location = new System.Drawing.Point(633, 23);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(24, 25);
            this.depthLabel.TabIndex = 21;
            this.depthLabel.Text = "0";
            // 
            // NoCountriesLabel
            // 
            this.NoCountriesLabel.AutoSize = true;
            this.NoCountriesLabel.Location = new System.Drawing.Point(935, 23);
            this.NoCountriesLabel.Name = "NoCountriesLabel";
            this.NoCountriesLabel.Size = new System.Drawing.Size(24, 25);
            this.NoCountriesLabel.TabIndex = 22;
            this.NoCountriesLabel.Text = "0";
            // 
            // searchCountryLabel
            // 
            this.searchCountryLabel.AutoSize = true;
            this.searchCountryLabel.Location = new System.Drawing.Point(72, 101);
            this.searchCountryLabel.Name = "searchCountryLabel";
            this.searchCountryLabel.Size = new System.Drawing.Size(161, 25);
            this.searchCountryLabel.TabIndex = 23;
            this.searchCountryLabel.Text = "Search Country";
            // 
            // searchCountryTextField
            // 
            this.searchCountryTextField.Location = new System.Drawing.Point(252, 98);
            this.searchCountryTextField.Name = "searchCountryTextField";
            this.searchCountryTextField.Size = new System.Drawing.Size(172, 31);
            this.searchCountryTextField.TabIndex = 24;
            this.searchCountryTextField.TextChanged += new System.EventHandler(this.searchCountryTextField_TextChanged);
            // 
            // partnersComboBox
            // 
            this.partnersComboBox.FormattingEnabled = true;
            this.partnersComboBox.Location = new System.Drawing.Point(693, 98);
            this.partnersComboBox.Name = "partnersComboBox";
            this.partnersComboBox.Size = new System.Drawing.Size(163, 33);
            this.partnersComboBox.TabIndex = 25;
            this.partnersComboBox.Text = "countries...";
            this.partnersComboBox.SelectedIndexChanged += new System.EventHandler(this.partnersComboBox_SelectedIndexChanged);
            // 
            // tradingWithLabel
            // 
            this.tradingWithLabel.AutoSize = true;
            this.tradingWithLabel.Location = new System.Drawing.Point(527, 101);
            this.tradingWithLabel.Name = "tradingWithLabel";
            this.tradingWithLabel.Size = new System.Drawing.Size(135, 25);
            this.tradingWithLabel.TabIndex = 26;
            this.tradingWithLabel.Text = "Trading with:";
            // 
            // bestTraderButton
            // 
            this.bestTraderButton.Location = new System.Drawing.Point(1034, 98);
            this.bestTraderButton.Name = "bestTraderButton";
            this.bestTraderButton.Size = new System.Drawing.Size(224, 85);
            this.bestTraderButton.TabIndex = 27;
            this.bestTraderButton.Text = "Calculate biggest potential for trade";
            this.bestTraderButton.UseVisualStyleBackColor = true;
            this.bestTraderButton.Click += new System.EventHandler(this.bestTraderButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(73, 877);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 88);
            this.button1.TabIndex = 28;
            this.button1.Text = "Modify name of selected country";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(303, 909);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 31);
            this.textBox1.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1502, 1023);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bestTraderButton);
            this.Controls.Add(this.tradingWithLabel);
            this.Controls.Add(this.partnersComboBox);
            this.Controls.Add(this.searchCountryTextField);
            this.Controls.Add(this.searchCountryLabel);
            this.Controls.Add(this.NoCountriesLabel);
            this.Controls.Add(this.depthLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addPartnerTextField);
            this.Controls.Add(this.addCountryTextField);
            this.Controls.Add(this.deletePartnerButton);
            this.Controls.Add(this.addPartnerButton);
            this.Controls.Add(this.deleteCountryButton);
            this.Controls.Add(this.addCountryButton);
            this.Controls.Add(this.saveDetailsButton);
            this.Controls.Add(this.hdiRankingTextField);
            this.Controls.Add(this.tradeBalanceTextField);
            this.Controls.Add(this.inflationTextField);
            this.Controls.Add(this.gdpGrowthTextField);
            this.Controls.Add(this.hdiRankingLabel);
            this.Controls.Add(this.tradeBalanceLabel);
            this.Controls.Add(this.inflationLabel);
            this.Controls.Add(this.gdpGrowthLabel);
            this.Controls.Add(this.tradingPartnersLabel);
            this.Controls.Add(this.countriesLabel);
            this.Controls.Add(this.tradingPartnersListBox);
            this.Controls.Add(this.countriesListBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "International Trading Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox countriesListBox;
        private System.Windows.Forms.ListBox tradingPartnersListBox;
        private System.Windows.Forms.Label countriesLabel;
        private System.Windows.Forms.Label tradingPartnersLabel;
        private System.Windows.Forms.Label gdpGrowthLabel;
        private System.Windows.Forms.Label inflationLabel;
        private System.Windows.Forms.Label tradeBalanceLabel;
        private System.Windows.Forms.Label hdiRankingLabel;
        private System.Windows.Forms.TextBox gdpGrowthTextField;
        private System.Windows.Forms.TextBox inflationTextField;
        private System.Windows.Forms.TextBox tradeBalanceTextField;
        private System.Windows.Forms.TextBox hdiRankingTextField;
        private System.Windows.Forms.Button saveDetailsButton;
        private System.Windows.Forms.Button addCountryButton;
        private System.Windows.Forms.Button deleteCountryButton;
        private System.Windows.Forms.Button addPartnerButton;
        private System.Windows.Forms.Button deletePartnerButton;
        private System.Windows.Forms.TextBox addCountryTextField;
        private System.Windows.Forms.TextBox addPartnerTextField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.Label NoCountriesLabel;
        private System.Windows.Forms.Label searchCountryLabel;
        private System.Windows.Forms.TextBox searchCountryTextField;
        private System.Windows.Forms.ComboBox partnersComboBox;
        private System.Windows.Forms.Label tradingWithLabel;
        private System.Windows.Forms.Button bestTraderButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

