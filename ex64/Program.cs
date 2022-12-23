// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.WriteLine("Enter a number");
int n = Convert.ToInt32(Console.ReadLine());
int num(int n1) {

    Console.WriteLine($"{(n1)} ");
    if (n1 == 1) return n1;
    return num(n1-1);
    
}

num(n);