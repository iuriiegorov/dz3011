﻿// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void FillArray(int[,] collection)
{

  for( int i = 0; i < collection.GetLength(0);i++)
  {
    for( int j = 0; j < collection.GetLength(1); j++)
    { 
      collection[i,j] = new Random().Next(1,100);   
    }      
  }
}

void PrintArray(int[,] col)
{
  for( int i = 0; i < col.GetLength(0);i++)
  {
    for( int j = 0; j < col.GetLength(1); j++)
    { 
      Console.Write($"{col[i,j]}  ");
    }  
      Console.WriteLine(); 
  }
}

void SortRows(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      for (int k = 0; k < matrix.GetLength(1) - 1; k++)
      {
        if (matrix[i, k] < matrix[i, k + 1])
        {
          int temp = matrix[i, k + 1];
          matrix[i, k + 1] = matrix[i, k];
          matrix[i, k] = temp;
        }
      }
    }
  }
}

Console.WriteLine("Enter size of the matrix");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

int [,] array = new int[m,n];

FillArray(array);

PrintArray(array);

SortRows(array);

Console.WriteLine();

PrintArray(array);