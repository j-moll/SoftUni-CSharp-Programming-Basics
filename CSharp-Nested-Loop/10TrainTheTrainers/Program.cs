namespace _10TrainTheTrainers;
class Program
{
    static void Main(string[] args)
    {
        int judgesCount = int.Parse(Console.ReadLine());

        //Calculations

        double presentationsTotalgrade = 0;
        double presentationsCount = 0;

        while (true)
        {
            string endCommandOrPresentationName = Console.ReadLine();

            if (endCommandOrPresentationName == "Finish")
            {
                break;
            }

            presentationsCount++;
            string presentationName = endCommandOrPresentationName;

            double totalPresentationGrade = 0;

            for (int i = 0; i < judgesCount; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                totalPresentationGrade += grade;
            }

            double averageGrade = totalPresentationGrade / judgesCount;
            presentationsTotalgrade += averageGrade;
            Console.WriteLine($"{presentationName} - {averageGrade:f2}.");
        }
        Console.WriteLine($"Student's final assessment is {presentationsTotalgrade / presentationsCount:f2}.");
    }
}

