// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
// сумма отрицательных равна -20.

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

void SumPosNeg(int[] arr)
{
    int pos, neg;//переменные '+' pos, '-' neg 
    pos = neg = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)//если текущий элемент больше 0
            pos += arr[i];// в pos сложить это значение
        else
            neg += arr[i];// если иначе,то в neg сложить это значение 
    }
    Console.WriteLine($"Сумма положительных: {pos}; Сумма отрицательных: {neg}");
}
Console.WriteLine("Введите длину массива: ");
int num = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите минимальное значение для диапозона случайного числа: ");
int start = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите максимальное значение для диапозона случайного числа: ");
int stop = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num,start,stop);// сборка массива
Print(mass);// печать собранного массива
SumPosNeg(mass);//вызов ф-и и передаем собранный массив
