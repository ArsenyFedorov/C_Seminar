//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Ввидите первое число");
int z = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ввидите второе  число");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ввидите третье число");
int c = int.Parse(Console.ReadLine()!);
if (z > x)
{
    if (z > c)
        Console.WriteLine( "Max:" + z);
}
else if (c > z)
    Console.WriteLine("Max:" + c);

else if (z < x)
{
    if (x > c)
        Console.WriteLine("Max:" + x);
}
else if (c > x)
    Console.WriteLine("Max:" + c);
