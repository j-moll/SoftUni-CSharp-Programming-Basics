namespace _10OddEvenSum;
class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        int oddSum = 0;
        int evenSum = 0;

        for (int i = 0; i < number; i++)

        {
            int inputNumber = int.Parse(Console.ReadLine());

            if (i % 2 == 0)
            {
                evenSum += inputNumber;
            }
            else
            {
                oddSum += inputNumber;
            }
        }

        if (oddSum == evenSum)
        {
            Console.WriteLine("Yes");
            Console.WriteLine($"Sum = {oddSum}");
        }
        else
        {
            int difference = Math.Abs(oddSum - evenSum);
            Console.WriteLine("No");
            Console.WriteLine($"Diff = {difference}");
        }
    }
}