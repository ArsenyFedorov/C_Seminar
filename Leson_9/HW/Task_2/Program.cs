//Задайте значения M и N. Напишите программу, которая найдёт сумму
//натуральных элементов в промежутке от M до N с помощью рекурсии
int SumMN(int m, int n)
{
    int sum = 0;
    if (n < m) return sum;
    SumMN(m, n - 1);
    sum += n;
    return sum;
}
Console.WriteLine("Ввидите M:");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ввидите N:");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(SumMN(M, N));