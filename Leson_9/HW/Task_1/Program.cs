//  Задайте значения M и N. Напишите программу, которая выведет все чётные
//  натуральные числа в промежутке от M до N с помощью рекурсии
void Nums(int m, int n)
{
    if (n % 2 == 0)
    {
        if (n < m) return;
        if (n == 2 ) return;
        Nums(m, n - 2);
        Console.Write(n - 2 + " ");
    }
    else
    {
        if (n < m) return;
        if (n == 1) return;
        Nums(m, n - 2);
        Console.Write(n - 1 + " ");

    }
}
Console.WriteLine("Ввидиет M:");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ввидите N:");
int N = int.Parse(Console.ReadLine()!);
Nums(M, N);