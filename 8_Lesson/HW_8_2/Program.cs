//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to + 1);
    return arr;
}

int[] SumRows(int[,] array)
{
    int[] sum = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            sum[i] += array[i, j];

    return sum;
}

int IndexMin(int[] array)
{
    int minIndex = 0;

    for (int i = 1; i < array.Length; i++)
        if (array[i] < array[minIndex]) 
            minIndex = i;
    return minIndex;
}

Console.Write("Введите количество строк: ");
int row_num = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов ");
int column_num = int.Parse(Console.ReadLine()!);

Console.Write("Введите минимальное значение для диапозона случайного числа: ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное значение для диапозона случайного числа: ");
int stop = int.Parse(Console.ReadLine()!);
int[,] mass = MassNums(row_num, column_num, start, stop);
Print(mass);

int[] Sum = SumRows(mass);
int numRow = IndexMin(Sum);
System.Console.WriteLine($"Номер строки с наименьшей суммой элементов: {numRow + 1}");
