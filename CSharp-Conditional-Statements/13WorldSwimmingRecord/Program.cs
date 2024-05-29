namespace _13WorldSwimmingRecord;
class Program
{
    static void Main(string[] args)
    {
        // Input

        double recordTimeInSeconds = double.Parse(Console.ReadLine());
        double distanceInMeters = double.Parse(Console.ReadLine());
        double secFor1MeterOfSwimming = double.Parse(Console.ReadLine());

        //Calculations

        double secsNeededForWholeDistance = distanceInMeters * secFor1MeterOfSwimming;
        double timeSlowedDown = Math.Floor(distanceInMeters / 15);
        secsNeededForWholeDistance += timeSlowedDown * 12.5;

        //Output

        if (secsNeededForWholeDistance < recordTimeInSeconds)
        {
            Console.WriteLine($"Yes, he succeeded! The new world record is {Math.Abs(secsNeededForWholeDistance):F2} seconds.");
        }
        else
        {
            Console.WriteLine($"No, he failed! He was {secsNeededForWholeDistance - recordTimeInSeconds:f2} seconds slower.");
        }
    }
}

