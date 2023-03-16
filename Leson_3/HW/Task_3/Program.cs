// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void Coobs(int N)
{
    int a = 1;
    while (a <= N)
    {
        Console.WriteLine(Math.Pow(a, 3));
        a++;
    }
}
Console.WriteLine("Ввидите число  :");
int number = int.Parse(Console.ReadLine()!);
Coobs(number);
