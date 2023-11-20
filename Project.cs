class Project
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number:");
            double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter a operator");
        String op = Console.ReadLine();

        Console.Write("Enter a number:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        if(op == "+")
        {
            Console.WriteLine(num1 + num2);
        }else if (op == "-")
        {
            Console.WriteLine(num1 - num2);
        }
        else if(op == "*")
        {
            Console.WriteLine(num1 * num2);
        }
        else if( op == "/")
        {
            if (num2 == 0)
                Console.WriteLine("Cannot divide by 0");
            if (num1 == 0)
                Console.WriteLine("o");
            else
            {
                Console.WriteLine(num1 / num2);
            }
        }
        else
        {
            Console.WriteLine("Invalid");
        }


        Console.ReadKey();
    }
}
