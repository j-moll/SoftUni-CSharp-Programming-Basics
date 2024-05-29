namespace _11Vacation;
class Program
{
    static void Main(string[] args)
    {
        double moneyNeededForTrip = double.Parse(Console.ReadLine());
        double accountBalance = double.Parse(Console.ReadLine());

        int daysMoneySpent = 0;
        int totalDaysCount = 0;

        while (moneyNeededForTrip > accountBalance && daysMoneySpent < 5)
        {
            string whatToDoWithMoney = Console.ReadLine();
            double moneyToBeSpentOrSaved = double.Parse(Console.ReadLine());

            totalDaysCount++;

            if (whatToDoWithMoney == "save")
            {
                accountBalance += moneyToBeSpentOrSaved;
                daysMoneySpent = 0;
            }
            else if (whatToDoWithMoney == "spend")
            {
                accountBalance -= moneyToBeSpentOrSaved;

                if (accountBalance < 0)
                {
                    accountBalance = 0;
                }

                daysMoneySpent++;
            }
        }

        if (accountBalance >= moneyNeededForTrip)
        {
            Console.WriteLine($"You saved the money for {totalDaysCount} days.");
        }

        if (daysMoneySpent == 5)
        {
            Console.WriteLine("You can't save the money.");
            Console.WriteLine(totalDaysCount);
        }
    }
}

