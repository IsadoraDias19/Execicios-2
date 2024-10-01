
Console.Write("Digite um número positivo:");

if(int. TryParse(Console.ReadLine(),out int numero) && numero >= 0)
{
    int fatorial = 1;

    for (int i = 1; i <= numero; i++)
    {
        fatorial *= i; 
    }
    Console.WriteLine($"O fatorial de {numero} é  = {fatorial}");
}
else
{
    Console.WriteLine("ERRO : Insira um número inteiro");
}
Console.WriteLine("Programa Encerrado.");
Console.ReadKey();