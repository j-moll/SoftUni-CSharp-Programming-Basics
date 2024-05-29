namespace _06OperationsBetweenNumbers;
class Program
{
    static void Main(string[] args)
    {
        double number1 = double.Parse(Console.ReadLine());
        double number2 = double.Parse(Console.ReadLine());
        char symbol = char.Parse(Console.ReadLine());

        double result = 0;
        if (symbol == '/' || symbol == '%')
        {
            if (number2 == 0)
            {
                Console.WriteLine($"Cannot divide {number1} by zero");
            }
            else //number2 != 0
            {
                if (symbol == '/')
                {
                    result = number1 / number2;
                    Console.WriteLine($"{number1} {symbol} {number2} = {result:F2}");
                }
                else
                {
                    result = number1 % number2;
                    Console.WriteLine($"{number1} {symbol} {number2} = {result}");
                }
            }
        }
        else //+,-,*
        {
            switch (symbol)
            {
                case '+':
                    result = number1 + number2;
                    break;
                case '-':
                    result = number1 - number2;
                    break;
                case '*':
                    result = number1 * number2;
                    break;
            }

            if (result % 2 == 0)
            {
                Console.WriteLine($"{number1} {symbol} {number2} = {result} - even");
            }
            else
            {
                Console.WriteLine($"{number1} {symbol} {number2} = {result} - odd");
            }
        }
    }
}

