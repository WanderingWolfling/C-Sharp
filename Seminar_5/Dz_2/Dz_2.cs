//  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


class Program
{
    static void Main(string[] args)
    {
        // Создание генератора случайных чисел.
        Random rnd = new Random();

        // Создание массива из 10 случайных чисел.
        int[] arr = new int[10];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(100);
        }

        // Вывод исходного массива.
        Console.WriteLine("Исходный массив: ");
        foreach (int elem in arr)
        {
            Console.Write(elem + " ");
        }

        // Нахождение суммы элементов на нечётных позициях.
        int sum = 0;
        for (int i = 1; i < arr.Length; i += 2)
        {
            sum += arr[i];
        }

        Console.WriteLine("Сумма элементов на нечётных позициях: " + sum);
    }
}