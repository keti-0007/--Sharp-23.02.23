﻿//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
// не работает с отрицательными числами :(


Console.Clear();
Console.Write("Введите первое число: ");
int N = int.Parse(Console.ReadLine()!);
int i = 2;

if (N > 1)
{
while (i <= N)
{
Console.Write($" {i} ");
 i= i+2;
}
}

// int num = int.Parse(Console.ReadLine()!);
// int i = 2;

// while(i <= num)
// {
//     Console.Write($"{i} ");
//     i+=2;
// }
