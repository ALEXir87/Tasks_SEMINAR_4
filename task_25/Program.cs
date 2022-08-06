// Задача №25:Напишите цикл,который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Задача №25");
Console.Write("Введи число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int result = numberA;
for (int i = 1; i<numberB; i++){
    result = result * numberA;}
Console.WriteLine($"Результат = {result}");