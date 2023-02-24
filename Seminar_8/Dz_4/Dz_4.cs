// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0, 1, 0)
// 34(1, 0, 0) 41(1, 1, 0)
// 27(0, 0, 1) 90(0, 1, 1)
// 26(1, 0, 1) 55(1, 1, 1)

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

int[,,] CreateTwoDimensionArray(int firstLength, int secondLength, int thirdLength)
{
    int[,,] result = new int[firstLength, secondLength, thirdLength];
    Random rand = new Random();

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < result.GetLength(2); k++)
            {
                result[i, j, k] = rand.Next(0, 10);
            }
        }
    }

    return result;
}

string TwoDimensionArrayToString(int[,,] array)
{
    string result = string.Empty;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                result += $"{array[i, j, k]} ";
            }

        }

        result += Environment.NewLine;
    }
    return result;
}



int[,,] array = CreateTwoDimensionArray(ReadInt("First Length"), ReadInt("Second Length"), ReadInt("Third Length"));
Console.WriteLine("U create Array!");
Console.WriteLine(TwoDimensionArrayToString(array));