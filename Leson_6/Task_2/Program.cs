//  Напишите программу, которая принимает на вход три числа
// и проверяет, может ли существовать треугольник с сторонами такой длины.
void Triangle(int a_1, int b_1, int c_1)
{
    if (a_1 < b_1 + c_1 && b_1 < a_1 + c_1 && c_1 < a_1 + b_1)
        Console.WriteLine("Такой треугольник существует");
    else
        Console.WriteLine("Такой треугольник не существует");
}
Console.WriteLine("Ввидите первую сторону:");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ввидите вторую сторону: ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ввидите третью сторону:");
int c = int.Parse(Console.ReadLine()!);
Triangle(a, b, c);