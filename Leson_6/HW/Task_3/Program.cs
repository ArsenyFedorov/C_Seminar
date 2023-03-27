//Напишите программу, которая будет создавать копию заданного двумерного массива с помощью поэлементного копирования.
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
void Print(int[,] arr, int line, int pillar)
{
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
int[,] Copy(int[,] arr, int line, int pillar)
{
    int[,] copyarr = new int[line, pillar];
    for (int i = 0; i < line; i++)
    {
        for (int k = 0; k < pillar; k++)
        {
            copyarr[i, k] = arr[i, k];
        }
    }
    return copyarr;
}
Console.WriteLine("Ввидите количество строк:");
int line1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ввидите количество столбцов:");
int pillar1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ввидите минимальное значениея массива:");
int min1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ввидите максимальное значение массива:");
int max1 = int.Parse(Console.ReadLine()!);
int[,] newarr =FilArr(line1, pillar1, min1, max1);
Print(newarr, line1, pillar1);
Console.WriteLine("");
int [,] coppyarr = Copy(newarr,line1,pillar1);
Print(coppyarr,line1,pillar1);