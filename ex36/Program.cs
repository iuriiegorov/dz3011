// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] array = new int[4];
int index = 0;
int sum = 0;
while (index < 4 ) {
    array[index] = new Random().Next(-100, 100);

      if (index%2 > 0) {
            sum = sum + array[index];
        };
        
    Console.WriteLine(array[index]);
    index++;
}
Console.WriteLine("Sum of odd numbers = " + sum);