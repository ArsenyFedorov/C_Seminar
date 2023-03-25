// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
double[] Mas(int long_1, double min, double max)
{
    double[] array = new double[long_1];
    for (int i = 0; i < long_1; i++)
    {
        array[i] = min + new Random().NextDouble() * (max - min);

    }
    return array;
}
void Print(double[] array)
{
    Console.WriteLine("Вваш массив:");
    Console.Write("[");
    for (int i = 0; i < array.Length ; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
}
double Min(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length - 1; i++)
    {
        if (min > array[i]) min = array[i];
    }
    return min;
}
double Max(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length - 1; i++)
    {
        if (max < array[i]) max = array[i];
    }
    return max;
}
Console.WriteLine("Ввидите длину массива:");
int long_2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ввидите минимальное значение массива:");
double min_1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Ввидите максимальное значение массива :");
double max_1 = double.Parse(Console.ReadLine()!);
double[] array_1 = Mas(long_2, min_1, max_1);
Print(array_1);
double min_2 = Min(array_1);
Console.WriteLine("Минимальный элемент массива:" + min_2);
double max_2 = Max(array_1);
Console.WriteLine("Максимальный  элемент массива:" + max_2);
double Subtraction = max_2 - min_1;
Console.WriteLine("Разница между макс и мин элементом :" + Subtraction);

