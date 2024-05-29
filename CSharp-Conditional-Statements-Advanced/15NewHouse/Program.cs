namespace _15NewHouse;
class Program
{
    static void Main(string[] args)
    {
        // input
        string flowerType = Console.ReadLine();
        int flowersCount = int.Parse(Console.ReadLine());
        double budget = int.Parse(Console.ReadLine());

        //calculations

        double flowerPrice = 0;

        switch (flowerType)
        {
            case "Roses":
                flowerPrice = 5;
                break;
            case "Dahlias":
                flowerPrice = 3.8;
                break;
            case "Tulips":
                flowerPrice = 2.8;
                break;
            case "Narcissus":
                flowerPrice = 3;
                break;
            case "Gladiolus":
                flowerPrice = 2.5;
                break;
            default:
                Console.WriteLine("Invalid flower type");
                break;
        }

        double totalCost = flowersCount * flowerPrice;

        if (flowerType == "Roses" && flowersCount > 80)
        {
            totalCost *= 0.9;
        }
        else if ((flowerType == "Dahlias" && flowersCount > 90) ||
                (flowerType == "Tulips" && flowersCount > 80))
        {
            totalCost *= 0.85;
        }
        else if (flowerType == "Narcissus" && flowersCount < 120)
        {
            totalCost *= 1.15;
        }
        else if (flowerType == "Gladiolus" && flowersCount < 80)
        {
            totalCost *= 1.2;
        }

        // Output

        if (totalCost <= budget)
        {
            double moneyLeft = budget - totalCost;
            Console.WriteLine($"Hey, you have a great garden with {flowersCount} {flowerType} and {moneyLeft:F2} leva left.");
        }
        else
        {
            double moneyNeeded = totalCost - budget;
            Console.WriteLine($"Not enough money, you need {moneyNeeded:F2} leva more.");
        }
    }
}

