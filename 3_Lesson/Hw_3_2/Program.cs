//Задача 21.Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

//Формула вычисления расстояния между двумя точками A(xa, ya, za) и B(xb, yb, zb) в пространстве:
//AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2




Console.Clear();
double Dis(double x1, double y1,double z1, double x2, double y2,double z2)
                                                                      
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1,2) + Math.Pow(z2 - z1,2));
}

System.Console.WriteLine("Введите координаты A:");
int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
int c = int.Parse(Console.ReadLine()!);


System.Console.WriteLine("Введите координаты B:");
int d = int.Parse(Console.ReadLine()!);
int e = int.Parse(Console.ReadLine()!);
int f = int.Parse(Console.ReadLine()!);

double segmentLength =  Math.Round (Dis(a,b,c,d,e,f), 2 );

Console.WriteLine($"Длина отрезка  {segmentLength}");


