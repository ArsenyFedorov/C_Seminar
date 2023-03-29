// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце
int[,] FilArr(int line, int pillar, int min, int max)
{
    int[,] arr = new int[line, pillar];
    for (int i = 0; i < line; i++)
    {
        for (int k = 0; k < pillar; k++)
        {
            arr[i, k] = new Random().Next(min, max + 1);
        }
    }
    return arr;
}
void Print(int[,] arr)
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
void Average(int[,] arr)
{
    double average = 0;
    double count = 0;
    int line = arr.GetLength(0);
    int pillar = arr.GetLength(1);
    for (int i = 0; i < pillar; i++)
    {
        count = 0;
        for (int j = 0; j < line; j++)
        {
        count+=arr[j,i];
        }
        Math.Round( average = count/line,1);
        Console.WriteLine($"Среднее арифмитическое {i+1}-ого стоблика:{average}");
    }
}
Console.WriteLine("Ввидите количество строк:");
int line1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ввидите количество столбцов:");
int pillar1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ввидите минимальное значениея массива:");
int min1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ввидите максимальное значение массива:");
int max1 = int.Parse(Console.ReadLine()!);
int[,] newarr = FilArr(line1, pillar1, min1, max1);
Print(newarr);
Average(newarr);