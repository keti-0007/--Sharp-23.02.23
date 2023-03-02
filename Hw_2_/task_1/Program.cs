// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//не add . -->commit -m --> push
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.Clear();
System.Console.WriteLine("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine()!);

int SearchNum(int num)
{
        return num %100/10;
}
int result = SearchNum(num);
System.Console.WriteLine(result);



// II вариант
// System.Console.WriteLine("-->");
// string NumSec(int num)
// {
//         if((-1000 < num && num < -100) || (num < 1000 && num > 100))
//         return $"{num /10 %10}";
//         return "The number is not three-digit!";

// }
// System.Console.WriteLine(NumSec(int.Parse(Console.ReadLine()!)));