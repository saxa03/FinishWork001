// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

using System;
using static System.Console;

Clear();

WriteLine("Введите длину массива: ");
int n = Convert.ToInt32(ReadLine());
string[] array = new string[n];

FillArray(array);
PrintArray(array);

WriteLine();

WriteLine("Массив из строк, длина которых меньше либо равна 3 символа: ");
NewArray (array);

void FillArray(string[] array) //метод заполнения массива строк с клавиатуры
{
    for (int i = 0; i < array.Length; i++)
    {
        WriteLine("Введите значение массива: ");
        array[i] = ReadLine();
    }
}

void PrintArray(string[] array)// метод вывода массива
{
    for (int i = 0; i < array.Length; i++)
    {
        Write(array[i] + "   ");        
    }
}

void NewArray (string[] array)// метод, который формирует массив из строк, длина которых меньше либо равна 3 символам
{
    string[] result = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)// длина элемента массива меньше или равна 3
        {
            result[i] = array[i];//создаем результирующий массив
            Write(result[i] + "   ");
        }
    }
}


