// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Задача 10: Напишите программу, которая принимает на вход 
//трёхзначное число и на выходе показывает вторую цифру 
//этого числа. Через строку решать нельзя.

//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Задача 10");
Console.WriteLine("Введите 3-х значное число:");

int a = int.Parse(Console.ReadLine()!);

if(a<100 || a>999)
{
    Console.WriteLine("Ошибка. Введите 3-х значное число:");
}
else
{
    a=a-(a-(a%100));
    a=a/10;
    Console.WriteLine(a);
}
