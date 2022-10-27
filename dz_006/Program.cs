// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет

Console.WriteLine("Задача 6.");

Console.WriteLine("Введите число ");
int input = int.Parse(Console.ReadLine()!);

if (input % 2 == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

