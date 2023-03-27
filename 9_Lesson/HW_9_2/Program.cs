// Задача 2. Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int SumNum(int m, int n)
{
    if (n == m) return m;
    return n + SumNum(m, n - 1);

}
System.Console.Write("Введите первое число: ");
int Num = int.Parse(Console.ReadLine()!);
System.Console.Write("Введите второе число: ");
int Num2 = int.Parse(Console.ReadLine()!);

int result = SumNum(Num, Num2);
System.Console.WriteLine(result);