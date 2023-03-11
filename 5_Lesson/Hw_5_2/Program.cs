// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

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

int NotEvenNum(int[] array)
{
    int Sum = 0;
    for (int i = 1; i < array.Length; i +=2)
    {
        Sum = Sum + array[i];
    }
    return Sum;
}

Console.WriteLine("Введите длину массива: ");
int num = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите минимальное значение для диапозона случайного числа: ");
int start = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите максимальное значение для диапозона случайного числа: ");
int stop = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num, start, stop);
Print(mass);

int result = NotEvenNum(mass);

Console.WriteLine($"\nСумма элементов, стоящих на нечётных позициях: {result}");

