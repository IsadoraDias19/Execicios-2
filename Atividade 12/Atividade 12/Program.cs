// Crie um programa que classifique a nota de um aluno com base nas seguintes regras:

//Nota de 90 a 100: A
//Nota de 80 a 89: B
//Nota de 70 a 79: C
//Nota de 60 a 69: D
//Nota abaixo de 60: F

Console.WriteLine("Digite a sua nota (0 a 100): ");
string nota = Console.ReadLine();

if (double.TryParse(nota, out double nota2))
{
    if (nota2 >= 90 && nota2 <= 100)
    {
        Console.WriteLine("Classificação: A");
    }

    else if (nota2 >= 80 && nota2 <= 90)
    {
        Console.WriteLine("Classificação: B");
    }
    else if (nota2 >= 70 && nota2 < 80)
    {
        Console.WriteLine("Classificação: C");
    }
    else if (nota2 >= 60 && nota2 < 70)
    {
        Console.WriteLine("Classificação: D");
    }
    else if (nota2 <= 60 && nota2 >=0)
    {
        Console.WriteLine("Classificação: F");
    }
 
}
else
{
    Console.WriteLine("Entrada invalida, digite um NÚMERO !!!");
}
Console.ReadKey();  
