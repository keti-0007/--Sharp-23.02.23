

//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//    https://blog.fenix.help/podgotovka-k-testam-yekzamenam-zachetam/pravilo-umnozheniya-matrits-primery-s-resheniyem
//    https://lfirmal.com/matritsyi-chastnyie-vidyi-matrits/#%D0%A3%D0%BC%D0%BD%D0%BE%D0%B6%D0%B5%D0%BD%D0%B8%D0%B5_%D0%BC%D0%B0%D1%82%D1%80%D0%B8%D1%86
//    https://ru.onlinemschool.com/math/assistance/matrix/multiply



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

int[,] MatrixProduct(int[,] arrayFirst, int[,] arraySecond)
{
    int row_size_1 = arrayFirst.GetLength(0);
    int column_size_1 = arrayFirst.GetLength(1);

    int row_saiz_2 = arraySecond.GetLength(0);
    int column_size_2 = arraySecond.GetLength(1);


    int[,] pr_matrix = new int[row_size_1, column_size_1];

    if (column_size_1 != row_saiz_2) return pr_matrix;//если  количество столбцов  первой матрицы  не равно количеству строк второй матрицы,такие матрицы нельзя перемножить 

    //Для того, чтобы умножить 1-ю и 2-ю, нужно взять строку в первой матрице и столбец во второй,
    // перемножить одинаковые элементы и сложить полученные произведения.

    else if (column_size_1 == row_saiz_2)
    {
        pr_matrix = new int[row_size_1, column_size_2];

        for (int i = 0; i < row_size_1; i++)
        {
            for (int j = 0; j < column_size_2; j++)
            {
                for (int g = 0; g < column_size_1; g++)

                    pr_matrix[i, j] += arrayFirst[i, g] * arraySecond[g, j];
            }
        }
    }
    return pr_matrix;

}


Console.Write("Введите количество строк первой матрицы: ");
int row_1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов первой матрицы: ");
int column_1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество строк второй матрицы: ");
int row_2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов второй матрицы: ");
int column_2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите минимальное значение для диапозона случайного числа для первой матрицы: ");
int start_1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное значение для диапозона случайного числа для первой матрицы: ");
int stop_1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите минимальное значение для диапозона случайного числа для второй матрицы: ");
int start_2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное значение для диапозона случайного числа для второй матрицы: ");
int stop_2 = int.Parse(Console.ReadLine()!);

int[,] arr_1 = MassNums(row_1, column_1, start_1, stop_1);
Print(arr_1);

int[,] arr_2 = MassNums(row_2, column_2, start_2, stop_2);
Print(arr_2);

int[,] res_matrix = MatrixProduct(arr_1, arr_2);
Print(res_matrix);
