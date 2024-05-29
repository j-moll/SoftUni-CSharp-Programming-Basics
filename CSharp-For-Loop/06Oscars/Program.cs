namespace _16Oscars;
class Program
{
    static void Main(string[] args)
    {
        string actorName = Console.ReadLine();
        double points = double.Parse(Console.ReadLine());
        int juryMembersCount = int.Parse(Console.ReadLine());

        for (int i = 1; i <= juryMembersCount; i++)
        {
            string juryName = Console.ReadLine();
            double pointsFromJury = double.Parse(Console.ReadLine());

            points += ((juryName.Length * pointsFromJury) / 2.0);

            if (points > 1250.5)
            {
                break;
            }
        }

        if (points <= 1250.5)
        {
            Console.WriteLine($"Sorry, {actorName} you need {1250.5 - points:f1} more!");
        }
        else
        {
            Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {points:f1}!");
        }
    }
}

