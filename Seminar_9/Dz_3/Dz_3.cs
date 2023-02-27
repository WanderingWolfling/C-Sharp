// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3->A(m, n) = 9
// m = 3, n = 2->A(m, n) = 29

static void Main(string[] args)
{
    int m = ReadInt("M");
    int n = ReadInt("N");

    int result = AckermannFunction(m, n);

    Console.WriteLine($"A({m}, {n}) = {result}");
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

static int AckermannFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }

    if (m > 0 && n == 0)
    {
        return AckermannFunction(m - 1, 1);
    }

    return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
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
