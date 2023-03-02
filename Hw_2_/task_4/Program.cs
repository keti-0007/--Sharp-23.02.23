// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


Console.Write("Введите номер(от 1 до 7) дня недели:");
 int day = Convert.ToInt32(Console.ReadLine());

 while (day < 1 || day > 7);

switch (day) 
{
case 6:
case 7:
Console.WriteLine("Выходной");
break;

default:
Console.WriteLine("Рабочий день");
break;
}

//II Вариант
// Console.Clear();
// Console.Write("Введите номер(от 1 до 7) дня недели: ");

//  void DayOff(int a)
//  {
//     string text = " Не соответсвует номеру дня недели, повторитте ввод!";/// переменная флаг(text)->она меняет свое состояние 
////в зависимости от того куда мы провалимся: if(да)выходной или else if(нет)рабочий день. Или же если ввели не то знач которое просили от пользователя.

//     if (a == 7 || a == 6) text = "Выходной день ";
//     else if (a < 6 && a > 0 ) text = "Рабочий день ";
    
// System.Console.WriteLine($"{a} {text}");
//  }
//   DayOff(int.Parse(Console.ReadLine()!));