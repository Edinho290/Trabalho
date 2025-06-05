

int qtdPaes, qtdBroas;
double total, poupanca;

Console.Write("Digite a quantidade de pães vendidos: ");
qtdPaes = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite a quantidade de broas vendidas: ");
qtdBroas = Convert.ToInt32(Console.ReadLine());

total = (qtdPaes * 0.12) + (qtdBroas * 1.50);
poupanca = total * 0.10;

Console.WriteLine("Total vendidos R$ " + total.ToString("F2"));
Console.WriteLine("Valor a ser depositado na poupança: R$ " + poupanca.ToString("F2"));

