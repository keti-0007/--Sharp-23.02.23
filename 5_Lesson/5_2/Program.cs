////  // 2. Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.


int[] InputRandomMassive(int lengthMas, int minRangeMas, int maxRangeMas)
{
    int[] masRandom = new int[lengthMas]; // Задаем массив
    for (int i = 0; i < lengthMas; i++)
    {
        masRandom[i] = new Random().Next(minRangeMas, maxRangeMas); // случайные числа в диапозоне     
    }
    return masRandom;
}
// Вывод массива
void PrintMassive(int[] mas)
{
    for (int i = 0; i < mas.Length; i++)
        Console.Write($" {mas[i]} ");
    Console.WriteLine();
}

void MassSearchNum(int[] arry, int num)
{
    for (int i = 0; i < arry.Length; i++)
    {
        if (arry[i] == num)
        {
            Console.WriteLine("Yes");
            return;
        }
    }
    Console.WriteLine("No");

}

Console.WriteLine("Введите длину массива: ");
int lengthMas = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите минимальное значение для диапозона случайного числа: ");
int minRangeMas = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите максимальное значение для диапозона случайного числа: ");
int maxRangeMas = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

int[] masRandom = InputRandomMassive(lengthMas, minRangeMas, maxRangeMas);
PrintMassive(masRandom);

MassSearchNum(masRandom, num);

















