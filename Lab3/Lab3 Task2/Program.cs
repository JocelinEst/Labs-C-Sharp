using System;
class Program
{
    static int Input(string message)
    {
        Console.Write(message);
        string input = Console.ReadLine();

        // Проверка на корректность ввода 
        if (!int.TryParse(input, out int result) || result <= 0)
        {
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
            Console.WriteLine();
            return Input(message); //  вызов метода для повторного ввода
        }

        return result;
    }
    static void Output(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            Console.Write("[" + i + "]" + "\t");

        }
        Console.WriteLine();
        for (int i = 0; i < nums.Length; i++)
        {
            Console.Write(nums[i] + "\t");
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
    static int GeometricMean(int[] nums)
    {
        int GeometricMean = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            GeometricMean *= nums[i];
        }
        return Math.Abs(GeometricMean * nums.Length);
    }
    static void Parity(ref int[] nums)
    {
        int first = -1, last = -1; // инициализируем -1, если четных элементов нет
        if (nums.Length > 1)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    first = i;
                    break;
                }
            }
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (nums[i] % 2 == 0)
                {
                    last = i;
                    break;
                }
            }
            int n = nums[first];
            nums[first] = nums[last];
            nums[last] = n;
        }
        //Console.WriteLine(first + "\t" + last);
    }
    public static void Main()
    {

        int len1 = Input("Введите размер первого массива: ");
        int len2 = Input("Введите размер второго массива: ");
        Console.WriteLine();
        int[] nums1 = new int[len1];
        int[] nums2 = new int[len2];
        Random rnd = new Random();

        for (int i = 0; i < len1; i++)
        {
            nums1[i] = rnd.Next(-10, 10);
        }
        for (int i = 0; i < len2; i++)
        {
            nums2[i] = rnd.Next(-10, 10);
        }
        Console.WriteLine("Первый массив:");
        Output(nums1);
        Console.WriteLine("Второй массив:");
        Output(nums2);
        Console.WriteLine();
        Console.WriteLine($"Среднее геометрическое первого массива: {GeometricMean(nums1)}");
        Console.WriteLine($"Среднее геометрическое второго массива: {GeometricMean(nums2)}");
        Console.WriteLine();
        if (GeometricMean(nums1) >= GeometricMean(nums2))
        {
            Console.WriteLine("Измененный первый массив: ");
            Parity(ref nums1);
            Output(nums1);
        }
        else
        {
            Console.WriteLine("Измененный второй массив: ");
            Parity(ref nums2);
            Output(nums2);
        }


    }
}
