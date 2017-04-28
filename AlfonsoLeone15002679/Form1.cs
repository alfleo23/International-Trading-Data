using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace AlfonsoLeone15002679
{
    public partial class Form1 : Form
    {
        
        static string[] headers = new string[6]; //column headers
        AVLTree<Country> countryTree = new AVLTree<Country>();
        List<string> tradingPartners;
        List<Country> unfilteredList = new List<Country>();
        List<Country> filteredList = new List<Country>();       

        // displayed country on the form
        Country dispCountry = new Country();

        public Form1()
        {
            InitializeComponent();

            const int MAX_LINES_FILE = 50000;
            string[] AllLines = new string[MAX_LINES_FILE];

            //reads from bin/DEBUG subdirectory of project directory
            AllLines = File.ReadAllLines("countries.csv");
            foreach (string line in AllLines)
            {
                if (line.StartsWith("Country")) //found first line - headers
                {
                    headers = line.Split(',');
                }
                else
                {
                    tradingPartners = new List<string>();
                    //split data using commas
                    string[] columns = line.Split(',');
                    //System.Console.Write(columns[0] + ","); //first string in line;
                    //System.Console.Write(columns[1] + ","); //2nd string in line;

                    string[] partners = columns[5].Split(';', '[', ']');
                    foreach (string tradePartner in partners)
                    {
                        if (tradePartner != "")
                        {
                            //System.Console.Write(":" + tradePartner);
                            tradingPartners.Add(tradePartner);
                        }
                    }

                    countryTree.InsertItemAVL( new Country(columns[0], float.Parse(columns[1]), float.Parse(columns[2]), float.Parse(columns[3]), float.Parse(columns[4]), tradingPartners));
                }
            }
                      
            string test = "";  
            countryTree.InOrder(ref test);
            //Console.WriteLine(test);
            initializeForm();
         }

        private void initializeForm()
        {
            countryTree.InOrderList(ref unfilteredList);
            partnersComboBox.Items.AddRange(unfilteredList.Select(c => c.Name).ToArray());
            countriesListBox.DataSource = unfilteredList;
            countriesListBox.DisplayMember = "name";
            tradingPartnersListBox.DataSource = tradingPartners;       
        }

        private void countriesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dispCountry = (Country)countriesListBox.SelectedValue;

            if (String.IsNullOrEmpty(searchCountryTextField.Text) && partnersComboBox.SelectedIndex < 0) //check which list to use
            {

                countriesListBox.DataSource = unfilteredList;
            }
            else
            {
                countriesListBox.DataSource = null;
                countriesListBox.DataSource = filteredList;
            }
            
            countriesListBox.DisplayMember = "name";
            try
            {
                tradingPartnersListBox.DataSource = dispCountry.TradingPartners;
                gdpGrowthTextField.Text = dispCountry.GDP_growth.ToString();
                inflationTextField.Text = dispCountry.Inflation.ToString();
                tradeBalanceTextField.Text = dispCountry.TradeBalance.ToString();
                hdiRankingTextField.Text = dispCountry.HDI_Ranking.ToString();
            }
            catch (Exception ex)
            { }
            
            depthLabel.Text = Convert.ToString(countryTree.Height());
            NoCountriesLabel.Text = Convert.ToString(countryTree.Count());

        }

        private void saveDetailsButton_Click(object sender, EventArgs e)
        {
            dispCountry.GDP_growth = float.Parse(gdpGrowthTextField.Text);
            dispCountry.Inflation = float.Parse(inflationTextField.Text);
            dispCountry.TradeBalance = float.Parse(tradeBalanceTextField.Text);
            dispCountry.HDI_Ranking = float.Parse(hdiRankingTextField.Text);
        }

        private void addPartnerButton_Click(object sender, EventArgs e)
        {
            dispCountry.TradingPartners.Add(addPartnerTextField.Text.ToString());
            tradingPartnersListBox.DataSource = null;
            tradingPartnersListBox.DataSource = dispCountry.TradingPartners;
            addPartnerTextField.Text = "";
        }

        private void deletePartnerButton_Click(object sender, EventArgs e)
        {
            string countryToRemove = tradingPartnersListBox.SelectedValue.ToString();
            dispCountry.TradingPartners.Remove(countryToRemove);
            tradingPartnersListBox.DataSource = null;
            tradingPartnersListBox.DataSource = dispCountry.TradingPartners;
        }

        private void addCountryButton_Click(object sender, EventArgs e)
        {
            Country countryToAdd = new Country(addCountryTextField.Text.ToString());
            countryTree.InsertItemAVL(countryToAdd);
            depthLabel.Text = Convert.ToString(countryTree.Height());
            NoCountriesLabel.Text = Convert.ToString(countryTree.Count());
            countriesListBox.DataSource = null;
            unfilteredList.Clear();
            countryTree.InOrderList(ref unfilteredList);
            countriesListBox.DataSource = unfilteredList;
            countriesListBox.DisplayMember = "name";
            partnersComboBox.SelectedIndex = -1;
            searchCountryTextField.Text = "";
            addCountryTextField.Text = "";
        }

        private void searchCountryTextField_TextChanged(object sender, EventArgs e)
        {
            filteredList = new List<Country>();
            foreach (Country c in unfilteredList)
            {
                if (c.Name.ToLower().StartsWith(searchCountryTextField.Text.ToLower()))
                {
                    filteredList.Add(c);                  
                }
            }
            countriesListBox.DataSource = null;
            countriesListBox.DataSource = filteredList;
            countriesListBox.DisplayMember = "name";
        }

        private void partnersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            filteredList = new List<Country>();
            if (partnersComboBox.Focused)
            {
                string partnerToSearch = partnersComboBox.SelectedItem.ToString();
                foreach (Country c in unfilteredList)
                {
                    try
                    {
                        foreach (string s in c.TradingPartners)
                        {
                            if (s.ToLower() == partnerToSearch.ToLower())
                            { filteredList.Add(c); }
                        } 
                    }
                    catch (Exception ex)
                    { }
                              
            }
                countriesListBox.DataSource = null;
                countriesListBox.DataSource = filteredList;
                countriesListBox.DisplayMember = "name";
            }
            
        }

        private void bestTraderButton_Click(object sender, EventArgs e)
        {
            float tradePotential;
            float biggestPotential = 0;
            string nationToDisplay = "";

            foreach (Country c in unfilteredList)
            {
                tradePotential = 0;
                try
                {
                    foreach (string s in c.TradingPartners)
                    {
                        Country partner = unfilteredList.Find(country => country.Name == s);
                        tradePotential += partner.GDP_growth;
                    }
                    if (tradePotential > biggestPotential)
                    {
                        biggestPotential = tradePotential;
                        nationToDisplay = c.Name;
                    }
                }
                catch (Exception ex)
                { }
                
            }
            MessageBox.Show(nationToDisplay + " has the biggest potential for trade");
        }

        private void deleteCountryButton_Click(object sender, EventArgs e)
        {
            Country countryToRemove = (Country) countriesListBox.SelectedValue;
            countryTree.RemoveItemAVL(countryToRemove);
            depthLabel.Text = Convert.ToString(countryTree.Height());
            NoCountriesLabel.Text = Convert.ToString(countryTree.Count());
            countriesListBox.DataSource = null;
            unfilteredList.Clear();
            countryTree.InOrderList(ref unfilteredList);
            countriesListBox.DataSource = unfilteredList;
            countriesListBox.DisplayMember = "name";
            partnersComboBox.SelectedIndex = -1;
            searchCountryTextField.Text = "";
        }

    }  // end of form
}
