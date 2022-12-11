// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length){
        collection[index] = Convert.ToInt32(Console.ReadLine());
        index++;
    }
    
}

Console.WriteLine ("Enter amount of numbers");

int m = Convert.ToInt32(Console.ReadLine());

int [] array = new int[m];

Console.WriteLine ("Enter numbers");

FillArray(array);

int morezero = 0;
int position = 0;
while (position < m) {
    if (array[position] > 0) {
        morezero++;
    }
    position++;
}

Console.WriteLine ("Amount of numbers more then zero = " + morezero);