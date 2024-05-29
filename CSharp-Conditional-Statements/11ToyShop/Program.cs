namespace _11ToyShop;
class Program
{
    static void Main(string[] args)
    {
        const decimal PuzzlePrice = 2.60m;
        const decimal TalkingDollPrice = 3.00m;
        const decimal TeddyBearPrice = 4.10m;
        const decimal MignonPrice = 8.20m;
        const decimal TruckPrice = 2.00m;

        decimal tripPrice = decimal.Parse(Console.ReadLine());
        int puzzleCount = int.Parse(Console.ReadLine());
        int talkingDollCount = int.Parse(Console.ReadLine());
        int teddyBearCount = int.Parse(Console.ReadLine());
        int mignonCount = int.Parse(Console.ReadLine());
        int truckCount = int.Parse(Console.ReadLine());

        int totalToysCount = puzzleCount + talkingDollCount
        + teddyBearCount + mignonCount + truckCount;

        decimal totalPuzzlePrice = puzzleCount * PuzzlePrice;
        decimal totalTalkingDollPrice = talkingDollCount * TalkingDollPrice;
        decimal totalTeddyBearPrice = teddyBearCount * TeddyBearPrice;
        decimal totalMignonPrice = mignonCount * MignonPrice;
        decimal totalTruckPrice = truckCount * TruckPrice;
        decimal totalPrice = totalPuzzlePrice
                             + totalTalkingDollPrice
                             + totalTeddyBearPrice
                             + totalMignonPrice
                             + totalTruckPrice;

        decimal discount = totalPrice * 0.25m;
        decimal priceAfterDiscount = totalPrice - discount;

        if (totalToysCount >= 50)
        {
            decimal shopRent = priceAfterDiscount * 0.1m;
            decimal remainingMoney = priceAfterDiscount - shopRent;

            if (remainingMoney >= tripPrice)
            {
                Console.WriteLine($"Yes! {remainingMoney - tripPrice:F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {tripPrice - remainingMoney:F2} lv needed.");
            }
        }

        if (totalToysCount >= 0 && totalToysCount < 50)
        {
            decimal shopRent = totalPrice * 0.1m;
            decimal remainingMoney = totalPrice - shopRent;

            if (remainingMoney >= tripPrice)
            {
                Console.WriteLine($"Yes! {remainingMoney - tripPrice:F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {tripPrice - remainingMoney:F2} lv needed.");
            }
        }
    }
}

