//Задача 15: Напишите программу, которая принимает на вход
 //цифру, обозначающую день недели, и проверяет, является
 // ли этот день выходным.

int ReadDayNumber()
{
Console.WriteLine("Введите номер дня недели");
int day = int.Parse(Console.ReadLine()!);
if (day < 8 && day > 0)
    return day;
else
    return -1;
}

int day = ReadDayNumber();
if(day==-1)
    Console.WriteLine("Такого дня в неделе нет!");
else
{
    if(day<6)
        Console.WriteLine("День не выходной!");
    else
        Console.WriteLine("Выходной!!!");    
}