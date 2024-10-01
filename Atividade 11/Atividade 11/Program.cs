// Faça uma aplicação de console que solicite dois números ao usuário e tente somá-los.
// Se o usuário digitar algo que não seja um número, exiba uma mensagem de erro apropriada.
// Use try-catch para tratar possíveis exceções de conversão.

try
{
    Console.Write("digite um número: ");
    double num1 = double.Parse(Console.ReadLine());

    Console.Write("digite o segundo número: ");
    double num2 = double.Parse(Console.ReadLine()); 

    double resultado = num1 + num2;

    Console.WriteLine($"o resultado da soma é: {resultado}");
}
catch (FormatException)
{
    Console.WriteLine("ERRO: Por favor, digite números válidos.");
}

Console.ReadKey();  