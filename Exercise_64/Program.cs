Console.Write("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"M={m}; N={n}");

string NaturalNumberRec(int m, int n)
{
    if (m == n) return Convert.ToString(m);
    else return m + ", " + NaturalNumberRec(m + 1, n);
}
Console.WriteLine(NaturalNumberRec(m, n));