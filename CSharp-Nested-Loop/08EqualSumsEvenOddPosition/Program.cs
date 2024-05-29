namespace _08EqualSumsEvenOddPosition;
class Program
{
    static void Main(string[] args)
    {
        int startNumber = int.Parse(Console.ReadLine());
        int endNumber = int.Parse(Console.ReadLine());

        for (int number = startNumber; number <= endNumber; number++)
        {
            string numberText = number.ToString();
            int evenPositionSum = 0;
            int oddPositionSum = 0;

            for (int charPosition = 0; charPosition < numberText.Length; charPosition++)
            {
                int digit = int.Parse(numberText[charPosition].ToString());

                if (charPosition % 2 == 0)
                {
                    evenPositionSum += digit;
                }
                else
                {
                    oddPositionSum += digit;
                }
            }

            if (evenPositionSum == oddPositionSum)
            {
                Console.Write($"{number} ");
            }
        }
    }
}

