// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int [] array = new int[10];
int index = 0;
int count = 0;
while (index < 10 )
{
    array[index] = new Random().Next(100, 1000);
        if (array[index]%2 == 0) {
            count++;
        };
    Console.WriteLine(array[index]);
    index++;
}
Console.WriteLine("Number of even numbers = " + count);