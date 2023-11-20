using System;
using System.Collections.Generic;

namespace BankAccountManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> accounts = new List<Account>();

            while (true)
            {
                Console.WriteLine("Welcome to the Bank Account Management System!");
                Console.WriteLine("1. Create New Account");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter your name: ");
                        string name = Console.ReadLine();
                        Console.Write("Set a password: ");
                        string password = Console.ReadLine();
                        Console.Write("Enter the initial balance: ");
                        double initialBalance = Convert.ToDouble(Console.ReadLine());
                        Account newAccount = new Account(name, password, initialBalance);
                        accounts.Add(newAccount);
                        Console.WriteLine("Account created successfully!");
                        Console.WriteLine("Your account number is: " + newAccount.AccountNumber);
                        break;

                    case 2:
                        Console.Write("Enter your account number: ");
                        string accountNumber = Console.ReadLine();
                        Console.Write("Enter your password: ");
                        string loginPassword = Console.ReadLine();
                        Account loggedInAccount = accounts.Find(account => account.AccountNumber == accountNumber && account.Password == loginPassword);
                        if (loggedInAccount != null)
                        {
                            Console.WriteLine("Login successful!");
                            Console.WriteLine("Welcome, " + loggedInAccount.Name + "!");
                            PerformAccountOperations(loggedInAccount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid account number or password. Please try again.");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Thank you for using the Bank Account Management System. Goodbye!");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void PerformAccountOperations(Account account)
        {
            while (true)
            {
                Console.WriteLine("Account Operations:");
                Console.WriteLine("1. Withdraw");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("4. Logout");
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the amount to withdraw: ");
                        double amountToWithdraw = Convert.ToDouble(Console.ReadLine());
                        account.Withdraw(amountToWithdraw);
                        Console.WriteLine("Withdrawal successful. Current balance: " + account.Balance);
                        break;

                    case 2:
                        Console.Write("Enter the amount to deposit: ");
                        double amountToDeposit = Convert.ToDouble(Console.ReadLine());
                        account.Deposit(amountToDeposit);
                        Console.WriteLine("Deposit successful. Current balance: " + account.Balance);
                        break;

                    case 3:
                        Console.WriteLine("Current balance: " + account.Balance);
                        break;

                    case 4:
                        Console.WriteLine("Logout successful. Goodbye, " + account.Name + "!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }

    class Account
    {
        private static int accountCount = 0;

        public string AccountNumber { get; }
        public string Name { get; }
        public string Password { get; }
        public double Balance { get; private set; }

        public Account(string name, string password, double initialBalance)
        {
            AccountNumber = GenerateAccountNumber();
            Name = name;
            Password = password;
            Balance = initialBalance;
        }

        private string GenerateAccountNumber()
        {
            accountCount++;
            return "ACC" + accountCount.ToString().PadLeft(4, '0');
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount. Please try again.");
            }
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
            }
            else
            {
                Console.WriteLine("Invalid deposit amount. Please try again.");
            }
        }
    }
}
