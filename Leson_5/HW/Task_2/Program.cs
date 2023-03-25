// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int[] Mas(int long_1, int min, int max)
{
    int[] array = new int[long_1];
    for (int i = 0; i < long_1; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}
void Print(int[] array)
{
    Console.WriteLine("Вваш массив:");
    Console.Write("[");
    for(int i = 0; i < array.Length -1;i++)
    {
        Console.Write(array[i] + " ");
    }
Console.Write("]");
}
int Position (int [] array )
{
 int sum = 0 ; 
 for (int i = 0; i < array.Length -1; i=i + 2)
 {
    sum = sum +  array[i];
 }
return sum;
}
Console.WriteLine("Ввидите длину массива:");
int long_2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ввидите минимальное значение массива:");
int min_1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ввидите максимальное значение массива :");
int max_1 = int.Parse(Console.ReadLine()!);
int [] array_1 = Mas (long_2,min_1,max_1);
Print(array_1);
Console.WriteLine("Сумма элементов нечётной позиции:");
Console.WriteLine(Position(array_1));
