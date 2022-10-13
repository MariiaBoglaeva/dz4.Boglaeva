﻿// Задача 29: Напишите программу, которая задаёт массив из 8 элементов
//  и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] array = new int[8];
FullArray(array);
PrintArray(array);

void FullArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next();// берем диапазон по умолчанию(от 0 до максимального предела int32)
    }
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[arr.Length - 1]}]");
}