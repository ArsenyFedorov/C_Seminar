// Напишите программу , которая принимает пятизначное число и проверяет , является ли оно полиндромом 
bool Chec5(int a)
{
    if (a < 10000 || a > 99999) return false;
    else return true;

}
bool Palindrom(int a)
{
    if (a / 1000 == (a % 10 * 10) + a % 100 / 10)
        return true;
    else return false;

}
Console.WriteLine("Ввидите число:");
int zxc = int.Parse(Console.ReadLine()!);
if (Chec5(zxc) == false) Console.WriteLine($"Число {zxc} не удовлетворяет условие программы ");

if (Palindrom(zxc)==true) 
Console.WriteLine($"Число {zxc} полиндром");
else Console.WriteLine($"Число {zxc} не полиндром");
