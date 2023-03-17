// // 4. Напишите программу, которая будет создавать
//    копию заданного массива с помощью поэлементного копирования.


// void Print(int[,] arr)
// {
//     int size = arr.GetLength(0);
//     int size_2 = arr.GetLength(1);

//     for (int i = 0; i < size; i++)
//     {
//         for (int j = 0; j < size_2; j++)
//         {
//             Console.Write($" {arr[i, j]} ");
//         }

//         Console.WriteLine();
//     }

// }

// int[,] MassNums(int rows, int columns, int from, int to)
// {
//     int[,] arr = new int[rows, columns];

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             arr[i, j] = new Random().Next(from, to);
//         }
//     }

//     return arr;
// }



// int[,] CopyMass(int[,] arr)
// {
//     int rows = arr.GetLength(0);
//     int columns = arr.GetLength(1);
//     int[,] newArr = new int[rows, columns];

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             newArr[i, j] = arr[i,j];
//         }

//     }
//     return newArr;

// }


// // Console.WriteLine("Введите минимальное значение для диапозона случайного числа: ");
// // int start = int.Parse(Console.ReadLine()!);

// // Console.WriteLine("Введите максимальное значение для диапозона случайного числа: ");
// // int stop = int.Parse(Console.ReadLine()!);

// int [,] mass = MassNums(3,4, 1,9);

// Print(mass);

// System.Console.WriteLine();

// int[,] newmass = CopyMass(mass);
// Print(newmass);




// 4. Напишите программу, которая будет создавать
//    копию заданного массива с помощью поэлементного копирования.

int[,] FillMass(int rows, int columns, int start, int end)
{
    int[,] Array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Array[i, j] = new Random().Next(start, end);
        }
    }
    return Array;
}

void PrinOff(int[,]arr){
    for (int i = 0; i < arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"  {arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,]CopyMass(int[,]arr){
    int row = arr.GetLength(0);
    int columns = arr.GetLength(1);
    int[,]newArr = new int[row, columns];
    for (int i = 0; i < row; i++){
        for (int j = 0; j < columns; j++)
        {
            newArr[i, j] = arr[i, j];
        }

    }
    return newArr;
}

int[,]mass = FillMass(3, 4, 1, 11);
PrinOff(mass);
Console.WriteLine();
int[,]mass2 = CopyMass(mass);
PrinOff(mass2);


