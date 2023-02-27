// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15-> 120
// M = 4; N = 8. -> 30

static void Main(string[] args)
{
    int m = ReadInt("M");
    int n = ReadInt("N");

    int sum = SumNaturalNumbers(m, n);

    Console.WriteLine($"The sum of natural numbers from {m} to {n} is {sum}");
}

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

static int SumNaturalNumbers(int m, int n)
{
    if (m > n)
    {
        return 0;
    }

    return m + SumNaturalNumbers(m + 1, n);
}

static int ReadInt(string arg)
{
    Console.Write($"Input {arg}: ");
    int result = 0;

    while (!int.TryParse(Console.ReadLine(), out result))
    {
        Console.Write("Try again! ");
    }

    return result;
}
