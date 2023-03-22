//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.


int InputIntNumber(string numberName)
{
    System.Console.Write($"Введите {numberName} :");
    int intNumber = int.Parse(Console.ReadLine()!);
    return intNumber;
}
int[,] Create2DArray(int rows, int columns)
{
    return new int[rows, columns];
}

void FillIntArray2DRandom(int[,] array, int minVal, int maxVal)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(minVal, maxVal + 1);
        }

    }
}

void PrintInt2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} \t");
        }
        System.Console.WriteLine();
    }
}

bool SearchNumberByInd(int row, int col, int indI, int indJ)
{
    return indI > 0 && indJ > 0 && indI <= row && indJ <= col;

}

string FoundElement(int[,] array, int indI, int indJ, bool verification)
{
    string res = "Такого элемента нет.";

    if (verification == true) res = $"Значение элемента: {array[indI - 1, indJ - 1]}.";
    return res;
}

int numRows = InputIntNumber(" количество строк");
int numCols = InputIntNumber(" количество столбцов");
int[,] myArray = Create2DArray(numRows, numCols);

int min = InputIntNumber(" минимальное значение для диапозона случайного числа");
int max = InputIntNumber(" максимальное значение для диапозона случайного числа");
FillIntArray2DRandom(myArray, min, max);

PrintInt2DArray(myArray);


int numRow2 = InputIntNumber(" координаты строки ");
int numCol2 = InputIntNumber(" координаты столбца");

bool verification = SearchNumberByInd(numRows, numCols, numRow2, numCol2);
string verificationElemetn = FoundElement(myArray, numRow2, numCol2, verification);
Console.Write(verificationElemetn);