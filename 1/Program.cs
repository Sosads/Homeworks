// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее

int a = 5;
int b = 7;
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
