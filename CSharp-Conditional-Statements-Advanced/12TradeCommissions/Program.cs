﻿namespace _12TradeCommissions;
class Program
{
    static void Main(string[] args)
    {
        string city = Console.ReadLine();
        double sales = double.Parse(Console.ReadLine());

        double commission = 0;
        bool isError = false;


        if (city == "Sofia")
        {
            if (sales >= 0 && sales <= 500)
            {
                commission = 5;
            }
            else if (sales > 500 && sales <= 1000)
            {
                commission = 7;
            }
            else if (sales > 1000 && sales <= 10000)
            {
                commission = 8;
            }
            else if (sales > 10000)
            {
                commission = 12;
            }
            else
            {
                isError = true;
                Console.WriteLine("error");
            }
        }
        else if (city == "Varna")
        {
            if (sales >= 0 && sales <= 500)
            {
                commission = 4.5;
            }
            else if (sales > 500 && sales <= 1000)
            {
                commission = 7.5;
            }
            else if (sales > 1000 && sales <= 10000)
            {
                commission = 10;
            }
            else if (sales > 10000)
            {
                commission = 13;
            }
            else
            {
                isError = true;
                Console.WriteLine("error");
            }
        }
        else if (city == "Plovdiv")
        {

            if (sales >= 0 && sales <= 500)
            {
                commission = 5.5;
            }
            else if (sales > 500 && sales <= 1000)
            {
                commission = 8;
            }
            else if (sales > 1000 && sales <= 10000)
            {
                commission = 12;
            }
            else if (sales > 10000)
            {
                commission = 14.5;
            }
            else
            {
                isError = true;
                Console.WriteLine("error");
            }
        }
        else
        {
            isError = true;
            Console.WriteLine("error");
        }

        if (!isError)
        {
            double finalcommission = sales * commission / 100;

            Console.WriteLine($"{finalcommission:F2}");
        }
    }
}

