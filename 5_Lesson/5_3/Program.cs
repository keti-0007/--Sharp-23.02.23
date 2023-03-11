//// 3. Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива,
// значения которых лежат в отрезке [10,99].


void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] MassNums(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to);
    return arr;
}


int RetNum(int[] Mass, int from, int to)//принимает массив который создали ниже -int[]Mass
                                        // его перекладываем в этот-->RetNum, а так же размерность массива
{
    int count = 0;// счетчик, если число попало в диапозон отрезка массивах[10,99] запишется в эту переменную
    for (int i = 0; i < Mass.Length; i++)
    {
        if (Mass[i] >= from && Mass[i] <= to)//if(Mass[i] >= 10 && Mass[i] <= 99)
                                             //  Mass[i]-текущее значение
            count++;// счетчик увеличиваем если условие выполнелось
    }
    return count;
}
Console.WriteLine("Введите длину массива: ");
int num = int.Parse(Console.ReadLine()!);// заполнение массива

Console.WriteLine("Введите минимальное значение для диапозона случайного числа: ");
int start = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите максимальное значение для диапозона случайного числа: ");
int stop = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num, start, stop);
Print(mass);

Console.WriteLine("Введите начальное значение для диапозона случайного числа: ");
int first = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите конечное значение для диапозона случайного числа: ");
int sec = int.Parse(Console.ReadLine()!);

int result = RetNum(mass, first, sec);
Console.WriteLine(result);


