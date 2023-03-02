// Задача2. Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа цифру
//456-->46 . 782-->72. 918-->98


void TwoNumber()
{
   int  n = new Random().Next(100, 1000);
   System.Console.WriteLine(n);
   System.Console.WriteLine($"{n /100}{n %10}");
    
}
TwoNumber();


// // II Вариант
// System.Console.WriteLine("Ведите число: ");
// string SecondNum (int n)
// {
//     if((-1000 < n && n < -99) || (n < 1000 && n > 99))
//         return $"{n} --> {n / 100 * 10 + n %10}";
//     return "Число не трехзначное, повторите ввод числа!";

// }
// System.Console.WriteLine(SecondNum(int.Parse(Console.ReadLine()!)));