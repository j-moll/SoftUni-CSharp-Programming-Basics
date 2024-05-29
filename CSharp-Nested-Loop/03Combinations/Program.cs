namespace _03Combinations;
class Program
{
    static void Main(string[] args)
    {
        int initialNumber = int.Parse(Console.ReadLine());
        int validCombinationsCount = 0;

        for (int i = 0; i <= initialNumber; i++)
        {
            for (int j = 0; j <= initialNumber; j++)
            {
                for (int k = 0; k <= initialNumber; k++)
                {
                    int sum = j + k + i;

                    if (sum == initialNumber)
                    {
                        validCombinationsCount++;
                    }
                }
            }
        }
        Console.WriteLine(validCombinationsCount);
    }
}

