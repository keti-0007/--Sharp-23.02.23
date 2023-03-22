// 3. Задайте двумерный массив. Найдите сумму элементов главной диагонали.
//    https://4apple.org/summa-diagonalnyh-jelementov-matricy/
//    https://ru.wikipedia.org/wiki/%D0%93%D0%BB%D0%B0%D0%B2%D0%BD%D0%B0%D1%8F_%D0%B4%D0%B8%D0%B0%D0%B3%D0%BE%D0%BD%D0%B0%D0%BB%D1%8C


void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j]}\t ");
    }
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to + 1);

    return arr;
}

int SumDiagonal(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    int diag_sum = 0;

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            if (i == j)// если i==j - главна диагональ
                diag_sum += arr[i, j];

    return diag_sum;
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
int result = SumDiagonal(mass);
Console.WriteLine(result);


//2 вариант метода. 
// int SumMainDiag(int[,] arr)
// {
// int sum = 0;

// int minSize = arr.GetLength(0);
// if (arr.GetLength(0) > arr.GetLength(1))
// minSize = arr.GetLength(1);

// // int minSize = arr.GetLength(0) < arr.GetLength(1) ? arr.GetLength(0) : arr.GetLength(1);//Тернарный оператор
//https://codechick.io/tutorials/csharp/csharp-ternary-operator
// //если это условие выполняется до ? присвоить arr.GetLength(0) --> если же нет, то :  arr.GetLength(1);

// for (int i = 0; i < minSize; i++)// т.к. индексы равны можно пройтись по одной раз-ти масиива использовать только индекс i
// sum += arr[i, i];
// return sum;
// }