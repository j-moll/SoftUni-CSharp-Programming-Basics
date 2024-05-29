namespace _08SumSeconds;
class Program
{
    static void Main(string[] args)
    {
        // Input

        int firstCompetitorTimeInSec = int.Parse(Console.ReadLine());
        int secondCompetitorTimeInSec = int.Parse(Console.ReadLine());
        int thirdCompetitorTimeInSec = int.Parse(Console.ReadLine());

        // Pre-calculations

        int totalTimeInSec = firstCompetitorTimeInSec
            + secondCompetitorTimeInSec
            + thirdCompetitorTimeInSec;

        int totalTimeInMin = totalTimeInSec / 60;
        int remainingSec = totalTimeInSec % 60;

        //Condition

        if (remainingSec < 10)
        {
            Console.WriteLine($"{totalTimeInMin}:0{remainingSec}");
        }
        else
        {
            Console.WriteLine($"{totalTimeInMin}:{remainingSec}");
        }
    }
}

