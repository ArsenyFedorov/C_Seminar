// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int Degree(int num, int degree)
{
    int result = 1;
    for (int i = 0; i < degree; i++)
    {
        result *=  num;
    }
return result;
}
Console.WriteLine("Пожалуйста ввидите число:");
int num_1= int.Parse(Console.ReadLine()!);
Console.WriteLine("Ввидите степень в которую хотете возвести ");
int degree_1= int.Parse(Console.ReadLine()!);
Console.WriteLine("Ответ:" + Degree(num_1,degree_1));