Console.WriteLine("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"M={m}; N={n}");

void NaturalNumber(int m, int n)
{
    if (n > m) 
    {
        for (int i = m; i <= n; i++)
        Console.Write($"{i}, ");
    }      
    else
    {
        for (int i = n; i <= m; i++) 
        Console.Write($"{i}, ");
    }
}
NaturalNumber(m, n);