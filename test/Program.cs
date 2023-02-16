float s = 1;
int n;
int p = 1;
n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    p = p * (2 * i) * (2 * i - 1);

    s = s + (float)(1.0 / p);
}

Console.WriteLine("{0}", s);