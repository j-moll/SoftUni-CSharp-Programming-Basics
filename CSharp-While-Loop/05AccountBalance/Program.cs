namespace _05AccountBalance;
class Program
{
    static void Main(string[] args)
    {
        double balance = 0;
        string input = Console.ReadLine();

        while (input != "NoMoreMoney")
        {
            double currentBalance = double.Parse(input);

            if (currentBalance < 0)
            {
                Console.WriteLine("Invalid operation!");
                break;
            }

            Console.WriteLine($"Increase: {currentBalance:f2}");

            balance += currentBalance;
            input = Console.ReadLine();
        }

        Console.WriteLine($"Total: {balance:f2}");
    }
}

