// 1. Задайте двумерный массив размера m на n,
//    каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
//    Выведите полученный массив на экран. 

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

int[,] MassSimple(int row, int column)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = i + j;

    return arr;
}

Console.WriteLine("Введите количество строк: ");
int row_num = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов ");
int column_num = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите минимальное значение для диапозона случайного числа: ");
int start = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите максимальное значение для диапозона случайного числа: ");
int stop = int.Parse(Console.ReadLine()!);

int[,] mass = MassSimple(row_num, column_num);
Print(mass);