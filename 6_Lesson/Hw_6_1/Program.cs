//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 3


int CountNum(int num)
{

    int count = 0;

    for (int i = 1; i <= num; i++)
    {
        System.Console.Write($"Число №{i}: ");

        int m = int.Parse(Console.ReadLine()!);
        if (m > 0) count++;
    }
    return count;
}

System.Console.WriteLine("Введите кол-во числел: ");
int M = int.Parse(Console.ReadLine()!);

int result = CountNum(M);
System.Console.WriteLine($"Кол-во чисел больше 0: {result}");


//      2 вариант со строкой 

int CoumtNumTwo()
{
    int count = 0;
    string word;//обявл строку

    while (true)//Бесконечный цикл
    {
        System.Console.Write("введите число: ");//запрос от пользоветеля
        word = Console.ReadLine()!;// сразу записывает значение полученное от пользоветеля в переменную строкового типа  содержащая символ в виде числа- word

        if (word == "") return count;// если пользоветель ввел пустую строку,завершается цикл и выводится  count
        else if (int.Parse(word) > 0) count += 1;// иначе строку-word преобразуем  к числу и проверяем больше ли 0,увеличиваем счетчик если больше 0.
        //если нет идем на новую итерацию.
    }

}
int countTwo = CoumtNumTwo();
System.Console.WriteLine($"Кол-во чисел больше 0: {countTwo}");
