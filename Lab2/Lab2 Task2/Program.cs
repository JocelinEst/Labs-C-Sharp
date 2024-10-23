using System;

public class MainClass
{
    public static void Main()
    {
        bool proccess = false;
        while (!proccess)
        {
            try
            {
                int col;
                int row;
                string str;

                Console.Write("Введите количество строк: ");
                str = Console.ReadLine();

                while (!int.TryParse(str, out row) || row <= 0)
                {
                    Console.WriteLine("Ошибка! Введите целое положительное число.");
                    str = Console.ReadLine();
                }

                row = Convert.ToInt32(str);
                Console.Write("Введите количество столбцов: ");
                str = Console.ReadLine();

                while (!int.TryParse(str, out col) || col <= 0)
                {
                    Console.WriteLine("Ошибка! Введите целое положительное число.");
                    str = Console.ReadLine();
                }

                col = Convert.ToInt32(str);

                int[,] numbers = new int[row, col];
                Random rnd = new Random();

                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        numbers[i, j] = rnd.Next(-100, 100);
                    }
                }

                // 1. Вывод исходной матрицы

                Console.WriteLine("Двумерный массив: ");
                Console.WriteLine();
                Console.Write("      ");
                for (int i = 0; i < col; i++)
                {
                    Console.Write("[ " + i + " ]\t");
                }
                Console.WriteLine();
                for (int i = 0; i < row; i++)
                {
                    Console.Write("[ " + i + " ]\t");
                    for (int j = 0; j < col; j++)
                    {
                        Console.Write(numbers[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine();




                // 2. Вычисление минимумов в каждом столбце и окрашивание
                Console.WriteLine();
                Console.WriteLine("Двумерный массив с минимальными элементами:");
                Console.WriteLine();
                Console.Write("      ");

                int[,] indexMin = new int[col, 2]; //Массив для хранения индексов минимальных элементов
                int[] min = new int[col];  //Массив для хранения минимальных элементов

                //Заполнение массива минимумов 
                for (int i = 0; i < col; i++)
                {
                    min[i] = 101;
                }

                //Заполнение массива индексов и массива минимальных элементов
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        if (numbers[i, j] < min[j])
                        {
                            min[j] = numbers[i, j];
                            indexMin[j, 0] = i;
                            indexMin[j, 1] = j;
                        }
                    }
                }
                //Собственно окрашивание
                for (int i = 0; i < col; i++)
                {
                    Console.Write("[ " + i + " ]\t");
                }
                Console.WriteLine();

                for (int i = 0; i < row; i++)
                {

                    Console.Write("[ " + i + " ]\t");
                    for (int j = 0; j < col; j++)
                    {

                        if ((i == indexMin[j, 0]) && (j == indexMin[j, 1]))
                        {

                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.Write(numbers[i, j] + "\t");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.Write(numbers[i, j] + "\t");
                        }
                    }

                    Console.WriteLine();
                    proccess = true;
                }

            }
            catch { Console.WriteLine("Массив оказался слишком большим"); }

        }

    }
}
