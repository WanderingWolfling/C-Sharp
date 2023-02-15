// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


class Program
{
    static void Main(string[] args)
    {
        // Создание массива вещественных чисел.
        double[] arr = new double[] { 3, 7, 22, 2, 78 };

        // Вывод исходного массива.
        Console.WriteLine("Исходный массив: ");
        foreach (double elem in arr)
        {
            Console.Write(elem + " ");
        }

        // Нахождение разницы между максимальным и минимальным элементами массива.
        double max = arr[0];
        double min = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }
        double diff = max - min;

        Console.WriteLine("\nРазница между максимальным и минимальным элементами: " + diff);
    }
}