decimal n1, n2, total;

Console.WriteLine("Digite a 1º Nota");
n1 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Digite a 2º Nota");
n2 = Convert.ToDecimal(Console.ReadLine());
if (n2 == 0)
{
    Console.WriteLine("Não se pode dividir por 0");
    return;
}
total = (n1 / n2);
Console.WriteLine($"A divisão do {n1} pela {n2}: {total:F2}");