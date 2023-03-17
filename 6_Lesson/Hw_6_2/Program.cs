// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//    https://studok.net/obrazovanie-i-kommunikacii/vopros-kak-vychislit-tochku-peresechenija-dvuh-prjamyh/
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
//  1, 4, 2, 3
// -1, -2, -1, 2


void CoordinatIntersection(double k1, double b1, double k2, double b2)
{
    double k_sub = k1 - k2;
    if (k_sub != 0)
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"Пересечение: ({x}; {y})");
    }
    else if (k1 == k2 && b1 == b2)
        Console.WriteLine("Существует бесконечное количество точек пересечения.");
    else
        Console.WriteLine("Нет точки пересечения");
}


Console.WriteLine("введите значение k1");
double k_1 = double.Parse(Console.ReadLine()!);

Console.WriteLine("введите значение b1");
double b_1 = double.Parse(Console.ReadLine()!);

Console.WriteLine("введите значение k2");
double k_2 = double.Parse(Console.ReadLine()!);

Console.WriteLine("введите значение b2");
double b_2 = double.Parse(Console.ReadLine()!);

CoordinatIntersection(k_1, b_1, k_2, b_2);
