//
//Crie um programa que solicite ao usuário para inserir um
//número positivo e, em seguida, exiba a tabuada desse
//número de 1 a 10.

Console.Write("Digite um número positivo:");
int numero = int.Parse(Console.ReadLine());
int numero2 = numero * 10;

Console.WriteLine($"Números de 0 até {numero}");
for (int i = 0; i <= numero2; i += numero )
{
    Console.WriteLine(i);
}
Console.WriteLine("Programa Encerrado.");
Console.ReadKey();
