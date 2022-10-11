Console.WriteLine("Пример №3");
int a = -9;
int b = -3;
int max = a;
int min = a;

if (max < a)
{
    max = a;
}
else
{
    min = a;
}
if (max < b)
{
    max = b;
}
else
{
    min = b;
}

Console.Write("max = ");
Console.WriteLine(max);

Console.Write("min = ");
Console.WriteLine(min);
