using System;
class Program
{

    static double Input(string message)
    {
        Console.Write(message);
        string input = Console.ReadLine();

        // Проверка на корректность ввода 
        if (!double.TryParse(input, out double result))
        {
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
            Console.WriteLine();
            return Input(message); //  вызов метода для повторного ввода
        }

        return result;
    }
    static double InputRadius(string message)
    {
        Console.Write(message);


        // Проверка на корректность ввода 
        if (!double.TryParse(Console.ReadLine(), out double result) || result <= 0)
        {
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
            Console.WriteLine();
            return InputRadius(message); //  вызов метода для повторного ввода
        }

        return result;

    }
    static void Intersection(double r1, double r2, double x1, double x2, double y1, double y2)
    {
        double distance = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
        if (distance < r1 + r2 && distance > Math.Abs(r1 - r2))
        {
            Console.WriteLine("Окружности пересекаются.");
        }
        else { Console.WriteLine("Окружности не пересекаются."); }
    }
    public static void Main()
    {
        double R1, R2;
        double x1, x2;
        double y1, y2;
        Console.WriteLine("Заполните данные первой окружности: ");

        R1 = InputRadius("Введите радиус: ");
        x1 = Input("Введите координату x центра:");
        y1 = Input("Введите координату y центра:");
        Console.WriteLine();
        Console.WriteLine("Заполните данные второй окружности: ");
        R2 = InputRadius("Введите радиус: ");
        x2 = Input("Введите координату x центра:");
        y2 = Input("Введите координату y центра:");
        Console.WriteLine();
        Intersection(R1, R2, x1, x2, y1, y2);
    }

}
