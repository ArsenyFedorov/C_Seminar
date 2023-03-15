// 3. Напишите программу, которая будет принимать на вход два числа и выводить,
//    является ли второе число кратным первому. Если число 2 не кратно числу 1, то
//    программа выводит остаток от деление.

//    34, 5 -> не кратно, остаток 4
//    16, 4 -> кратно
Console.WriteLine("Ввидите первое число:");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ввидите второе число:");
int num2 = int.Parse(Console.ReadLine()!);

void divide(int nm1, int nm2)
{
    if (nm1 % nm2 == 0)
    {
        Console.WriteLine($"Число {nm1}  кратно {nm2} ");
    }
    else
    {
        Console.WriteLine($"Число {nm2} не кратно {nm1} , остаток {nm1 % nm2}");

    }
}
divide(num1, num2);