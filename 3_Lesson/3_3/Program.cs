// // 3. Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу квадратов чисел от 1 до N.
//5-> 1,4,9,16,25
//2--> 1,4

Console.Clear();
System.Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
int i = 1;

void Div(int num)
{
    while( num >= i)
    {
        System.Console.WriteLine(Math.Pow(i , 2));
        i++;
    }

}

Div(N);