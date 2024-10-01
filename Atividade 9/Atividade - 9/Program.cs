// Crie uma aplicação de console onde o usuário pode preencher um vetor com tarefas diárias da semana.
// A aplicação deve:
//1.Ter um vetor com os dias da semana.

//2.Outro vetor vazio que será preenchido com as tarefas.

//3.Pedir para o usuário inserir uma tarefa para cada dia da semana.

//4.Exibir as tarefas preenchidas ao final.


using static System.Runtime.InteropServices.JavaScript.JSType;

string[] DiaSemana = new string[]
{
    "Segunda-feira", //index 0 posição 1
    "Terça-feira",  // index 1 posição 2
    "Quarta-feira",
    "Quinta-feira",
    "Sexta-feira",
    "Sábado",
    "Domingo",
};

string[] vetTarefas = new string[DiaSemana.Length];

for (int i = 0; i < DiaSemana.Length; i ++)
{
    Console.WriteLine($"Digite a tarefa para {DiaSemana[i]}");

    vetTarefas[i] = Console.ReadLine();
}

Console.WriteLine("Tarefas da Semana: ");
for (int i = 0;i < DiaSemana.Length;i++)
{
    Console.WriteLine($" O dia {DiaSemana[i]} tem a tarefa: {vetTarefas[i]}");
}

Console.ReadKey();
