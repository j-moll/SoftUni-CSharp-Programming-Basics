namespace _17Journey;
class Program
{
    static void Main(string[] args)
    {
        // input

        double budget = double.Parse(Console.ReadLine());
        string season = Console.ReadLine();

        // calculations

        string destination = "";

        if (budget <= 100)
        {
            destination = "Bulgaria";
        }
        else if (budget <= 1000)
        {
            destination = "Balkans";
        }
        else if (budget > 1000)
        {
            destination = "Europe";
        }
        else
        {
            Console.WriteLine("Invalid data");
        }

        double budgetPercentageSpent = 0;
        string placeToStayType = "";

        switch (destination)
        {
            case "Bulgaria":
                switch (season)
                {
                    case "summer":
                        budgetPercentageSpent = 0.3;
                        placeToStayType = "Camp";
                        break;

                    case "winter":
                        budgetPercentageSpent = 0.7;
                        placeToStayType = "Hotel";
                        break;
                }
                break;
            case "Balkans":
                switch (season)
                {
                    case "summer":
                        budgetPercentageSpent = 0.4;
                        placeToStayType = "Camp";
                        break;

                    case "winter":
                        budgetPercentageSpent = 0.8;
                        placeToStayType = "Hotel";
                        break;
                }
                break;

            case "Europe":
                budgetPercentageSpent = 0.9;
                placeToStayType = "Hotel";
                break;
            default: Console.WriteLine("invalid data");
                break;
        }

        //output
        double moneySpent = budget * budgetPercentageSpent;

        Console.WriteLine($"Somewhere in {destination}");
        Console.WriteLine($"{placeToStayType} - {moneySpent:F2}");
    }
}

