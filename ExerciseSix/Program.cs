﻿/*Задача 6: Напишите программу, 
которая на вход принимает число и 
выдаёт, является ли число чётным 
(делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет*/

Console.WriteLine("Введите любое целое число");
int number = Convert.ToInt32(Console.ReadLine());
bool evenNumber = Convert.ToBoolean(number % 2);
if (evenNumber)
{
    Console.WriteLine($"Число {number} является нечетным");
}
else
{
    Console.WriteLine($"Число {number} является четным");
}
