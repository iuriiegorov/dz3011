// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

void FillArray(int[,] collection)
{

  for( int i = 0; i < collection.GetLength(0);i++)
  {
    for( int j = 0; j < collection.GetLength(1); j++)
    { 
      collection[i,j] = new Random().Next(1,10);   
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

Console.WriteLine("Enter size of the matrix");
int m = Convert.ToInt32(Console.ReadLine());
int n = m;
int [,] array = new int[m,n];

FillArray(array);

PrintArray(array);

int SumRows(int[,] array, int i)
{
  int sum = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sum = sum + array[i,j];
  }
  return sum;
}

int min = 0;
int sum = SumRows(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int temp = SumRows(array, i);
  if (sum > temp)
  {
    sum = temp;
    min = i;
  }
}

Console.WriteLine($"Row with min sum is {min}");