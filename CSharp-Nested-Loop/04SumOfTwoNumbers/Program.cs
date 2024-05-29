namespace _04SumOfTwoNumbers;
class Program
{
    static void Main(string[] args)
    {
        int startNumber = int.Parse(Console.ReadLine());
        int endNumber = int.Parse(Console.ReadLine());
        int magicNumber = int.Parse(Console.ReadLine());
        int combinationsCount = 0;
        bool combinationIsFound = false;

        for (int i = startNumber; i <= endNumber; i++)
        {
            for (int k = startNumber; k <= endNumber; k++)
            {
                combinationsCount++;

                if (i + k == magicNumber)
                {
                    combinationIsFound = true;
                    Console.WriteLine($"Combination N:{combinationsCount} ({i} + {k} = {magicNumber})");
                    break;
                }
            }

            if (combinationIsFound)
            {
                break;
            }
        }

        if (!combinationIsFound)
        {
            Console.WriteLine($"{combinationsCount} combinations - neither equals {magicNumber}");
        }
    }
}

