// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int[] UserNumbers(int num)
{
    int a = 0;
    int[] arr = new int[num];
    for (int i = 0; i < num; i++)
    {
        a = 0;
        Console.WriteLine($"Ввидите {i + 1}-ое число:");
        a = int.Parse(Console.ReadLine()!);
        arr[i] = a;
    }
    return arr;
}
int Num(int[] arr)
{
    int count = 0 ;
    for (int i = 0; i < arr.Length ; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}

Console.WriteLine("Ввидите количество чисел которые ввидёте:");
int numuser = int.Parse(Console.ReadLine()!);
 int[] arr_1 = UserNumbers(numuser);
Console.WriteLine("Количество положительных чисел:");
Console.WriteLine(Num(arr_1));