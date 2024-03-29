﻿/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int[] CreateRandomArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }   
    return array;
}

void WriteArray(int[] array)
{
    Console.Write("[ ");

    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }    

    Console.Write("]");
}

int GetCountOfEvenNumbers(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            count++;
        }
    }        
    return count;
}

Console.Clear();

Console.Write("Введите количество элементов: ");
int lenght = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(lenght);
WriteArray(myArray);

int result = GetCountOfEvenNumbers(myArray);

Console.WriteLine($" -> {result}");