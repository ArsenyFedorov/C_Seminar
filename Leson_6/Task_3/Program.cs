//  Напишите программу, которая будет
// преобразовывать десятичное число в двоичное.

string binary(int num)
{
string result = "";
while (num > 0)
{
result = num % 2 + result;
num /= 2;
}
return result;
}

Console.Write("Ввидите число:");
int x = int.Parse(Console.ReadLine()!);
string answer = binary(x);
Console.WriteLine("Ваше число в двоичной системуе исчисления :");
Console.WriteLine(answer);
