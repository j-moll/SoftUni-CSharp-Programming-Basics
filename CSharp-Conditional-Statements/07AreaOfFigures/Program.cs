namespace _07AreaOfFigures;
class Program
{
    static void Main(string[] args)
    {
        string figure = Console.ReadLine();

        if (figure == "square")
        {
            double side = double.Parse(Console.ReadLine());
            double areaOfSqr = side * side;
            Console.WriteLine($"{areaOfSqr:F3}");
        }
        else if (figure == "rectangle")
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            double areaOfRectangle = sideA * sideB;
            Console.WriteLine($"{areaOfRectangle:F3}");
        }
        else if (figure == "triangle")
        {
            double baseOfTriangle = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double areaOfTriangle = baseOfTriangle * height / 2;
            Console.WriteLine($"{areaOfTriangle:F3}");
        }
        else if (figure == "circle")
        {
            double radius = double.Parse(Console.ReadLine());
            double areaOfCircle = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"{areaOfCircle:F3}");
        }
    }
}

