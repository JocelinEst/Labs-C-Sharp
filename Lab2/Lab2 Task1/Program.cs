using System;

public class MainClass
{
    public static void Main()
    {
        //Размер массива и отказоустойчивость

        Console.WriteLine("Введите размер массива (целое положительное число):");
        int num;
        string str;
        str = Console.ReadLine();

        while (!int.TryParse(str, out num) || num <= 0)
        {
            Console.WriteLine("Ошибка! Введите целое положительное число.");
            str = Console.ReadLine();
        }
        //------------------------------------


        Console.WriteLine("Одномерный массив: ");
        Console.WriteLine();
        int[] numbers = new int[num];
        Random rnd = new Random();


        //Заполнение массива

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rnd.Next(-100, 100);
            Console.WriteLine("[ " + i + " ]   " + numbers[i]);
        }
        //----------------------------------------------


        Console.WriteLine("Одномерный массив (измененный): ");

        //Вывод по заданию

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 0 && numbers[i] < 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("[ " + i + " ]   " + numbers[i]);
                Console.ResetColor();
            }
            else if (numbers[i] % 2 != 0 && numbers[i] < 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[ " + i + " ]   " + numbers[i]);
                Console.ResetColor();
            }
            else { Console.WriteLine("[ " + i + " ]   " + numbers[i]); }
        }
        //----------------------------------------------------------

    }
}