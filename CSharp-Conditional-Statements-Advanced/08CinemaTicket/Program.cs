namespace _08CinemaTicket;
class Program
{
    static void Main(string[] args)
    {
        string dayOfWeek = Console.ReadLine();

        if(dayOfWeek == "Monday" ||
           dayOfWeek == "Tuesday" ||
           dayOfWeek == "Friday")
        {
            double ticketPrice = 12;
            Console.WriteLine($"{ticketPrice}");
        }
        else if(dayOfWeek == "Wednesday" ||
                dayOfWeek == "Thursday")
        {
            double ticketPrice = 14;
            Console.WriteLine($"{ticketPrice}");
        }
        else if(dayOfWeek == "Saturday" ||
                dayOfWeek == "Sunday")
        {
            double ticketPrice = 16;
            Console.WriteLine($"{ticketPrice}");
        }
        else
        {
            Console.WriteLine("Invalid day");
        }
    }
}

