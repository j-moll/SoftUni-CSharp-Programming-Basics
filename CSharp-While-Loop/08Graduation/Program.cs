namespace _08Graduation;
class Program
{
    static void Main(string[] args)
    {
        string name = Console.ReadLine();

        int grade = 1;
        int badGrades = 0;
        double totalPoints = 0;


        while (grade <= 12)
        {
            double currentPoints = double.Parse(Console.ReadLine());

            if (currentPoints < 4)
            {
                badGrades++;
                if (badGrades == 2)
                {
                    Console.WriteLine($"{name} has been excluded at {grade} grade");
                    break;
                }
                continue;
            }

            grade++;
            totalPoints += currentPoints;
        }

        if (grade >= 12)
        {
            double averageGrade = totalPoints / 12;
            Console.WriteLine($"{name} graduated. Average grade: {averageGrade:f2}");
        }
    }
}

