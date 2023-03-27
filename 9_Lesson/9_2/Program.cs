// Задача 2: Задайте значения M и N. Напишите программу, которая
// рекурсивно выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"



void NumsFromTo(int M, int N)
{
    if (M > N) return;
    NumsFromTo(M, N - 1);
    System.Console.Write($"{N}, ");
}
System.Console.Write("Введите первое число: ");
int Num = int.Parse(Console.ReadLine()!);
System.Console.Write("Введите второе число: ");
int Num2 = int.Parse(Console.ReadLine()!);


NumsFromTo(Num, Num2);

//                    2вариант

// void NumsFromTo(int M, int N)
// {
//     if (M == N + 1) return;
//     NumsFromTo(M, N - 1);
//     System.Console.Write($"{N}, ");
// }
// System.Console.Write("Введите первое число: ");
// int Num = int.Parse(Console.ReadLine()!);
// System.Console.Write("Введите второе число: ");
// int Num2 = int.Parse(Console.ReadLine()!);


// NumsFromTo(Num, Num2);

