using System;

namespace PowerBillCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Monthly Power Bill Calculator!");

            // Input power consumption
            double powerConsumption;
            Console.WriteLine("Please enter the power consumption in kWh:");
            if (!double.TryParse(Console.ReadLine(), out powerConsumption) || powerConsumption < 0)
            {
                Console.WriteLine("Invalid input for power consumption. Please enter a valid positive number.");
                return;
            }

            // Input usage type
            Console.WriteLine("Please enter the usage type (residential, commercial, or industrial):");
            string usageType = Console.ReadLine().ToLower();

            double tariffRate = 0;

            // Determine tariff rate based on usage type
            switch (usageType)
            {
                case "residential":
                    tariffRate = 12.50;
                    break;
                case "commercial":
                    tariffRate = 15.75;
                    break;
                case "industrial":
                    tariffRate = 18.90;
                    break;
                default:
                    Console.WriteLine("Invalid usage type entered. Please enter residential, commercial, or industrial.");
                    return;
            }

            // Calculate total bill and display breakdown
            double totalBill = powerConsumption * tariffRate;

            Console.WriteLine($"Breakdown for {usageType} usage:");
            Console.WriteLine($"Power Consumption: {powerConsumption} kWh");
            Console.WriteLine($"Tariff Rate: {tariffRate} KES/kWh");
            Console.WriteLine($"Total Bill: {totalBill} KES");
        }
    }
}
