// Напишите программу вычисления функции Аккермана с помощью рекурсии.
Console.Clear();

Console.Write("Enter m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter n: ");
int n = Convert.ToInt32(Console.ReadLine());


Console.WriteLine($"A({m}, {n}) = {Ackermann(m, n)}");


int Ackermann(int m, int n)
{

    int result;

    if (m == 0)
        return n + 1;
    else
    {
        if (n == 0)
            return Ackermann(m - 1, 1);
    }

    return Ackermann(m - 1, Ackermann(m, n - 1));

}