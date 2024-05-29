namespace _14CleverLily;
class Program
{
    static void Main(string[] args)
    {
        int ageOfLily = int.Parse(Console.ReadLine());
        double washerPrice = double.Parse(Console.ReadLine());
        double toyPrice = double.Parse(Console.ReadLine());

        int toyCount = 0;
        double money = 0;
        double totalMoney = 0;
        double moneyForBrother = 0;

        for (int i = 1; i <= ageOfLily; i++)
        {
            if (i % 2 == 0)
            {
                money += 10;
                totalMoney += money;
                moneyForBrother++;
            }
            else
            {
                toyCount++;
            }
        }

        double totalToysPrice = toyCount * toyPrice;
        double totalMoneySaved = (totalToysPrice + totalMoney) - moneyForBrother;

        if (totalMoneySaved >= washerPrice)
        {
            Console.WriteLine($"Yes! {totalMoneySaved - washerPrice:F2}");
        }
        else
        {
            Console.WriteLine($"No! {washerPrice - totalMoneySaved:F2}");
        }
    }
}

