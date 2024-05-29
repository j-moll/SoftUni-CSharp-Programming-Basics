namespace _12GodzillaVsKong;
class Program
{
    static void Main(string[] args)
    {
        double filmBudget = double.Parse(Console.ReadLine());
        int statistsCount = int.Parse(Console.ReadLine());
        double artisticLookPrice = double.Parse(Console.ReadLine());

        double decorationsPrice = filmBudget * 0.1;

        if (statistsCount > 150)
        {
            artisticLookPrice *= 0.9;
        }

        double decorAndLookPrice = artisticLookPrice * statistsCount + decorationsPrice;

        if (filmBudget < decorAndLookPrice)
        {
            Console.WriteLine("Not enough money!");
            Console.WriteLine($"Wingard needs {decorAndLookPrice - filmBudget:F2} leva more.");
        }
        else
        {
            Console.WriteLine("Action!");
            Console.WriteLine($"Wingard starts filming with {filmBudget - decorAndLookPrice:F2} leva left.");
        }
    }
}

