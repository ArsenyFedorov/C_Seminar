//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
int ThirdNumber(int a)
{
    if (a < 100) Console.WriteLine($"У  числа {a} нет 3 цифры ");
    else if (a > 999)
    {
        Console.WriteLine($"Третьей цифрой числа {a} является:");
        while (a > 999)
        {
            a = a / 10;
        }
        a = a % 100;
        a = a % 10;
        Console.Write(a);
    }
    else if (a >= 100 & a <= 999)
    {

        a = a % 100;
        a = a % 10;
        Console.WriteLine($"Третьей цифрой числа {a} является:");
        Console.Write(a);
    }
    return a;
}
Console.WriteLine("Ввидите число:");
int num = int.Parse(Console.ReadLine()!);
num = ThirdNumber(num);