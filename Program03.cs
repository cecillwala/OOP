using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace waterbillcalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"-----------------------------------------------
 Welcome to the Monthly Water Bill Calculator!
-----------------------------------------------");
            bool isRunning = true;
            while (isRunning)
            {
                try
                {
                    Console.WriteLine();
                    // Input water consumption
                    Console.Write("Please enter the water consumption in m^3: ");
                    double waterConsumption = double.Parse(Console.ReadLine());

                    // Input usage type
                    Console.WriteLine("Please enter the usage type:");
                    Console.WriteLine("1. Residential.");
                    Console.WriteLine("2. Commercial.");
                    Console.WriteLine("3. Industrial.");
                    Console.Write("Select choice: ");
                    int usageType = int.Parse(Console.ReadLine());
                    string usage = "residential";
                    double Rate = 0;

                    // Determine rate based on usage type
                    if (usageType == 1)
                    {
                        Rate = 12.50;
                        usage = "residential";
                    }
                    else if (usageType == 2)
                    {
                        Rate = 15.75;
                        usage = "commercial";
                    }
                    else if (usageType == 3)
                    {
                        Rate = 18.90;
                        usage = "industrial";
                    }

                    // Calculate total bill and display breakdown
                    double totalBill = waterConsumption * Rate;
                    Console.WriteLine($"Breakdown for {usage} usage:");
                    Console.WriteLine($"Water Consumption: {waterConsumption} m^3");
                    Console.WriteLine($"Rate: {Rate} KES/m^3");
                    Console.WriteLine($"Total Bill: {totalBill} KES");
                    Console.Write("Press enter to exit.");
                }
                catch
                {
                    Console.WriteLine("Wrong input. Try again");
                    continue;
                }
                Console.ReadKey();
                
            }
        }
    }

