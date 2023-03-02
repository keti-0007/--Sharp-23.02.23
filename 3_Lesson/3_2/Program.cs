// // 2. Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 2D пространстве.
// https://ru.onlinemschool.com/math/library/analytic_geometry/point_point_length/

// A(3,6); B(2,1)-->5,09
// A(7,-5);B(1,-1)-->7,21

double Dis(double x1, double y1, double x2, double y2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1,2));
}

System.Console.WriteLine("Введите координаты A:");
int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите координаты B:");
int c = int.Parse(Console.ReadLine()!);
int d = int.Parse(Console.ReadLine()!);
System.Console.WriteLine(Dis(a,b,c,d));


