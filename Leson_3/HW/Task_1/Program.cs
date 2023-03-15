// Напишите программу , которая принимает пятизначное число и проверяет , является ли оно полиндромом 
bool Chec5(int a)
{
    return (a < 10000 || a > 99999) ? false : true;

}
bool Palindrom(int a)
{
    return (a / 1000 == (a % 10 * 10) + a % 100 / 10) ? true : false;
}
Console.WriteLine("Ввидите число:");
int zxc = int.Parse(Console.ReadLine()!);
if (Chec5(zxc))
{
    if (Palindrom(zxc))
        Console.WriteLine($"Число {zxc} полиндром");
    else Console.WriteLine($"Число {zxc} не полиндром");
}
else  Console.WriteLine("Число не удовлетворяет условия программы");


