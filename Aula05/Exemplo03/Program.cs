int n;
long fat = 1;
Console.Write("Entre com o fatorial");
n = int.Parse(Console.ReadLine());
for (int i = 2; i <= n; i++)
{

    fat = fat * i;

}

Console.WriteLine(n + " x " + i + " = " + n * i);