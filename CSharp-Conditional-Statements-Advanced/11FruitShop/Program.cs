namespace _11FruitShop;
class Program
{
    static void Main(string[] args)
    {
        string fruit = Console.ReadLine();
        string dayOfWeek = Console.ReadLine();
        double fruitCount = double.Parse(Console.ReadLine());

        bool workingDay = dayOfWeek == "Monday" ||
                          dayOfWeek == "Tuesday" ||
                          dayOfWeek == "Wednesday" ||
                          dayOfWeek == "Thursday" ||
                          dayOfWeek == "Friday";

        bool weekend = dayOfWeek == "Saturday" ||
                       dayOfWeek == "Sunday";

        double price = 0;
        bool isError = false;

        if (workingDay)
        {
            switch (fruit)
            {
                case "banana":
                    price = 2.50;
                    break;
                case "apple":
                    price = 1.20;
                    break;
                case "orange":
                    price = 0.85;
                    break;
                case "grapefruit":
                    price = 1.45;
                    break;
                case "kiwi":
                    price = 2.70;
                    break;
                case "pineapple":
                    price = 5.50;
                    break;
                case "grapes":
                    price = 3.85;
                    break;
                default:
                    isError = true;
                    Console.WriteLine("error");
                    break;
            }
        }
        else if (weekend)
        {
            switch (fruit)
            {
                case "banana":
                    price = 2.70;
                    break;
                case "apple":
                    price = 1.25;
                    break;
                case "orange":
                    price = 0.90;
                    break;
                case "grapefruit":
                    price = 1.60;
                    break;
                case "kiwi":
                    price = 3.00;
                    break;
                case "pineapple":
                    price = 5.60;
                    break;

                case "grapes":
                    price = 4.20;
                    break;
                default:
                    isError = true;
                    Console.WriteLine("error");
                    break;
            }
        }
        else
        {
            isError = true;
            Console.WriteLine("error");
        }

        if (!isError)
        {
            double totalPrice = fruitCount * price;
            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}

