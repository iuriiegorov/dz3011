// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int [] array = new int[8];
int index = 0;
while (index < 8 )
{
    array[index] = new Random().Next(1, 100);
    Console.WriteLine(array[index]);
    index++;
}