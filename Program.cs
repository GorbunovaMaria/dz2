/*Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/
/*
int CupNumber (int num)
{
    int result = ((num / 10) % 10);
    return result;
}    

Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());

int result = CupNumber(num);
Console.WriteLine($"Второе число {num} is {result}");*/

/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/


/*
void DayNumber (int num)
{
    if (num >= 1 && num <= 5)
    {
    Console.WriteLine("-> рабочий день");
    }
    if (num >= 6 && num <= 7)
    {
    Console.WriteLine("-> выходной");
    }
}
Console.WriteLine("Введите день недели от 1 до 7");
int num = Convert.ToInt32(Console.ReadLine());

DayNumber (num);*/

/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6*/
/*
void HundredNumer (int num)
{
    if(num >=100)
    {
    Console.WriteLine($" третья цифра числа {num} равна {num%10}");
    }
    else 
    {
    Console.WriteLine("третьей цифры нет");
    }
}
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
HundredNumer (num);*/
