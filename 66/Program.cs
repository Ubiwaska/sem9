// //  Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.Clear();

Console.Write("Enter M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter N: ");
int N = Convert.ToInt32(Console.ReadLine());

int temp = M;

if (M > N)
{
    Console.Write("Error: N cannot be greater than M ");
}

PrintSum(M, N, temp = 0);

void PrintSum(int M, int N, int Sum)
{
    Sum = Sum + N;
    if (N <= M)
    {
        Console.Write($"Sum = {Sum} ");
        return;
    }
    PrintSum(M, N - 1, Sum);
}
