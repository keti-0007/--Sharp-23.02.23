// ЗАДАЧА 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9


int InputIntNumber(string numberName)
{
    System.Console.Write($"Input {numberName} :");
    int intNumber = Convert.ToInt32(Console.ReadLine());
    return intNumber;
}

void FillDoubleArray2Drandom(double[,] array, Random rnd, int min, int max)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = min + rnd.NextDouble() * (max - min);
        }

    }
}

void PrintDoubleArray2D(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]:f2}\t");
        }
        System.Console.WriteLine();
    }
}

int m = InputIntNumber("number of rows");
int n = InputIntNumber("number of columns");
double[,] doubleArray2D = new double[m, n];
Random rnd = new Random();
FillDoubleArray2Drandom(doubleArray2D, rnd, -10, 10);
PrintDoubleArray2D(doubleArray2D);