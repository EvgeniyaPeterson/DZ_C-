
//Задача 10: Напишите программу, которая принимает на вход 
//трёхзначное число и на выходе показывает вторую цифру 
//этого числа. Через строку решать нельзя.

//456 -> 5
//782 -> 8
//918 -> 1


int ReadRandomNumber()
{
Console.WriteLine("Введите трехзначное число ");
int Num = int.Parse(Console.ReadLine()!);
if (Num < 1000 && Num > 99)
    return Num;
else
    return -1;
}

int SecondDigit(int Num)
{
    return (Num % 100) / 10;
}

int randomNumber = ReadRandomNumber();
if (randomNumber==-1)
    Console.WriteLine("Введено не трехзначное число!");
else
{
    Console.WriteLine("Введено число: " + randomNumber);
    Console.WriteLine(" Вторая цифра:  " +SecondDigit(randomNumber));
}


