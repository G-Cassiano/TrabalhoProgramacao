decimal n1, n2, n3, total;

Console.WriteLine("Digite a primeira nota (Peso 1): ");
n1 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Digite a segunda nota (Peso 2): ");
n2 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Digite a nota nota (Peso 3): ");
n3 = Convert.ToDecimal(Console.ReadLine());

total = (n1) + (n2 * 2) + (n3 * 3) / 6;

Console.WriteLine($"A sua nota com os pesos aplicado é {total}");