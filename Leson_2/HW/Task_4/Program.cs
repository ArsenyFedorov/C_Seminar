// Написать программу ,которая выводит случайное трёхзначное число и удаляет вторую его цифру 
int Delet(int a)
{
Console.WriteLine($"Изначальное число {a}");
int b = a % 10;
int c = a / 100 ; 
c = c * 10 ; 
a = c+ b;
Console.WriteLine($"Число без десятков: {a}");
return a ;
}
int num = Delet(new Random().Next( 100,1000 ));