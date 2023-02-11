// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int Hello(string mesg)
{
    Console.WriteLine(mesg);
    int.TryParse(Console.ReadLine(), out int numbers);
    return numbers;
}

int[] NewArray(int Leght, int minValue, int maxValue)
{
    int[] array = new int[Leght];
    Random random = new Random();
    for (int i = 0; i < Leght; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }
    return array;
}

int Leght = Hello("Длинна массива: ");
int minValue = Hello("Минимальное число: ");
int maxValue = Hello("Максимальное число: ");
int[] array = NewArray(Leght, minValue, maxValue);
List<int> write = array.ToList();
write.ForEach(Console.WriteLine);
