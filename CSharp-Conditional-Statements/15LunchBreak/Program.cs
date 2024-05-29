namespace _15LunchBreak;
class Program
{
    static void Main(string[] args)
    {
        string episodName = Console.ReadLine();
        int epizodTime = int.Parse(Console.ReadLine());
        double wholeBreak = double.Parse(Console.ReadLine());

        double lunch = wholeBreak * 1 / 8;
        double rest = wholeBreak * 1 / 4;
        double remainingTime = wholeBreak - (lunch + rest); // wholeBreak /5 /8;

        if (remainingTime >= epizodTime)
        {
            Console.WriteLine($"You have enough time to watch {episodName} and left with {Math.Ceiling(remainingTime - epizodTime)} minutes free time.");
        }
        else
        {
            Console.WriteLine($"You don't have enough time to watch {episodName}, you need {Math.Ceiling(epizodTime - remainingTime)} more minutes.");
        }
    }
}

