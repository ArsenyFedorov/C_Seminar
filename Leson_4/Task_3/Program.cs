//  Напишите программу, которая принимает на вход
//  число N и выдаёт произведение чисел от 1 до N.
int Multiplication(int num)
{
    int result = 1;
    for(int i = 1 ;i<=num;i++)
    {
      result *=i;
    }
    return result;
}
Console.WriteLine("Ввидите число:");
int zxc = Multiplication(int.Parse(Console.ReadLine()!));
Console.WriteLine(zxc);