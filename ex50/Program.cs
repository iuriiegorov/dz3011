// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

void FillArray(int[,] collection){

  for( int i = 0; i < collection.GetLength(0);i++)
  {
    for( int j = 0; j < collection.GetLength(1); j++)
        { collection[i,j] = new Random().Next(1,100);
       
        }      
  }
}
void PrintArray(int[,] col)
{
  for( int i = 0; i < col.GetLength(0);i++){
    for( int j = 0; j < col.GetLength(1); j++)
 
            Console.Write($"{col[i,j]}  ");
       
        Console.WriteLine(); 
        }
}

Console.WriteLine("Enter size of the matrix");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

int [,] array = new int[m,n];

FillArray(array);

Console.WriteLine("Enter a position in matrix x,y");

int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

PrintArray(array);

Console.WriteLine();

if (x<=m && y<=n) {

    int result = array[x,y]; 
    Console.WriteLine($"Element on the position ( {x} , {y} ) is {result}"); 
}

else { 
   
    Console.WriteLine("there is no such element");
    
    }
