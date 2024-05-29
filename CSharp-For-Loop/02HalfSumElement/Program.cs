namespace _12HalfSumElement;
class Program
{
    static void Main(string[] args)
    {
        int numberCount = int.Parse(Console.ReadLine());
        int maxNumber = int.MinValue;
        int sum = 0;

        for (int i = 0; i < numberCount; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());
            sum += currentNumber;

            if (currentNumber > maxNumber)
            {
                maxNumber = currentNumber;
            }
        }

        int difference = Math.Abs(sum - maxNumber);

        if (difference == maxNumber)
        {
            Console.WriteLine("Yes");
            Console.WriteLine($"Sum = {maxNumber}");
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine($"Diff = {Math.Abs(difference - maxNumber)}");
        }
    }
}

