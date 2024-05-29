using System.Text.Unicode;
namespace _14SummerOutfit;
class Program
{
    static void Main(string[] args)
    {
        //input
        int degrees = int.Parse(Console.ReadLine());
        string timeOfDay = Console.ReadLine();

        // calculations
        string outfit = "";
        string shoes = "";

        if (timeOfDay == "Morning")
        {
            if (degrees >= 10 && degrees <= 18)
            {
                outfit = "Sweatshirt";
                shoes = "Sneakers";
            }
            else if (degrees > 18 && degrees <= 24)
            {
                outfit = "Shirt";
                shoes = "Moccasins";
            }
            else if (degrees >= 25)
            {
                outfit = "T-Shirt";
                shoes = "Sandals";
            }
            else
            {
                Console.WriteLine("Invalid data");
            }
        }
        else if (timeOfDay == "Afternoon")
        {
            if (degrees >= 10 && degrees <= 18)
            {
                outfit = "Shirt";
                shoes = "Moccasins";
            }
            else if (degrees > 18 && degrees <= 24)
            {
                outfit = "T-Shirt";
                shoes = "Sandals";
            }
            else if (degrees >= 25)
            {
                outfit = "Swim Suit";
                shoes = "Barefoot";
            }
            else
            {
                Console.WriteLine("Invalid data");
            }
        }
        else if (timeOfDay == "Evening")
        {
            outfit = "Shirt";
            shoes = "Moccasins";
        }
        else
        {
            Console.WriteLine("Invalid data");
        }

        Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
    }
}

