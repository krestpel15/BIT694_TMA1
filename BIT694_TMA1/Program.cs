/*
 *  Livestock Tool - Main class
 *  
 *  Display menu ask for valid menu option. 
 *  Displays output in accordaance to option entered.
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
    class Program
    {
        const String fileLocation = "C:/Users/krest/Desktop/C#Projects/BIT694_TMA1/livestock.txt";
        const int fileLines = 20;
        const String titleLine = ("---------------Menu-------------");

        //displays the Menu option list
        static void DisplayFirstMenu()
        {
            String[] options = {        "Exit",
                                        "Display livestock information by ID ",
                                        "Display the cow that produced the most milk",
                                        "Display the goat that produced least amount of millk",
                                        "Calculate farm profit",
                                        "Display unprofitable livestock",
                };

            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine(i + ") " + options[i]);
            }
        }

        //asks to enter a menu option and check input for validity
        static int DisplayMenu()
        {
            Console.WriteLine();
            Console.Write("Enter an option: ");
            String key = Console.ReadLine();

            while (true)
            {
                if (int.TryParse(key, out int result))
                {
                    if (result >= 0 && result <= 5)
                    {
                        return result;
                    }

                    else
                    {

                        Console.WriteLine("Invalid option");
                        Console.Write("Enter an option: ");
                        key = Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid option");
                    Console.Write("Enter an option: ");
                    key = Console.ReadLine();
                }

            }
            return 0;
        }

        // Display Info of a Livestock by Id
        static void DisplayInfoByID(Livestock[] array)
        {
            Console.Write("Enter account ID: ");
            String id = Console.ReadLine();

            if (int.TryParse(id, out int result))
            {
                int livestockPos = -1;

                for (int i = 0; i < array.Length; i++)

                    if (array[i].accessID == result)
                    {
                        livestockPos = i;
                        array[i].displayInfo();
                    }

            }
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        //Displays the cow that produced most milk
        static void MostProducedCow(Livestock[] array)
        {
            Console.WriteLine("Cow with most milk produce: ");

            double max = array[0].accessAmountMilk;

            for (int i = 0; i < array.Length; i++)
                if (array[i].accessLivestockType.Equals("Cow"))
                {
                    if (array[i].accessAmountMilk >= max)
                    {
                        max = array[i].accessAmountMilk;

                    }
                }

            for (int i = 0; i < array.Length; i++)
                if (array[i].accessAmountMilk == max)
                {

                    array[i].displayInfo();
                }
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        //Displays the Goat that produced the least amount of milk
        static void LeastProducedGoat(Livestock[] array)
        {
            Console.WriteLine("Goat that produced least amount of milk: ");

            double min = array[0].accessAmountMilk;

            for (int i = 0; i < array.Length; i++)
                if (array[i].accessLivestockType.Equals("Goat"))
                {
                    if (array[i].accessAmountMilk <= min)
                    {
                        min = array[i].accessAmountMilk;
                    }
                }

            for (int i = 0; i < array.Length; i++)
                if (array[i].accessAmountMilk == min)
                {

                    array[i].displayInfo();
                }
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        //Displays the total profit of farm for a month
        static void TotalProfitability(Livestock[] array)
        {
            Console.WriteLine("Calculation of farm profit: ");
            Console.Write("Enter price of milk: ");
            double MilkPrice = 0;
            Boolean invalid = true;
            while (invalid)
            {
                try
                {
                    MilkPrice = double.Parse(Console.ReadLine());
                    if (MilkPrice < 0)
                    {
                        Console.WriteLine("Invalid input");
                        Console.Write("Enter price of milk: ");
                    }
                    else
                    {
                        invalid = false;
                    }
                }
                //display appropriate message if input is invalid
                catch (Exception e)
                {
                    Console.WriteLine("Invalid input");
                    Console.Write("Enter price of milk: ");
                }
            }

            double MilkPerMonth = 0;
            double totalCostPerMonth = 0;
            double CostOfVaccinationPerMonth = 0;
            double TotalProfit = 0;

            for (int i = 0; i < array.Length; i++)
            {
                totalCostPerMonth += array[i].accessCostPerMonth;
            }

            for (int i = 0; i < array.Length; i++)
            {
                CostOfVaccinationPerMonth += (array[i].accessCostOfVaccination / 12);
            }

            for (int i = 0; i < array.Length; i++)
            {
                MilkPerMonth += (array[i].accessAmountMilk * MilkPrice) * 30;
            }

            TotalProfit = Math.Round(MilkPerMonth - (totalCostPerMonth + CostOfVaccinationPerMonth), 2);
            Console.WriteLine("Farm Profit: $" + TotalProfit + " per Month");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }

        //Display the unprofitable livestocks
        static void UnprofitableLivestock(Livestock[] totalLiveStock)
        {
            Console.WriteLine("Livestock that are not profitable: ");
            Console.Write("Enter price of milk: ");
            double MilkPrice = 0;
            Boolean invalid = true;
            while (invalid)
            {
                try
                {
                    MilkPrice = double.Parse(Console.ReadLine());
                    if (MilkPrice < 0)
                    {
                        Console.WriteLine("Invalid input");
                        Console.Write("Enter price of milk: ");
                    }
                    else
                    {
                        invalid = false;
                    }
                }
                //display appropriate message if input is invalid
                catch (Exception e)
                {
                    Console.WriteLine("Invalid input");
                    Console.Write("Enter price of milk: ");
                }
            }



            Boolean noneFound = true;
            foreach (Livestock animal in totalLiveStock)
            {
                var a = animal.accessAmountMilk * MilkPrice * 30;
                var b = animal.accessCostPerMonth + (animal.accessCostOfVaccination / 12);

                //Equation below is to find out if the animal is profitable
                if ((animal.accessAmountMilk * MilkPrice * 31) <= (animal.accessCostPerMonth + (animal.accessCostOfVaccination / 12)))
                {
                    animal.displayInfo();
                    noneFound = false;
                }
            }
            if (noneFound)
            {
                Console.WriteLine("All Live Stock Profitable");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }

        public static void Main(string[] args)
        {
            Console.WriteLine(titleLine);
            Livestock[] allLivestock = Utilities.LivestockList(fileLocation, fileLines);

            DisplayFirstMenu();

            // Menu loop
            bool running = true;

            while (running)
            {
                int option = DisplayMenu();

                switch (option)
                {
                    case 0:
                        running = false;
                        break;
                    case 1:
                        DisplayInfoByID(allLivestock);
                        break;
                    case 2:
                        MostProducedCow(allLivestock);
                        break;
                    case 3:
                        LeastProducedGoat(allLivestock);
                        break;
                    case 4:
                        TotalProfitability(allLivestock);
                        break;
                    case 5:
                        UnprofitableLivestock(allLivestock);
                        break;

                }
            } // end of Menu loop
            Console.WriteLine();
            Console.WriteLine("End of program, press any key to continue ...");
            Console.ReadKey();
        }

    }
}
