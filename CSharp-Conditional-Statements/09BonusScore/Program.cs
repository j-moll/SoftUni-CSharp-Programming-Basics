namespace _09BonusScore;
class Program
{
    static void Main(string[] args)
    {
        double inputScore = double.Parse(Console.ReadLine());

        double bonusScore = 0.0;

        if (inputScore <= 100)
        {
            bonusScore = 5;
        }
        else if (inputScore > 100 && inputScore <= 1000)
        {
            bonusScore = inputScore * 0.2;

        }
        else if (inputScore > 1000)
        {
            bonusScore = inputScore * 0.1;

        }
        if (inputScore % 2 == 0)

        {
            bonusScore = bonusScore + 1;
        }
        else if (inputScore % 10 == 5)
        {
            bonusScore += 2;
        }

        Console.WriteLine($"{bonusScore}");

        Console.WriteLine($"Total score:{inputScore + bonusScore}");
    }
}

