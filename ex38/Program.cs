// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length){
        collection[index] = new Random().Next(1,100);
        index++;
    }
    
}

void PrintArray(int[] col)
{
    int count =col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int MaxElement(int[] collection)
{
    int count = collection.Length;
    int index = 0;
    int max = 0;

    while (index < count) {
        if(collection[index] > max) {
            max = collection[index];
        }
        index++;
    }
    return max;
}

int MinElement(int[] collection)
{
    int count = collection.Length;
    int index = 0;
    int min = collection[1];

    while (index < count) {
        if(collection[index] < min) {
            min = collection[index];
        }
        index++;
    }
    return min;
}

int [] array = new int[10];

FillArray(array);

PrintArray(array);

MaxElement(array);

MinElement(array);

Console.WriteLine ();

int max = MaxElement(array);
int min = MinElement(array);
int diff = max - min;

Console.WriteLine ("Min = " + min);
Console.WriteLine ("Max  = " + max);

Console.WriteLine ("Difference between Max and Min = " + diff);