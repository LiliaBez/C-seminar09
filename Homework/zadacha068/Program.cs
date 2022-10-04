/*Напишите программу вычисления функции Аккермана 
с помощью рекурсии. 
Даны два неотрицательных числа m и n.*/

Console.Write("Введите целое неотрицательное число m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите целое неотрицательное число n: ");
int n = int.Parse(Console.ReadLine()!);

if (m < 0 || n < 0)
    Console.WriteLine("Вы ввели отрицательное число!");
else
    Console.WriteLine($"A({m}, {n}) = {FindAckermanFunction(m, n)}");

int FindAckermanFunction(int m, int n)
{
    int result;
    if (m == 0) result = n + 1;
    else if (n == 0)
        result = FindAckermanFunction(m - 1, 1);
    else
        result = FindAckermanFunction(m - 1, FindAckermanFunction(m, n - 1));
    return result;
}

