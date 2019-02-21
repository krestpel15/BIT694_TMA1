/*
 *  Livestock Tool - Utilities class
 *  
 *  Utility that reads and creates an array of 20 Livestocks.
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
using System.IO;

namespace BIT694_TMA1
{
    public static class Utilities
    {
        public static Livestock[] LivestockList(String fileLocation, int fileLines)
        {
            Livestock[] allLivestock = new Livestock[20]; //creates an array of 20 lines
            int counter = 0; //an array pointer
            String myLine; //a line pointer
            String[] words; //a string to use to split the words

            try
            {
                TextReader tr = new StreamReader("C:/Users/krest/Desktop/C# Projects/BIT694_TMA1/livestock.txt");

                while ((myLine = tr.ReadLine()) != null)
                { 
                    words = myLine.Split(',');

                    int ID = int.Parse(words[0]);
                    String LivestockType = words[1];
                    int YearBorn = int.Parse(words[2]);
                    double CostPerMonth = double.Parse(words[3]);
                    double CostOfVaccination = double.Parse(words[4]);
                    double AmountMilk = double.Parse(words[5]);

                    //see what Livestock type it is and add to appropriate array
                    if (words[1].Equals("cow"))
                    {
                        Cow c = new Cow(ID, LivestockType, YearBorn, CostPerMonth, CostOfVaccination, AmountMilk);
                        allLivestock[counter] = c;
                    }
                    else
                    {
                        Goat g = new Goat(ID, LivestockType, YearBorn, CostPerMonth, CostOfVaccination, AmountMilk);
                        allLivestock[counter] = g;
                    }
                    

                    counter++;
                }
            }
            //if the file is not found or invalid it will display
            catch (FileNotFoundException e)
            {
                Console.WriteLine("LiveStock file is invalid!");
                Console.WriteLine();
                Console.WriteLine(e.Message);
            }
            return allLivestock;
        }

    }
}
