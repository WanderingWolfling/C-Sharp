// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17->такого числа в массиве нет

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

int FindTwoDimensionArray(int[,] array, int row, int column)
{
    int numRows = array.GetLength(0);
    int numColumns = array.GetLength(1);

    if (row >= numRows || column >= numColumns)
    {
        // элемент с указанными позициями выходит за пределы массива
        return -1;
    }

    return array[row - 1, column - 1];
}


int[,] array = CreateTwoDimensionArray(ReadInt("First Length"), ReadInt("Second Length"));
Console.WriteLine(TwoDimensionArrayToString(array));
Console.WriteLine(FindTwoDimensionArray(array, ReadInt("Row:"), ReadInt("Colums:")));
