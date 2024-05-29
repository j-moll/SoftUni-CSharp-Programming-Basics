namespace _07WorkingHours;
class Program
{
    static void Main(string[] args)
    {
        int hour = int.Parse(Console.ReadLine());
        string dayOfWeek = Console.ReadLine();

        bool isValid = hour >= 10 && hour <= 18;

        if (isValid)
        {
            switch (dayOfWeek)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                case "Saturday":
                    Console.WriteLine("open");
                    break;

                case "Sunday":
                    Console.WriteLine("closed");
                    break;
                default:
                    Console.WriteLine("invalid day");
                    break;
            }
        }
        else if (!isValid)
        {
            Console.WriteLine("closed");
        }
        else
        {
            Console.WriteLine("invalid hour");
        }
    }
}

