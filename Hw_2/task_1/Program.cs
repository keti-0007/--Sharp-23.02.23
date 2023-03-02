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
