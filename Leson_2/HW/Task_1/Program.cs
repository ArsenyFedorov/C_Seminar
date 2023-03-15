//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1
int SecondNumber(int b)
{
    if (b <= 999 & b >= 100)
    {
        Console.WriteLine($" Исходное число :{b}");
        b = b / 10;
        b = b % 10;
        Console.WriteLine($"Десятки числа : {b}");
    }
    else
    {
        Console.WriteLine("Вы ввели не трёхзначное число ");
        Console.WriteLine("Попробуйте снова  ");
    }
    return b;
}
Console.WriteLine("Ввидите трёхзначное число :");
int num = int.Parse(Console.ReadLine()!);
num = SecondNumber(num);
