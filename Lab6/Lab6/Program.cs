using Lab6;
using System;
using System.Collections.Generic;
using System.Drawing;


namespace Lab6
{
    class Program
    {
        static List<Point> figures = new List<Point>();
        static double Input(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            if (!double.TryParse(input, out double res))
            {
                Console.WriteLine("Неккоректный ввод, введите заново");
                return Input(message);
            }
            else { return res; }
        }
        static double InputRadius(string message)
        {

            Console.Write(message);
            string input = Console.ReadLine();
            if (!double.TryParse(input, out double res) || res <= 0)
            {
                Console.WriteLine("Неккоректный ввод, введите заново");
                return Input(message);
            }
            else { return res; }
        }

        static void AddTOList()
        {
            int m = 1;
            do
            {

                bool ism = false;
                do
                {

                    try
                    {
                        Console.WriteLine("        Введите номер класса обьекты , который хотите добавить:");
                        Console.WriteLine("1 - Точка");
                        Console.WriteLine("2 - Окружность");
                        Console.WriteLine("3 - Эллипс");
                        Console.WriteLine("4 - Вывод списка");
                        Console.WriteLine("5 - Выход");
                        m = Convert.ToInt32(Console.ReadLine());
                        if (m < 1 || m > 5)
                        {
                            throw new FormatException();
                        }
                        ism = true;

                    }
                    catch (FormatException)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Неверный ввод. Введите заново.");
                        Console.WriteLine();
                    }

                } while (!ism);
                switch (m)
                {
                    case 1:
                        Point point = new Point(Input("Введите координату X: "), Input("Введите координату Y:"));
                        figures.Add(point);
                        break;
                    case 2:
                        Circle circle = new Circle(Input("Введите координату X: "), Input("Введите координату Y:"), InputRadius("Введите радиус окружности: "));
                        figures.Add(circle);
                        break;
                    case 3:
                        Ellipse ellipse = new Ellipse(Input("Введите координату X: "), Input("Введите координату Y:"), InputRadius("Введите первый радиус: "), InputRadius("Введите второй радиус"));
                        figures.Add(ellipse);
                        break;
                    case 4:
                        for (int i = 0; i < figures.Count; i++)
                        {
                            figures[i].Print();
                            Console.WriteLine();
                        }
                        break;
                    case 5:
                        break;


                }

            } while (m < 5);
        }
        static void Delete()
        {
            if (figures.Count == 0)
            {
                Console.WriteLine("На данный момент в списке нет ни одного объекта.");
                return;
            }

            Console.WriteLine("Введите порядковый номер элемента на удаление: ");
            Console.Write("Доступные номера на удаление: ");
            for (int i = 0; i < figures.Count; i++)
            {
                Console.Write($"{i + 1} ");
            }
            Console.WriteLine();

            int number;
            bool validInput = false;

            while (!validInput)
            {
                string input = Console.ReadLine();

                if (!int.TryParse(input, out number) || number <= 0 || number > figures.Count)
                {
                    Console.WriteLine("Некорректный ввод, введите заново");
                }
                else
                {
                    validInput = true;
                    figures.RemoveAt(number - 1);
                    Console.WriteLine($"Элемент с номером {number} был успешно удален.");
                }
            }
        }
        static void Edit()
        {
            if (figures.Count == 0)
            {
                Console.WriteLine("На данный момент в списке нет ни одного обьекта.");
                return;
            }




            Console.WriteLine("Введите порядковый номер элемента для корректировки: ");
            Console.Write("Доступные номера:");
            for (int i = 0; i < figures.Count; i++) Console.Write($"{i + 1} ");
            Console.WriteLine();
            string input = Console.ReadLine();

            bool edit = false;
            int number;



            do
            {
                if (!int.TryParse(input, out number) || number <= 0 || number > figures.Count)
                {
                    Console.WriteLine("Некорректный ввод, введите заново");
                    input = Console.ReadLine(); // Запрашиваем ввод снова
                }
                else
                {
                    edit = true;
                    number--; // Приводим к индексу
                }
            } while (!edit);
            figures[number].Print();

            string inputChoice;
            if (figures[number] is Point)
            {
                int choice = 0;
                bool editChoice = false;
                while (!editChoice)
                {
                    Console.WriteLine("          Что вы хотите изменить?");
                    Console.WriteLine("1 - Координата X");
                    Console.WriteLine("2 - Координата Y");
                    Console.WriteLine("3 - Все поля");
                    Console.WriteLine("4 - Выход");
                    if (int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= 6)
                    {
                        editChoice = true;

                    }
                    else
                    {
                        Console.WriteLine("Некорректный ввод, введите заново");
                    }
                }
                switch (choice)
                {
                    case 1:
                        figures[number].X = Input("Введите новое значение координаты X: ");
                        break;
                    case 2:
                        figures[number].Y = Input("Введите новое значение координаты Y: ");
                        break;
                    case 3:
                        figures[number].X = Input("Введите новое значение координаты X: ");
                        figures[number].X = Input("Введите новое значение координаты Y: ");
                        break;
                    case 4:
                        break;

                }
            }
            else if (figures[number] is Circle circle)
            {
                int choice = 0;
                bool editChoice = false;
                while (!editChoice)
                {
                    Console.WriteLine("          Что вы хотите изменить?");
                    Console.WriteLine("1 - Координата X");
                    Console.WriteLine("2 - Координата Y");
                    Console.WriteLine("3 - Первый радиус");
                    Console.WriteLine("4 - Все поля");
                    Console.WriteLine("5 - Выход");


                    if (int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= 6)
                    {
                        editChoice = true;

                    }
                    else
                    {
                        Console.WriteLine("Некорректный ввод, введите заново");
                    }

                }
                switch (choice)
                {
                    case 1:
                        circle.X = Input("Введите новое значение координаты X: ");
                        break;
                    case 2:
                        circle.Y = Input("Введите новое значение координаты Y: ");
                        break;
                    case 3:
                        circle.Radius = InputRadius("Введите новое значение Радиуса: ");
                        break;
                    case 4:
                        circle.X = Input("Введите новое значение координаты X: ");
                        circle.Y = Input("Введите новое значение координаты Y: ");
                        circle.Radius = InputRadius("Введите новое значение Радиуса: ");
                        break;
                    case 5:
                        break;
                }
            }
            else if (figures[number] is Ellipse ellipse)
            {
                int choice = 0;
                bool editChoice = false;
                while (!editChoice)
                {
                    Console.WriteLine("Что вы хотите изменить?");
                    Console.WriteLine("1 - Координата X");
                    Console.WriteLine("2 - Координата Y");
                    Console.WriteLine("3 - Первый радиус");
                    Console.WriteLine("4 - Второй радиус");
                    Console.WriteLine("5 - Все поля");
                    Console.WriteLine("6 - Выход");

                    if (int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= 6)
                    {
                        editChoice = true;

                    }
                    else
                    {
                        Console.WriteLine("Некорректный ввод, введите заново");
                    }
                }
                switch (choice)
                {
                    case 1:
                        ellipse.X = Input("Введите новое значение координаты X: ");
                        break;
                    case 2:
                        ellipse.Y = Input("Введите новое значение координаты Y: ");
                        break;
                    case 3:
                        ellipse.Radius = InputRadius("Введите новое значение Первого радиуса: ");
                        break;
                    case 4:
                        ellipse.SecondRadius = InputRadius("Введите новое значение Второго радиуса: ");
                        break;
                    case 5:
                        ellipse.X = Input("Введите новое значение координаты X: ");
                        ellipse.Y = Input("Введите новое значение координаты Y: ");
                        ellipse.Radius = InputRadius("Введите новое значение Первого радиуса: ");
                        ellipse.SecondRadius = InputRadius("Введите новое значение Второго радиуса: ");
                        break;
                    case 6:
                        break;
                }
            }








        }
        static void Show()
        {
            for (int i = 0; i < figures.Count; i++)
            {
                Console.WriteLine($"Порядковый номер обьекта: {i + 1}");
                Console.WriteLine("----------------------------------");
                figures[i].Print();
                Console.WriteLine();
                Console.WriteLine();
            }
        }
        static void Main()
        {
            Point point = new Point(1, 2);
            figures.Add(point);
            Circle circle = new Circle(1, 2, 3);
            figures.Add(circle);
            Circle ellipse = new Ellipse(1, 2, 3, 2);
            figures.Add(ellipse);
            Ellipse ellipse2 = new Ellipse(32, 34, 5, 6);
            figures.Add(ellipse2);

            bool isChoice = false;
            int choice;

            do
            {
                Console.WriteLine("               Меню");
                Console.WriteLine("1 - Вывод списка");
                Console.WriteLine("2 - Удаление объекта");
                Console.WriteLine("3 - Добавление объекта");
                Console.WriteLine("4 - Изменение объекта");
                Console.WriteLine("5 - Выход");

                // Проверяем ввод пользователя
                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 5)
                {
                    Console.WriteLine("Некорректный ввод, введите заново");
                }

                switch (choice)
                {
                    case 1:
                        Show();
                        break;
                    case 2:
                        Delete();
                        break;
                    case 3:
                        AddTOList();
                        break;
                    case 4:
                        Edit();
                        break;
                    case 5:
                        Console.WriteLine("Выход из программы.");
                        break;
                }

            } while (choice != 5);

            Console.ReadKey();
        }


    }
}


