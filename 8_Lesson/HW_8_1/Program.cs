
//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


void Print(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
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

void SorterBuf(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - j - 1; k++)//-j для того чтобы отсортированный элемент не трогать(он стоит где нужно)

            {
                if (array[i, k] < array[i, k + 1])
                {
                    int buf = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = buf;
                }
            }
        }
    }
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

SorterBuf(mass);
Print(mass);
