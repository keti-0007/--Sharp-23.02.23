// 3. Напишите программу, которая будет принимать на вход число
//    и возвращать сумму его цифр. Использовать рекурсию.


int SumDigits(int M)
{
    if (M == 0) return 0;
    return SumDigits(M / 10) + M % 10;
}
System.Console.Write("Введите число: ");
int Num = int.Parse(Console.ReadLine()!);


int result = SumDigits(Num);
System.Console.WriteLine(result);


// int SumNum(int num)
// {
//     if (num == 0) return 0;
//     return SumNum(num / 10) + num % 10;    
// }

// Console.WriteLine(SumNum(453));
// Console.WriteLine(SumNum(45));
