
// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7




void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j],3} ");
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

int[] MinElemenrArray(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    int min_num = arr[0, 0];
    int[] index = new int[2];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            if (min_num > arr[i, j])
            {
                min_num = arr[i, j];
                index[0] = i;
                index[1] = j;
            }
    }
    Console.WriteLine($"Mинимальный элемент в массиве: {arr[index[0], index[1]]}");
    return index;
}


void WithoutRowColumn(int[,] arr, int[] m_index)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            if (m_index[0] == i || m_index[1] == j) continue;
            else Console.Write($"{arr[i, j],3}");
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Введите количество строк в массиве: ");
int row_num = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int column_num = int.Parse(Console.ReadLine()!);

Console.Write("Введите минимальное значение для диапозона случайного числа: ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное значение для диапозона случайного числа: ");
int stop = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(row_num, column_num, start, stop);
Print(mass);

int[] mass_new = MinElemenrArray(mass);
System.Console.WriteLine();
Console.WriteLine($"Получившийся массив:");
WithoutRowColumn(mass, mass_new);

