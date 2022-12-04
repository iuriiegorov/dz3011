// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Enter number A");

int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number B");

int b = Convert.ToInt32(Console.ReadLine());

int count = 1;
int result = 1;

while ( b >= count ) {
    result = result * a;
    count++;   
}

Console.WriteLine(result); 