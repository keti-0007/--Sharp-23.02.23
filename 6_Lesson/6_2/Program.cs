
// 2. Напишите программу, которая будет
//    преобразовывать десятичное число в двоичное.



// в строковую переменную можно складывать результат арифметических ывычислений 
string ConvertBin(int num)
{
    string result = String.Empty;// инит пустую строку,которая в
    while (num > 0) //цикл пока num больше 0
    {
        result = num % 2 + result;// разбираем чило %2 (двоичная система исчисления поэтому основание 2)
        num = num / 2;//уменшаем число: num / 2
    }
    return result;
}

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine()!);

string Result = ConvertBin(n);
Console.WriteLine(Result);