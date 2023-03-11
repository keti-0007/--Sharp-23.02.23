// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


void Print(double[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

double[] MassNums(int size, int from, int to)
{
    double[] arr = new double[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to);
    return arr;
}

double MassMaxMin(int a, int b)
{
    Random rnd = new Random();
    double rndDouble = a + rnd.NextDouble()*(b-a);
  return rndDouble;
}


Console.WriteLine("Введите длину массива: ");
int num = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите минимальное значение для диапозона случайного числа: ");
int start = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите максимальное значение для диапозона случайного числа: ");
int stop = int.Parse(Console.ReadLine()!);

double[] mass = MassNums(num, start, stop);
Print(mass);

Console.WriteLine($"Max {mass.Max()} Min {mass.Min()} Разница max-min = {mass.Max()-mass.Min()}");





