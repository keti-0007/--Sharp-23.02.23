// 1. Задайте значение N. Напишите программу, которая выведет
//    все натуральные числа в промежутке от 1 до N при помощи рекурсии.

void SeriesNum(int N)
{
    if (N == 0) return;
    SeriesNum(N - 1);// вызываем рекурсию (метод). Он движется к 0, поэтому N -1 
    System.Console.Write($"{N}, ");
}
System.Console.Write("Введите число: ");
int Num = int.Parse(Console.ReadLine()!);

SeriesNum(Num);