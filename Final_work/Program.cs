﻿// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше, либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


Console.WriteLine("Введите желаемое количество элементов в массиве: ");
int a = int.Parse(Console.ReadLine());
string [] Array = new string [a];

for(int i = 0; i<Array.Length; i++)
{
    Array[i] = Console.ReadLine();
    
} 
Console.WriteLine("Массив: ");
for(int i =0; i<Array.Length; i++)
{
    Console.Write(Array[i] + "; ");
}
Console.WriteLine();
Console.WriteLine("Элементы массива у которых 3 или меньше символов: ");
for(int i = 0; i<Array.Length; i++)
{
    if(Array[i].Length <= 3)
    {
        Console.Write($" '{Array[i]}'; ");
    }
    
}