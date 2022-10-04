/* Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов 
в промежутке от M до N..*/

Console.Write("Введите натуральное число M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите натуральное число N: ");
int n = int.Parse(Console.ReadLine()!);


if (m < 1 || n < 1) 
    Console.WriteLine("Вы ввели не натуральное число");
else if (m > n) 
{
    Swap(ref m, ref n);
    Console.WriteLine($"Cумма натуральных элементов в промежутке от {m} до {n}: {FindSumNaturalNumbers(m, n)}");
}
else 
Console.WriteLine($"Cумма натуральных элементов в промежутке от {m} до {n}: {FindSumNaturalNumbers(m, n)}");

/*Proverit(m, n); 
Console.WriteLine($"Cумма натуральных элементов в промежутке от {m} до {n}: {FindSumNaturalNumbers(m, n)}");

void Proverit (int m, int n)
{
if (m < 1 || n < 1) 
    Console.WriteLine("Вы ввели не натуральное число");
else if (m > n) 
    Swap(ref m, ref n);
}*/

int FindSumNaturalNumbers(int m, int n)
{
    int sum = m;
    if (m == n) return m;
    {
        sum += FindSumNaturalNumbers(m + 1, n);
    }
    return sum;
}

static void Swap(ref int a, ref int b)
{
    int temp = a;
    a = b;
    b = temp;
}

