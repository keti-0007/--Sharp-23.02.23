//// 4. Найдите произведение пар чисел в одномерном массиве.
//    Парой считаем первый и последний элемент, второй и предпоследний
//    и т.д. Результат запишите в новом массиве.

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

int[] MultiMas(int[] arr)// массив int[] MultiMas который  возвращае массив который получит(int[] arr)
{
    int size = arr.Length;// пременная size-длинна массиваint[] MultiMas
    int[] newMass = new int[size / 2 + size % 2];//новый массив должен быть
    // равен половине зашедшего массива (size/2) + size%2 зашедшего массива его размерности
    for (int i = 0; i < size / 2; i++)// крутимся в половине зашедшего массиваint[] MultiMas.  size/2 -четное кол-во раз,не затрагивая середину
    {
        newMass[i] = arr[i] * arr[size - 1 - i];//[size-1-i]--> обращение к последнему элементу массива
        //в новый массив по текущему значению newMass[i] находим  произведение 1-го и последнего элемента
    }
    if (size%2 == 1)// если size%2 не четный 
    {
        newMass[newMass.Length-1] = arr[arr.Length/2];//добавим в массив 
    }
    return newMass;

}



Console.WriteLine("Введите длину массива: ");
int num = int.Parse(Console.ReadLine()!);// переменная size

Console.WriteLine("Введите минимальное значение для диапозона случайного числа: ");
int start = int.Parse(Console.ReadLine()!);// переменная from

Console.WriteLine("Введите максимальное значение для диапозона случайного числа: ");
int stop = int.Parse(Console.ReadLine()!);//переменная  to

int[] mass = MassNums(num, start, stop);
Print(mass);

int[] newNewMass = MultiMas(mass);
Print(newNewMass);

