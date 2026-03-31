Console.WriteLine("Entre com a Qtde de números:");
    int n = int.Parse(Console.ReadLine());
int soma = 0;
for (int i =1; i <= n; i++) //i++<=>i=i+i+1<=>i+=1
{

    soma = soma + i;

}
Console.WriteLine("Soma:" + soma);