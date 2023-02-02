// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Введите трёхзначное число:");
int.TryParse(Console.ReadLine(), out int a);
string text = a.ToString();

if (text.Length > 3 || text.Length < 3)
{
    Console.WriteLine($"Введи трёхзначное число, братан, моя твоя не понимать. {text} - не трёхзначное число");

}
else
{
    int find = 2;
    char found_text = text[find];
    Console.WriteLine($"{found_text} -> трёхзначное число");
}



// Console.WriteLine($"{text}");