// // 1. Напишите программу, которая принимает
//    на вход число и выдаёт количество цифр в числе.
//
int LengthNum(int num)
{
    int a = 0;
    for (int i = 1; num > 0; i++)
    {
        num = num /10;
        a++;
    }
    return a;
}

System.Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int result = LengthNum(num);
System.Console.WriteLine(result);