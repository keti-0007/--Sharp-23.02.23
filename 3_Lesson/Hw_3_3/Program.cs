
// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.Clear();
System.Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
int i = 1;

void Div(int num)
{
    while( num >= i)
    {
        System.Console.WriteLine(Math.Pow(i , 3));
        i++;
    }

}

Div(N);