// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


Console.WriteLine("Задача 1.");
Console.WriteLine("Введите число а");

int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число b");
int b = int.Parse(Console.ReadLine()!);

if(a == b*b)
{
Console.WriteLine("Да");
} 
else
{
    Console.WriteLine("Нет");
}