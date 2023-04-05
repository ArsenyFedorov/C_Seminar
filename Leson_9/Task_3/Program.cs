﻿// Напишите программу, которая будет принимать на вход число
// и возвращать сумму его цифр. Использовать рекурсию.
int RecSum(int n)
{
    if (n == 0) return 0;
    return n % 10 + RecSum(n / 10);
}
Console.WriteLine("Ввидите число:");
int n = int.Parse(Console.ReadLine()!);
Console.Write(RecSum(n));