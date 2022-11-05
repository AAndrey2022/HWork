// Напишите программу, которая:
// 1. на вход принимает число (N), 
// 2. на выходе показывает все чётные числа от 1 до N.

// Например: 5 -> 2, 4
//           8 -> 2, 4, 6, 8

Console.WriteLine("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 0) Console.WriteLine("Введено отрицательное число-Некорректный ввод");
else
{
    int count = 2;
    while (count <= num)
    {
        Console.Write($"{count}. ");
        count+=2;
    }
}

