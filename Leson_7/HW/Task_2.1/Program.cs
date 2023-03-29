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
void Arr(int[,] arr, int userline, int userpillar)
{
    if (arr.GetLength(0) >= userline - 1 && arr.GetLength(1) >= userpillar - 1) Console.WriteLine($"Число с такими индексами в данном массиве: {UserNum( arr, userline, userpillar)}");
    else Console.WriteLine("В данном массиве нет числа с такими индексами");
}

int UserNum(int[,] arr, int userline, int userpillar)
{
    return arr[userline-1,userpillar-1];
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
Console.WriteLine("Ввидите искомую строку:");
int userline = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ввидите искомый столбец:");
int userpillar = int.Parse(Console.ReadLine()!);
Arr(newarr, userline, userpillar);

