//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int start = 1;
FromHighToLower(num, start);
void FromHighToLower(int arg1, int arg2)
{
    if (arg1 < arg2)
    {
        return;
    }
    else
    {
        FromHighToLower(arg1, arg2 + 1);
        Console.Write($"{arg2} ");
    }
}