// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int Sum(int num)
{
    int sum = 0;
    // Хотел сделать for но я глупый и поэтому сделал через while)
    //for (int i = 0; i <= num;)
    //{
   //     sum = sum + num % 10;
   //     num = num / 10;
   // }
    while(0<num)
    {
        sum = sum + num %10;
        num = num / 10 ;
    }
    return sum;
}
Console.WriteLine("Ввидите число:");
int zxc = int.Parse(Console.ReadLine()!);
Console.WriteLine(Sum(zxc));