﻿namespace _03EvenOrOdd;
class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        //Condition

        if (number % 2 == 0)
        {
            Console.WriteLine("even");
        }
        else
        {
            Console.WriteLine("odd");
        }
    }
}

