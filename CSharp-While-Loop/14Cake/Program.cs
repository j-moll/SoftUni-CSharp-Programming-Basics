namespace _14Cake;
class Program
{
    static void Main(string[] args)
    {
        int cakeHeight = int.Parse(Console.ReadLine());
        int cakeWidth = int.Parse(Console.ReadLine());
        int totalPieces = cakeHeight * cakeWidth;

        while (totalPieces > 0)
        {
            string input = Console.ReadLine();

            if (input == "STOP")
            {
                break;
            }
            int sliceCount = int.Parse(input);
            totalPieces -= sliceCount;
        }

        if (totalPieces < 0)
        {
            Console.WriteLine($"No more cake left! You need {Math.Abs(totalPieces)} pieces more.");
        }
        else
        {
            Console.WriteLine($"{totalPieces} pieces are left.");
        }
    }
}

