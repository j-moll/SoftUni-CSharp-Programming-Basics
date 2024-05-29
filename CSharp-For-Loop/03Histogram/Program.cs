namespace _13Histogram;
class Program
{
    static void Main(string[] args)
    {
        int numbersCount = int.Parse(Console.ReadLine());

        double p1 = 0, p2 = 0, p3 = 0, p4 = 0, p5 = 0;

        for (int i = 0; i < numbersCount; i++)
        {
            int currentnumber = int.Parse(Console.ReadLine());

            switch (currentnumber)
            {
                case < 200: p1++; break;
                case < 400: p2++; break;
                case < 600: p3++; break;
                case < 800: p4++; break;
                case <= 1000: p5++; break;
            }
        }

        //output

        Console.WriteLine($"{p1 / numbersCount * 100:f2}%");
        Console.WriteLine($"{p2 / numbersCount * 100:f2}%");
        Console.WriteLine($"{p3 / numbersCount * 100:f2}%");
        Console.WriteLine($"{p4 / numbersCount * 100:f2}%");
        Console.WriteLine($"{p5 / numbersCount * 100:f2}%");
    }
}

