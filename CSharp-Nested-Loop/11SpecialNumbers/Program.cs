namespace _11SpecialNumbers;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        //calculations

        for (int number = 1111; number <= 9999; number++)
        {

            bool isNumberSpecial = true;
            int numberCopy = number;

            while (numberCopy > 0)
            {
                int lastDigit = numberCopy % 10;
                if (lastDigit == 0)
                {
                    isNumberSpecial = false;
                    break;
                }

                if (n % lastDigit != 0)
                {
                    isNumberSpecial = false;
                    break;
                }
                numberCopy /= 10;
            }

            if (isNumberSpecial)
            {
                Console.Write($"{number} ");
            }
        }
    }
}

