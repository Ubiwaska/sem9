// //  Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.Clear();

Console.Write("Enter M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter N: ");
int N = Convert.ToInt32(Console.ReadLine());


if (M > N)
{
    Console.Write("Error: N cannot be greater than M ");
}
else
{

    int Sum = ComputeTheSum(M, N);
    Console.Write($"Sum = {Sum} ");

}

int ComputeTheSum(int M, int N)
{

    int result;

    if (N < M)
        return 0;

    result = ComputeTheSum(M, N - 1) + N;
    return result;


}