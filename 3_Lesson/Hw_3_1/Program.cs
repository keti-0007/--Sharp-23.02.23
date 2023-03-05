// Задача 19.Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет, 12821 -> да, 23432 -> да

Console.Clear();
Console.Write("Введите 5-ти значное число: ");
string number = Console.ReadLine()!;
int length = number.Length;

void palindrom(string number)
{
  if (number[0]==number[4] || number[1]==number[3])
  {
    Console.WriteLine($"Ваше число: {number} - палиндром.");
  }
  else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
}

if (length == 5)
{
  palindrom(number);
  
}
else Console.WriteLine($" {number}: Не 5-ти значное число! Введи правильное число!");

//2 варивнт:
// Console.Write("Введите 5-ти значное число: ");

// void palindrom()
// {
//     int number = int.Parse(Console.ReadLine()!); 
//     int num1 = number / 10000 % 10;
//     int num2 = number / 1000 % 10;
//     int rev1 = number / 10 % 10;
//     int rev2 = number % 10;
//     int nul = number / 10000;

//     if (nul < 1 || nul > 9)
//     {
//         Console.WriteLine($"{number}: НЕ 5-ти значное число! Введи правильное число!");
//     }
//     else if  (num1 == rev2 && num2 == rev1)
//     {
//         Console.WriteLine( $"Ваше число: {number} -  палиндром");
//     }
//     else
//     {
//         Console.WriteLine($"Ваше число: {number} -  Не палиндром");
//     }
//     }
 
//      palindrom();
    