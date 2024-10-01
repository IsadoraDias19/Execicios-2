// ao usuário adivinhar um número secreto.
// O número secreto será 7. O usuário deve continuar tentando até adivinhar corretamente.
// Use um loop do-while.

int numero = 7;
int palpite;
bool acertou = false;
do
{
    Console.WriteLine("Digite um número de 1 a 10(para saber o número SECRETO): )");
    palpite = int.Parse(Console.ReadLine());

    if (palpite == numero)
    {
        Console.WriteLine("ACERTOU!!!");
        acertou = true;
    }
    else
    {
        Console.WriteLine("Tente Novamente..");
       
    }
}
while (!acertou);

Console.Write($"Programa encerrado.");
Console.ReadKey();

