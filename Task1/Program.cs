﻿/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
Console.WriteLine("Введите пятизначное число: ");
string a = Console.ReadLine()??"";
int len = a.Length;

if(len == 5)
{
    if (a[0] == a[4] && a[1] == a[3])
    {
        Console.WriteLine($"{a} палиндром");
    }
    else { Console.WriteLine($"{a} не палиндром"); }
}
else { Console.Write("Вы ввели не пятизначное число"); }