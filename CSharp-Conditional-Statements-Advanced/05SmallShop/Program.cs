namespace _05SmallShop;
class Program
{
    static void Main(string[] args)
    {
        // input

        string product = Console.ReadLine();
        string city = Console.ReadLine();
        double productCount = double.Parse(Console.ReadLine());

        // calculations

        if (city == "Sofia")
        {
            switch (product)
            {
                case "coffee":
                    Console.WriteLine(0.50 * productCount);
                    break;
                case "water":
                    Console.WriteLine(0.80 * productCount);
                    break;
                case "beer":
                    Console.WriteLine(1.20 * productCount);
                    break;
                case "sweets":
                    Console.WriteLine(1.45 * productCount);
                    break;
                case "peanuts":
                    Console.WriteLine(1.60 * productCount);
                    break;
                default:
                    Console.WriteLine("Invalid product");
                    break;
            }
        }
        else if (city == "Plovdiv")
        {
            switch (product)
            {
                case "coffee":
                    Console.WriteLine(0.40 * productCount);
                    break;
                case "water":
                    Console.WriteLine(0.70 * productCount);
                    break;
                case "beer":
                    Console.WriteLine(1.15 * productCount);
                    break;
                case "sweets":
                    Console.WriteLine(1.30 * productCount);
                    break;
                case "peanuts":
                    Console.WriteLine(1.50 * productCount);
                    break;
                default:
                    Console.WriteLine("Invalid product");
                    break;
            }
        }
        else if (city == "Varna")
        {
            switch (product)
            {
                case "coffee":
                    Console.WriteLine(0.45 * productCount);
                    break;
                case "water":
                    Console.WriteLine(0.70 * productCount);
                    break;
                case "beer":
                    Console.WriteLine(1.10 * productCount);
                    break;
                case "sweets":
                    Console.WriteLine(1.35 * productCount);
                    break;
                case "peanuts":
                    Console.WriteLine(1.55 * productCount);
                    break;
                default:
                    Console.WriteLine("Invalid product");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid city");
        }
    }
}

