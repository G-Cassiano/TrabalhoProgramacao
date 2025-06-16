decimal Reais, VGasolina, Litros;

Console.WriteLine("Digite quantos reais você vai abastecer: ");
Reais = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o valor da gasolina: ");
VGasolina = Convert.ToDecimal(Console.ReadLine());

Litros = Reais / VGasolina;

Console.WriteLine($"Você conseguiu abastecer {Litros:F2} litros.");
