// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов
//  в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Enter a min number");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter a max number");
int m = Convert.ToInt32(Console.ReadLine());

int sum = 0;

int num(int n1, int m1) {

    sum =sum + n1;
    if (m1 == n1) return n1;
    return num(n1+1, m1);
    
}

num(n,m);
Console.WriteLine(sum);