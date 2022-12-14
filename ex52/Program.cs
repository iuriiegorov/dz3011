// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void FillArray(int[,] collection){

  for( int i = 0; i < collection.GetLength(0);i++)
  {
    for( int j = 0; j < collection.GetLength(1); j++)
        { collection[i,j] = new Random().Next(1,10);
       
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
PrintArray(array);

double avg = 0;

for(int y = 0; y < n; y++) {

    for(int x = 0; x < m; x++ ) {

        avg = avg + array[x,y];

    }

    Console.WriteLine(Math.Round(avg/m,2));
    avg = 0;
}
