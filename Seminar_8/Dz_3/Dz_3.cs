// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


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


if (matrix1.GetLength(1) != matrix2.GetLength(0))
{
    Console.WriteLine("Невозможно выполнить умножение матриц");
}
else
{
    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }

    Console.WriteLine("Результат умножения двух матриц:");

    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            Console.Write(resultMatrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] array_1 = CreateTwoDimensionArray(ReadInt("First Length"), ReadInt("Second Length"));
Console.WriteLine("U create Array!");
int[,] array_2 = CreateTwoDimensionArray(ReadInt("First Length"), ReadInt("Second Length"));
Console.WriteLine("U create Array!");
Console.WriteLine(TwoDimensionArrayToString(array_1));
Console.WriteLine(TwoDimensionArrayToString(array_2));