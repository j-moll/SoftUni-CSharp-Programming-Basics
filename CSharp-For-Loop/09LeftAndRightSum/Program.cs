namespace _09LeftAndRightSum;
class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        int leftSum = 0;
        int rightSum = 0;

        for (int i = 1; i <= number; i++)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            leftSum += inputNumber;
        }

        for (int i = 1; i <= number; i++)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            rightSum += inputNumber;
        }

        if (leftSum == rightSum)
        {
            Console.WriteLine($"Yes, sum = {rightSum}");
        }
        else
        {
            int difference = Math.Abs(leftSum - rightSum);
            Console.WriteLine($"No, diff = {difference}");
        }
    }
}

