// Задача 34: Задайте массив заполненный случайными
// положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных
// чисел в массиве.
//[345, 897, 568, 234] -> 2


void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] MassNums(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to);
    return arr;
}

int EvenNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i = +2)
        count++;

    return count;

}

Console.WriteLine("Введите длину массива: ");
int num = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите минимальное значение для диапозона случайного числа: ");
int start = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите максимальное значение для диапозона случайного числа: ");
int stop = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num, start, stop);
Print(mass);

int result = EvenNum(mass);

Console.WriteLine($"Количество чётных чисел в массиве: {result}");


