//  Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
double[,] FilArr(int line, int pillar, double min, double max)
{
    double[,] arr = new double[line, pillar];
    for (int i = 0; i < line; i++)
    {
        for (int k = 0; k < pillar; k++)
        {
            arr[i, k] = Math.Round(min + new Random().NextDouble() * (max - min),2);
        }
    }
    return arr;
}
void Print(double[,] arr)
{
    int line = arr.GetLength(0);
    int pillar = arr.GetLength(1);
    for (int i = 0; i < line; i++)
    {
        for (int k = 0; k < pillar; k++)
        {
            Console.Write(arr[i, k]);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Ввидите количество строк:");
int line1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ввидите количество столбцов:");
int pillar1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ввидите минимальное значениея массива:");
double min1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Ввидите максимальное значение массива:");
double max1 = double.Parse(Console.ReadLine()!);
double[,] newarr =FilArr(line1, pillar1, min1, max1);
Print(newarr);
Console.WriteLine("");

