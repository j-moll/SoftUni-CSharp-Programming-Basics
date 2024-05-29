namespace _02GreaterNumber;
class Program
{
    static void Main(string[] args)
    {
        // Variables
        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());

        //Condition
        if (number1 > number2)
        {
            Console.WriteLine(number1);
        }
        else
        {
            Console.WriteLine(number2);
        }
    }
}

