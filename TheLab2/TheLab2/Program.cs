using System;
using System.Diagnostics.Eventing.Reader;

internal class Program
{
    private static void Main(string[] args)
    {
        double a, b, c;
        Console.WriteLine("Введите длину первой стороны треугольника");
        a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите длину второй стороны треугольника");
        b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите длину третьей стороны треугольника");
        c = Convert.ToDouble(Console.ReadLine());


        if (a + b > c && a + c > b && c + b > a)
        {
            Console.WriteLine("Данный треугольник существует и");
            if (a == b || a == c || b == c)
            {
                Console.WriteLine("он является равнобедренным");
            }
            else
                Console.WriteLine("он не является равнобедренным.");
        }
        else
            Console.WriteLine("Данный треугольник не может существовать!");
    }
}