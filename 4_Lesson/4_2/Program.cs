//// 2. Напишите программу, которая принимает на вход
//    число N и выдаёт произведение чисел от 1 до N.


int CompositionNum(int num)
{
    int mutiply = 1;
    for(int i = 1; num >= i; i++)
        mutiply *= i;

    return mutiply;
}
System.Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
int result = CompositionNum(N);
Console.WriteLine(result);


