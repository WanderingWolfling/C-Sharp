// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6
Console.WriteLine("Введите трёхзначное число:");
int.TryParse(Console.ReadLine(), out int a);
string text = a.ToString();

if (text.Length < 3)
{
    Console.WriteLine($"{a} -> ну тут физически третьей цифры не может быть");

}
else
{
    int find = 2;
    char found_text = text[find];
    Console.WriteLine(found_text);
}



