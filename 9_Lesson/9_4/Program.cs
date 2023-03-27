// Задача 4: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8 

int Degree(int a, int b)
{
    if (b == 0) return 1;
    return a * Degree(a, b - 1);

}
System.Console.Write("Введите первое число: ");
int Num = int.Parse(Console.ReadLine()!);
System.Console.Write("Введите второе число: ");
int Num2 = int.Parse(Console.ReadLine()!);

int result = Degree(Num, Num2);
System.Console.WriteLine(result);


//                          //2 вариант

// double Degree(double a, int b)
// {
//     if (b == 0) return 1;
//     if (b % 2 == 1)
//         return a * Degree(a, b - 1);
//     else
//         return Degree(a * a, b / 2);// быстрый алгоритм возмедения в степень. для чет степени

// }
// System.Console.Write("Введите первое число: ");
// int Num = int.Parse(Console.ReadLine()!);
// System.Console.Write("Введите второе число: ");
// int Num2 = int.Parse(Console.ReadLine()!);

// double result = Degree(Num, Num2);
// System.Console.WriteLine(result);