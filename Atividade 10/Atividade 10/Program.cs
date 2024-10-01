// Solicite ao usuário que informe um número de 1 a 12 (representando os meses do ano)
// e, utilizando a estrutura switch, exiba a estação correspondente ao mês informado.
//Ordem das estações:

//Meses de dezembro, janeiro e fevereiro: Verão
//Meses de março, abril e maio: Outono
//Meses de junho, julho: e agosto: Inverno
//Meses de setembro, outubro e novembro: Primavera

Console.WriteLine("Escolha um número de 1 a 12 (para escolher um mês do ano para saber a estação): ");
int numeroEscolhido = int.Parse(Console.ReadLine());

switch (numeroEscolhido)
{
    case 1:
        Console.WriteLine("Você escolheu o mês do Verão.");
        break;

    case 2:
        Console.WriteLine("Você escolheu  o mês do Verão.");
        break;

    case 3:
        Console.WriteLine("Você escolheu o mês do Outono.");
        break;

    case 4:
        Console.WriteLine("Você escolheu o mês do Outono.");
        break;
    case 5:
        Console.WriteLine("Você escolheu o mês do Outono.");
        break;

    case 6:
        Console.WriteLine("Você escolheu o mês do Inverno.");
        break;

    case 7:
        Console.WriteLine("Você escolheu o mês do Inverno.");
        break;

    case 8:
        Console.WriteLine("Você escolheu  o mês do Inverno.");
        break;

    case 9:
        Console.WriteLine("Você escolheu o mês da Primavera.");
        break;

    case 10:
        Console.WriteLine("Você escolheu o mês da Primavera.");
        break;
    case 11:
        Console.WriteLine("Você escolheu o mês da Primaveira.");
        break;

    case 12:
        Console.WriteLine("Você escolheu o mês do Verão.");
        break;

    default
        :
        Console.WriteLine("O numero escolhido não é permitido");
        break;
}

Console.WriteLine("Digite uma tecla para encerrar!");
Console.ReadKey();