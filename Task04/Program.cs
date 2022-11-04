// Напишите программу, которая:
// 1. Принимает на вход три числа 
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
// 2. Выдаёт максимальное из этих чисел.

Console.Write("Введите целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
//  Convert.ToInt32(Console.ReadLine())
Console.Write("Введите целое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int num_max = 0;
if (num1 > num_max)
{ num_max = num1; }
if (num2 > num_max)
{ num_max = num2; }
if (num3 > num_max)
{num_max = num3;}
Console.Write($"Максимальное число: {num_max}");