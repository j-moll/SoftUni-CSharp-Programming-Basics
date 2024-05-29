namespace _10TimePlus15Minutes;
class Program
{
    static void Main(string[] args)
    {
        int timeInHours = int.Parse(Console.ReadLine());
        int timeInMinutes = int.Parse(Console.ReadLine());

        int newTimeInMinutes = timeInMinutes + 15;

        if ((timeInHours >= 0 && timeInHours <= 23) &&

           (timeInMinutes >= 0 && timeInMinutes <= 59))
        {
            int totalTimeInHours = (timeInHours * 60 + newTimeInMinutes) / 60;
            int totalTimeInMinutes = (timeInHours * 60 + newTimeInMinutes) % 60;

            if (totalTimeInMinutes >= 0 && totalTimeInMinutes <= 9)
            {
                Console.WriteLine($"{totalTimeInHours % 24}:0{totalTimeInMinutes}");
            }
            else if (totalTimeInMinutes >= 10 && totalTimeInMinutes <= 59)
            {
                Console.WriteLine($"{totalTimeInHours % 24}:{totalTimeInMinutes}");
            }
            else
            {
                Console.WriteLine("Invalid time format!");
            }

        }
    }
}

