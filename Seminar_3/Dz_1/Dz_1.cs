// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.WriteLine("Введите пятизначное число");
string num = Console.ReadLine();
string rev = string.Concat(num.Reverse()); //КАК Я С ЭТИМ НАМУЧАЛСЯ
Console.WriteLine(num == rev ? "палиндром" : "не палиндром");

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
