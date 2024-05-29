namespace _09SumPrimeNonPrime;
class Program
{
    static void Main(string[] args)
    {
        int primeNumbersSum = 0;
        int nonPrimeNumbersSum = 0;

        while (true)
        {
            string commandOrnumbers = Console.ReadLine();

            if (commandOrnumbers == "stop")
            {
                break;
            }

            int number = int.Parse(commandOrnumbers);

            if (number < 0)
            {
                Console.WriteLine("Number is negative.");
                continue;
            }

            bool numberIsPrime = true;

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    numberIsPrime = false;
                    break;
                }
            }

            if (numberIsPrime)
            {
                primeNumbersSum += number;
            }
            else
            {
                nonPrimeNumbersSum += number;
            }
        }

        Console.WriteLine($"Sum of all prime numbers is: {primeNumbersSum}");
        Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeNumbersSum}");
    }
}

