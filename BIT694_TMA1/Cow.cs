/*
 *  Livestock Tool - Cow class
 *  
 *  Is inherited from the Livestock Class.
 * 
 *  Made by Kresta Pelayo
 *  27/11/2017
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT694_TMA1
{
    class Cow : Livestock
    {
        //instantiate a Cow object
        public Cow(int ID, String LivestockType, int YearBorn, double CostPerMonth, double CostOfVaccination, double AmountMilk) : base(ID, LivestockType, YearBorn, CostPerMonth, CostOfVaccination, AmountMilk)  {}

        //overrides method displayInfo
        public override void displayInfo()
        {
            base.displayInfo();
        }

        //overrides method accessID
        public override int accessID { get => base.accessID; set => base.accessID = value; }

        //overrides accessLivestockType
        public override string accessLivestockType { get => base.accessLivestockType; set => base.accessLivestockType = value; }

        //overrides accessYearBorn
        public override int accessYearBorn { get => base.accessYearBorn; set => base.accessYearBorn = value; }

        //overrides method accessAmountMilk
        public override double accessAmountMilk { get => base.accessAmountMilk; set => base.accessAmountMilk = value; }

        //overrides method accessCostOfVaccination
        public override double accessCostOfVaccination { get => base.accessCostOfVaccination; set => base.accessCostOfVaccination = value; }

        //overrides method accessCostPerMonth
        public override double accessCostPerMonth { get => base.accessCostPerMonth; set => base.accessCostPerMonth = value; }


        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
    
}
