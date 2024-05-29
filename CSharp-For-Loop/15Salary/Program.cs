namespace _15Salary;
class Program
{
    static void Main(string[] args)
    {
        int openTabsCount = int.Parse(Console.ReadLine());
        double salary = double.Parse(Console.ReadLine());

        for (int i = 0; i <= openTabsCount; i++)
        {
            string websiteName = Console.ReadLine();

            if (websiteName == "Facebook")
            {
                salary -= 150;
            }
            else if (websiteName == "Instagram")
            {
                salary -= 100;
            }
            else if (websiteName == "Reddit")
            {
                salary -= 50;
            }

            if (salary <= 0)
            {
                break;
            }
        }

        if (salary > 0)
        {
            Console.WriteLine(salary);
        }
        else
        {
            Console.WriteLine("You have lost your salary.");
        }
    }
}

