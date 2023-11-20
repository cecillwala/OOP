using System;
using System.Diagnostics;

class CurrencyConverter
{
    static void Main()
    {
        Console.WriteLine("Currency Converter");

        // Exchange rates
        double kesToUsdRate = 151.80;
        double kesToEurRate = 161.92;
        double kesToGbpRate = 185.61;
        double kesToYenRate = 1.00;
        double kesToYuanRate = 20.81;
        double kesToIrpRate = 1.82;
        double kesToBtcRate = 5568282.06;
        double kesToWldRate = 227.7;
        double kesToChfRate = 167.95;
        double kesToRubRate = 1.65;
        double kesToNokRate = 13.56;
        double kesToZarRate = 8.11;
        double kesToUgx = 24.84;
        double kesToTzs = 16.47;
        double kesToRwf = 8.12;

        // Get user input
        
        {
        
            Console.WriteLine("1.Enter amount in KES: ");
            double kesAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Currencies available are USD, EUR, GBP, YEN, YUAN, IRP, BTC, WLD, CHF, RUB, ZAR, NOK, UGX, TZS,RWF");
            Console.WriteLine("2.Enter target currency:");
            String targetcurrency = Console.ReadLine();


            // Convert to other currencies
            double usdAmount = kesAmount / kesToUsdRate;
            double eurAmount = kesAmount / kesToEurRate;
            double gbpAmount = kesAmount / kesToGbpRate;
            double yenAmount = kesAmount / kesToYenRate;
            double yuanAmount = kesAmount / kesToYuanRate;
            double irpAmount = kesAmount / kesToIrpRate;
            double btcAmount = kesAmount / kesToBtcRate;
            double wldAmount = kesAmount / kesToWldRate;
            double chfAmount = kesAmount / kesToChfRate;
            double rubAmount = kesAmount / kesToRubRate;
            double zarAmount = kesAmount / kesToZarRate;
            double nokAmount = kesAmount / kesToNokRate;
            double ugxAmount = kesAmount * kesToUgx;
            double tzsAmount = kesAmount * kesToTzs;
            double rwfAmount = kesAmount * kesToRwf;



            // Display results

            switch (targetcurrency)
            {
                case "USD":
                    Console.WriteLine($"Amount in USD: {usdAmount}");
                    break;
                case "EUR":
                    Console.WriteLine($"Amount in EUR: {eurAmount}");
                    break;
                case "GBP":
                    Console.WriteLine($"Amount in GBP: {gbpAmount}");
                    break;
                case "YEN":
                    Console.WriteLine($"Amount in YEN: {yenAmount}");
                    break;
                case "YUAN":
                    Console.WriteLine($"Amount in YUAN: {yuanAmount}");
                    break;
                case "IRP":
                    Console.WriteLine($"Amount in IRP: {irpAmount}");
                    break;
                case "BTC":
                    Console.WriteLine($"Amount in BTC: {btcAmount}");
                    break;
                case "WLD":
                    Console.WriteLine($"Amount in WLD: {wldAmount}");
                    break;
                case "CHF":
                    Console.WriteLine($"Amount in CHF: {chfAmount}");
                    break;
                case "RUB":
                    Console.WriteLine($"Amount in RUB: {rubAmount}");
                    break;
                case "ZAR":
                    Console.WriteLine($"Amount in ZAR: {zarAmount}");
                    break;
                case "NOK":
                    Console.WriteLine($"Amount in NOK: {nokAmount}");
                    break;
                case "UGX":
                    Console.WriteLine($"Amount in UGX:{ugxAmount}");
                    break;
                case "TZS":
                    Console.WriteLine($"Amount in TZS:{tzsAmount}");
                    break;
                case "RWF":
                    Console.WriteLine($"Amount in RWF:{rwfAmount}");
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }

        }
    }
}
