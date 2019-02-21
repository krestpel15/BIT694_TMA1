/*
 *  Livestock Tool - Goat class
 *  
 *  A class inherited from Livestock Class
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
    class Goat : Livestock
    {
        //instantiate a Goat object
        public Goat(int ID, String LivestockType, int YearBorn, double CostPerMonth, double CostOfVaccination, double AmountMilk) : base(ID, LivestockType, YearBorn, CostPerMonth, CostOfVaccination, AmountMilk) { }

        //overrides method displayInfo 
        public override void displayInfo()
        {
            base.displayInfo();
        }

        //overrides method accessId
        public override int accessID { get => base.accessID; set => base.accessID = value; }

        //overrides method accessLivestockType
        public override string accessLivestockType { get => base.accessLivestockType; set => base.accessLivestockType = value; }

        //overrides method accessBorn
        public override int accessYearBorn { get => base.accessYearBorn; set => base.accessYearBorn = value; }
        
        //overrides method accessAmounMilk
        public override double accessAmountMilk { get => base.accessAmountMilk; set => base.accessAmountMilk = value; }

        //overrides method accessCostVaccination
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
