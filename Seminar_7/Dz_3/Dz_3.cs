// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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


void FindAverage(int[,] array)
{
    double result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result += j;
        }
        Console.WriteLine(result / array.GetLength(1));
        ;
    }

}


int[,] array = CreateTwoDimensionArray(ReadInt("First Length"), ReadInt("Second Length"));
Console.WriteLine(TwoDimensionArrayToString(array));
// Console.WriteLine(FindTwoDimensionArray(array, ReadInt("Row:"), ReadInt("Colums:")));
FindAverage(array);