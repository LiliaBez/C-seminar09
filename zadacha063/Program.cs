/* Задайте значение N. Напишите программу, которая 
выведет все натуральные числа в промежутке от 1 до N.*/

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);

Console.Write($"Все натуральные числа в промежутке от 1 до {n}: ");
int i = 1;
FindAllNaturalNumbers(i, n);
Console.WriteLine();

void FindAllNaturalNumbers(int i, int n)
{
    if (i == n + 1) return;
    
    {
        Console.Write($"{i}, ");
        FindAllNaturalNumbers(i + 1, n);
    }
}









