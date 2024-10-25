using System;
using System.Drawing;


namespace Lab5
{
    class Program
    {
        static void Main()
        {
           
            //Проверка функционала конструкторов и методов для вывода
            Point point = new Point(1, 2);
            point.Print();
            //Проверка функционала свойств
            point.X = 3;
            point.Y = 4; Console.WriteLine($"Координата точки X: {point.X}");
            Console.WriteLine();
            Console.WriteLine();
            Circle circle = new Circle(1, 2, 3);
            circle.Print(); Console.WriteLine();
            Circle ellipse = new Ellipse(1, 2, 3, 2);
            ellipse.Print();
            //Проверка функционала методов для вычисления площади
            Console.WriteLine();
            Console.WriteLine($"Площадь окружности: {circle.Square()}");
            Console.WriteLine($"Площадь эллипса: {ellipse.Square()}");
            Console.WriteLine();
            //Проверка функционала базовых конструкторов
            Point point2 = new Point();
            point2.Print();
            Console.WriteLine();
            Ellipse ellipse2 = new Ellipse(); ellipse2.Print();
            Console.WriteLine(); Circle circle2 = new Circle();
            circle2.Print(); Console.WriteLine();

        }
    }
}

