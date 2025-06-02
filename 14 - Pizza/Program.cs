decimal tamanho, area;

Console.WriteLine("Digite o raio da pizza (metade do tamanho em CM)");
tamanho = Convert.ToDecimal(Console.ReadLine());

area = 3.14m * tamanho*tamanho;

Console.WriteLine($"A area da pizza é: {area}cm²");