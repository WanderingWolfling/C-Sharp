//  Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[10];
        Random rand = new Random();

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rand.Next(100, 1000);
        }

        int evenCount = 0;
        Console.Write("Array: [ ");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
            if (number % 2 == 0)
            {
                evenCount++;
            }
        }
        Console.Write("]\n");

        Console.WriteLine("Number of even numbers: " + evenCount);
    }
}

// В этом коде мы используем класс Random для генерации случайных трехзначных чисел и сохраняем их в массив numbers. 
// Затем мы перебираем все числа в массиве, печатаем каждое число и, если оно четное, увеличиваем переменную evenCount на 1.
//  В конце мы выводим количество четных чисел на экран с помощью метода Console.WriteLine().