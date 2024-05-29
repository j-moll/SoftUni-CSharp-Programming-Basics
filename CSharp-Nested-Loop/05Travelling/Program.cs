namespace _05Travelling;
class Program
{
    static void Main(string[] args)
    {
        string destination = Console.ReadLine();

        while (destination != "End")
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double savedMoney = double.Parse(Console.ReadLine());

            while (savedMoney < neededMoney)
            {
                double currentMoney = double.Parse(Console.ReadLine());
                savedMoney += currentMoney;
            }

            Console.WriteLine($"Going to {destination}!");
            destination = Console.ReadLine();
        }
    }
}

