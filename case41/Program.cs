﻿/* Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

int InputNum (string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
} 

void Numbers(int num)
{
    Console.Write(num);
    Console.WriteLine();
    string b = $"{num}";
    while (num != 0)
    {
    Console.Write("Введите число: ");
    string a = Console.ReadLine()!;
    b = b + $", {a}";
    Console.Write(b);
    Console.WriteLine();
    
    }
}


int number = InputNum("Введите число: ");
Numbers(number);