namespace _14Shopping;
class Program
{
    static void Main(string[] args)
    {
        const double VideoCardPrice = 250;

        // input
        double budget = double.Parse(Console.ReadLine());
        int videoCardCount = int.Parse(Console.ReadLine());
        int processorCount = int.Parse(Console.ReadLine());
        int ramCount = int.Parse(Console.ReadLine());

        // calculations
        double totalVideoCardPrice = videoCardCount * VideoCardPrice;
        double processorPrice = totalVideoCardPrice * 0.35;
        double ramPrice = totalVideoCardPrice * 0.1;
        double totalProcessorPrice = processorPrice * processorCount;
        double totalRamPrice = ramPrice * ramCount;
        double totalPrice = totalVideoCardPrice + totalProcessorPrice + totalRamPrice;

        if (videoCardCount > processorCount)
        {
            totalPrice *= 0.85;
        }

        if (budget >= totalPrice)
        {
            Console.WriteLine($"You have {budget - totalPrice:F2} leva left!");
        }
        else
        {
            Console.WriteLine($"Not enough money! You need {totalPrice - budget:F2} leva more!");
        }
    }
}

