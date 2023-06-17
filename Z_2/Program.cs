//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int temp = M;

if (M > N)
{
    M = N;
    N = temp;
}
Summ(M, N, temp = 0);
void Summ(int M, int N, int sum)
{
    sum = sum + N;
    if (N <= M)
    {
        Console.WriteLine($"Сумма элементов = {sum}");
        return;
    }
    Summ(M, N - 1, sum);
}
