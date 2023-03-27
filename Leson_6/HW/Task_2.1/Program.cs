//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
void IntersectionPoint(int coefficientB1, double coefficientK1, int coefficientB2, double coefficientK2)
{
    double ccoefficientX = 1;
    double ccoefficientY = 0;
    if (coefficientB1 == coefficientB2 && coefficientK1 == coefficientK2) Console.WriteLine("Прямые наложенны друг на друа ");
    else if (coefficientK1 == coefficientK2) Console.WriteLine("Пряммые паралельны ");
    else
    {
        ccoefficientX = (coefficientB2 - coefficientB1) / (coefficientK1 - coefficientK2);
        ccoefficientY = coefficientK1 * ccoefficientX + coefficientB1;
        Console.WriteLine($"Точка пересечения прямых: {ccoefficientX};{ccoefficientY}");
    }
}
Console.WriteLine("Ввидите кайфицент b1:");
int b1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ввидите кайфицент k1:");
double k1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Ввидите кайфицент b2:");
int b2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ввидите кайфицент k2:");
double k2 = double.Parse(Console.ReadLine()!);
IntersectionPoint(b1, k1, b2, k2);