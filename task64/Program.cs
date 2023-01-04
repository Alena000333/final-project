﻿// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void PrintNum(int num)
{
    if(num >=1)
    {
        Console.Write(num+" ");
        PrintNum(num-1);
    }
}

Console.WriteLine("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());
PrintNum(N);