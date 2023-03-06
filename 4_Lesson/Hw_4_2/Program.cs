// //Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Clear();
System.Console.WriteLine("Введите число: ");
int A = int.Parse(Console.ReadLine()!);

int SumNum(int a)
{
   int sum = 0;
    while(a > 0)
    {
        sum += a %10;
        a /=10;
    }  
    return sum;
}
int result = SumNum(A);
Console.WriteLine("Ответ: " + result);