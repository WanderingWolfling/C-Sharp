/*Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

int.TryParse(Console.ReadLine(), out int a);
int.TryParse(Console.ReadLine(), out int b);

var max = 0;

if (a > b)
{
    max = a;
}
else
{
    max = b;
}

Console.WriteLine(max);