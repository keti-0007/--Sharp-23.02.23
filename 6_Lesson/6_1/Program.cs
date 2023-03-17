// // 1. Напишите программу, которая принимает на вход три числа
// и проверяет, может ли существовать треугольник с сторонами такой длины.


void Triangle(int A, int B, int C)
{
    if (A < B + C && B < A + C && C < A + B)
        System.Console.WriteLine("Да");

    else
        System.Console.WriteLine("Нет");

}
System.Console.WriteLine("Введите первое значение:");
int a = int.Parse(Console.ReadLine()!);

System.Console.WriteLine("Введите второе значение:");
int b = int.Parse(Console.ReadLine()!);

System.Console.WriteLine("Введите третье значение:");
int c = int.Parse(Console.ReadLine()!);


Triangle(a, b, c);