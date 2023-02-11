// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число");
int.TryParse(Console.ReadLine(), out int number);
Console.WriteLine(CalcNumbs(number));


int CalcNumbs(int number)
{
    int calc = 0;
    while (number > 0)
    {
        calc += number % 10;
        number = number / 10;
    }

    return calc;
}



// int CalculateNumbers(int number)
// {
//   int count = 0;

//   while (number > 0) 
//   {
//     number /= 10;
//     count++;
//   }

//   return count;
// }