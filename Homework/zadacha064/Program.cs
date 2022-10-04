/* Задайте значение N. Напишите программу, которая 
выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.*/

Console.Write("Введите натуральное число N: ");
int n = int.Parse(Console.ReadLine()!);

if (n < 1) Console.WriteLine("Вы ввели не натуральное число");
else
{
    int i = 1;
    Console.Write($"Все натуральные числа в промежутке от {n} до {i}: ");
    FindAllNaturalNumbers(i, n);
    Console.WriteLine(i); //чтобы избавиться от последней запятой
}


void FindAllNaturalNumbers(int i, int n)
{
    if (n == i) return;
    {
        Console.Write($"{n}, ");
        FindAllNaturalNumbers(i, n - 1);
    }
}


