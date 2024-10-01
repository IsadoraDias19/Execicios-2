// Crie um programa que exiba um menu de opções para o usuário.
// O usuário deve escolher uma opção e o programa deve continuar exibindo o menu até que o usuário escolha a opção de sair.

//Opções do Menu:
//1.Exibir uma mensagem
//2.Fazer uma soma
//3.Sair

int opcao;

do
{
    Console.WriteLine("Escolha uma das opções abaixo:");
    Console.WriteLine("1.Exibir uma mensagem ;");
    Console.WriteLine("2.Fazer uma soma;");
    Console.WriteLine("3.Sair;");

    while (!int.TryParse(Console.ReadLine(), out opcao))
    {
        Console.WriteLine("Insira um numero valido:");
        Console.Write("Escolha uma opção: ");
    }

    switch (opcao)
    {
        case 1:
            Console.WriteLine("Olá Professor, como estou na aula?");
            break;

        case 2:
            Console.WriteLine("Digite o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double soma = num1 + num2;
            Console.WriteLine($"A soma é {soma}");
            break;
        case 3:
            Console.WriteLine("SAINDO DO PROGRAMA. Até mais..");
            break;
        default:
            Console.WriteLine("Opção Invalida, digite as opçãoes 1, 2 ou 3.");
            break;
    }
    Console.WriteLine();
}
while (opcao != 3);

Console.ReadKey();  