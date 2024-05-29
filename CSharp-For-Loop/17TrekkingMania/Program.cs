namespace _17TrekkingMania;
class Program
{
    static void Main(string[] args)
    {
        int groupsCount = int.Parse(Console.ReadLine());
        int musala = 0, monblanc = 0, kilimanjaro = 0, k2 = 0, everest = 0;

        for (int i = 0; i < groupsCount; i++)
        {
            int climbersCount = int.Parse(Console.ReadLine());

            if (climbersCount <= 5)
            {
                musala += climbersCount;
            }
            else if (climbersCount >= 6 && climbersCount <= 12)
            {
                monblanc += climbersCount;
            }
            else if (climbersCount >= 13 && climbersCount <= 25)
            {
                kilimanjaro += climbersCount;
            }
            else if (climbersCount >= 26 && climbersCount <= 40)
            {
                k2 += climbersCount;
            }
            else
            {
                everest += climbersCount;
            }
        }

        int totalClimbersCount = musala + monblanc + kilimanjaro + k2 + everest;

        Console.WriteLine($"{((double)musala / totalClimbersCount * 100):f2}%");
        Console.WriteLine($"{((double)monblanc / totalClimbersCount * 100):f2}%");
        Console.WriteLine($"{((double)kilimanjaro / totalClimbersCount * 100):f2}%");
        Console.WriteLine($"{((double)k2 / totalClimbersCount * 100):f2}%");
        Console.WriteLine($"{((double)everest / totalClimbersCount * 100):f2}%");
    }
}

