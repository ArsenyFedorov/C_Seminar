// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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
int MinSum(int[,] arr)
{
    int line = arr.GetLength(0);
    int pillar = arr.GetLength(1);
    int minsum = 0;
    int sum = 0;
    int lineminsum = 0;
    for (int k = 0; k < pillar; k++)
    {
        minsum+=arr[0,k];
    }
    for (int i = 1; i < line; i++)
    {
        sum = 0 ;
        for (int j = 0; j < pillar; j++)
        {
            sum+=arr[i,j];
        }
        if (minsum > sum)
        {
            minsum = sum;
            lineminsum = i ;
        }
    }
    lineminsum++;
    return lineminsum;
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
Console.WriteLine("Саммая маленькая сумма элементов находится в строчке - " + MinSum(newarr));