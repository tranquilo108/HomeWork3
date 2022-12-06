﻿/*Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B(2, 1, -7), -> 15.84

A(7, -5, 0); B(1, -1, 9)-> 11.53*/

Console.WriteLine("x1 = ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y1 = ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("z1 = ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("x2 = ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y2 = ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("z2 = ");
int z2 = Convert.ToInt32(Console.ReadLine());

int xx = x2 - x1;
int yy = y2 - y1;
int zz = z2 - z1;

double lenght = Math.Sqrt(Math.Pow(xx, 2) + Math.Pow(yy, 2) + Math.Pow(zz, 2));
Console.WriteLine($"Расстояние между двух точек = {lenght}");