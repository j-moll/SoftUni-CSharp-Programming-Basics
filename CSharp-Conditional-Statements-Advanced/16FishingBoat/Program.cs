namespace _16FishingBoat;
class Program
{
    static void Main(string[] args)
    {
        // input
        int budget = int.Parse(Console.ReadLine());
        string season = Console.ReadLine();
        int peopleCount = int.Parse(Console.ReadLine());

        //calculations
        double price = season switch
        {
            "Spring" => 3000,
            "Summer" => 4200,
            "Autumn" => 4200,
            "Winter" => 2600
        };

        if (peopleCount >= 1 && peopleCount <= 6)
        {
            price *= 0.9;
        }
        else if (peopleCount >= 7 && peopleCount <= 11)
        {
            price *= 0.85;
        }
        else if (peopleCount >= 12)
        {
            price *= 0.75;
        }
        else
        {
            Console.WriteLine("Invalid data");
        }

        //Additional discount

        if ((peopleCount % 2 == 0) && (season != "Autumn"))
        {
            price *= 0.95;
        }

        //Output

        if (budget >= price)
        {
            double moneyLeft = budget - price;
            Console.WriteLine($"Yes! You have {moneyLeft:F2} leva left.");
        }
        else
        {
            double moneyNeeded = price - budget;
            Console.WriteLine($"Not enough money! You need {moneyNeeded:F2} leva.");
        }
    }
}

