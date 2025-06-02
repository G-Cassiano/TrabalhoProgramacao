decimal raio, altura, volume;

Console.WriteLine("Digite o diamentro da caixa d'agua: ");
raio = Convert.ToDecimal(Console.ReadLine()) / 2;

Console.WriteLine("Digite a altura da caixa d'agua");
altura = Convert.ToDecimal(Console.ReadLine());

volume = 3.14m * (raio * raio) * altura * 1000;

Console.WriteLine($"O volume da Caixa d'agua é: {volume:F2}");
