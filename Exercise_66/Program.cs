Console.Write("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"M={m}; N={n}");

int SumNumber(int m, int n)
{
    int sum = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        sum = m + SumNumber(m, n);
        return sum;
    }
}

void SumMN(int m, int n)
{
    Console.Write(SumNumber(m - 1, n));
}
SumMN(m, n);