namespace _10ExamPreparation;
class Program
{
    static void Main(string[] args)
    {
        int unsatisfactoryGradesCount = int.Parse(Console.ReadLine());
        int tasksCount = 0;
        string lastTaskName = "";
        double gradesSum = 0;
        int failedtimes = 0;

        while (failedtimes < unsatisfactoryGradesCount)
        {
            string taskName = Console.ReadLine();

            if (taskName == "Enough")
            {
                break;
            }

            lastTaskName = taskName;
            tasksCount++;
            int grade = int.Parse(Console.ReadLine());
            gradesSum += grade;

            if (grade <= 4)
            {
                failedtimes++;
            }
        }

        if (failedtimes >= unsatisfactoryGradesCount)
        {
            Console.WriteLine($"You need a break, {failedtimes} poor grades.");
        }
        else
        {
            Console.WriteLine($"Average score: {gradesSum / tasksCount:f2}");
            Console.WriteLine($"Number of problems: {tasksCount}");
            Console.WriteLine($"Last problem: {lastTaskName}");
        }
    }
}

