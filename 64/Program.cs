//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.Clear();

Console.Write("Enter N: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N < 1)
{
    Console.WriteLine("Error: entered number must positive");
}
else
{
    PrintUptoNumber(N);
}

void PrintUptoNumber(int N)
{

    Console.WriteLine(N);

    if (N > 1)
        PrintUptoNumber(N - 1);

}