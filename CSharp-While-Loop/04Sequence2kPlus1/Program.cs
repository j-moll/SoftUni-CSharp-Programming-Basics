namespace _04Sequence2kPlus1;
class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        int outputNumber = 1;

        while (outputNumber <= number)
        {
            Console.WriteLine(outputNumber);
            outputNumber = outputNumber * 2 + 1;
        }
    }
}

