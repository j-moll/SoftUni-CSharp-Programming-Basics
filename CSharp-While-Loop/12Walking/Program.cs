namespace _12Walking;
class Program
{
    static void Main(string[] args)
    {
        int stepsPer1Walk = 0;

        // goal - 10_000 steps per day
        int maxNumberStepsPerDay = 10_000;

        while (stepsPer1Walk < maxNumberStepsPerDay)
        {
            string command = Console.ReadLine();

            if (command != "Going home") //input is integer
            {
                int addedStepsNumber = int.Parse(command);
                stepsPer1Walk += addedStepsNumber;
            }
            else //input is Going home
            {
                int stepsWhileGoingHome = int.Parse(Console.ReadLine());
                stepsPer1Walk += stepsWhileGoingHome;
                break;
            }
        }
        int difference = maxNumberStepsPerDay - stepsPer1Walk;

        if (difference <= 0)
        {
            Console.WriteLine("Goal reached! Good job!");
            Console.WriteLine($"{Math.Abs(difference)} steps over the goal!");
        }
        else
        {
            Console.WriteLine($"{difference} more steps to reach goal.");
        }
    }
}

