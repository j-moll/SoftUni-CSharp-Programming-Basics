namespace _09OldBooks;
class Program
{
    static void Main(string[] args)
    {
        string bookName = Console.ReadLine();
        int booksCount = 0;
        bool bookIsFound = false;

        while (true)
        {
            string currentBookName = Console.ReadLine();

            if (currentBookName == bookName)
            {
                bookIsFound = true;
                break;
            }

            if (currentBookName == "No More Books")
            {
                break;
            }
            booksCount++;
        }

        if (bookIsFound)
        {
            Console.WriteLine($"You checked {booksCount} books and found it.");
        }
        else
        {
            Console.WriteLine("The book you search is not here!");
            Console.WriteLine($"You checked {booksCount} books.");
        }
    }
}

