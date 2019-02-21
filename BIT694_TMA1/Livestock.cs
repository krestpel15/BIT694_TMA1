/*
 *  Livestock Tool - Livestock class
 *  
 *  Class that instantiate Livestock with methods displayInfo
 *  and the Setter and Getters to access attributes.
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
    public class Livestock
    {
        private int ID; //the livestock id
        private String LivestockType; //livestock type either cow or goat
        private int YearBorn; //year livestock was born
        private double CostPerMonth; //cost per month
        private double CostOfVaccination; //cost of vaccination in a year
        private double AmountMilk; //amount of milk in liters per day

        public Livestock(int ID, String LivestockType, int YearBorn, double CostPerMonth, double CostOfVaccination, double AmountMilk)
        {
            this.ID = ID;
            this.LivestockType = LivestockType;
            this.YearBorn = YearBorn;
            this.CostPerMonth = CostPerMonth;
            this.CostOfVaccination = CostOfVaccination;
            this.AmountMilk = AmountMilk;
        }

        public virtual void displayInfo()
        {
            Console.WriteLine(LivestockType);
            Console.WriteLine("ID: " + ID);
            Console.WriteLine("Year: " + YearBorn);
            Console.WriteLine("Maintenance Cost: $" + CostPerMonth);
            Console.WriteLine("Vaccination Cost: $" + CostOfVaccination);
            Console.WriteLine("Milk per Day: " + AmountMilk + " Liters");
        }

        //Setters and Getters to access the attributes of the Livestock object

        public virtual int accessID
        {
            get { return this.ID; }
            set { this.ID = value; }
        }

        public virtual String accessLivestockType
        {
            get { return this.LivestockType; }
            set { this.LivestockType = value; }
        }

        public virtual int accessYearBorn
        {
            get { return this.YearBorn; }
            set { this.YearBorn = value; }
        }

        public virtual double accessCostPerMonth
        {
            get { return this.CostPerMonth; }
            set { this.CostPerMonth = value; }
        }

        public virtual double accessCostOfVaccination
        {
            get { return this.CostOfVaccination; }
            set { this.CostOfVaccination = value; }
        }

        public virtual double accessAmountMilk
        {
            get { return this.AmountMilk; }
            set { this.AmountMilk = value; }
        }


    }
}
