// 2.Задача55. Задайте двумерный массив. Напишите программу,
//    которая заменяет строки на столбцы. В случае, если это невозможно,
//    программа должна вывести сообщение для пользователя.

// https://ru.wikihow.com/%D1%82%D1%80%D0%B0%D0%BD%D1%81%D0%BF%D0%BE%D0%BD%D0%B8%D1%80%D0%BE%D0%B2%D0%B0%D1%82%D1%8C-%D0%BC%D0%B0%D1%82%D1%80%D0%B8%D1%86%D1%83

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

string MatrixTrans(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    if (row != column) return "Транспонирование  матриц невозможна";

    for (int i = 1; i < row; i++)
    {
        for (int j = 0; j < i; j++)// j < i --> ограничитель чтобы не возвращаться в исходное состояние 
            (arr[i, j], arr[j, i]) = (arr[j, i], arr[i, j]);// кортеж
    }
    Print(arr);

    return "Возможна транспозиция матрицы";
}


Console.Write("Введите количество строк: ");
int row_num = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int column_num = int.Parse(Console.ReadLine()!);

Console.Write("Введите минимальное значение для диапозона случайного числа: ");
int start = int.Parse(Console.ReadLine()!);

Console.Write("Введите максимальное значение для диапозона случайного числа: ");
int stop = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(row_num, column_num, start, stop);
Print(mass);

string resultTrans = MatrixTrans(mass);
Console.WriteLine(resultTrans);

