﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

System.Console.WriteLine("Введите число");

int.TryParse(Console.ReadLine(), out int a);

int b = 1;

while (b <= a)
{
    System.Console.WriteLine(Math.Pow(b, 3));
    b++;
}