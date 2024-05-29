namespace _19HotelRoom;
class Program
{
    static void Main(string[] args)
    {
        // Input

        string month = Console.ReadLine();

        int nightsCount = int.Parse(Console.ReadLine());

        // calculations

        double pricePerNightStudio = 0;
        double pricePerNightApartment = 0;

        switch (month)
        {
            case "May":
            case "October":
                pricePerNightStudio = 50;
                pricePerNightApartment = 65;
                break;
            case "June":
            case "September":
                pricePerNightStudio = 75.20;
                pricePerNightApartment = 68.70;
                break;
            case "July":
            case "August":
                pricePerNightStudio = 76;
                pricePerNightApartment = 77;
                break;
            default:
                Console.WriteLine("Invalid month");
                break;
        }

        double totalStudioPrice = pricePerNightStudio * nightsCount;
        double totalApartmentPrice = pricePerNightApartment * nightsCount;

        // discount

        if ((nightsCount > 7 && nightsCount <= 14) && (month == "May" || month == "October"))
        {
            totalStudioPrice *= 0.95;
        }
        else if (nightsCount > 14)
        {
            totalApartmentPrice *= 0.9;

            switch (month)
            {
                case "May":
                case "October":
                    totalStudioPrice *= 0.7;
                    break;
                case "June":
                case "September":
                    totalStudioPrice *= 0.8;
                    break;
            }
        }

        // output
        Console.WriteLine($"Apartment: {totalApartmentPrice:F2} lv.");
        Console.WriteLine($"Studio: {totalStudioPrice:F2} lv.");
    }
}

