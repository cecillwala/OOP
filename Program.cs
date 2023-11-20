using System;
using System.IO;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your income in Ksh: ");
        double income = Convert.ToDouble(Console.ReadLine());

        double tax = CalculatePAYE(income);

        Console.WriteLine("Your PAYE tax is: " + tax.ToString("C", CultureInfo.CreateSpecificCulture("en-KE")));

        // Generate PAYE Certificate or Report
        GeneratePAYECertificateOnDesktop(income, tax);
    }

    static double CalculatePAYE(double income)
    {
        double tax = 0;

        if (income <= 24000)
        {
            tax = income * 0.1;
        }
        else if (income <= 40000)
        {
            tax = 2400 + (income - 24000) * 0.15;
        }
        else if (income <= 60000)
        {
            tax = 4800 + (income - 40000) * 0.2;
        }
        else if (income <= 100000)
        {
            tax = 8800 + (income - 60000) * 0.25;
        }
        else if (income <= 150000)
        {
            tax = 18800 + (income - 100000) * 0.3;
        }
        else if (income <= 250000)
        {
            tax = 38800 + (income - 150000) * 0.35;
        }
        else
        {
            tax = 78800 + (income - 250000) * 0.4;
        }

        return tax;
    }

    static void GeneratePAYECertificateOnDesktop(double income, double tax)
    {
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string certificatePath = Path.Combine(desktopPath, "PAYECertificate.txt");

        string certificate = $"PAYE Certificate\n\nIncome: {income:C}\nPAYE Tax: {tax:C}\n\nThank you for your contribution to taxes.";

        // Save the certificate to the desktop
        File.WriteAllText(certificatePath, certificate);

        Console.WriteLine($"PAYE Certificate generated and saved to {certificatePath}");
    }
}
