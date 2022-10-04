/*Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в 
промежутке от M до N по убыванию.*/

int m = EnterNum("Введите число М: ");
int n = EnterNum("Введите число N: ");

DoCheck(m, n);
Console.WriteLine($"Все натуральные числа в промежутке от {m} до {n} по убыванию: ");
FindAllNaturalNumbers(m, n);
Console.WriteLine();


int EnterNum(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine()!);
}

void DoCheck(int m, int n)
{
    if (m <= n)
    throw new Exception("Число М должно быть больше числа N");
}

/*void DoCheck(int m, int n)
{
    if (m < n)
    Swap(ref m, ref n);
}

void Swap(ref int a, ref int b) 
{
    int c = a;
    a = b;
    b = c;
}*/

void FindAllNaturalNumbers(int m, int n)
{
    if (m < n) return;

    Console.Write($"{m}, ");
    FindAllNaturalNumbers(m - 1, n);
}


