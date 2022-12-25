/*
Задача 64. Задайте значение M и N. Напишите программу,
которая выведет все натуральные числа в промежутке от N до M. 
Выполнить с помощью рекурсии.

M = 1; N = 5. -> "5,4,3,2,1"
M = 4; N = 8. -> "8, 7, 6, 5, 4"
*/

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = (m);
NaturalToLow(n, count);

void NaturalToLow(int n, int count)
{
    if (count > n)
    {
        return;
    }
    else
    {
        NaturalToLow(n, count + 1);
        Console.Write(count + ", ");
    }
}