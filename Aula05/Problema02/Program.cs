int n = 5;
Double soma = 0;
Double preço;

for (int i = 0; 1 < n; i++)
{

        Console.WriteLine("Entre Preço");
        preço = Double.Parse(Console.ReadLine());
        soma = soma + preço;
    }
    Console.WriteLine("soma:" +soma);
    Double media = soma / n;
    Console.WriteLine("Preço Médio:" + media);