// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

void NewMatrix(int[,] array, int[,] matrix, int[,] result)
{
  for (int i = 0; i < result.GetLength(0); i++)
  {
    for (int j = 0; j < result.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < array.GetLength(1); k++)
      {
        sum = sum + array[i,k] * matrix[k,j];
      }
      result[i,j] = sum;
    }
  }
}

Console.WriteLine("Enter size of the matrix");
int m = Convert.ToInt32(Console.ReadLine());
int n = m;

int [,] array = new int[m,n];
int [,] matrix = new int[m,n];
int [,] result = new int[m,n];

FillArray(array);
PrintArray(array);

Console.WriteLine();

FillArray(matrix);
PrintArray(matrix);

Console.WriteLine();

Console.WriteLine("new matrix:");

NewMatrix(array,matrix,result);

PrintArray(result);
