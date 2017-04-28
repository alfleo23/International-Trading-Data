using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlfonsoLeone15002679
{
    public class Country : IComparable
    {
        private string name;
        private float gdp_growth;
        private float inflation;
        private float tradeBalance;
        private float hdi_ranking;
        private List<string> trading_Partners;
        
        public Country()
        {      }

        public Country(string name)
        {
            List<string> emptyList = new List<string>();
            this.name = name;
            this.trading_Partners = emptyList;
        }

        public Country(string name, float gdpGrowth, float inflation, float tradeBalance, float hdiRanking, List<string> aList)
        {
            this.name = name;
            this.gdp_growth = gdpGrowth;
            this.inflation = inflation;
            this.tradeBalance = tradeBalance;
            this.hdi_ranking = hdiRanking;
            this.trading_Partners = aList;
        }

        public int CompareTo(object other)
        {
            Country temp = (Country)other;
            return name.CompareTo(temp.name);
        }

        public override string ToString()
        {
            if (trading_Partners != null)
            {
                string temp = string.Join(":", trading_Partners.ToArray());
                return name + "," + gdp_growth + "," + inflation + "," + tradeBalance + "," + hdi_ranking + "," + temp;
            }
            else 
                {
                    
                    return name + "," + gdp_growth + "," + inflation + "," + tradeBalance + "," + hdi_ranking ;
                }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public float GDP_growth
        {
            get { return gdp_growth; }
            set { gdp_growth = value; }
        }

        public float Inflation
        {
            get { return inflation; }
            set { inflation = value; }
        }

        public float TradeBalance
        {
            get { return tradeBalance; }
            set { tradeBalance = value; }
        }

        public float HDI_Ranking
        {
            get { return hdi_ranking; }
            set { hdi_ranking = value; }
        }

        public List<string> TradingPartners
        {
            get { return trading_Partners; }
            set { trading_Partners = value; }
        }

    }
   
}
