// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные
//натуральные числа в промежутке от M до N с помощью рекурсии.

// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"


void EvenNum(int m, int n)
{
    if (m > n) return;
    if (m % 2 == 0)
    {
        Console.Write($"{m}, ");
    }
    EvenNum(m + 1, n);
}

System.Console.Write("Введите значение М: ");
int M = int.Parse(Console.ReadLine()!);
System.Console.Write("Введите значение N: ");
int N = int.Parse(Console.ReadLine()!);

EvenNum(M, N);

