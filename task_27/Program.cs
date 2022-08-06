// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Задача №27");
Console.Write("Введи число N : ");
int N = Convert.ToInt32(Console.ReadLine());
int result = 0;
while(N>0){
    result=result + N%10;
    N=N/10;}
Console.WriteLine($"Cумма цифр в числе = {result}");