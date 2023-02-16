int n = int.Parse(Console.ReadLine());
int[] a = new int[n];
for(int i = 0; i < n; i++)
{
    Console.Write("a[" + i + "] =");
    a[i] = int.Parse(Console.ReadLine());
}


Console.Write("Cac so le trong day ");

for (int i = 0; i < n; i++)
{
    if (a[i] % 2 != 0)
        Console.Write("{0} ", a[i]);

}

Console.Write("Trung binh cong so chan trong day la ");
int s  = 0;
int d = 0;
for (int i = 0; i < n; i++)
{
    if (a[i] % 2 == 0)
    {
        s = s + a[i];
        d++;
    }       
}
s = s / d;
Console.Write(s);

//Kiem tra phuong trinh bac 2 cua 3 so dau tien cua day
if (a[0] == 0)
{
    if (a[1] == 0)
    {
        Console.WriteLine("Phuong trinh vo nghiem!");
    }
    else
    {
        Console.WriteLine("Phuong trinh co mot nghiem: x = {0}", (-a[2] / a[1]));
    }
    return;
}
// tinh delta
float delta = a[1] * a[1] - 4 * a[0] * a[2];
float x1;
float x2;
// tinh nghiem
if (delta > 0)
{
    x1 = (float)((-(a[1]) + Math.Sqrt(delta)) / (2 * a[0]));
    x2 = (float)((-(a[1]) - Math.Sqrt(delta)) / (2 * a[0]));
    Console.WriteLine("Phuong trinh co 2 nghiem la: x1 = {0} va x2 = {1}", x1, x2);
}
else if (delta == 0)
{
    x1 = (-(a[1]) / (2 * a[0]));
    Console.WriteLine("Phong trinh co nghiem kep: x1 = x2 = {0}", x1);
}
else
{
    Console.WriteLine("Phuong trinh vo nghiem!");
}


Console.ReadKey();
