//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
string DotXY(double coefficientB1, double coefficientK1, double coefficientB2, double coefficientK2)
{
string xy ;
double x = (coefficientB2 - coefficientB1) / (coefficientK1 - coefficientK2);
double y = coefficientK1 * x + coefficientB1;
xy = $"{x};{y}";
return xy;
}
Console.WriteLine("Ввидите кайфицент b1:");
double b1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Ввидите кайфицент k1:");
double k1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Ввидите кайфицент b2:");
double b2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Ввидите кайфицент k2:");
double k2 = double.Parse(Console.ReadLine()!);
if (k1 == k2 && b1 == b2) Console.WriteLine("Прямые наложены друг на друга ");
else if (k1 == k2) Console.WriteLine("Прямые паралельны ");
else Console.WriteLine($"Точка пересечения прямых:{DotXY(b1, k1, b2, k2)}");