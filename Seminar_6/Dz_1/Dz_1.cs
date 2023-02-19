// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

class PositiveNumbersCounter
{
    static void Main()
    {
        Console.Write("Enter the number of values to input: ");
        int M = int.Parse(Console.ReadLine());

        int positiveCount = 0;

        for (int i = 1; i <= M; i++)
        {
            Console.Write("Enter value #" + i + ": ");
            int value = int.Parse(Console.ReadLine());

            if (value >= 0)
            {
                positiveCount++;
            }
        }

        Console.WriteLine("Number of positive values: " + positiveCount);
    }
}
// В этом коде мы создаем отдельный класс PositiveNumbersCounter, в котором определяем метод Main() без параметров.
// Затем мы запрашиваем у пользователя количество чисел, которые он хочет ввести, и сохраняем это значение в переменной M. 
// Затем мы запускаем цикл for, который просит пользователя ввести каждое число по очереди и проверяет, является ли каждое число положительным.
// Если число больше 0, мы увеличиваем переменную positiveCount на 1. В конце мы выводим количество положительных чисел на экран с помощью метода
// Console.WriteLine().