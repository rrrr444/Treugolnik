using System;

namespace Treugolnik
{
    public class Triangle
    {
        public static (string triangleType, double area) GetTriangleProperties(double a, double b, double c)
        {
            // Проверка корректности ввода
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Длины сторон должны быть положительными числами.");
            }

            if (a + b <= c || a + c <= b || b + c <= a)
            {
                throw new ArgumentException("Сумма двух сторон должна быть больше третьей стороны.");
            }

            // Определение вида треугольника
            string triangleType;
            if (a == b && b == c)
            {
                triangleType = "Равносторонний треугольник";
            }
            else if (a == b || a == c || b == c)
            {
                triangleType = "Равнобедренный треугольник";
            }
            else
            {
                triangleType = "Разносторонний треугольник";
            }

            // Вычисление площади с использованием формулы Герона
            double p = (a + b + c) / 2; // Полупериметр
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c)); // Площадь

            return (triangleType, area);
        }
    }
}
