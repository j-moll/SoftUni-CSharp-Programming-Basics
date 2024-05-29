namespace _18TennisRanklist;
class Program
{
    static void Main(string[] args)
    {
        int tourneysCount = int.Parse(Console.ReadLine());
        int entryPoints = int.Parse(Console.ReadLine());
        int tourneyPoints = 0;
        int winnerTourneysCount = 0;

        for (int i = 0; i < tourneysCount; i++)
        {
            string position = Console.ReadLine();

            switch (position)
            {
                case "W":
                    tourneyPoints += 2000;
                    break;
                case "F":
                    tourneyPoints += 1200;
                    break;
                case "SF":
                    tourneyPoints += 720;
                    break;
            }

            if (position == "W")
            {
                winnerTourneysCount++;
            }
        }

        int finalPoints = entryPoints + tourneyPoints;
        Console.WriteLine($"Final points: {finalPoints}");

        double averagePoints = tourneyPoints / tourneysCount;
        Console.WriteLine($"Average points: {averagePoints}");

        double winnerTourneypercentage = (double)winnerTourneysCount / tourneysCount * 100;
        Console.WriteLine($"{winnerTourneypercentage:f2}%");
    }
}

