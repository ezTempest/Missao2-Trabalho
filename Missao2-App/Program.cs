Console.Write("Nome: ");
string nome = Console.ReadLine();

Console.Write("Idade: ");
int idade = int.Parse(Console.ReadLine());

Console.Write("Altura: ");
double altura = double.Parse(Console.ReadLine());

Console.Write("Saldo: ");
decimal saldo = decimal.Parse(Console.ReadLine());

char inicial = nome[0];

Console.Write("Ativo (true/false): ");
bool ativo = bool.Parse(Console.ReadLine());

var anoAtual = DateTime.Now.Year;
var maiorDeIdade = idade >= 18;
var mensagem = "Missão 2";

Console.WriteLine($"\n{mensagem}");
Console.WriteLine($"Nome: {nome} ({inicial})");
Console.WriteLine($"Idade: {idade}");
Console.WriteLine($"Altura: {altura}");
Console.WriteLine($"Saldo: {saldo}");
Console.WriteLine($"Ativo: {ativo}");
Console.WriteLine($"Ano atual: {anoAtual}");

int idadeFutura = idade + 5;
double dobroAltura = altura * 2;

Console.WriteLine($"Idade em 5 anos: {idadeFutura}");
Console.WriteLine($"Dobro da altura: {dobroAltura}");
Console.WriteLine($"Maior de idade: {maiorDeIdade}");