using System;

class Triangle
{
    static void Main()
    {
        Console.WriteLine("Введите длины сторон треугольника:");

        Console.Write("Сторона a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Сторона b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Сторона c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        if (a <= 0 || b <= 0 || c <= 0)
        {
            Console.WriteLine("Ошибка: длины сторон должны быть положительными числами.");
            return;
        }

        if (a + b <= c || a + c <= b || b + c <= a)
        {
            Console.WriteLine("Ошибка: сумма двух сторон должна быть больше третьей стороны.");
            return;
        }

        if (a == b && b == c)
        {
            Console.WriteLine("Треугольник равносторонний.");
        }
        else if (a == b || a == c || b == c)
        {
            Console.WriteLine("Треугольник равнобедренный.");
        }
        else
        {
            Console.WriteLine("Треугольник разносторонний.");
        }
    }
}
