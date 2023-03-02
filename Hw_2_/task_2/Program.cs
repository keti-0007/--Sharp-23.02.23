// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
System.Console.WriteLine("Введите число: ");

void ThreNum (int a)
{
    if(a < 100)
    {
        System.Console.WriteLine($"Третьей цифры нет");
        return;
    }

    while(a > 999)
    a = a/10;
    System.Console.WriteLine($"Третья цифра данного числа: {a%10}");
    
   
}

ThreNum(int.Parse(Console.ReadLine()!));


//II вариант

// Console.Clear();
// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);

// if (Math.Abs(number) > 100)
// {
//     while (Math.Abs(number) >999)
//     {
//         number = number / 10;

//     }
//     number = Math.Abs(number % 10); 
//     System.Console.WriteLine($"Третья цифра {number}");
// }
// else
// {
//     System.Console.WriteLine("Третьей цифры нет");
// }
