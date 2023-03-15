//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
void DayOff(int a)
{
    if (a > 7) Console.WriteLine("День недели указан не верно ");
    if (a <= 0) Console.WriteLine("День недели указан не верно ");
    if (a == 1)
    {
        Console.WriteLine("Сегодня только понедельник иди работай  ");
        Console.WriteLine("Отдохнёшь через 4 дня  ");
    }
    if (a == 2)
    {
        Console.WriteLine("Сегодня только вторник  иди работай  ");
        Console.WriteLine("Отдохнёшь через 3 дня  ");
    }
    if (a == 3)
    {
        Console.WriteLine("Сегодня только среда  иди работай  ");
        Console.WriteLine("Отдохнёшь через 2 дня  ");
    }
    if (a == 4)
    {
        Console.WriteLine("Сегодня только четверг  иди работай  ");
        Console.WriteLine("Отдохнёшь через 1 день  ");
    }
    if (a == 5)
    {
        Console.WriteLine("Сегодня только пятница  иди работай ");
        Console.WriteLine("Завтра уже выходные ");
    }
    if (a == 6)
    {
        Console.WriteLine("Сегодня суббота и значит сегодня выходной   ");
        Console.WriteLine("Ты заслужил отдохнуть  ");
    }
    if (a == 7)
    {
        Console.WriteLine("Сегодня воскресенье и  значит сегодня выходной   ");
        Console.WriteLine("Завтра  опять на работу (  ");
    }
    if (a <=  0 & a > 7) Console.WriteLine("День недели указан не верно ");
}
Console.WriteLine("Ввидите число дня недели(от 1 до 7):");
int num = int.Parse(Console.ReadLine()!);
DayOff(num);
