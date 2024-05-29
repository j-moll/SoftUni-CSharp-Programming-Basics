namespace _07NumberPyramid;
class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        int lastPrintedNumber = 0;

        for (int row = 0; row < number; row++)
        {
            for (int column = 0; column <= row; column++)
            {
                Console.Write($"{++lastPrintedNumber} ");

                if (lastPrintedNumber == number)
                {
                    break;
                }
            }

            if (lastPrintedNumber == number)
            {
                break;
            }
            Console.WriteLine();
        }
    }
}

