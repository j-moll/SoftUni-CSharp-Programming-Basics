namespace _21SkiTrip;
class Program
{
    static void Main(string[] args)
    {
        int daysCount = int.Parse(Console.ReadLine());
        string roomType = Console.ReadLine();
        string review = Console.ReadLine();

        int nightsCount = daysCount - 1;

        double pricePerNight = roomType switch
        {
            "room for one person" => 18,
            "apartment" => 25,
            "president apartment" => 35
        };

        double totalRoomPrice = nightsCount * pricePerNight;

        // discount
        if (roomType == "apartment")
        {
            if (daysCount > 0 && daysCount < 10)
            {
                totalRoomPrice *= 0.7;

                if (review == "positive")
                {
                    totalRoomPrice += totalRoomPrice * 0.25;
                }
                else
                {
                    totalRoomPrice *= 0.9;
                }
            }
            else if (daysCount >= 10 && daysCount <= 15)
            {
                totalRoomPrice *= 0.65;

                if (review == "positive")
                {
                    totalRoomPrice += totalRoomPrice * 0.25;
                }
                else
                {
                    totalRoomPrice *= 0.9;
                }
            }
            else if (daysCount > 15)
            {
                totalRoomPrice *= 0.5;

                if (review == "positive")
                {
                    totalRoomPrice += totalRoomPrice * 0.25;
                }
                else
                {
                    totalRoomPrice *= 0.9;
                }
            }
        }
        else if (roomType == "president apartment")
        {
            if (daysCount > 0 && daysCount < 10)
            {
                totalRoomPrice *= 0.9;

                if (review == "positive")
                {
                    totalRoomPrice += totalRoomPrice * 0.25;
                }
                else
                {
                    totalRoomPrice *= 0.9;
                }
            }
            else if (daysCount >= 10 && daysCount <= 15)
            {
                totalRoomPrice *= 0.85;

                if (review == "positive")
                {
                    totalRoomPrice += totalRoomPrice * 0.25;
                }
                else
                {
                    totalRoomPrice *= 0.9;
                }
            }
            else if (daysCount > 15)
            {
                totalRoomPrice *= 0.8;

                if (review == "positive")
                {
                    totalRoomPrice += totalRoomPrice * 0.25;
                }
                else
                {
                    totalRoomPrice *= 0.9;
                }
            }
        }
        else
        {
            if (review == "positive")
            {
                totalRoomPrice += totalRoomPrice * 0.25;
            }
            else
            {
                totalRoomPrice *= 0.9;
            }
        }

        Console.WriteLine($"{totalRoomPrice:F2}");
    }
}

