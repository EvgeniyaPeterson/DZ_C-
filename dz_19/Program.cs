//Задача 19
//Напишите программу, которая принимает на вход пятизначное 
//число и проверяет, является ли оно палиндромом. 
//12821 -> да
//23432 -> да

int PalindromeOrNo()
{
Console.WriteLine("Введите пятизначное число");
int num = int.Parse(Console.ReadLine()!);
if (num < 99999 && num > 10000)
    return num;
else
    return -1;
}

int number = PalindromeOrNo();
if(number==-1)
    Console.WriteLine("Число не пятизначное!");
else
{
    if(number/10000==number%10 && (number/1000)%10==number%100/10)
        Console.WriteLine("Да, палиндром " + number);
    else
        Console.WriteLine("Нет, не палиндром " + number);    
}