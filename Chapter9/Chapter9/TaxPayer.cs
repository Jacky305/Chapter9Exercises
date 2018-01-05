using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter9
{
    class TaxPayer: IComparable
    {
        private string socialNumber;
        public string SocialNumber { get { return socialNumber; } set { socialNumber = value; } }
        private double yearlyGrossIncome;
        public double YearlyGrossIncome { get { return yearlyGrossIncome; } set { yearlyGrossIncome = value; } }
        private int taxOwed;
        public int TaxOwed { get { return taxOwed; } }
        
        public TaxPayer() : this(1)
        {

        }
        public TaxPayer(double grossIncome)
        {
            this.YearlyGrossIncome = grossIncome;
            taxOwed = ComputeTax();
        }
        private int ComputeTax()
        {
            double tempTax;
            if (this.YearlyGrossIncome <30000)
            {
                tempTax = this.YearlyGrossIncome * 0.15;
            }
            else
            {
                tempTax = this.YearlyGrossIncome * 0.28;
            }
            
            return (int)tempTax;
        }

        int IComparable.CompareTo(object obj)
        {
            int returnVal;

            TaxPayer temp = (TaxPayer)obj;
            if (this.taxOwed > temp.taxOwed)
                returnVal = 1;
            else
                if (this.taxOwed < temp.taxOwed)
                    returnVal = -1;
                else
                    returnVal = 0;

            return returnVal;
        }
    }
}
