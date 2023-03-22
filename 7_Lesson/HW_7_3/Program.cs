
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6;3


int InputIntNumber(string numberName)
{
    System.Console.Write($"Введите {numberName} :");
    int intNumber = int.Parse(Console.ReadLine()!);
    return intNumber;
}
int[,] Create2DArray(int rows, int columns)
{
    return new int[ rows,  columns];
 }

void FillIntArray2Drandom(int[,] array, int from, int to)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(from, to + 1);
        }

    }
}

void PrintIntArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

void PrintColumnsAverageArray2D(int[,] array)
{
    double[] columnSum = new double [array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)//  наруж цикл идет по столбцам пока j меньше кол-ва столбцов
    {
        for (int i = 0; i < array.GetLength(0); i++)// проход по всем строкам
        {
            columnSum[j]+= array[i, j];// сумма запишеться в одномер.массив[j] элемента + = зчение внутри конкретному столбца
        }
        System.Console.Write($"{columnSum[j] / array.GetLength(1):f2};\t");// сумму / кол-во строк--> кол-во элементов в столбце
    }
}

int numRows = InputIntNumber("количество строк");
int numCols = InputIntNumber("количсемво столбцов");
int[,] intArray2D =  Create2DArray(numRows, numCols);
int min = InputIntNumber ("минимальное значение для диапозона случайного числа");
int max = InputIntNumber("максимальное значение для диапозона случайного числа");
FillIntArray2Drandom(intArray2D, min, max);
PrintIntArray2D(intArray2D);
PrintColumnsAverageArray2D(intArray2D);



