//  Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int[] Mas(int long_1)
{
    int[] array = new int[long_1];
    for (int i = 0; i < long_1; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}
void Print(int[] array)
{
    Console.WriteLine("Вваш массив:");
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
}
int Even(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0) sum++;

 return sum;
}
Console.WriteLine("Ввидите длинну массива:");
int long_2 = int.Parse(Console.ReadLine()!);
int[] array_1 = Mas(long_2);
Print(array_1);
Console.WriteLine("Количество чётныйх чисел:");
Console.WriteLine(Even(array_1));
