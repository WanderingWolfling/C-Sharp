// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.WriteLine("Введите пятизначное число");
string num = Console.ReadLine();
string rev = string.Concat(num.Reverse()); //КАК Я С ЭТИМ НАМУЧАЛСЯ. Обьясните почему оно не работает без контакт, я не понимаю

if (num.Length < 5 || num.Length > 5)
{
    Console.WriteLine($"Читай условие задачи, умник");
}
else if (num == rev)
{
    Console.WriteLine($"Это палиндром. (Помолись богу за автора, он так намучался)");
}
else
{
    Console.WriteLine($"Это не палиндром.");
}


// string ex_1 = "LOL";
// string ex_2 = "LOL";



// if (string.Compare(ex_1, ex_2))
// {
//     Console.WriteLine($"Полиндром");
// }
// else
// {
//     Console.WriteLine($"Not Полиндром");
// }
