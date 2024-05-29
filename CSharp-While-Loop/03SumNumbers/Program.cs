namespace _03SumNumbers;
class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        int sum = 0;

        while (sum < number)
        {
            int number2 = int.Parse(Console.ReadLine());
            sum += number2;
        }

        Console.WriteLine(sum);
    }
}

