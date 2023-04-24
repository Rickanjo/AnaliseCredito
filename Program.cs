// Um cliente quer solicitar um empréstimo. Receba o valor solicitado, a quantidade de parcelas desejada e a renda mensal comprovada.
Console.WriteLine("--- Empréstimo ---");

Console.Write("");
double valorSolicitado, rendaMensal;
int qtdeParcelas;

Console.Write("Digite o valor solicitado: R$ ");
valorSolicitado = double.Parse(Console.ReadLine()!);

Console.Write("Digite a quantidade de parcelas desejada: ");
qtdeParcelas = int.Parse(Console.ReadLine()!);

Console.Write("Digite a renda mensal comprovada: R$ ");
rendaMensal = double.Parse(Console.ReadLine()!);

double valorParcela = valorSolicitado / qtdeParcelas;
double limiteParcela = rendaMensal * 0.3;

if (valorParcela <= limiteParcela) {
    Console.WriteLine("Empréstimo autorizado!");
    
} else {
    Console.WriteLine("Empréstimo não autorizado.");
}