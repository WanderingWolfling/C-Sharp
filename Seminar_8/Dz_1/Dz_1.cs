// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


int ReadInt(string arg)
{
    Console.Write($"Input {arg}: ");
    int result = 0;

    while (!int.TryParse(Console.ReadLine(), out result))
    {
        Console.Write("Try again! ");
    }

    return result;
}

int[,] CreateTwoDimensionArray(int firstLength, int secondLength)
{
    int[,] result = new int[firstLength, secondLength];
    Random rand = new Random();

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = rand.Next(0, 10);
        }
    }

    return result;
}
//Взято с прошлых дз

int[,] SortArray(int[,] array)
{
    // Проходимся по каждой строке массива
    for (int i = 0; i < array.GetLength(0); i++)
    {
        // Создаем временный массив для сортировки
        int[] temp = new int[array.GetLength(1)];

        // Копируем элементы строки во временный массив
        for (int j = 0; j < array.GetLength(1); j++)
        {
            temp[j] = array[i, j];
        }

        // Сортируем временный массив в порядке убывания
        Array.Sort(temp);
        Array.Reverse(temp);

        // Копируем отсортированные элементы из временного массива обратно в исходный массив
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = temp[j];
        }

    }
    return array;
}

string TwoDimensionArrayToString(int[,] array)
{
    string result = string.Empty;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result += $"{array[i, j]} ";
        }

        result += Environment.NewLine;
    }

    return result;
}

int[,] array = CreateTwoDimensionArray(ReadInt("First Length"), ReadInt("Second Length"));
Console.WriteLine(TwoDimensionArrayToString(array));
// Console.WriteLine(FindTwoDimensionArray(array, ReadInt("Row:"), ReadInt("Colums:")));
SortArray(array);
Console.WriteLine(TwoDimensionArrayToString(array));
