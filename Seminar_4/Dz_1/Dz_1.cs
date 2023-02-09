// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


System.Console.WriteLine("Введите число");
int.TryParse(Console.ReadLine(), out int a);

System.Console.WriteLine("Введите степень");
int.TryParse(Console.ReadLine(), out int b);

System.Console.WriteLine(Math.Pow(a, b));



// while (b <= a)
// {
//     System.Console.WriteLine(Math.Pow(b, 3));
//     b++;
// }