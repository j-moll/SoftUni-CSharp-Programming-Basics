namespace _15Moving;
class Program
{
    static void Main(string[] args)
    {
        int roomWidth = int.Parse(Console.ReadLine());
        int roomHeight = int.Parse(Console.ReadLine());
        int roomLenght = int.Parse(Console.ReadLine());
        int wholeRoomSpace = roomHeight * roomLenght * roomWidth;

        while (wholeRoomSpace > 0)
        {
            string input = Console.ReadLine();

            if (input == "Done")
            {
                break;
            }
            int boxesCount = int.Parse(input);
            wholeRoomSpace -= boxesCount;
        }

        if (wholeRoomSpace > 0)
        {
            Console.WriteLine($"{wholeRoomSpace} Cubic meters left.");
        }
        else
        {
            Console.WriteLine($"No more free space! You need {Math.Abs(wholeRoomSpace)} Cubic meters more.");
        }
    }
}

