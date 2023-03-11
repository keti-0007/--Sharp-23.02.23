//Задача 3: Напишите программу, которая задаёт массив из
// 8 элементов случайными числами и выводит их на экран.
// Оформите заполнение массива и вывод в виде функции
// (пригодится в следующих задачах)
// 1,2,5,7,19,1,2,8 -> 1,2,5,7,19,1,2,8
// 6,1,33,5,6,7,7,1 -> 6,1,33,5,6,7,7,1


// показываем масиив в консоли - ПРИНТ
void Print(int[] arr)//принимает массив
{
    int size = arr.Length;//  в переменную size записываем длинну массива
    
    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");// выводим массив
    Console.WriteLine();

}

// формирование массива
int[] EightMass(int size, int from, int to)// size- длина/размер массива, from- переменная начальная от, to- переменная конечная до.
{
    // собираем новый массив:
    int[] arr = new int[size];//в int[] arr переменная куда запишется новый массив с размерностью 

    for (int i = 0; i < size; i++)// условия 
        arr[i] = new Random().Next(from, to);// сборка нового массив с размерностью  от, до
    return arr;// вывод массива
}
Console.WriteLine("Введите длину массива: ");
int num = int.Parse(Console.ReadLine()!);// переменная size

Console.WriteLine("Введите минимальное значение для диапозона случайного числа: ");
int start = int.Parse(Console.ReadLine()!);// переменная from

Console.WriteLine("Введите максимальное значение для диапозона случайного числа: ");
int stop = int.Parse(Console.ReadLine()!);//переменная  to

int[] mass = EightMass(num, start, stop); // переменная для сформированного массива
Print(mass);




// int[] arr = new int[8];
// Random rnd = new Random();

// for (int i = 0; i < arr.Length; i++)
// {
//     arr[i] = rnd.Next(100);
// }
// for (int i = 0; i < arr.Length; i++)
// {
//     System.Console.Write(arr[i] + " ");
// }

