﻿// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.WriteLine("Введите пятизначное число");
int x = int.Parse(Console.ReadLine());
int y = x/1000;
if (x/10000 == x%10 && y%10 == x%100 / 10) Console.WriteLine("да");
else Console.WriteLine("нет");