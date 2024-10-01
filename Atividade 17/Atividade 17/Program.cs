

Console.Write("Digite um número positivo:");
int numero;

while (!int.TryParse(Console.ReadLine(), out numero) || numero <= 0) 
{
    Console.WriteLine("Por Favor insira um número inteiro positivo: ");
    Console.Write("Digite um número inteiro positivo");
}

Console.WriteLine($"Numeros impares até {numero} ");

for (int i = 1; i <= numero; i += 2)
{
   Console.WriteLine(i);
}

Console.WriteLine("Programa Encerrado.");
Console.ReadKey();