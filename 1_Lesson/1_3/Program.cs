// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница


System.Console.WriteLine("Введите число: ");
 
 int a = int.Parse(Console.ReadLine()!);
  if( a == 1)
  {
    System.Console.WriteLine("Monday");
  }
  else if (a == 2)
{
    System.Console.WriteLine("Tuesday");
}
 else if (a == 3)
{
    System.Console.WriteLine("Wednesday");
}
 else if (a == 4)
{
    System.Console.WriteLine("Thursday");
}
else if (a == 5)
{
    System.Console.WriteLine("Friday");
}
else if (a == 6)
{
    System.Console.WriteLine("Saturday");
}
else if (a == 7)
{
    System.Console.WriteLine("Sunday");
}
else
{
    System.Console.WriteLine("Повторитте ввод от 1 до 7!");
}