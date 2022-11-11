// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


//Задача 13: Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.Через 
//строку решать нельзя.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

//Console.WriteLine("Задача 13.");

int GetThirdDigit(int Num)
{
    while (Num > 1000)
        Num = Num/10; 
    if (Num >=100 && Num < 1000)
        return = Num % 10;
    else
        return -1;
}
Console.WriteLine("Введите число ");
int Num = int.Parse(Console.ReadLine()!);
int ThirdDigit=GetThirdDigit(Num);
if (ThirdDigit==-1)
    Console.WriteLine("Третьего числа нет");
else
    Console.WriteLine("Третье число: " + ThirdDigit);






