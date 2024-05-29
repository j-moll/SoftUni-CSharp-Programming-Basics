namespace _13Cinema;
class Program
{
    static void Main(string[] args)
    {
        // input

        string movieType = Console.ReadLine();
        int rows = int.Parse(Console.ReadLine());
        int columns = int.Parse(Console.ReadLine());

        //calculations

        int totalSeats = rows * columns;
        double price = 0;

        if (movieType == "Premiere")
        {
            price = 12;
        }
        else if (movieType == "Normal")
        {
            price = 7.50;
        }
        else if (movieType == "Discount")
        {
            price = 5.00;
        }
        else
        {
            Console.WriteLine("error");
        }

        double totalIncome = totalSeats * price;

        Console.WriteLine($"{totalIncome:F2}");
    }
}

