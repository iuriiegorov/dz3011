﻿// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Enter size of array");

int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

double [,] array = new double [m,n];
Random random = new Random();

for( int i = 0; i < array.GetLength(0);i++){
    for( int j = 0; j < array.GetLength(1); j++)
        { array[i,j] = Math.Round(random.NextDouble() + random.Next(-10,10), 1);
        Console.Write($"{array[i,j]}  ");
        }
    Console.WriteLine();
}
