// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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
void Order(int[,] arr)
{
    int line = arr.GetLength(0);
    int pillar = arr.GetLength(1);
    int [] arrtest = new int[pillar];
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < pillar; j++)
        {
            arrtest[j] = arr[i, j];
        }
        Array.Sort(arrtest);
        Array.Reverse(arrtest);
        for (int j = 0; j < pillar; j++)
        {
            arr[i, j] = arrtest[j];
        }
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
Order(newarr);
Print(newarr);
