using System;

namespace seweragebillcalcultor
{
    class Sewerage
    {
        public static void Main(string[] args)
        {
            bool isRunning = true;
            while (isRunning)
            {
                try
                {
                    double charge = 0;
                    Console.WriteLine("Welcome to sewerage bill calculator");
                    Console.Write("Enter amount consumed:");
                    double consumption = Convert.ToDouble(Console.ReadLine());

                    // Input usage type
                    Console.WriteLine("Please enter the usage type(i.e 1, 2 or 3):");
                    Console.WriteLine("1. Residential.");
                    Console.WriteLine("2. Commercial.");
                    Console.WriteLine("3. Industrial.");

                    Console.Write("Select choice: ");
                    int usertype = int.Parse(Console.ReadLine());

                    switch (usertype)
                    {
                        case 1:
                            charge = consumption * 10.00;
                            Console.WriteLine("User Residential,your consumption is " + consumption + "\nRate per cubic meter is sh10.00");
                            Console.WriteLine("Amount you will pay: " + charge);
                            isRunning = false;
                            break;
                        case 2:
                            charge = consumption * 12.50;
                            Console.WriteLine("User Commercial,your consumption is " + consumption + "\nRate per cubic meter is sh12.50");
                            Console.WriteLine("Amount you will pay: " + charge);
                            isRunning = false;
                            break;
                        case 3:
                            charge = consumption * 15.00;
                            Console.WriteLine("User Industrial,your consumption is " + consumption + "\nRate per cubic meter is sh15.00");
                            Console.WriteLine("Amount you will pay: " + charge);
                            isRunning = false;
                            break;
                    }
                }
                catch 
                {
                    Console.WriteLine("Invalid input. Try again."); 
                }
                }
            Console.ReadKey();

        }
    }
}
