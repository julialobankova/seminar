﻿/*Напишите программу, которая принимает на вход 
трёхзначное число и на выходе показывает
 последнюю цифру этого числа.*/

Console.WriteLine("Введите трехзначное число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine(a%10);

